<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REGISTER
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
        lblPhone = New Label()
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        txtIDnum = New TextBox()
        txtEmail = New TextBox()
        txtPassword = New TextBox()
        txtConfirm = New TextBox()
        btnNext = New Button()
        MaskedTextBox1 = New MaskedTextBox()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        lblTandC = New LinkLabel()
        ToolTip1 = New ToolTip(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Mongolian Baiti", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(350, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 37)
        Label1.TabIndex = 0
        Label1.Text = "SIGN UP"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.BackColor = Color.Transparent
        lblPhone.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblPhone.ForeColor = Color.Black
        lblPhone.Location = New Point(169, 319)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(82, 15)
        lblPhone.TabIndex = 9
        lblPhone.Text = "Phone/ Home"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.BackColor = Color.White
        txtFirstName.Location = New Point(169, 122)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.PlaceholderText = "First Name(s)"
        txtFirstName.Size = New Size(206, 23)
        txtFirstName.TabIndex = 10
        ToolTip1.SetToolTip(txtFirstName, "Enter your first name(s)")
        ' 
        ' txtLastName
        ' 
        txtLastName.BackColor = Color.White
        txtLastName.Location = New Point(477, 122)
        txtLastName.Name = "txtLastName"
        txtLastName.PlaceholderText = "Last Name"
        txtLastName.Size = New Size(206, 23)
        txtLastName.TabIndex = 11
        ToolTip1.SetToolTip(txtLastName, "Enter your last name")
        ' 
        ' txtIDnum
        ' 
        txtIDnum.BackColor = Color.White
        txtIDnum.Location = New Point(477, 172)
        txtIDnum.Name = "txtIDnum"
        txtIDnum.PlaceholderText = "ID Number"
        txtIDnum.Size = New Size(206, 23)
        txtIDnum.TabIndex = 12
        ToolTip1.SetToolTip(txtIDnum, "Enter your identity number")
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.White
        txtEmail.Location = New Point(169, 272)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email Address"
        txtEmail.Size = New Size(206, 23)
        txtEmail.TabIndex = 13
        ToolTip1.SetToolTip(txtEmail, "Enter your email address")
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.White
        txtPassword.Location = New Point(169, 221)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Password"
        txtPassword.Size = New Size(206, 23)
        txtPassword.TabIndex = 14
        ToolTip1.SetToolTip(txtPassword, "Enter password")
        ' 
        ' txtConfirm
        ' 
        txtConfirm.BackColor = Color.White
        txtConfirm.Location = New Point(477, 221)
        txtConfirm.Name = "txtConfirm"
        txtConfirm.PlaceholderText = "Confirm Password"
        txtConfirm.Size = New Size(206, 23)
        txtConfirm.TabIndex = 15
        ToolTip1.SetToolTip(txtConfirm, "Confirm your password")
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(360, 394)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(126, 42)
        btnNext.TabIndex = 19
        btnNext.Text = "NEXT"
        ToolTip1.SetToolTip(btnNext, "Click for next")
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Location = New Point(169, 337)
        MaskedTextBox1.Mask = "(999) 000-0000"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(206, 23)
        MaskedTextBox1.TabIndex = 23
        ToolTip1.SetToolTip(MaskedTextBox1, "Enter phone/home number")
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Mr.", "Mrs.", "Miss.", "Ms.", "Other.", "Prof.", "Dr."})
        ComboBox1.Location = New Point(169, 172)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(206, 23)
        ComboBox1.TabIndex = 24
        ToolTip1.SetToolTip(ComboBox1, "Select your title")
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(169, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(29, 15)
        Label2.TabIndex = 25
        Label2.Text = "Title"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.user
        PictureBox1.Location = New Point(54, 52)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(43, 39)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(103, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 17)
        Label3.TabIndex = 27
        Label3.Text = "Get started..."
        ' 
        ' lblTandC
        ' 
        lblTandC.AutoSize = True
        lblTandC.LinkColor = Color.Black
        lblTandC.Location = New Point(336, 448)
        lblTandC.Name = "lblTandC"
        lblTandC.Size = New Size(184, 15)
        lblTandC.TabIndex = 28
        lblTandC.TabStop = True
        lblTandC.Text = "Terms and Condition and Privacy "
        ToolTip1.SetToolTip(lblTandC, "click here to view the terms & conditions and privacy")
        ' 
        ' REGISTER
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(865, 478)
        Controls.Add(lblTandC)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(MaskedTextBox1)
        Controls.Add(btnNext)
        Controls.Add(txtConfirm)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(txtIDnum)
        Controls.Add(txtLastName)
        Controls.Add(txtFirstName)
        Controls.Add(lblPhone)
        Controls.Add(Label1)
        Name = "REGISTER"
        Text = "REGISTER"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtIDnum As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTandC As LinkLabel
    Friend WithEvents ToolTip1 As ToolTip
End Class
