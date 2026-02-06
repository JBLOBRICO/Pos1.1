<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcashierdashboard
    Inherits System.Windows.Forms.Form

    'Dispose
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlStats = New System.Windows.Forms.Panel()
        Me.cardSales = New System.Windows.Forms.Panel()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.cardCustomers = New System.Windows.Forms.Panel()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.cardRevenue = New System.Windows.Forms.Panel()
        Me.lblRevenue = New System.Windows.Forms.Label()
        Me.lblRecent = New System.Windows.Forms.Label()
        Me.dgvRecent = New System.Windows.Forms.DataGridView()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlStats.SuspendLayout()
        Me.cardSales.SuspendLayout()
        Me.cardCustomers.SuspendLayout()
        Me.cardRevenue.SuspendLayout()
        CType(Me.dgvRecent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlStats
        '
        Me.pnlStats.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlStats.Controls.Add(Me.cardSales)
        Me.pnlStats.Controls.Add(Me.cardCustomers)
        Me.pnlStats.Controls.Add(Me.cardRevenue)
        Me.pnlStats.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStats.Location = New System.Drawing.Point(0, 0)
        Me.pnlStats.Name = "pnlStats"
        Me.pnlStats.Size = New System.Drawing.Size(731, 140)
        Me.pnlStats.TabIndex = 0
        '
        'cardSales
        '
        Me.cardSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cardSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cardSales.Controls.Add(Me.lblSales)
        Me.cardSales.Location = New System.Drawing.Point(30, 10)
        Me.cardSales.Name = "cardSales"
        Me.cardSales.Padding = New System.Windows.Forms.Padding(10)
        Me.cardSales.Size = New System.Drawing.Size(180, 120)
        Me.cardSales.TabIndex = 0
        '
        'lblSales
        '
        Me.lblSales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblSales.Location = New System.Drawing.Point(10, 10)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(158, 98)
        Me.lblSales.TabIndex = 0
        Me.lblSales.Text = "🛒 Today's Sales: ₱0.00"
        Me.lblSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cardCustomers
        '
        Me.cardCustomers.BackColor = System.Drawing.Color.Aqua
        Me.cardCustomers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cardCustomers.Controls.Add(Me.lblCustomers)
        Me.cardCustomers.Location = New System.Drawing.Point(230, 10)
        Me.cardCustomers.Name = "cardCustomers"
        Me.cardCustomers.Padding = New System.Windows.Forms.Padding(10)
        Me.cardCustomers.Size = New System.Drawing.Size(180, 120)
        Me.cardCustomers.TabIndex = 1
        '
        'lblCustomers
        '
        Me.lblCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCustomers.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblCustomers.Location = New System.Drawing.Point(10, 10)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(158, 98)
        Me.lblCustomers.TabIndex = 0
        Me.lblCustomers.Text = "👥 Transaction: 0"
        Me.lblCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cardRevenue
        '
        Me.cardRevenue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cardRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cardRevenue.Controls.Add(Me.lblRevenue)
        Me.cardRevenue.Location = New System.Drawing.Point(432, 10)
        Me.cardRevenue.Name = "cardRevenue"
        Me.cardRevenue.Padding = New System.Windows.Forms.Padding(10)
        Me.cardRevenue.Size = New System.Drawing.Size(180, 120)
        Me.cardRevenue.TabIndex = 2
        '
        'lblRevenue
        '
        Me.lblRevenue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRevenue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblRevenue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblRevenue.Location = New System.Drawing.Point(10, 10)
        Me.lblRevenue.Name = "lblRevenue"
        Me.lblRevenue.Size = New System.Drawing.Size(158, 98)
        Me.lblRevenue.TabIndex = 0
        Me.lblRevenue.Text = "💵 Revenue: ₱0.00"
        Me.lblRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRecent
        '
        Me.lblRecent.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblRecent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRecent.Location = New System.Drawing.Point(30, 160)
        Me.lblRecent.Name = "lblRecent"
        Me.lblRecent.Size = New System.Drawing.Size(250, 23)
        Me.lblRecent.TabIndex = 1
        Me.lblRecent.Text = "📜 Recent Transactions"
        '
        'dgvRecent
        '
        Me.dgvRecent.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRecent.EnableHeadersVisualStyles = False
        Me.dgvRecent.Location = New System.Drawing.Point(30, 190)
        Me.dgvRecent.Name = "dgvRecent"
        Me.dgvRecent.Size = New System.Drawing.Size(616, 260)
        Me.dgvRecent.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(466, 470)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(180, 50)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "🔒 Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'frmcashierdashboard
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(731, 550)
        Me.Controls.Add(Me.pnlStats)
        Me.Controls.Add(Me.lblRecent)
        Me.Controls.Add(Me.dgvRecent)
        Me.Controls.Add(Me.btnLogout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmcashierdashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cashier Dashboard"
        Me.pnlStats.ResumeLayout(False)
        Me.cardSales.ResumeLayout(False)
        Me.cardCustomers.ResumeLayout(False)
        Me.cardRevenue.ResumeLayout(False)
        CType(Me.dgvRecent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlStats As Panel
    Friend WithEvents cardSales As Panel
    Friend WithEvents lblSales As Label
    Friend WithEvents cardCustomers As Panel
    Friend WithEvents lblCustomers As Label
    Friend WithEvents cardRevenue As Panel
    Friend WithEvents lblRevenue As Label
    Friend WithEvents lblRecent As Label
    Friend WithEvents dgvRecent As DataGridView
    Friend WithEvents btnLogout As Button
End Class
