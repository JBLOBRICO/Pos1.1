<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPayment
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lvPayment = New System.Windows.Forms.ListView()
        Me.colItemCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colQuantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSubtotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.cmbPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.rtbReceipt = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'lvPayment
        '
        Me.lvPayment.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colItemCode, Me.colDescription, Me.colQuantity, Me.colPrice, Me.colSubtotal})
        Me.lvPayment.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lvPayment.FullRowSelect = True
        Me.lvPayment.GridLines = True
        Me.lvPayment.HideSelection = False
        Me.lvPayment.Location = New System.Drawing.Point(20, 20)
        Me.lvPayment.Name = "lvPayment"
        Me.lvPayment.Size = New System.Drawing.Size(600, 350)
        Me.lvPayment.TabIndex = 0
        Me.lvPayment.UseCompatibleStateImageBehavior = False
        Me.lvPayment.View = System.Windows.Forms.View.Details
        '
        'colItemCode
        '
        Me.colItemCode.Text = "Item Code"
        Me.colItemCode.Width = 100
        '
        'colDescription
        '
        Me.colDescription.Text = "Description"
        Me.colDescription.Width = 200
        '
        'colQuantity
        '
        Me.colQuantity.Text = "Qty"
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 100
        '
        'colSubtotal
        '
        Me.colSubtotal.Text = "Subtotal"
        Me.colSubtotal.Width = 100
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.Location = New System.Drawing.Point(420, 380)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(200, 25)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "Total: ₱0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbPaymentMethod
        '
        Me.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPaymentMethod.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbPaymentMethod.Items.AddRange(New Object() {"Cash", "GCash", "Credit Card"})
        Me.cmbPaymentMethod.Location = New System.Drawing.Point(20, 380)
        Me.cmbPaymentMethod.Name = "cmbPaymentMethod"
        Me.cmbPaymentMethod.Size = New System.Drawing.Size(180, 28)
        Me.cmbPaymentMethod.TabIndex = 1
        '
        'txtCash
        '
        Me.txtCash.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCash.Location = New System.Drawing.Point(220, 380)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(100, 27)
        Me.txtCash.TabIndex = 2
        '
        'lblChange
        '
        Me.lblChange.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblChange.Location = New System.Drawing.Point(220, 415)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(200, 25)
        Me.lblChange.TabIndex = 5
        Me.lblChange.Text = "Change: ₱0.00"
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.SeaGreen
        Me.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPay.ForeColor = System.Drawing.Color.White
        Me.btnPay.Location = New System.Drawing.Point(520, 408)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(100, 42)
        Me.btnPay.TabIndex = 4
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'rtbReceipt
        '
        Me.rtbReceipt.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.rtbReceipt.Location = New System.Drawing.Point(640, 20)
        Me.rtbReceipt.Name = "rtbReceipt"
        Me.rtbReceipt.ReadOnly = True
        Me.rtbReceipt.Size = New System.Drawing.Size(300, 420)
        Me.rtbReceipt.TabIndex = 3
        Me.rtbReceipt.Text = ""
        '
        'frmPayment
        '
        Me.ClientSize = New System.Drawing.Size(960, 460)
        Me.Controls.Add(Me.rtbReceipt)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.cmbPaymentMethod)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lvPayment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvPayment As ListView
    Friend WithEvents colItemCode As ColumnHeader
    Friend WithEvents colDescription As ColumnHeader
    Friend WithEvents colQuantity As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents colSubtotal As ColumnHeader
    Friend WithEvents lblTotal As Label
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents txtCash As TextBox
    Friend WithEvents lblChange As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents rtbReceipt As RichTextBox
End Class
