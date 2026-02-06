Imports MySql.Data.MySqlClient

Public Class frmdashboard

    Private Sub frmdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItems()
    End Sub

    Private Sub LoadItems()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' ---- Inventory Value (halimbawa sum ng lahat ng Price) ----
                Dim sqlInventory As String = "SELECT IFNULL(SUM(Price),0) FROM products"
                Using cmd As New MySqlCommand(sqlInventory, conn)
                    lblInventoryValue.Text = cmd.ExecuteScalar().ToString()
                End Using

                ' ---- Users Count ----
                Dim sqlUsers As String = "SELECT COUNT(*) FROM users"
                Using cmd As New MySqlCommand(sqlUsers, conn)
                    lblUsersValue.Text = cmd.ExecuteScalar().ToString()
                End Using

                ' ---- Sales Total ----
                Dim sqlSales As String = "SELECT IFNULL(SUM(TotalAmount),0) FROM sales"
                Using cmd As New MySqlCommand(sqlSales, conn)
                    lblSalesValue.Text = cmd.ExecuteScalar().ToString()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading dashboard data: " & ex.Message)
        End Try
    End Sub

    Private Sub mainPanel_Paint(sender As Object, e As PaintEventArgs) Handles mainPanel.Paint

    End Sub
End Class
