Public Class frmcashiermain
    Private Sub PanelSidebar_Paint(sender As Object, e As PaintEventArgs) Handles PanelSidebar.Paint

    End Sub

    Private Sub OpenChildForm(childForm As Form)
        PanelMain.Controls.Clear()

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        PanelMain.Controls.Add(childForm)
        PanelMain.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        OpenChildForm(New frmcashierdashboard())
    End Sub

    Private Sub PanelMain_Paint(sender As Object, e As PaintEventArgs) Handles PanelMain.Paint

    End Sub

    Private Sub PanelTop_Paint(sender As Object, e As PaintEventArgs) Handles PanelTop.Paint

    End Sub

    Private Sub btnNewSale_Click(sender As Object, e As EventArgs) Handles btnNewSale.Click
        OpenChildForm(New frmnewsale())
    End Sub
End Class
