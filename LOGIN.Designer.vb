<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        txtUsername = New TextBox()
        PictureBox2 = New PictureBox()
        txtPassword = New TextBox()
        PictureBox3 = New PictureBox()
        LinkLabel1 = New LinkLabel()
        btnLogin = New Button()
        btnSignUp = New Button()
        lblTandC = New LinkLabel()
        PictureBox1 = New PictureBox()
        ToolTip1 = New ToolTip(components)
        chkRemember = New CheckBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(350, 200)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 25)
        Label1.TabIndex = 1
        Label1.Text = "SIGN IN..."
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.White
        txtUsername.Location = New Point(300, 238)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "USERNAME"
        txtUsername.Size = New Size(229, 23)
        txtUsername.TabIndex = 4
        ToolTip1.SetToolTip(txtUsername, "Enter Username")
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.user__1_
        PictureBox2.Location = New Point(260, 232)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(34, 34)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.White
        txtPassword.Location = New Point(300, 299)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "PASSWORD"
        txtPassword.Size = New Size(229, 23)
        txtPassword.TabIndex = 4
        ToolTip1.SetToolTip(txtPassword, "Enter Password")
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = My.Resources.Resources.padlock
        PictureBox3.Location = New Point(260, 293)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(34, 34)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.DisabledLinkColor = Color.Black
        LinkLabel1.ForeColor = Color.Black
        LinkLabel1.LinkColor = Color.Black
        LinkLabel1.Location = New Point(356, 327)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(173, 15)
        LinkLabel1.TabIndex = 4
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Forgot Username or Password ?"
        ToolTip1.SetToolTip(LinkLabel1, "Click here if you forgot your Username or Password")
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.AliceBlue
        btnLogin.Cursor = Cursors.Hand
        btnLogin.Font = New Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogin.Location = New Point(417, 384)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(138, 46)
        btnLogin.TabIndex = 5
        btnLogin.Text = "LOGIN"
        ToolTip1.SetToolTip(btnLogin, "Click here to login")
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnSignUp
        ' 
        btnSignUp.BackColor = Color.AliceBlue
        btnSignUp.Cursor = Cursors.Hand
        btnSignUp.Font = New Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnSignUp.Location = New Point(258, 384)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(138, 46)
        btnSignUp.TabIndex = 7
        btnSignUp.Text = "SIGN UP"
        ToolTip1.SetToolTip(btnSignUp, "Click here to sign up")
        btnSignUp.UseVisualStyleBackColor = False
        ' 
        ' lblTandC
        ' 
        lblTandC.AutoSize = True
        lblTandC.LinkColor = Color.Black
        lblTandC.Location = New Point(314, 453)
        lblTandC.Name = "lblTandC"
        lblTandC.Size = New Size(184, 15)
        lblTandC.TabIndex = 8
        lblTandC.TabStop = True
        lblTandC.Text = "Terms and Condition and Privacy "
        ToolTip1.SetToolTip(lblTandC, "Ts & Cs")
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.user__2_
        PictureBox1.Location = New Point(334, 51)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(132, 127)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' chkRemember
        ' 
        chkRemember.AutoSize = True
        chkRemember.Location = New Point(389, 345)
        chkRemember.Name = "chkRemember"
        chkRemember.Size = New Size(140, 19)
        chkRemember.TabIndex = 10
        chkRemember.Text = "Remember Username"
        chkRemember.UseVisualStyleBackColor = True
        ' 
        ' LOGIN
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(802, 486)
        Controls.Add(chkRemember)
        Controls.Add(PictureBox1)
        Controls.Add(lblTandC)
        Controls.Add(btnSignUp)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(btnLogin)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(LinkLabel1)
        Controls.Add(Label1)
        Name = "LOGIN"
        Text = "LOGIN"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnSignUp As Button
    Friend WithEvents lblTandC As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents chkRemember As CheckBox
End Class
