<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblUsername = New Label()
        lblPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnClear = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.Transparent
        lblUsername.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        lblUsername.ForeColor = Color.DarkBlue
        lblUsername.Location = New Point(280, 226)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(119, 24)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username:"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = Color.Transparent
        lblPassword.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        lblPassword.ForeColor = Color.DarkBlue
        lblPassword.Location = New Point(281, 321)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(114, 24)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password:"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = SystemColors.ButtonFace
        txtUsername.Font = New Font("Tahoma", 12F)
        txtUsername.Location = New Point(212, 264)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(253, 32)
        txtUsername.TabIndex = 3
        txtUsername.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = SystemColors.ButtonFace
        txtPassword.Font = New Font("Tahoma", 12F)
        txtPassword.Location = New Point(212, 357)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(253, 32)
        txtPassword.TabIndex = 4
        txtPassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.LightBlue
        btnLogin.Font = New Font("Microsoft YaHei UI", 12F, FontStyle.Bold)
        btnLogin.ForeColor = Color.Navy
        btnLogin.Location = New Point(114, 444)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(113, 36)
        btnLogin.TabIndex = 5
        btnLogin.Text = "LOG-IN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.LightBlue
        btnClear.Font = New Font("Microsoft YaHei UI", 12F, FontStyle.Bold)
        btnClear.ForeColor = Color.Navy
        btnClear.Location = New Point(283, 444)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(113, 36)
        btnClear.TabIndex = 6
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.LightBlue
        btnExit.Font = New Font("Microsoft YaHei UI", 12F, FontStyle.Bold)
        btnExit.ForeColor = Color.Navy
        btnExit.Location = New Point(453, 444)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(113, 36)
        btnExit.TabIndex = 7
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(682, 553)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Log-In"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button

End Class
