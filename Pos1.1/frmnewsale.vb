Imports MySql.Data.MySqlClient

Public Class frmNewSale

    ' Database connection
    Private conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos_grocery1")

    ' ----------------------
    ' Helper: calculate totals
    ' ----------------------
    Private Sub UpdateTotals()
        Dim totalQty As Integer = 0
        Dim totalAmount As Decimal = 0

        For Each item As ListViewItem In lvCart.Items
            totalQty += Convert.ToInt32(item.SubItems(2).Text)
            totalAmount += Convert.ToDecimal(item.SubItems(4).Text)
        Next

        lblTotalItems.Text = "Items: " & totalQty
        lblTotalAmount.Text = "Total: ₱" & totalAmount.ToString("N2")
    End Sub

    ' ----------------------
    ' Scan barcode
    ' ----------------------
    Private Sub txtScan_KeyDown(sender As Object, e As KeyEventArgs) Handles txtScan.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim barcode As String = txtScan.Text.Trim
            If barcode = "" Then
                MessageBox.Show("Please enter a barcode.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Validate duplicate barcode in cart
            For Each item As ListViewItem In lvCart.Items
                If item.SubItems(0).Tag IsNot Nothing AndAlso item.SubItems(0).Tag.ToString() = barcode Then
                    MessageBox.Show("This item has already been added to the cart.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtScan.Clear()
                    txtScan.Focus()
                    Return
                End If
            Next

            ' Retrieve product from database
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT ProductID, ItemName, Price FROM Products WHERE Barcode=@barcode", conn)
                cmd.Parameters.AddWithValue("@barcode", barcode)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim productID As Integer = Convert.ToInt32(reader("ProductID"))
                    Dim itemName As String = reader("ItemName").ToString()
                    Dim price As Decimal = Convert.ToDecimal(reader("Price"))

                    ' Add to cart
                    Dim lvItem As New ListViewItem(productID.ToString())
                    lvItem.SubItems.Add(itemName)
                    lvItem.SubItems.Add("1") ' Quantity
                    lvItem.SubItems.Add(price.ToString("N2")) ' Price
                    lvItem.SubItems.Add(price.ToString("N2")) ' Subtotal
                    lvItem.SubItems(0).Tag = barcode ' store barcode in Tag for validation
                    lvCart.Items.Add(lvItem)

                    UpdateTotals()
                Else
                    MessageBox.Show("Item not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                reader.Close()

            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
                txtScan.Clear()
                txtScan.Focus()
            End Try
        End If
    End Sub

    ' ----------------------
    ' Remove selected item
    ' ----------------------
    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        If lvCart.SelectedItems.Count > 0 Then
            lvCart.SelectedItems(0).Remove()
            UpdateTotals()
        Else
            MessageBox.Show("Please select an item to remove.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' ----------------------
    ' Clear cart
    ' ----------------------
    Private Sub btnClearCart_Click(sender As Object, e As EventArgs) Handles btnClearCart.Click
        If lvCart.Items.Count > 0 Then
            If MessageBox.Show("Clear all items from the cart?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                lvCart.Items.Clear()
                UpdateTotals()
            End If
        Else
            MessageBox.Show("Cart is already empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' ----------------------
    ' Edit quantity on double-click
    ' ----------------------
    Private Sub lvCart_DoubleClick(sender As Object, e As EventArgs) Handles lvCart.DoubleClick
        If lvCart.SelectedItems.Count > 0 Then
            Dim rect = lvCart.SelectedItems(0).SubItems(2).Bounds
            txtEditQty.Bounds = rect
            txtEditQty.Text = lvCart.SelectedItems(0).SubItems(2).Text
            txtEditQty.Visible = True
            txtEditQty.Focus()
        End If
    End Sub

    ' ----------------------
    ' Update quantity after editing
    ' ----------------------
    Private Sub txtEditQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEditQty.KeyDown
        If e.KeyCode = Keys.Enter AndAlso lvCart.SelectedItems.Count > 0 Then
            Dim newQty As Integer
            If Integer.TryParse(txtEditQty.Text, newQty) Then
                If newQty <= 0 Then
                    MessageBox.Show("Quantity must be at least 1.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    lvCart.SelectedItems(0).SubItems(2).Text = newQty.ToString()
                    Dim price As Decimal = Convert.ToDecimal(lvCart.SelectedItems(0).SubItems(3).Text)
                    lvCart.SelectedItems(0).SubItems(4).Text = (newQty * price).ToString("N2")
                    UpdateTotals()
                End If
            Else
                MessageBox.Show("Invalid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            txtEditQty.Visible = False
        ElseIf e.KeyCode = Keys.Escape Then
            txtEditQty.Visible = False
        End If
    End Sub

    ' ----------------------
    ' Checkout
    ' ----------------------
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        If lvCart.Items.Count = 0 Then
            MessageBox.Show("Cannot checkout. Cart is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Open payment form
        Dim paymentForm As New frmPayment()
        paymentForm.LoadCart(Me.lvCart.Items)
        paymentForm.ShowDialog()

        ' Clear cart after payment
        lvCart.Items.Clear()
        UpdateTotals()
    End Sub

    ' ----------------------
    ' Form load
    ' ----------------------
    Private Sub frmNewSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtScan.Focus()
    End Sub

End Class
