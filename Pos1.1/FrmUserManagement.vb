Imports MySql.Data.MySqlClient

Public Class FrmUserManagement

    ' Load users and roles on start
    Private Sub FrmUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
        LoadRoles()
    End Sub

    ' Load users into DataGridView
    Private Sub LoadUsers()
        Try
            Using conn = GetConnection()
                conn.Open()
                Dim query As String = "SELECT UserID, Username, Password, RoleID FROM users"
                Dim da As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvUsers.DataSource = dt
                dgvUsers.ClearSelection()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Load roles into ComboBox
    Private Sub LoadRoles()
        Try
            Using conn = GetConnection()
                conn.Open()
                Dim query As String = "SELECT RoleID FROM roles"
                Dim cmd As New MySqlCommand(query, conn)
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                cmbRoleID.Items.Clear()
                While dr.Read()
                    cmbRoleID.Items.Add(dr("RoleID").ToString())
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading roles: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ------------------- Add User -------------------
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Validate input
        If txtUsername.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Or cmbRoleID.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Optional: password length
        If txtPassword.Text.Length < 4 Then
            MessageBox.Show("Password must be at least 4 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check duplicate username
        If UserExists(txtUsername.Text.Trim()) Then
            MessageBox.Show("Username already exists! Please choose another.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Add user
        Try
            Using conn = GetConnection()
                conn.Open()
                Dim query As String = "INSERT INTO users (Username, Password, RoleID) VALUES (@Username, @Password, @RoleID)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim()) ' 🔒 Hash later
                    cmd.Parameters.AddWithValue("@RoleID", cmbRoleID.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadUsers()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error adding user: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ------------------- Update User -------------------
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Validate ID
        If Not IsNumeric(txtUserID.Text.Trim()) Then
            MessageBox.Show("Invalid User ID!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate fields
        If txtUsername.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Or cmbRoleID.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check for duplicate username (ignore current user)
        If UserExists(txtUsername.Text.Trim(), txtUserID.Text.Trim()) Then
            MessageBox.Show("Username already exists! Please choose another.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Update user
        Try
            Using conn = GetConnection()
                conn.Open()
                Dim query As String = "UPDATE users SET Username=@Username, Password=@Password, RoleID=@RoleID WHERE UserID=@UserID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim()) ' 🔒 Hash later
                    cmd.Parameters.AddWithValue("@RoleID", cmbRoleID.Text.Trim())
                    cmd.Parameters.AddWithValue("@UserID", txtUserID.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadUsers()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error updating user: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ------------------- Delete User -------------------
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Validate ID
        If Not IsNumeric(txtUserID.Text.Trim()) Then
            MessageBox.Show("Invalid User ID!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirm
        If MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Using conn = GetConnection()
                    conn.Open()
                    Dim query As String = "DELETE FROM users WHERE UserID=@UserID"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@UserID", txtUserID.Text.Trim())
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadUsers()
                ClearForm()
            Catch ex As Exception
                MessageBox.Show("Error deleting user: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' ------------------- Check Duplicate Username -------------------
    Private Function UserExists(username As String, Optional userID As String = "") As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM users WHERE Username=@Username"
                If userID <> "" Then query &= " AND UserID<>@UserID"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username.Trim())
                    If userID <> "" Then cmd.Parameters.AddWithValue("@UserID", userID.Trim())
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking username: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    ' ------------------- DataGridView Click -------------------
    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvUsers.Rows(e.RowIndex)
            txtUserID.Text = row.Cells("UserID").Value.ToString()
            txtUsername.Text = row.Cells("Username").Value.ToString()
            txtPassword.Text = row.Cells("Password").Value.ToString()
            cmbRoleID.Text = row.Cells("RoleID").Value.ToString()
        End If
    End Sub

    ' ------------------- Clear Form -------------------
    Private Sub ClearForm()
        txtUserID.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        cmbRoleID.SelectedIndex = -1
        dgvUsers.ClearSelection()
    End Sub

    Private Sub PanelTop_Paint(sender As Object, e As PaintEventArgs) Handles PanelTop.Paint

    End Sub
End Class
