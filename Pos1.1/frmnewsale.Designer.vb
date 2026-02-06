<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewSale
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtScan = New System.Windows.Forms.TextBox()
        Me.lvCart = New System.Windows.Forms.ListView()
        Me.colItem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colQuantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSubtotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblTotalItems = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.btnClearCart = New System.Windows.Forms.Button()
        Me.txtEditQty = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtScan
        '
        Me.txtScan.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtScan.Location = New System.Drawing.Point(20, 20)
        Me.txtScan.Name = "txtScan"
        Me.txtScan.Size = New System.Drawing.Size(400, 29)
        Me.txtScan.TabIndex = 0
        '
        'lvCart
        '
        Me.lvCart.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colItem, Me.colDescription, Me.colQuantity, Me.colPrice, Me.colSubtotal})
        Me.lvCart.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lvCart.FullRowSelect = True
        Me.lvCart.GridLines = True
        Me.lvCart.HideSelection = False
        Me.lvCart.Location = New System.Drawing.Point(20, 60)
        Me.lvCart.Name = "lvCart"
        Me.lvCart.Size = New System.Drawing.Size(760, 350)
        Me.lvCart.TabIndex = 1
        Me.lvCart.UseCompatibleStateImageBehavior = False
        Me.lvCart.View = System.Windows.Forms.View.Details
        '
        'colItem
        '
        Me.colItem.Text = "Item Code"
        Me.colItem.Width = 100
        '
        'colDescription
        '
        Me.colDescription.Text = "Description"
        Me.colDescription.Width = 300
        '
        'colQuantity
        '
        Me.colQuantity.Text = "Quantity"
        Me.colQuantity.Width = 80
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 120
        '
        'colSubtotal
        '
        Me.colSubtotal.Text = "Subtotal"
        Me.colSubtotal.Width = 120
        '
        'lblTotalItems
        '
        Me.lblTotalItems.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalItems.Location = New System.Drawing.Point(20, 420)
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Size = New System.Drawing.Size(200, 25)
        Me.lblTotalItems.TabIndex = 5
        Me.lblTotalItems.Text = "Items: 0"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalAmount.Location = New System.Drawing.Point(580, 420)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(200, 25)
        Me.lblTotalAmount.TabIndex = 4
        Me.lblTotalAmount.Text = "Total: ₱0.00"
        Me.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.SeaGreen
        Me.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCheckout.ForeColor = System.Drawing.Color.White
        Me.btnCheckout.Location = New System.Drawing.Point(640, 460)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(140, 50)
        Me.btnCheckout.TabIndex = 3
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.BackColor = System.Drawing.Color.IndianRed
        Me.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemoveItem.ForeColor = System.Drawing.Color.White
        Me.btnRemoveItem.Location = New System.Drawing.Point(20, 460)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(140, 50)
        Me.btnRemoveItem.TabIndex = 2
        Me.btnRemoveItem.Text = "Remove Item"
        Me.btnRemoveItem.UseVisualStyleBackColor = False
        '
        'btnClearCart
        '
        Me.btnClearCart.BackColor = System.Drawing.Color.DarkOrange
        Me.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearCart.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClearCart.ForeColor = System.Drawing.Color.White
        Me.btnClearCart.Location = New System.Drawing.Point(180, 460)
        Me.btnClearCart.Name = "btnClearCart"
        Me.btnClearCart.Size = New System.Drawing.Size(140, 50)
        Me.btnClearCart.TabIndex = 1
        Me.btnClearCart.Text = "Clear Cart"
        Me.btnClearCart.UseVisualStyleBackColor = False
        '
        'txtEditQty
        '
        Me.txtEditQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditQty.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtEditQty.Location = New System.Drawing.Point(0, 0)
        Me.txtEditQty.Name = "txtEditQty"
        Me.txtEditQty.Size = New System.Drawing.Size(80, 27)
        Me.txtEditQty.TabIndex = 0
        Me.txtEditQty.Visible = False
        '
        'frmNewSale
        '
        Me.ClientSize = New System.Drawing.Size(800, 530)
        Me.Controls.Add(Me.txtEditQty)
        Me.Controls.Add(Me.btnClearCart)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.lblTotalItems)
        Me.Controls.Add(Me.lvCart)
        Me.Controls.Add(Me.txtScan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNewSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Sale"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtScan As TextBox
    Friend WithEvents lvCart As ListView
    Friend WithEvents colItem As ColumnHeader
    Friend WithEvents colDescription As ColumnHeader
    Friend WithEvents colQuantity As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents colSubtotal As ColumnHeader
    Friend WithEvents lblTotalItems As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents btnClearCart As Button
    Friend WithEvents txtEditQty As TextBox
End Class
