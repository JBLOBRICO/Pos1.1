Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FrmLogin

    ' Handle login
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        ' Validate input first
        If String.IsNullOrWhiteSpace(txtuser.Text) Or String.IsNullOrWhiteSpace(txtpass.Text) Then
            MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' SQL query with JOIN to get role name
                Dim sql As String = "
                    SELECT u.UserID, u.Username, r.RoleName 
                    FROM users u 
                    INNER JOIN roles r ON u.RoleID = r.RoleID
                    WHERE u.Username=@username AND u.Password=@password
                "

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@username", txtuser.Text.Trim())
                    cmd.Parameters.AddWithValue("@password", txtpass.Text.Trim()) ' 🔒 consider hashing later

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            Dim userID As Integer = Convert.ToInt32(dr("UserID"))
                            Dim roleName As String = dr("RoleName").ToString()

                            ' Set global current user ID
                            dbconnection.currentUserID = userID

                            lblrole.Text = roleName ' display role

                            MessageBox.Show("Welcome " & txtuser.Text & "! Your role is " & roleName, "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Open form based on role
                            Select Case roleName
                                Case "Admin"
                                    frmmain.Show()
                                    Me.Hide()
                                Case "Cashier"
                                    frmcashiermain.Show()
                                    Me.Hide()
                                Case Else
                                    MessageBox.Show("No form assigned for this role.", "Role Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End Select
                        Else
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Exit button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
