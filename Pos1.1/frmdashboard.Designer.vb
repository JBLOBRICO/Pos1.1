<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmdashboard
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.cardSales = New System.Windows.Forms.Panel()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblSalesValue = New System.Windows.Forms.Label()
        Me.cardInventory = New System.Windows.Forms.Panel()
        Me.lblInventory = New System.Windows.Forms.Label()
        Me.lblInventoryValue = New System.Windows.Forms.Label()
        Me.cardUsers = New System.Windows.Forms.Panel()
        Me.lblUsers = New System.Windows.Forms.Label()
        Me.lblUsersValue = New System.Windows.Forms.Label()
        Me.mainPanel.SuspendLayout()
        Me.cardSales.SuspendLayout()
        Me.cardInventory.SuspendLayout()
        Me.cardUsers.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainPanel
        '
        Me.mainPanel.BackColor = System.Drawing.Color.White
        Me.mainPanel.Controls.Add(Me.cardSales)
        Me.mainPanel.Controls.Add(Me.cardInventory)
        Me.mainPanel.Controls.Add(Me.cardUsers)
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(1074, 594)
        Me.mainPanel.TabIndex = 0
        '
        'cardSales
        '
        Me.cardSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.cardSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cardSales.Controls.Add(Me.lblSales)
        Me.cardSales.Controls.Add(Me.lblSalesValue)
        Me.cardSales.Location = New System.Drawing.Point(20, 20)
        Me.cardSales.Name = "cardSales"
        Me.cardSales.Size = New System.Drawing.Size(200, 100)
        Me.cardSales.TabIndex = 0
        '
        'lblSales
        '
        Me.lblSales.ForeColor = System.Drawing.Color.White
        Me.lblSales.Location = New System.Drawing.Point(10, 10)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(100, 23)
        Me.lblSales.TabIndex = 0
        Me.lblSales.Text = "Total Sales"
        '
        'lblSalesValue
        '
        Me.lblSalesValue.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblSalesValue.ForeColor = System.Drawing.Color.White
        Me.lblSalesValue.Location = New System.Drawing.Point(10, 40)
        Me.lblSalesValue.Name = "lblSalesValue"
        Me.lblSalesValue.Size = New System.Drawing.Size(100, 23)
        Me.lblSalesValue.TabIndex = 1
        Me.lblSalesValue.Text = "₱0.00"
        '
        'cardInventory
        '
        Me.cardInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cardInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cardInventory.Controls.Add(Me.lblInventory)
        Me.cardInventory.Controls.Add(Me.lblInventoryValue)
        Me.cardInventory.Location = New System.Drawing.Point(240, 20)
        Me.cardInventory.Name = "cardInventory"
        Me.cardInventory.Size = New System.Drawing.Size(200, 100)
        Me.cardInventory.TabIndex = 1
        '
        'lblInventory
        '
        Me.lblInventory.ForeColor = System.Drawing.Color.White
        Me.lblInventory.Location = New System.Drawing.Point(10, 10)
        Me.lblInventory.Name = "lblInventory"
        Me.lblInventory.Size = New System.Drawing.Size(100, 23)
        Me.lblInventory.TabIndex = 0
        Me.lblInventory.Text = "Inventory Items"
        '
        'lblInventoryValue
        '
        Me.lblInventoryValue.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblInventoryValue.ForeColor = System.Drawing.Color.White
        Me.lblInventoryValue.Location = New System.Drawing.Point(10, 40)
        Me.lblInventoryValue.Name = "lblInventoryValue"
        Me.lblInventoryValue.Size = New System.Drawing.Size(100, 23)
        Me.lblInventoryValue.TabIndex = 1
        Me.lblInventoryValue.Text = "0"
        '
        'cardUsers
        '
        Me.cardUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.cardUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cardUsers.Controls.Add(Me.lblUsers)
        Me.cardUsers.Controls.Add(Me.lblUsersValue)
        Me.cardUsers.Location = New System.Drawing.Point(460, 20)
        Me.cardUsers.Name = "cardUsers"
        Me.cardUsers.Size = New System.Drawing.Size(200, 100)
        Me.cardUsers.TabIndex = 2
        '
        'lblUsers
        '
        Me.lblUsers.ForeColor = System.Drawing.Color.White
        Me.lblUsers.Location = New System.Drawing.Point(10, 10)
        Me.lblUsers.Name = "lblUsers"
        Me.lblUsers.Size = New System.Drawing.Size(100, 23)
        Me.lblUsers.TabIndex = 0
        Me.lblUsers.Text = "Active Users"
        '
        'lblUsersValue
        '
        Me.lblUsersValue.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsersValue.ForeColor = System.Drawing.Color.White
        Me.lblUsersValue.Location = New System.Drawing.Point(10, 40)
        Me.lblUsersValue.Name = "lblUsersValue"
        Me.lblUsersValue.Size = New System.Drawing.Size(100, 23)
        Me.lblUsersValue.TabIndex = 1
        Me.lblUsersValue.Text = "0"
        '
        'frmdashboard
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1074, 594)
        Me.Controls.Add(Me.mainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmdashboard"
        Me.Text = "Dashboard"
        Me.mainPanel.ResumeLayout(False)
        Me.cardSales.ResumeLayout(False)
        Me.cardInventory.ResumeLayout(False)
        Me.cardUsers.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainPanel As Panel
    Friend WithEvents cardSales As Panel
    Friend WithEvents lblSales As Label
    Friend WithEvents lblSalesValue As Label
    Friend WithEvents cardInventory As Panel
    Friend WithEvents lblInventory As Label
    Friend WithEvents lblInventoryValue As Label
    Friend WithEvents cardUsers As Panel
    Friend WithEvents lblUsers As Label
    Friend WithEvents lblUsersValue As Label
End Class
