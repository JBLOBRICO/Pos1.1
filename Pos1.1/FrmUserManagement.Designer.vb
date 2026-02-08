<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUserManagement
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cmbRoleID = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblRoleID = New System.Windows.Forms.Label()
        Me.PanelTop.SuspendLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.lblTitle)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(800, 60)
        Me.PanelTop.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(202, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "👤 User Management"
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(20, 15)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(100, 20)
        Me.txtUserID.TabIndex = 3
        Me.txtUserID.Visible = False
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(20, 40)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(250, 20)
        Me.txtUsername.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(20, 95)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(250, 20)
        Me.txtPassword.TabIndex = 5
        '
        'cmbRoleID
        '
        Me.cmbRoleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRoleID.Location = New System.Drawing.Point(20, 150)
        Me.cmbRoleID.Name = "cmbRoleID"
        Me.cmbRoleID.Size = New System.Drawing.Size(250, 21)
        Me.cmbRoleID.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(20, 190)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "➕ Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(110, 190)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 23)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "✏️ Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(210, 190)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(70, 23)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "🗑 Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToDeleteRows = False
        Me.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsers.BackgroundColor = System.Drawing.Color.White
        Me.dgvUsers.Location = New System.Drawing.Point(340, 80)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsers.Size = New System.Drawing.Size(400, 300)
        Me.dgvUsers.TabIndex = 2
        '
        'PanelForm
        '
        Me.PanelForm.BackColor = System.Drawing.Color.White
        Me.PanelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelForm.Controls.Add(Me.lblUsername)
        Me.PanelForm.Controls.Add(Me.lblPassword)
        Me.PanelForm.Controls.Add(Me.lblRoleID)
        Me.PanelForm.Controls.Add(Me.txtUserID)
        Me.PanelForm.Controls.Add(Me.txtUsername)
        Me.PanelForm.Controls.Add(Me.txtPassword)
        Me.PanelForm.Controls.Add(Me.cmbRoleID)
        Me.PanelForm.Controls.Add(Me.btnAdd)
        Me.PanelForm.Controls.Add(Me.btnUpdate)
        Me.PanelForm.Controls.Add(Me.btnDelete)
        Me.PanelForm.Location = New System.Drawing.Point(20, 80)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(300, 250)
        Me.PanelForm.TabIndex = 1
        '
        'lblUsername
        '
        Me.lblUsername.Location = New System.Drawing.Point(20, 20)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(100, 23)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(20, 75)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(100, 23)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password"
        '
        'lblRoleID
        '
        Me.lblRoleID.Location = New System.Drawing.Point(20, 130)
        Me.lblRoleID.Name = "lblRoleID"
        Me.lblRoleID.Size = New System.Drawing.Size(100, 23)
        Me.lblRoleID.TabIndex = 2
        Me.lblRoleID.Text = "Role"
        '
        'FrmUserManagement
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.PanelForm)
        Me.Controls.Add(Me.dgvUsers)
        Me.Name = "FrmUserManagement"
        Me.Text = "User Management"
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelForm.ResumeLayout(False)
        Me.PanelForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents PanelForm As Panel
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblRoleID As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cmbRoleID As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvUsers As DataGridView
End Class
