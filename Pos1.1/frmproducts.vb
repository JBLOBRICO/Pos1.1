Imports MySql.Data.MySqlClient

Public Class frmProducts

    ' -----------------------
    ' Form Load
    ' -----------------------
    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With lvProducts
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Clear()
            .Columns.Add("ID", 80)
            .Columns.Add("Product Name", 200)
            .Columns.Add("Category", 150)
            .Columns.Add("Price", 100)
            .Columns.Add("Barcode", 150)
        End With

        LoadItems()
    End Sub

    ' -----------------------
    ' Load existing items from database
    ' -----------------------
    Private Sub LoadItems()
        lvProducts.Items.Clear()
        Try
            Using conn As New MySqlConnection("server=localhost;user id=root;password=;database=pos_grocery1")
                conn.Open()
                Dim query As String = "SELECT ProductID, ItemName, Category, Price, Barcode FROM products"
                Using cmd As New MySqlCommand(query, conn)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            Dim item As New ListViewItem(dr("ProductID").ToString())
                            item.SubItems.Add(dr("ItemName").ToString())
                            item.SubItems.Add(dr("Category").ToString())
                            item.SubItems.Add(Convert.ToDouble(dr("Price")).ToString("F2"))
                            item.SubItems.Add(dr("Barcode").ToString())
                            lvProducts.Items.Add(item)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -----------------------
    ' Populate fields when selecting an item
    ' -----------------------
    Private Sub lvProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvProducts.SelectedIndexChanged
        If lvProducts.SelectedItems.Count = 0 Then Exit Sub

        Dim selected As ListViewItem = lvProducts.SelectedItems(0)
        txtItemName.Text = selected.SubItems(1).Text
        cmbCategory.SelectedItem = selected.SubItems(2).Text
        txtPrice.Text = selected.SubItems(3).Text
        txtBarcode.Text = selected.SubItems(4).Text
    End Sub

    ' -----------------------
    ' Add new product
    ' -----------------------
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' -----------------------
        ' Validation
        ' -----------------------
        If String.IsNullOrWhiteSpace(txtItemName.Text) OrElse cmbCategory.SelectedIndex = -1 _
       OrElse String.IsNullOrWhiteSpace(txtPrice.Text) OrElse String.IsNullOrWhiteSpace(txtBarcode.Text) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim price As Double
        If Not Double.TryParse(txtPrice.Text, price) OrElse price < 0 Then
            MessageBox.Show("Please enter a valid price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPrice.Focus()
            Return
        End If

        ' -----------------------
        ' Check duplicate barcode in database
        ' -----------------------
        Try
            Using conn As New MySqlConnection("server=localhost;user id=root;password=;database=pos_grocery1")
                conn.Open()

                Dim checkSql As String = "SELECT COUNT(*) FROM Products WHERE Barcode=@Barcode"
                Using checkCmd As New MySqlCommand(checkSql, conn)
                    checkCmd.Parameters.AddWithValue("@Barcode", txtBarcode.Text.Trim())
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("This barcode already exists in the database.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtBarcode.Focus()
                        Return
                    End If
                End Using

                ' -----------------------
                ' Insert into database
                ' -----------------------
                Dim insertSql As String = "INSERT INTO Products (ItemName, Category, Price, Barcode) VALUES (@ItemName, @Category, @Price, @Barcode); SELECT LAST_INSERT_ID();"
                Using insertCmd As New MySqlCommand(insertSql, conn)
                    insertCmd.Parameters.AddWithValue("@ItemName", txtItemName.Text.Trim())
                    insertCmd.Parameters.AddWithValue("@Category", cmbCategory.SelectedItem.ToString())
                    insertCmd.Parameters.AddWithValue("@Price", price)
                    insertCmd.Parameters.AddWithValue("@Barcode", txtBarcode.Text.Trim())

                    ' Get the new ProductID
                    Dim newID As Integer = Convert.ToInt32(insertCmd.ExecuteScalar())

                    ' -----------------------
                    ' Add to ListView
                    ' -----------------------
                    Dim lvItem As New ListViewItem(newID.ToString())
                    lvItem.SubItems.Add(txtItemName.Text.Trim())
                    lvItem.SubItems.Add(cmbCategory.SelectedItem.ToString())
                    lvItem.SubItems.Add(price.ToString("F2"))
                    lvItem.SubItems.Add(txtBarcode.Text.Trim())
                    lvProducts.Items.Add(lvItem)

                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearInputs()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -----------------------
    ' Update selected product
    ' -----------------------
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If lvProducts.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a product to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validation
        If String.IsNullOrWhiteSpace(txtItemName.Text) Or cmbCategory.SelectedIndex = -1 Or String.IsNullOrWhiteSpace(txtPrice.Text) Or String.IsNullOrWhiteSpace(txtBarcode.Text) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim price As Double
        If Not Double.TryParse(txtPrice.Text, price) OrElse price < 0 Then
            MessageBox.Show("Please enter a valid price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPrice.Focus()
            Return
        End If

        ' Check for duplicate barcode in other products
        For Each item As ListViewItem In lvProducts.Items
            If item IsNot lvProducts.SelectedItems(0) AndAlso item.SubItems(4).Text.Trim() = txtBarcode.Text.Trim() Then
                MessageBox.Show("This barcode already exists in another product.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtBarcode.Focus()
                Return
            End If
        Next

        Dim productID As Integer
        If Not Integer.TryParse(lvProducts.SelectedItems(0).Text, productID) Then
            MessageBox.Show("Invalid Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Update database
        Try
            Using conn As New MySqlConnection("server=localhost;user id=root;password=;database=pos_grocery1")
                conn.Open()
                Dim sql As String = "UPDATE Products SET ItemName=@ItemName, Category=@Category, Price=@Price, Barcode=@Barcode WHERE ProductID=@ProductID"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Category", cmbCategory.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Price", price)
                    cmd.Parameters.AddWithValue("@Barcode", txtBarcode.Text.Trim())
                    cmd.Parameters.AddWithValue("@ProductID", productID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Update ListView
            Dim selected As ListViewItem = lvProducts.SelectedItems(0)
            selected.SubItems(1).Text = txtItemName.Text.Trim()
            selected.SubItems(2).Text = cmbCategory.SelectedItem.ToString()
            selected.SubItems(3).Text = price.ToString("F2")
            selected.SubItems(4).Text = txtBarcode.Text.Trim()

            MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearInputs()
            lvProducts.SelectedItems.Clear()
        Catch ex As Exception
            MessageBox.Show("Error updating product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -----------------------
    ' Remove selected product
    ' -----------------------
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lvProducts.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a product to remove.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim productID As Integer
        If Not Integer.TryParse(lvProducts.SelectedItems(0).Text, productID) Then
            MessageBox.Show("Invalid Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As New MySqlConnection("server=localhost;user id=root;password=;database=pos_grocery1")
                conn.Open()

                ' Check for associated sales
                Dim checkSql As String = "SELECT COUNT(*) FROM SaleItems WHERE ProductID=@ProductID"
                Using checkCmd As New MySqlCommand(checkSql, conn)
                    checkCmd.Parameters.AddWithValue("@ProductID", productID)
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Cannot delete this product because it has associated sales.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                ' Delete product
                Dim deleteSql As String = "DELETE FROM Products WHERE ProductID=@ProductID"
                Using deleteCmd As New MySqlCommand(deleteSql, conn)
                    deleteCmd.Parameters.AddWithValue("@ProductID", productID)
                    deleteCmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lvProducts.Items.Remove(lvProducts.SelectedItems(0))
                ClearInputs()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -----------------------
    ' Save new items from ListView to database
    ' -----------------------
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If lvProducts.Items.Count = 0 Then
            MessageBox.Show("No products to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As New MySqlConnection("server=localhost;user id=root;password=;database=pos_grocery1")
                conn.Open()
                For Each lvItem As ListViewItem In lvProducts.Items
                    ' Only save new items (ID empty)
                    If String.IsNullOrWhiteSpace(lvItem.Text) Then
                        Dim sql As String = "INSERT INTO Products (ItemName, Category, Price, Barcode) VALUES (@ItemName, @Category, @Price, @Barcode)"
                        Using cmd As New MySqlCommand(sql, conn)
                            cmd.Parameters.AddWithValue("@ItemName", lvItem.SubItems(1).Text.Trim())
                            cmd.Parameters.AddWithValue("@Category", lvItem.SubItems(2).Text.Trim())
                            cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(lvItem.SubItems(3).Text))
                            cmd.Parameters.AddWithValue("@Barcode", lvItem.SubItems(4).Text.Trim())
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next
            End Using

            MessageBox.Show("Products saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lvProducts.Items.Clear()
            ClearInputs()
        Catch ex As Exception
            MessageBox.Show("Error saving products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -----------------------
    ' Clear input fields
    ' -----------------------
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInputs()
    End Sub

    Private Sub ClearInputs()
        txtItemName.Clear()
        cmbCategory.SelectedIndex = -1
        txtPrice.Clear()
        txtBarcode.Clear()
        txtItemName.Focus()
    End Sub

    Private Sub txtBarcode_TextChanged(sender As Object, e As EventArgs) Handles txtBarcode.TextChanged

    End Sub
End Class
