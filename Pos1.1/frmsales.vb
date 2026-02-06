Imports MySql.Data.MySqlClient

Public Class frmSales

    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Default date range (last 7 days)
        dtpFrom.Value = DateTime.Now.AddDays(-7)
        dtpTo.Value = DateTime.Now

        ' Ensure category has a value
        If cmbCategory.Items.Count = 0 Then
            cmbCategory.Items.AddRange(New Object() {"All", "Drinks", "Snacks", "Groceries", "Others"})
        End If
        If cmbCategory.SelectedIndex = -1 Then cmbCategory.SelectedIndex = 0

        LoadSalesData()
    End Sub

    Private Sub LoadSalesData(Optional keyword As String = "")
        ' --------- Validation ---------
        If dtpFrom.Value.Date > dtpTo.Value.Date Then
            MessageBox.Show("The 'From' date cannot be later than the 'To' date.", "Date Range Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(cmbCategory.Text) Then
            MessageBox.Show("Please select a valid category.", "Category Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim sql As String =
"SELECT 
    s.SaleID AS 'Transaction No.',
    DATE_FORMAT(s.SaleDate, '%Y-%m-%d %H:%i') AS 'Date & Time',
    p.ItemName AS 'Product',
    p.Category AS 'Category',
    p.Barcode AS 'Barcode',
    si.Quantity AS 'Qty',
    p.Price AS 'Unit Price',
    si.Subtotal AS 'Subtotal',
    s.TotalAmount AS 'Total Sale',
    s.PaymentMethod AS 'Payment',
    u.Username AS 'Processed By'
FROM SaleItems si
INNER JOIN Sales s ON si.SaleID = s.SaleID
INNER JOIN Products p ON si.ProductID = p.ProductID
INNER JOIN Users u ON s.UserID = u.UserID
WHERE (@kw = '' OR p.ItemName LIKE @kw OR u.Username LIKE @kw OR s.SaleID LIKE @kw)
  AND (@category = 'All' OR p.Category = @category)
  AND s.SaleDate BETWEEN @fromDate AND @toDate
ORDER BY s.SaleDate DESC, s.SaleID DESC
LIMIT 0, 50;"

                Using cmd As New MySqlCommand(sql, conn)
                    ' Keyword search
                    Dim kwParam As String = ""
                    If Not String.IsNullOrWhiteSpace(keyword) Then
                        kwParam = "%" & keyword.Replace("%", "[%]").Replace("_", "[_]") & "%" ' escape wildcards
                    End If
                    cmd.Parameters.AddWithValue("@kw", kwParam)

                    ' Category
                    cmd.Parameters.AddWithValue("@category", cmbCategory.Text)

                    ' Date range
                    cmd.Parameters.AddWithValue("@fromDate", dtpFrom.Value.Date)
                    cmd.Parameters.AddWithValue("@toDate", dtpTo.Value.Date.AddDays(1).AddSeconds(-1))

                    Dim da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    dgvSales.DataSource = dt
                    dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    dgvSales.ReadOnly = True

                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("No sales records found for the selected criteria.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error loading sales: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ------------------- Events -------------------
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadSalesData(txtSearch.Text.Trim())
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        LoadSalesData(txtSearch.Text.Trim())
    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        LoadSalesData(txtSearch.Text.Trim())
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        LoadSalesData(txtSearch.Text.Trim())
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        LoadSalesData(txtSearch.Text.Trim())
    End Sub
End Class
