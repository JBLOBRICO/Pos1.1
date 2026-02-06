Public Class frmmain

    ' Function to open any child form inside PanelMain
    Private Sub OpenChildForm(childForm As Form)
        ' Clear PanelMain para walang lumang form
        PanelMain.Controls.Clear()

        ' Setup child form
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        ' Add to panel
        PanelMain.Controls.Add(childForm)
        childForm.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        OpenChildForm(New frmdashboard())
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        OpenChildForm(New frmProducts())
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        OpenChildForm(New frmsales())
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        FrmLogin.Show()
    End Sub

    Private Sub PanelTop_Paint(sender As Object, e As PaintEventArgs) Handles PanelTop.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenChildForm(New FrmUserManagement())
    End Sub

    Private Sub PanelSidebar_Paint(sender As Object, e As PaintEventArgs) Handles PanelSidebar.Paint

    End Sub
End Class
