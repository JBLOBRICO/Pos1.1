<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcashiermain
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelSidebar = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNewSale = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.PanelSidebar.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSidebar
        '
        Me.PanelSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelSidebar.Controls.Add(Me.Label1)
        Me.PanelSidebar.Controls.Add(Me.btnNewSale)
        Me.PanelSidebar.Controls.Add(Me.btnDashboard)
        Me.PanelSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSidebar.Location = New System.Drawing.Point(0, 0)
        Me.PanelSidebar.Name = "PanelSidebar"
        Me.PanelSidebar.Size = New System.Drawing.Size(200, 778)
        Me.PanelSidebar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(26, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cashier POS"
        '
        'btnNewSale
        '
        Me.btnNewSale.BackColor = System.Drawing.Color.Transparent
        Me.btnNewSale.FlatAppearance.BorderSize = 0
        Me.btnNewSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewSale.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnNewSale.ForeColor = System.Drawing.Color.Black
        Me.btnNewSale.Location = New System.Drawing.Point(0, 130)
        Me.btnNewSale.Name = "btnNewSale"
        Me.btnNewSale.Size = New System.Drawing.Size(200, 45)
        Me.btnNewSale.TabIndex = 1
        Me.btnNewSale.Text = "🛒 New Sale"
        Me.btnNewSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewSale.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnDashboard.ForeColor = System.Drawing.Color.Black
        Me.btnDashboard.Location = New System.Drawing.Point(0, 80)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(200, 45)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "🏠 Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.lblRole)
        Me.PanelTop.Controls.Add(Me.lblTitle)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(200, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1284, 60)
        Me.PanelTop.TabIndex = 1
        '
        'lblRole
        '
        Me.lblRole.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRole.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblRole.ForeColor = System.Drawing.Color.Black
        Me.lblRole.Location = New System.Drawing.Point(1080, 20)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(160, 20)
        Me.lblRole.TabIndex = 1
        Me.lblRole.Text = "Role: Cashier"
        Me.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(105, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Dashboard"
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.White
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(200, 60)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(1284, 718)
        Me.PanelMain.TabIndex = 2
        '
        'frmcashiermain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1484, 778)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.PanelSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmcashiermain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cashier Panel"
        Me.PanelSidebar.ResumeLayout(False)
        Me.PanelSidebar.PerformLayout()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSidebar As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnNewSale As Button
    Friend WithEvents PanelTop As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents PanelMain As Panel
    Friend WithEvents Label1 As Label
End Class
