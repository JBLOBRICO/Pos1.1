Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class frmPayment

    Private TotalAmount As Double = 0
    Private ChangeAmount As Double = 0
    Private CartItems As ListView.ListViewItemCollection
    Private WithEvents pd As New PrintDocument()

    ' -----------------------
    ' Load cart items
    ' -----------------------
    Public Sub LoadCart(ByVal items As ListView.ListViewItemCollection)
        If items Is Nothing OrElse items.Count = 0 Then
            MessageBox.Show("Cart is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        CartItems = items
        lvPayment.Items.Clear()
        TotalAmount = 0

        For Each lvItem As ListViewItem In CartItems
            If lvItem.SubItems.Count < 5 Then Continue For

            Dim productID As String = lvItem.SubItems(0).Text.Trim()
            Dim description As String = lvItem.SubItems(1).Text.Trim()
            Dim qtyText As String = lvItem.SubItems(2).Text.Trim()
            Dim priceText As String = lvItem.SubItems(3).Text.Trim()
            Dim subtotalText As String = lvItem.SubItems(4).Text.Trim()

            ' -----------------------
            ' Duplicate item check
            ' -----------------------
            Dim isDuplicate As Boolean = False
            For Each existingItem As ListViewItem In lvPayment.Items
                If existingItem.SubItems(0).Text.Trim() = productID Then
                    isDuplicate = True
                    Exit For
                End If
            Next
            If isDuplicate Then
                MessageBox.Show("Product '" & description & "' is already in the cart. Please update the quantity instead of scanning again.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Continue For
            End If

            ' -----------------------
            ' Numeric validation
            ' -----------------------
            Dim qty, price, subtotal As Double
            If Not Double.TryParse(qtyText, qty) OrElse qty <= 0 Then qty = 0
            If Not Double.TryParse(priceText, price) OrElse price < 0 Then price = 0
            If Not Double.TryParse(subtotalText, subtotal) OrElse subtotal < 0 Then subtotal = qty * price

            ' -----------------------
            ' Add to lvPayment
            ' -----------------------
            Dim list As New ListViewItem(productID)
            list.SubItems.Add(description)
            list.SubItems.Add(qty.ToString())
            list.SubItems.Add(price.ToString("F2"))
            list.SubItems.Add(subtotal.ToString("F2"))
            lvPayment.Items.Add(list)

            TotalAmount += subtotal
        Next

        lblTotal.Text = "Total: ₱" & TotalAmount.ToString("F2")
        lblChange.Text = "Change: ₱0.00"
        txtCash.Clear()
    End Sub

    ' -----------------------
    ' Calculate Change
    ' -----------------------
    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        If String.IsNullOrWhiteSpace(txtCash.Text) Then
            lblChange.Text = "Change: ₱0.00"
            ChangeAmount = 0
            Return
        End If

        Dim cash As Double
        If Double.TryParse(txtCash.Text, cash) Then
            If cash < 0 Then
                lblChange.Text = "Change: ₱0.00"
                ChangeAmount = 0
                Return
            End If
            ChangeAmount = cash - TotalAmount
            lblChange.Text = "Change: ₱" & ChangeAmount.ToString("F2")
        Else
            lblChange.Text = "Change: ₱0.00"
            ChangeAmount = 0
        End If
    End Sub

    ' -----------------------
    ' Process Payment
    ' -----------------------
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        ' Cart validation
        If lvPayment.Items.Count = 0 Then
            MessageBox.Show("No items to process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Payment method validation
        Dim paymentMethod As String = If(cmbPaymentMethod.SelectedItem, "").ToString().Trim()
        If String.IsNullOrEmpty(paymentMethod) Then
            MessageBox.Show("Please select a payment method.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Cash validation
        Dim cashReceived As Double = 0
        If paymentMethod.ToLower() = "cash" Then
            If String.IsNullOrWhiteSpace(txtCash.Text) Then
                MessageBox.Show("Please enter cash amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCash.Focus()
                Return
            End If
            If Not Double.TryParse(txtCash.Text, cashReceived) Then
                MessageBox.Show("Invalid cash amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCash.Focus()
                Return
            End If
            If cashReceived < TotalAmount Then
                MessageBox.Show("Cash is not enough to cover the total amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCash.Focus()
                Return
            End If
        End If

        ' Optional confirmation
        If MessageBox.Show("Are you sure you want to process this payment?", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        ' -----------------------
        ' Save to Database
        ' -----------------------
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' Insert into Sales table
                Dim sqlSale As String = "INSERT INTO Sales (SaleDate, TotalAmount, PaymentMethod, UserID) VALUES (NOW(), @TotalAmount, @PaymentMethod, @UserID); SELECT LAST_INSERT_ID();"
                Dim saleID As Integer

                Using cmd As New MySqlCommand(sqlSale, conn)
                    cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount)
                    cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod)
                    cmd.Parameters.AddWithValue("@UserID", dbconnection.currentUserID)
                    saleID = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                ' Insert SaleItems
                For Each lvItem As ListViewItem In lvPayment.Items
                    Dim sqlItem As String = "INSERT INTO SaleItems (SaleID, ProductID, Quantity, Subtotal) VALUES (@SaleID, @ProductID, @Quantity, @Subtotal)"
                    Using cmdItem As New MySqlCommand(sqlItem, conn)
                        Dim prodID = lvItem.SubItems(0).Text.Trim()
                        Dim qty As Double
                        Dim subtotal As Double
                        If Not Double.TryParse(lvItem.SubItems(2).Text, qty) OrElse qty <= 0 Then qty = 1
                        If Not Double.TryParse(lvItem.SubItems(4).Text, subtotal) OrElse subtotal < 0 Then subtotal = 0

                        cmdItem.Parameters.AddWithValue("@SaleID", saleID)
                        cmdItem.Parameters.AddWithValue("@ProductID", prodID)
                        cmdItem.Parameters.AddWithValue("@Quantity", qty)
                        cmdItem.Parameters.AddWithValue("@Subtotal", subtotal)
                        cmdItem.ExecuteNonQuery()
                    End Using
                Next
            End Using

            ' Generate and print receipt
            GenerateReceipt(paymentMethod, cashReceived)
            PrintReceipt()

            MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error processing payment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -----------------------
    ' Auto-print receipt
    ' -----------------------
    Private Sub PrintReceipt()
        AddHandler pd.PrintPage, AddressOf Me.pd_PrintPage
        Try
            pd.Print()
        Catch ex As Exception
            MessageBox.Show("Error printing receipt: " & ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pd_PrintPage(sender As Object, e As PrintPageEventArgs)
        e.Graphics.DrawString(rtbReceipt.Text, New Font("Arial", 10), Brushes.Black, 10, 10)
    End Sub

    ' -----------------------
    ' Generate Receipt
    ' -----------------------
    Private Sub GenerateReceipt(paymentMethod As String, cashReceived As Double)
        rtbReceipt.Clear()
        rtbReceipt.AppendText("----- Grocery POS Receipt -----" & vbCrLf)
        rtbReceipt.AppendText("Date: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm") & vbCrLf & vbCrLf)
        rtbReceipt.AppendText("Items:" & vbCrLf)

        For Each lvItem As ListViewItem In lvPayment.Items
            rtbReceipt.AppendText($"{lvItem.SubItems(1).Text} x{lvItem.SubItems(2).Text}  ₱{lvItem.SubItems(4).Text}" & vbCrLf)
        Next

        rtbReceipt.AppendText(vbCrLf & "Total: ₱" & TotalAmount.ToString("F2") & vbCrLf)
        rtbReceipt.AppendText("Payment Method: " & paymentMethod & vbCrLf)
        If paymentMethod.ToLower() = "cash" Then
            rtbReceipt.AppendText("Cash Received: ₱" & cashReceived.ToString("F2") & vbCrLf)
            rtbReceipt.AppendText("Change: ₱" & ChangeAmount.ToString("F2") & vbCrLf)
        End If
        rtbReceipt.AppendText("-------------------------------" & vbCrLf)
        rtbReceipt.AppendText("Thank you for shopping with us!" & vbCrLf)
    End Sub

    Private Sub rtbReceipt_TextChanged(sender As Object, e As EventArgs) Handles rtbReceipt.TextChanged

    End Sub
End Class
