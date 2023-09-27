<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Register))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        pbCloseApp = New PictureBox()
        btnLogin = New Button()
        btnRegister = New Button()
        GroupBox3 = New GroupBox()
        txtNoKEmail = New TextBox()
        txtNokPhone = New TextBox()
        txtNoKSurname = New TextBox()
        cbNoKTitle = New ComboBox()
        Label19 = New Label()
        txtNoKNames = New TextBox()
        Label15 = New Label()
        Label18 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        GroupBox2 = New GroupBox()
        txtZip = New TextBox()
        txtCity = New TextBox()
        txtSuburb = New TextBox()
        cbProvince = New ComboBox()
        txtStreet = New TextBox()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label1 = New Label()
        Label20 = New Label()
        GroupBox1 = New GroupBox()
        cbUserGroup = New ComboBox()
        Label10 = New Label()
        cbTitle = New ComboBox()
        txtConfirmPass = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtID = New TextBox()
        txtPass = New TextBox()
        txtEmail = New TextBox()
        txtMobile = New TextBox()
        txtLastName = New TextBox()
        txtNames = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(pbCloseApp, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.live
        PictureBox1.Location = New Point(3, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(263, 105)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(pbCloseApp)
        Panel1.Controls.Add(btnLogin)
        Panel1.Controls.Add(btnRegister)
        Panel1.Controls.Add(GroupBox3)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(Label20)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(879, 486)
        Panel1.TabIndex = 0
        ' 
        ' pbCloseApp
        ' 
        pbCloseApp.Image = CType(resources.GetObject("pbCloseApp.Image"), Image)
        pbCloseApp.Location = New Point(803, 23)
        pbCloseApp.Name = "pbCloseApp"
        pbCloseApp.Size = New Size(48, 46)
        pbCloseApp.TabIndex = 22
        pbCloseApp.TabStop = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.CadetBlue
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Location = New Point(770, 450)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(81, 25)
        btnLogin.TabIndex = 21
        btnLogin.Text = "Go to Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.CadetBlue
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Location = New Point(22, 450)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(81, 25)
        btnRegister.TabIndex = 20
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtNoKEmail)
        GroupBox3.Controls.Add(txtNokPhone)
        GroupBox3.Controls.Add(txtNoKSurname)
        GroupBox3.Controls.Add(cbNoKTitle)
        GroupBox3.Controls.Add(Label19)
        GroupBox3.Controls.Add(txtNoKNames)
        GroupBox3.Controls.Add(Label15)
        GroupBox3.Controls.Add(Label18)
        GroupBox3.Controls.Add(Label16)
        GroupBox3.Controls.Add(Label17)
        GroupBox3.Location = New Point(579, 111)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(272, 320)
        GroupBox3.TabIndex = 0
        GroupBox3.TabStop = False
        GroupBox3.Text = "NEXT OF KIN"
        ' 
        ' txtNoKEmail
        ' 
        txtNoKEmail.BackColor = Color.CadetBlue
        txtNoKEmail.BorderStyle = BorderStyle.FixedSingle
        txtNoKEmail.Location = New Point(113, 170)
        txtNoKEmail.Name = "txtNoKEmail"
        txtNoKEmail.Size = New Size(139, 23)
        txtNoKEmail.TabIndex = 19
        txtNoKEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtNokPhone
        ' 
        txtNokPhone.BackColor = Color.CadetBlue
        txtNokPhone.BorderStyle = BorderStyle.FixedSingle
        txtNokPhone.Location = New Point(113, 112)
        txtNokPhone.Name = "txtNokPhone"
        txtNokPhone.Size = New Size(139, 23)
        txtNokPhone.TabIndex = 17
        txtNokPhone.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtNoKSurname
        ' 
        txtNoKSurname.BackColor = Color.CadetBlue
        txtNoKSurname.BorderStyle = BorderStyle.FixedSingle
        txtNoKSurname.Location = New Point(113, 83)
        txtNoKSurname.Name = "txtNoKSurname"
        txtNoKSurname.Size = New Size(139, 23)
        txtNoKSurname.TabIndex = 16
        txtNoKSurname.TextAlign = HorizontalAlignment.Center
        ' 
        ' cbNoKTitle
        ' 
        cbNoKTitle.BackColor = Color.CadetBlue
        cbNoKTitle.FormattingEnabled = True
        cbNoKTitle.Items.AddRange(New Object() {"Mr", "Ms", "Mrs", "MD", "PhD", "Sir", "King", "Queen"})
        cbNoKTitle.Location = New Point(113, 141)
        cbNoKTitle.Name = "cbNoKTitle"
        cbNoKTitle.Size = New Size(53, 23)
        cbNoKTitle.TabIndex = 18
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(20, 172)
        Label19.Name = "Label19"
        Label19.Size = New Size(39, 15)
        Label19.TabIndex = 0
        Label19.Text = "Email:"
        ' 
        ' txtNoKNames
        ' 
        txtNoKNames.BackColor = Color.CadetBlue
        txtNoKNames.BorderStyle = BorderStyle.FixedSingle
        txtNoKNames.Location = New Point(113, 54)
        txtNoKNames.Name = "txtNoKNames"
        txtNoKNames.Size = New Size(139, 23)
        txtNoKNames.TabIndex = 15
        txtNoKNames.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(20, 56)
        Label15.Name = "Label15"
        Label15.Size = New Size(56, 15)
        Label15.TabIndex = 0
        Label15.Text = "Name(s):"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(20, 114)
        Label18.Name = "Label18"
        Label18.Size = New Size(45, 15)
        Label18.TabIndex = 0
        Label18.Text = "Phone:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(20, 85)
        Label16.Name = "Label16"
        Label16.Size = New Size(60, 15)
        Label16.TabIndex = 0
        Label16.Text = "Surname:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(20, 144)
        Label17.Name = "Label17"
        Label17.Size = New Size(35, 15)
        Label17.TabIndex = 0
        Label17.Text = "Title:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtZip)
        GroupBox2.Controls.Add(txtCity)
        GroupBox2.Controls.Add(txtSuburb)
        GroupBox2.Controls.Add(cbProvince)
        GroupBox2.Controls.Add(txtStreet)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Location = New Point(301, 111)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(272, 320)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        GroupBox2.Text = "ADDRESS"
        ' 
        ' txtZip
        ' 
        txtZip.BackColor = Color.CadetBlue
        txtZip.BorderStyle = BorderStyle.FixedSingle
        txtZip.Location = New Point(102, 170)
        txtZip.MaxLength = 4
        txtZip.Name = "txtZip"
        txtZip.Size = New Size(53, 23)
        txtZip.TabIndex = 14
        txtZip.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCity
        ' 
        txtCity.BackColor = Color.CadetBlue
        txtCity.BorderStyle = BorderStyle.FixedSingle
        txtCity.Location = New Point(102, 112)
        txtCity.Name = "txtCity"
        txtCity.Size = New Size(153, 23)
        txtCity.TabIndex = 12
        txtCity.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtSuburb
        ' 
        txtSuburb.BackColor = Color.CadetBlue
        txtSuburb.BorderStyle = BorderStyle.FixedSingle
        txtSuburb.Location = New Point(102, 83)
        txtSuburb.Name = "txtSuburb"
        txtSuburb.Size = New Size(153, 23)
        txtSuburb.TabIndex = 11
        txtSuburb.TextAlign = HorizontalAlignment.Center
        ' 
        ' cbProvince
        ' 
        cbProvince.BackColor = Color.CadetBlue
        cbProvince.FormattingEnabled = True
        cbProvince.Items.AddRange(New Object() {"Eastern Cape", "Gauteng", "Kwa-Zulu Natal", "Limpopo", "Mpumalanga", "North West", "Northern Cape", "Western Cape"})
        cbProvince.Location = New Point(102, 141)
        cbProvince.Name = "cbProvince"
        cbProvince.Size = New Size(153, 23)
        cbProvince.TabIndex = 13
        ' 
        ' txtStreet
        ' 
        txtStreet.BackColor = Color.CadetBlue
        txtStreet.BorderStyle = BorderStyle.FixedSingle
        txtStreet.Location = New Point(102, 54)
        txtStreet.Name = "txtStreet"
        txtStreet.Size = New Size(153, 23)
        txtStreet.TabIndex = 10
        txtStreet.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(18, 172)
        Label14.Name = "Label14"
        Label14.Size = New Size(55, 15)
        Label14.TabIndex = 0
        Label14.Text = "Zip Code"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(18, 144)
        Label13.Name = "Label13"
        Label13.Size = New Size(56, 15)
        Label13.TabIndex = 0
        Label13.Text = "Province"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(18, 114)
        Label12.Name = "Label12"
        Label12.Size = New Size(63, 15)
        Label12.TabIndex = 0
        Label12.Text = "Town/City"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(18, 85)
        Label11.Name = "Label11"
        Label11.Size = New Size(47, 15)
        Label11.TabIndex = 0
        Label11.Text = "Suburb"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 15)
        Label1.TabIndex = 0
        Label1.Text = "Street"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(599, 455)
        Label20.Name = "Label20"
        Label20.Size = New Size(148, 15)
        Label20.TabIndex = 0
        Label20.Text = "Already have an acoount?"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cbUserGroup)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(cbTitle)
        GroupBox1.Controls.Add(txtConfirmPass)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtID)
        GroupBox1.Controls.Add(txtPass)
        GroupBox1.Controls.Add(txtEmail)
        GroupBox1.Controls.Add(txtMobile)
        GroupBox1.Controls.Add(txtLastName)
        GroupBox1.Controls.Add(txtNames)
        GroupBox1.Location = New Point(23, 111)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(272, 320)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "REGISTRANT INFORMATION"
        ' 
        ' cbUserGroup
        ' 
        cbUserGroup.BackColor = Color.CadetBlue
        cbUserGroup.FormattingEnabled = True
        cbUserGroup.Items.AddRange(New Object() {"Admin", "Patient", "Doctor"})
        cbUserGroup.Location = New Point(124, 286)
        cbUserGroup.Name = "cbUserGroup"
        cbUserGroup.Size = New Size(53, 23)
        cbUserGroup.TabIndex = 9
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(18, 56)
        Label10.Name = "Label10"
        Label10.Size = New Size(56, 15)
        Label10.TabIndex = 0
        Label10.Text = "Name(s):"
        ' 
        ' cbTitle
        ' 
        cbTitle.BackColor = Color.CadetBlue
        cbTitle.FormattingEnabled = True
        cbTitle.Items.AddRange(New Object() {"Mr", "Ms", "Mrs", "MD", "PhD", "Sir", "King", "Queen"})
        cbTitle.Location = New Point(124, 141)
        cbTitle.Name = "cbTitle"
        cbTitle.Size = New Size(53, 23)
        cbTitle.TabIndex = 4
        ' 
        ' txtConfirmPass
        ' 
        txtConfirmPass.BackColor = Color.CadetBlue
        txtConfirmPass.BorderStyle = BorderStyle.FixedSingle
        txtConfirmPass.Location = New Point(124, 257)
        txtConfirmPass.Name = "txtConfirmPass"
        txtConfirmPass.Size = New Size(129, 23)
        txtConfirmPass.TabIndex = 8
        txtConfirmPass.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(18, 201)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 15)
        Label7.TabIndex = 0
        Label7.Text = "Email:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(18, 172)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 15)
        Label6.TabIndex = 0
        Label6.Text = "Phone:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(18, 144)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 15)
        Label5.TabIndex = 0
        Label5.Text = "Title:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(18, 289)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 15)
        Label8.TabIndex = 0
        Label8.Text = "User Group:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(18, 259)
        Label9.Name = "Label9"
        Label9.Size = New Size(105, 15)
        Label9.TabIndex = 0
        Label9.Text = "Repeat Password:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(18, 230)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 15)
        Label4.TabIndex = 0
        Label4.Text = "Password:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(18, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 15)
        Label3.TabIndex = 0
        Label3.Text = "ID Number:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 0
        Label2.Text = "Surname:"
        ' 
        ' txtID
        ' 
        txtID.BackColor = Color.CadetBlue
        txtID.BorderStyle = BorderStyle.FixedSingle
        txtID.Location = New Point(124, 112)
        txtID.MaxLength = 13
        txtID.Name = "txtID"
        txtID.Size = New Size(129, 23)
        txtID.TabIndex = 3
        txtID.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPass
        ' 
        txtPass.BackColor = Color.CadetBlue
        txtPass.BorderStyle = BorderStyle.FixedSingle
        txtPass.Location = New Point(124, 228)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(129, 23)
        txtPass.TabIndex = 7
        txtPass.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.CadetBlue
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Location = New Point(124, 199)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(129, 23)
        txtEmail.TabIndex = 6
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtMobile
        ' 
        txtMobile.BackColor = Color.CadetBlue
        txtMobile.BorderStyle = BorderStyle.FixedSingle
        txtMobile.Location = New Point(124, 170)
        txtMobile.Name = "txtMobile"
        txtMobile.Size = New Size(129, 23)
        txtMobile.TabIndex = 5
        txtMobile.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtLastName
        ' 
        txtLastName.BackColor = Color.CadetBlue
        txtLastName.BorderStyle = BorderStyle.FixedSingle
        txtLastName.Location = New Point(124, 83)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(129, 23)
        txtLastName.TabIndex = 2
        txtLastName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtNames
        ' 
        txtNames.BackColor = Color.CadetBlue
        txtNames.BorderStyle = BorderStyle.FixedSingle
        txtNames.Location = New Point(124, 54)
        txtNames.Name = "txtNames"
        txtNames.Size = New Size(129, 23)
        txtNames.TabIndex = 1
        txtNames.TextAlign = HorizontalAlignment.Center
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(882, 489)
        ControlBox = False
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(pbCloseApp, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNames As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtNoKEmail As TextBox
    Friend WithEvents txtNokPhone As TextBox
    Friend WithEvents txtNoKSurname As TextBox
    Friend WithEvents cbNoKTitle As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtNoKNames As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtSuburb As TextBox
    Friend WithEvents cbProvince As ComboBox
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbUserGroup As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbTitle As ComboBox
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents pbCloseApp As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label20 As Label
End Class
