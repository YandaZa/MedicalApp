<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BOOKING_OT
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
        Label3 = New Label()
        cbTime = New ComboBox()
        MonthCalendar1 = New MonthCalendar()
        Panel1 = New Panel()
        lblEmail = New Label()
        lblPhone = New Label()
        lblActiveUser = New Label()
        PictureBox5 = New PictureBox()
        Label6 = New Label()
        PictureBox4 = New PictureBox()
        PictureBox1 = New PictureBox()
        btnSubmitOT = New Button()
        ToolTip1 = New ToolTip(components)
        btnHome = New Button()
        btnMD = New Button()
        btnPerdiatrician = New Button()
        btnDentist = New Button()
        btnOtolaryngologist = New Button()
        btnOptometrist = New Button()
        btnDermatologist = New Button()
        PictureBox3 = New PictureBox()
        Panel3 = New Panel()
        btnPM = New Button()
        btnAM = New Button()
        pbDerma = New PictureBox()
        pbOptimitrist = New PictureBox()
        pbEar = New PictureBox()
        pbCardio = New PictureBox()
        btnCardialogist = New Button()
        pbDentist = New PictureBox()
        pbPerdiatrician = New PictureBox()
        pbMD = New PictureBox()
        Label4 = New Label()
        Label2 = New Label()
        txtAppDescription = New TextBox()
        txtAppointmentTitle = New TextBox()
        Panel4 = New Panel()
        Label5 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(pbDerma, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbOptimitrist, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbEar, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbCardio, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbDentist, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbPerdiatrician, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMD, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(15, 202)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 20)
        Label3.TabIndex = 15
        Label3.Text = "TIME"
        ' 
        ' cbTime
        ' 
        cbTime.FormattingEnabled = True
        cbTime.Items.AddRange(New Object() {"01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00"})
        cbTime.Location = New Point(73, 203)
        cbTime.Name = "cbTime"
        cbTime.Size = New Size(108, 23)
        cbTime.TabIndex = 0
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.AccessibleRole = AccessibleRole.MenuBar
        MonthCalendar1.BackColor = Color.CadetBlue
        MonthCalendar1.Location = New Point(12, 122)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 12
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(lblEmail)
        Panel1.Controls.Add(lblPhone)
        Panel1.Controls.Add(lblActiveUser)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(591, 98)
        Panel1.TabIndex = 11
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmail.Location = New Point(91, 49)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(43, 15)
        lblEmail.TabIndex = 3
        lblEmail.Text = "Label1"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblPhone.Location = New Point(91, 34)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(55, 15)
        lblPhone.TabIndex = 3
        lblPhone.Text = "lblPhone"
        ' 
        ' lblActiveUser
        ' 
        lblActiveUser.AutoSize = True
        lblActiveUser.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblActiveUser.Location = New Point(91, 19)
        lblActiveUser.Name = "lblActiveUser"
        lblActiveUser.Size = New Size(43, 15)
        lblActiveUser.TabIndex = 3
        lblActiveUser.Text = "Label1"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.rating
        PictureBox5.Location = New Point(399, 44)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(62, 36)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 1
        PictureBox5.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(399, 11)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 30)
        Label6.TabIndex = 2
        Label6.Text = "Dr Liyema" & vbCrLf & "Otolaryngologist" & vbCrLf
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.otolaryngologist
        PictureBox4.Location = New Point(317, 19)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(65, 61)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.otolaryngologist
        PictureBox1.Location = New Point(20, 19)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(65, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' btnSubmitOT
        ' 
        btnSubmitOT.BackColor = Color.CadetBlue
        btnSubmitOT.Cursor = Cursors.Hand
        btnSubmitOT.FlatStyle = FlatStyle.Flat
        btnSubmitOT.Location = New Point(12, 454)
        btnSubmitOT.Name = "btnSubmitOT"
        btnSubmitOT.Size = New Size(75, 23)
        btnSubmitOT.TabIndex = 16
        btnSubmitOT.Text = "SUBMIT"
        ToolTip1.SetToolTip(btnSubmitOT, "Click to submit")
        btnSubmitOT.UseVisualStyleBackColor = False
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.CadetBlue
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.Location = New Point(93, 454)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(75, 23)
        btnHome.TabIndex = 17
        btnHome.Text = "HOME"
        ToolTip1.SetToolTip(btnHome, "Return to home page")
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' btnMD
        ' 
        btnMD.BackColor = Color.CadetBlue
        btnMD.Cursor = Cursors.Hand
        btnMD.FlatStyle = FlatStyle.Flat
        btnMD.Font = New Font("Segoe UI", 6F, FontStyle.Bold, GraphicsUnit.Point)
        btnMD.Location = New Point(320, 102)
        btnMD.Name = "btnMD"
        btnMD.Size = New Size(85, 37)
        btnMD.TabIndex = 0
        btnMD.Text = "MEDICAL DOCTOR"
        ToolTip1.SetToolTip(btnMD, "Medical Doctor")
        btnMD.UseVisualStyleBackColor = False
        ' 
        ' btnPerdiatrician
        ' 
        btnPerdiatrician.BackColor = Color.CadetBlue
        btnPerdiatrician.Cursor = Cursors.Hand
        btnPerdiatrician.FlatStyle = FlatStyle.Flat
        btnPerdiatrician.Font = New Font("Segoe UI", 6F, FontStyle.Bold, GraphicsUnit.Point)
        btnPerdiatrician.Location = New Point(411, 102)
        btnPerdiatrician.Name = "btnPerdiatrician"
        btnPerdiatrician.Size = New Size(83, 37)
        btnPerdiatrician.TabIndex = 7
        btnPerdiatrician.Text = "P&AEDIATRICIAN"
        ToolTip1.SetToolTip(btnPerdiatrician, "Paediatrician")
        btnPerdiatrician.UseVisualStyleBackColor = False
        ' 
        ' btnDentist
        ' 
        btnDentist.BackColor = Color.CadetBlue
        btnDentist.Cursor = Cursors.Hand
        btnDentist.FlatStyle = FlatStyle.Flat
        btnDentist.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point)
        btnDentist.Location = New Point(500, 102)
        btnDentist.Name = "btnDentist"
        btnDentist.Size = New Size(93, 37)
        btnDentist.TabIndex = 9
        btnDentist.Text = "&Dentist"
        ToolTip1.SetToolTip(btnDentist, "Paediatrician")
        btnDentist.UseVisualStyleBackColor = False
        ' 
        ' btnOtolaryngologist
        ' 
        btnOtolaryngologist.BackColor = Color.CadetBlue
        btnOtolaryngologist.Cursor = Cursors.Hand
        btnOtolaryngologist.FlatStyle = FlatStyle.Flat
        btnOtolaryngologist.Font = New Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point)
        btnOtolaryngologist.Location = New Point(469, 315)
        btnOtolaryngologist.Name = "btnOtolaryngologist"
        btnOtolaryngologist.Size = New Size(124, 37)
        btnOtolaryngologist.TabIndex = 12
        btnOtolaryngologist.Text = "OT&OLARYNGOLOGIST"
        ToolTip1.SetToolTip(btnOtolaryngologist, "Otolaryngologist")
        btnOtolaryngologist.UseVisualStyleBackColor = False
        ' 
        ' btnOptometrist
        ' 
        btnOptometrist.BackColor = Color.CadetBlue
        btnOptometrist.Cursor = Cursors.Hand
        btnOptometrist.FlatStyle = FlatStyle.Flat
        btnOptometrist.Font = New Font("Segoe UI", 6F, FontStyle.Bold, GraphicsUnit.Point)
        btnOptometrist.Location = New Point(320, 202)
        btnOptometrist.Name = "btnOptometrist"
        btnOptometrist.Size = New Size(143, 37)
        btnOptometrist.TabIndex = 14
        btnOptometrist.Text = "&OPTOMETRIST "
        ToolTip1.SetToolTip(btnOptometrist, "Optometrist")
        btnOptometrist.UseVisualStyleBackColor = False
        ' 
        ' btnDermatologist
        ' 
        btnDermatologist.BackColor = Color.CadetBlue
        btnDermatologist.Cursor = Cursors.Hand
        btnDermatologist.FlatStyle = FlatStyle.Flat
        btnDermatologist.Font = New Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point)
        btnDermatologist.Location = New Point(320, 315)
        btnDermatologist.Name = "btnDermatologist"
        btnDermatologist.Size = New Size(143, 37)
        btnDermatologist.TabIndex = 16
        btnDermatologist.Text = "D&emartologist"
        ToolTip1.SetToolTip(btnDermatologist, "Optometrist")
        btnDermatologist.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.live
        PictureBox3.Location = New Point(609, 12)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(261, 98)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 18
        PictureBox3.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.CadetBlue
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(cbTime)
        Panel3.Controls.Add(btnPM)
        Panel3.Controls.Add(btnAM)
        Panel3.Controls.Add(btnDermatologist)
        Panel3.Controls.Add(pbDerma)
        Panel3.Controls.Add(btnOptometrist)
        Panel3.Controls.Add(pbOptimitrist)
        Panel3.Controls.Add(btnOtolaryngologist)
        Panel3.Controls.Add(pbEar)
        Panel3.Controls.Add(pbCardio)
        Panel3.Controls.Add(btnCardialogist)
        Panel3.Controls.Add(btnDentist)
        Panel3.Controls.Add(pbDentist)
        Panel3.Controls.Add(btnPerdiatrician)
        Panel3.Controls.Add(pbPerdiatrician)
        Panel3.Controls.Add(pbMD)
        Panel3.Controls.Add(btnMD)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(txtAppDescription)
        Panel3.Controls.Add(txtAppointmentTitle)
        Panel3.Location = New Point(251, 122)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(619, 355)
        Panel3.TabIndex = 19
        ' 
        ' btnPM
        ' 
        btnPM.BackColor = Color.CadetBlue
        btnPM.FlatStyle = FlatStyle.Flat
        btnPM.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnPM.Location = New Point(130, 239)
        btnPM.Name = "btnPM"
        btnPM.Size = New Size(51, 23)
        btnPM.TabIndex = 17
        btnPM.Text = "PM"
        btnPM.UseVisualStyleBackColor = False
        ' 
        ' btnAM
        ' 
        btnAM.BackColor = Color.CadetBlue
        btnAM.FlatStyle = FlatStyle.Flat
        btnAM.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnAM.Location = New Point(73, 239)
        btnAM.Name = "btnAM"
        btnAM.Size = New Size(51, 23)
        btnAM.TabIndex = 17
        btnAM.Text = "AM"
        btnAM.UseVisualStyleBackColor = False
        ' 
        ' pbDerma
        ' 
        pbDerma.BackColor = Color.Transparent
        pbDerma.Image = My.Resources.Resources.dermatologist
        pbDerma.Location = New Point(320, 245)
        pbDerma.Name = "pbDerma"
        pbDerma.Size = New Size(143, 65)
        pbDerma.SizeMode = PictureBoxSizeMode.StretchImage
        pbDerma.TabIndex = 15
        pbDerma.TabStop = False
        ' 
        ' pbOptimitrist
        ' 
        pbOptimitrist.BackColor = Color.Transparent
        pbOptimitrist.Image = My.Resources.Resources.optometrist
        pbOptimitrist.Location = New Point(320, 146)
        pbOptimitrist.Name = "pbOptimitrist"
        pbOptimitrist.Size = New Size(143, 50)
        pbOptimitrist.SizeMode = PictureBoxSizeMode.StretchImage
        pbOptimitrist.TabIndex = 13
        pbOptimitrist.TabStop = False
        ' 
        ' pbEar
        ' 
        pbEar.BackColor = Color.Transparent
        pbEar.Image = My.Resources.Resources.deaf
        pbEar.Location = New Point(469, 245)
        pbEar.Name = "pbEar"
        pbEar.Size = New Size(124, 65)
        pbEar.SizeMode = PictureBoxSizeMode.StretchImage
        pbEar.TabIndex = 11
        pbEar.TabStop = False
        ' 
        ' pbCardio
        ' 
        pbCardio.BackColor = Color.Transparent
        pbCardio.Image = My.Resources.Resources.medical
        pbCardio.Location = New Point(469, 146)
        pbCardio.Name = "pbCardio"
        pbCardio.Size = New Size(124, 50)
        pbCardio.SizeMode = PictureBoxSizeMode.StretchImage
        pbCardio.TabIndex = 10
        pbCardio.TabStop = False
        ' 
        ' btnCardialogist
        ' 
        btnCardialogist.BackColor = Color.CadetBlue
        btnCardialogist.Cursor = Cursors.Hand
        btnCardialogist.FlatStyle = FlatStyle.Flat
        btnCardialogist.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point)
        btnCardialogist.Location = New Point(469, 202)
        btnCardialogist.Name = "btnCardialogist"
        btnCardialogist.Size = New Size(124, 37)
        btnCardialogist.TabIndex = 9
        btnCardialogist.Text = "&Cadiologist"
        btnCardialogist.UseVisualStyleBackColor = False
        ' 
        ' pbDentist
        ' 
        pbDentist.BackColor = Color.Transparent
        pbDentist.Image = My.Resources.Resources.dentist__1_
        pbDentist.Location = New Point(500, 46)
        pbDentist.Name = "pbDentist"
        pbDentist.Size = New Size(93, 50)
        pbDentist.SizeMode = PictureBoxSizeMode.StretchImage
        pbDentist.TabIndex = 8
        pbDentist.TabStop = False
        ' 
        ' pbPerdiatrician
        ' 
        pbPerdiatrician.BackColor = Color.Transparent
        pbPerdiatrician.Image = My.Resources.Resources.children
        pbPerdiatrician.Location = New Point(411, 46)
        pbPerdiatrician.Name = "pbPerdiatrician"
        pbPerdiatrician.Size = New Size(83, 50)
        pbPerdiatrician.SizeMode = PictureBoxSizeMode.StretchImage
        pbPerdiatrician.TabIndex = 6
        pbPerdiatrician.TabStop = False
        ' 
        ' pbMD
        ' 
        pbMD.BackColor = Color.Transparent
        pbMD.Image = My.Resources.Resources.medical_assistance
        pbMD.Location = New Point(320, 46)
        pbMD.Name = "pbMD"
        pbMD.Size = New Size(85, 50)
        pbMD.SizeMode = PictureBoxSizeMode.StretchImage
        pbMD.TabIndex = 1
        pbMD.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(15, 93)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 15)
        Label4.TabIndex = 1
        Label4.Text = "Appointment Description"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(15, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 15)
        Label2.TabIndex = 1
        Label2.Text = "Appointment Title"
        ' 
        ' txtAppDescription
        ' 
        txtAppDescription.BorderStyle = BorderStyle.FixedSingle
        txtAppDescription.Location = New Point(15, 120)
        txtAppDescription.Multiline = True
        txtAppDescription.Name = "txtAppDescription"
        txtAppDescription.Size = New Size(274, 70)
        txtAppDescription.TabIndex = 0
        ' 
        ' txtAppointmentTitle
        ' 
        txtAppointmentTitle.BorderStyle = BorderStyle.FixedSingle
        txtAppointmentTitle.Location = New Point(15, 46)
        txtAppointmentTitle.Name = "txtAppointmentTitle"
        txtAppointmentTitle.Size = New Size(274, 23)
        txtAppointmentTitle.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label5)
        Panel4.Location = New Point(12, 296)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(227, 88)
        Panel4.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(52, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(148, 15)
        Label5.TabIndex = 1
        Label5.Text = "Appointment Description"
        ' 
        ' BOOKING_OT
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(882, 489)
        ControlBox = False
        Controls.Add(Panel3)
        Controls.Add(PictureBox3)
        Controls.Add(btnHome)
        Controls.Add(btnSubmitOT)
        Controls.Add(MonthCalendar1)
        Controls.Add(Panel1)
        Controls.Add(Panel4)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "BOOKING_OT"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(pbDerma, ComponentModel.ISupportInitialize).EndInit()
        CType(pbOptimitrist, ComponentModel.ISupportInitialize).EndInit()
        CType(pbEar, ComponentModel.ISupportInitialize).EndInit()
        CType(pbCardio, ComponentModel.ISupportInitialize).EndInit()
        CType(pbDentist, ComponentModel.ISupportInitialize).EndInit()
        CType(pbPerdiatrician, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMD, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSubmitOT As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnHome As Button
    Friend WithEvents cbTime As ComboBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAppDescription As TextBox
    Friend WithEvents txtAppointmentTitle As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblActiveUser As Label
    Friend WithEvents pbMD As PictureBox
    Friend WithEvents btnMD As Button
    Friend WithEvents pbPerdiatrician As PictureBox
    Friend WithEvents btnPerdiatrician As Button
    Friend WithEvents btnDentist As Button
    Friend WithEvents pbDentist As PictureBox
    Friend WithEvents pbCardio As PictureBox
    Friend WithEvents btnCardialogist As Button
    Friend WithEvents pbEar As PictureBox
    Friend WithEvents btnOtolaryngologist As Button
    Friend WithEvents pbOptimitrist As PictureBox
    Friend WithEvents btnOptometrist As Button
    Friend WithEvents btnDermatologist As Button
    Friend WithEvents pbDerma As PictureBox
    Friend WithEvents btnPM As Button
    Friend WithEvents btnAM As Button
End Class
