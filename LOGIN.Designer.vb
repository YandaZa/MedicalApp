<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        pbClossApp = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        btnCreateAccount = New Button()
        btnLogin = New Button()
        txtPassword = New TextBox()
        txtID = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(pbClossApp, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.live
        PictureBox1.Location = New Point(210, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(417, 159)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(pbClossApp)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(btnCreateAccount)
        Panel1.Controls.Add(btnLogin)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(txtID)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(858, 465)
        Panel1.TabIndex = 0
        ' 
        ' pbClossApp
        ' 
        pbClossApp.Image = CType(resources.GetObject("pbClossApp.Image"), Image)
        pbClossApp.Location = New Point(792, 18)
        pbClossApp.Name = "pbClossApp"
        pbClossApp.Size = New Size(52, 50)
        pbClossApp.TabIndex = 7
        pbClossApp.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.medical_care
        PictureBox3.Location = New Point(332, 216)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(29, 26)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.padlock
        PictureBox2.Location = New Point(336, 274)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(25, 26)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' btnCreateAccount
        ' 
        btnCreateAccount.BackColor = Color.CadetBlue
        btnCreateAccount.FlatStyle = FlatStyle.Flat
        btnCreateAccount.Location = New Point(376, 351)
        btnCreateAccount.Name = "btnCreateAccount"
        btnCreateAccount.Size = New Size(120, 30)
        btnCreateAccount.TabIndex = 4
        btnCreateAccount.Text = "&Create account"
        btnCreateAccount.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.CadetBlue
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Location = New Point(396, 315)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 30)
        btnLogin.TabIndex = 3
        btnLogin.Text = "&Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.CadetBlue
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Location = New Point(367, 277)
        txtPassword.MaxLength = 20
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(149, 23)
        txtPassword.TabIndex = 2
        ' 
        ' txtID
        ' 
        txtID.BackColor = Color.CadetBlue
        txtID.BorderStyle = BorderStyle.FixedSingle
        txtID.Location = New Point(367, 219)
        txtID.MaxLength = 13
        txtID.Name = "txtID"
        txtID.Size = New Size(149, 23)
        txtID.TabIndex = 1
        txtID.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(412, 259)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 0
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(412, 201)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 15)
        Label1.TabIndex = 0
        Label1.Text = " User ID"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(882, 489)
        ControlBox = False
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(pbClossApp, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents pbClossApp As PictureBox
End Class
