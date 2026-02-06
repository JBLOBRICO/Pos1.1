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
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        Me.PanelForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(52, 152, 219) 'Blue Header
        Me.PanelTop.Controls.Add(Me.lblTitle)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Height = 60
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Text = "👤 User Management"
        '
        'PanelForm
        '
        Me.PanelForm.BackColor = System.Drawing.Color.White
        Me.PanelForm.BorderStyle = BorderStyle.FixedSingle
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
        Me.PanelForm.Size = New System.Drawing.Size(300, 250)
        '
        'txtUserID (hidden)
        '
        Me.txtUserID.Location = New System.Drawing.Point(20, 15)
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Visible = False
        '
        'lblUsername
        '
        Me.lblUsername.Text = "Username"
        Me.lblUsername.Location = New System.Drawing.Point(20, 20)
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(20, 40)
        Me.txtUsername.Width = 250
        '
        'lblPassword
        '
        Me.lblPassword.Text = "Password"
        Me.lblPassword.Location = New System.Drawing.Point(20, 75)
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(20, 95)
        Me.txtPassword.PasswordChar = "*"c
        Me.txtPassword.Width = 250
        '
        'lblRoleID
        '
        Me.lblRoleID.Text = "Role"
        Me.lblRoleID.Location = New System.Drawing.Point(20, 130)
        '
        'cmbRoleID
        '
        Me.cmbRoleID.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmbRoleID.Location = New System.Drawing.Point(20, 150)
        Me.cmbRoleID.Width = 250
        '
        'btnAdd
        '
        Me.btnAdd.Text = "➕ Add"
        Me.btnAdd.BackColor = Color.FromArgb(46, 204, 113) 'Green
        Me.btnAdd.FlatStyle = FlatStyle.Flat
        Me.btnAdd.ForeColor = Color.White
        Me.btnAdd.Location = New System.Drawing.Point(20, 190)
        Me.btnAdd.Width = 70
        '
        'btnUpdate
        '
        Me.btnUpdate.Text = "✏️ Update"
        Me.btnUpdate.BackColor = Color.FromArgb(241, 196, 15) 'Yellow
        Me.btnUpdate.FlatStyle = FlatStyle.Flat
        Me.btnUpdate.ForeColor = Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(110, 190)
        Me.btnUpdate.Width = 80
        '
        'btnDelete
        '
        Me.btnDelete.Text = "🗑 Delete"
        Me.btnDelete.BackColor = Color.FromArgb(231, 76, 60) 'Red
        Me.btnDelete.FlatStyle = FlatStyle.Flat
        Me.btnDelete.ForeColor = Color.White
        Me.btnDelete.Location = New System.Drawing.Point(210, 190)
        Me.btnDelete.Width = 70
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToDeleteRows = False
        Me.dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsers.BackgroundColor = Color.White
        Me.dgvUsers.Location = New System.Drawing.Point(340, 80)
        Me.dgvUsers.Size = New System.Drawing.Size(400, 300)
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '
        'FrmUserManagement
        '
        Me.BackColor = Color.FromArgb(236, 240, 241) 'Light Gray background
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.PanelForm)
        Me.Controls.Add(Me.dgvUsers)
        Me.Text = "User Management"
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
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
