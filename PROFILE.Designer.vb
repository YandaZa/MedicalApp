<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PROFILE
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnPersonalInfo = New Button()
        btnResAddress = New Button()
        btnMedicalAid = New Button()
        btnEmergency = New Button()
        btnMedicalRecord = New Button()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        btnHome = New Button()
        ToolTip1 = New ToolTip(components)
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.AliceBlue
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(282, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(295, 238)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.user1
        PictureBox1.Location = New Point(55, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(181, 177)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.LightSkyBlue
        Label1.Location = New Point(90, 183)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 25)
        Label1.TabIndex = 6
        Label1.Text = "My Profile"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(51, 214)
        Label2.Name = "Label2"
        Label2.Size = New Size(194, 16)
        Label2.TabIndex = 7
        Label2.Text = "Ms Wendy Athayanda Zakhe"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(90, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 8
        ' 
        ' btnPersonalInfo
        ' 
        btnPersonalInfo.BackColor = Color.PowderBlue
        btnPersonalInfo.Location = New Point(30, 173)
        btnPersonalInfo.Name = "btnPersonalInfo"
        btnPersonalInfo.Size = New Size(167, 44)
        btnPersonalInfo.TabIndex = 9
        btnPersonalInfo.Text = "PERSONAL INFORMATION"
        ToolTip1.SetToolTip(btnPersonalInfo, "Click to view yourPersonal Information")
        btnPersonalInfo.UseVisualStyleBackColor = False
        ' 
        ' btnResAddress
        ' 
        btnResAddress.BackColor = Color.PowderBlue
        btnResAddress.Location = New Point(337, 393)
        btnResAddress.Name = "btnResAddress"
        btnResAddress.Size = New Size(167, 44)
        btnResAddress.TabIndex = 10
        btnResAddress.Text = "RESIDENTIAL ADDRESS"
        ToolTip1.SetToolTip(btnResAddress, "Click to view your Residential address")
        btnResAddress.UseVisualStyleBackColor = False
        ' 
        ' btnMedicalAid
        ' 
        btnMedicalAid.BackColor = Color.PowderBlue
        btnMedicalAid.Location = New Point(80, 393)
        btnMedicalAid.Name = "btnMedicalAid"
        btnMedicalAid.Size = New Size(167, 44)
        btnMedicalAid.TabIndex = 11
        btnMedicalAid.Text = "MEDICAL AID DETAILS"
        ToolTip1.SetToolTip(btnMedicalAid, "Click to view your Medical Aid details")
        btnMedicalAid.UseVisualStyleBackColor = False
        ' 
        ' btnEmergency
        ' 
        btnEmergency.BackColor = Color.PowderBlue
        btnEmergency.Location = New Point(593, 393)
        btnEmergency.Name = "btnEmergency"
        btnEmergency.Size = New Size(167, 44)
        btnEmergency.TabIndex = 12
        btnEmergency.Text = "EMERGENCY CONTACTS"
        ToolTip1.SetToolTip(btnEmergency, "Click to view your Emergency contacts")
        btnEmergency.UseVisualStyleBackColor = False
        ' 
        ' btnMedicalRecord
        ' 
        btnMedicalRecord.BackColor = Color.PowderBlue
        btnMedicalRecord.Location = New Point(663, 173)
        btnMedicalRecord.Name = "btnMedicalRecord"
        btnMedicalRecord.Size = New Size(167, 44)
        btnMedicalRecord.TabIndex = 13
        btnMedicalRecord.Text = "MEDICAL RECORDS"
        ToolTip1.SetToolTip(btnMedicalRecord, "Click to view your Medical Record")
        btnMedicalRecord.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.user__3_1
        PictureBox2.Location = New Point(80, 98)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(70, 69)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 20
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.first_aid_kit__1_1
        PictureBox3.Location = New Point(127, 318)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(70, 69)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 21
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.home_address1
        PictureBox4.Location = New Point(382, 318)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(70, 69)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 22
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.emergency_call__1_4
        PictureBox5.Location = New Point(635, 318)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(70, 69)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 23
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.medical_record1
        PictureBox6.Location = New Point(710, 98)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(70, 69)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 24
        PictureBox6.TabStop = False
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.PowderBlue
        btnHome.Location = New Point(7, 6)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(71, 26)
        btnHome.TabIndex = 25
        btnHome.Text = "HOME"
        ToolTip1.SetToolTip(btnHome, "Return to home page")
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' PROFILE
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(864, 481)
        Controls.Add(btnHome)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(btnMedicalRecord)
        Controls.Add(btnEmergency)
        Controls.Add(btnMedicalAid)
        Controls.Add(btnResAddress)
        Controls.Add(btnPersonalInfo)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Name = "PROFILE"
        Text = "MY PROFILE"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPersonalInfo As Button
    Friend WithEvents btnResAddress As Button
    Friend WithEvents btnMedicalAid As Button
    Friend WithEvents btnEmergency As Button
    Friend WithEvents btnMedicalRecord As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents btnHome As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
