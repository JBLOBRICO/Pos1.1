Imports MySql.Data.MySqlClient

Public Class frmcashierdashboard

    ' Connection string (palitan depende sa DB setup mo)
    Dim connStr As String = "server=localhost;userid=root;password=;database=pos_grocery1;"
    Dim conn As New MySqlConnection(connStr)

    Private Sub frmcashierdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardStats()
        LoadRecentTransactions()
    End Sub

    ' -------------------------
    ' 🟦 Load Dashboard Stats
    ' -------------------------
    Private Sub LoadDashboardStats()
        Try
            conn.Open()

            ' Get Today’s Sales
            Dim cmdSales As New MySqlCommand("SELECT IFNULL(SUM(totalamount),0) FROM sales WHERE DATE(saledate)=CURDATE()", conn)
            lblSales.Text = "🛒 Today's Sales: ₱" & cmdSales.ExecuteScalar().ToString()

            ' Get Customers Served Today
            Dim cmdTrans As New MySqlCommand("SELECT COUNT(*) FROM sales WHERE DATE(saledate)=CURDATE()", conn)
            lblCustomers.Text = "🧾 Transactions: " & cmdTrans.ExecuteScalar().ToString()

            ' Get Total Revenue
            Dim cmdRevenue As New MySqlCommand("SELECT IFNULL(SUM(TotalAmount),0) FROM sales", conn)
            lblRevenue.Text = "💵 Revenue: ₱" & cmdRevenue.ExecuteScalar().ToString()

        Catch ex As Exception
            MessageBox.Show("Error loading dashboard stats: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' -------------------------
    ' 📜 Load Recent Transactions
    ' -------------------------
    Private Sub LoadRecentTransactions()
        Try
            conn.Open()
            Dim query As String = "SELECT saleid AS 'Sale ID', saledate AS 'Date', totalamount AS 'Amount' FROM sales ORDER BY saledate DESC LIMIT 10"
            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvRecent.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading transactions: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub






    ' -------------------------
    ' 🔒 Logout
    ' -------------------------
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            FrmLogin.Show()
            frmcashiermain.Close()
        End If
    End Sub

    Private Sub lblCustomers_Click(sender As Object, e As EventArgs) Handles lblCustomers.Click

    End Sub

    Private Sub pnlStats_Paint(sender As Object, e As PaintEventArgs) Handles pnlStats.Paint

    End Sub
End Class
