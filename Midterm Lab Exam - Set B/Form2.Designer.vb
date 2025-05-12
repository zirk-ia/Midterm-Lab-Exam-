<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        lblActiveUser = New Label()
        lblBalance = New Label()
        lblAmount = New Label()
        lblBalanceDisplay = New Label()
        txtAmount = New TextBox()
        lblActiveUserDisplay = New Label()
        btnWithdraw = New Button()
        btnDeposit = New Button()
        btnBack = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' lblActiveUser
        ' 
        lblActiveUser.AutoSize = True
        lblActiveUser.BackColor = Color.Transparent
        lblActiveUser.Font = New Font("Verdana", 10.8F, FontStyle.Bold)
        lblActiveUser.Location = New Point(132, 173)
        lblActiveUser.Name = "lblActiveUser"
        lblActiveUser.Size = New Size(133, 22)
        lblActiveUser.TabIndex = 1
        lblActiveUser.Text = "Active User:"
        ' 
        ' lblBalance
        ' 
        lblBalance.AutoSize = True
        lblBalance.BackColor = Color.Transparent
        lblBalance.Font = New Font("Verdana", 10.8F, FontStyle.Bold)
        lblBalance.Location = New Point(132, 224)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New Size(97, 22)
        lblBalance.TabIndex = 2
        lblBalance.Text = "Balance:"
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.BackColor = Color.Transparent
        lblAmount.Font = New Font("Verdana", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblAmount.Location = New Point(132, 291)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(96, 22)
        lblAmount.TabIndex = 5
        lblAmount.Text = "Amount:"
        ' 
        ' lblBalanceDisplay
        ' 
        lblBalanceDisplay.AutoSize = True
        lblBalanceDisplay.BackColor = Color.Transparent
        lblBalanceDisplay.Font = New Font("Verdana", 10.8F)
        lblBalanceDisplay.ForeColor = Color.Maroon
        lblBalanceDisplay.Location = New Point(269, 224)
        lblBalanceDisplay.Name = "lblBalanceDisplay"
        lblBalanceDisplay.Size = New Size(166, 22)
        lblBalanceDisplay.TabIndex = 6
        lblBalanceDisplay.Text = "                          "
        lblBalanceDisplay.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtAmount
        ' 
        txtAmount.BackColor = SystemColors.Control
        txtAmount.Font = New Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAmount.Location = New Point(269, 284)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(166, 29)
        txtAmount.TabIndex = 8
        txtAmount.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblActiveUserDisplay
        ' 
        lblActiveUserDisplay.AutoSize = True
        lblActiveUserDisplay.BackColor = Color.Transparent
        lblActiveUserDisplay.Font = New Font("Verdana", 10.8F)
        lblActiveUserDisplay.ForeColor = Color.Navy
        lblActiveUserDisplay.Location = New Point(269, 173)
        lblActiveUserDisplay.Name = "lblActiveUserDisplay"
        lblActiveUserDisplay.Size = New Size(166, 22)
        lblActiveUserDisplay.TabIndex = 9
        lblActiveUserDisplay.Text = "                          "
        lblActiveUserDisplay.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnWithdraw
        ' 
        btnWithdraw.BackColor = Color.CadetBlue
        btnWithdraw.Font = New Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold)
        btnWithdraw.ForeColor = SystemColors.ControlLightLight
        btnWithdraw.Location = New Point(405, 348)
        btnWithdraw.Name = "btnWithdraw"
        btnWithdraw.Size = New Size(187, 34)
        btnWithdraw.TabIndex = 10
        btnWithdraw.Text = "WITHDRAW"
        btnWithdraw.UseVisualStyleBackColor = False
        ' 
        ' btnDeposit
        ' 
        btnDeposit.BackColor = Color.CadetBlue
        btnDeposit.Font = New Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold)
        btnDeposit.ForeColor = SystemColors.ControlLightLight
        btnDeposit.Location = New Point(405, 397)
        btnDeposit.Name = "btnDeposit"
        btnDeposit.Size = New Size(187, 34)
        btnDeposit.TabIndex = 11
        btnDeposit.Text = "DEPOSIT"
        btnDeposit.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.CadetBlue
        btnBack.Font = New Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold)
        btnBack.ForeColor = SystemColors.ControlLightLight
        btnBack.Location = New Point(405, 446)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(187, 34)
        btnBack.TabIndex = 12
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.LightBlue
        btnExit.Font = New Font("Microsoft YaHei UI", 12F, FontStyle.Bold)
        btnExit.ForeColor = Color.Navy
        btnExit.Location = New Point(440, 496)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(113, 36)
        btnExit.TabIndex = 13
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(682, 553)
        Controls.Add(btnExit)
        Controls.Add(btnBack)
        Controls.Add(btnDeposit)
        Controls.Add(btnWithdraw)
        Controls.Add(lblActiveUserDisplay)
        Controls.Add(txtAmount)
        Controls.Add(lblBalanceDisplay)
        Controls.Add(lblAmount)
        Controls.Add(lblBalance)
        Controls.Add(lblActiveUser)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Banco De Nomar"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblActiveUser As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblBalanceDisplay As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblActiveUserDisplay As Label
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnExit As Button
End Class
