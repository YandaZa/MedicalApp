<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BOOKING_CONFIRMATION
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
        cmbPills = New ComboBox()
        lblQ3 = New Label()
        ListBox1 = New ListBox()
        rd1 = New RadioButton()
        rd2 = New RadioButton()
        rd3 = New RadioButton()
        chkMorning = New CheckBox()
        chkAfternoon = New CheckBox()
        chkEvening = New CheckBox()
        lblQ4 = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        lblQ2 = New Label()
        btnSubmitR = New Button()
        btnHome = New Button()
        lblstatement1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmbPills
        ' 
        cmbPills.FormattingEnabled = True
        cmbPills.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        cmbPills.Location = New Point(20, 52)
        cmbPills.Name = "cmbPills"
        cmbPills.Size = New Size(148, 23)
        cmbPills.TabIndex = 0
        ' 
        ' lblQ3
        ' 
        lblQ3.AutoSize = True
        lblQ3.Font = New Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblQ3.Location = New Point(6, 18)
        lblQ3.Name = "lblQ3"
        lblQ3.Size = New Size(217, 16)
        lblQ3.TabIndex = 1
        lblQ3.Text = "How many types of pills do take?"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(424, 116)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(254, 274)
        ListBox1.TabIndex = 2
        ' 
        ' rd1
        ' 
        rd1.AutoSize = True
        rd1.Location = New Point(22, 48)
        rd1.Name = "rd1"
        rd1.Size = New Size(31, 19)
        rd1.TabIndex = 3
        rd1.TabStop = True
        rd1.Text = "1"
        rd1.UseVisualStyleBackColor = True
        ' 
        ' rd2
        ' 
        rd2.AutoSize = True
        rd2.Location = New Point(22, 73)
        rd2.Name = "rd2"
        rd2.Size = New Size(31, 19)
        rd2.TabIndex = 4
        rd2.TabStop = True
        rd2.Text = "2"
        rd2.UseVisualStyleBackColor = True
        ' 
        ' rd3
        ' 
        rd3.AutoSize = True
        rd3.Location = New Point(22, 98)
        rd3.Name = "rd3"
        rd3.Size = New Size(31, 19)
        rd3.TabIndex = 5
        rd3.TabStop = True
        rd3.Text = "3"
        rd3.UseVisualStyleBackColor = True
        ' 
        ' chkMorning
        ' 
        chkMorning.AutoSize = True
        chkMorning.Location = New Point(12, 192)
        chkMorning.Name = "chkMorning"
        chkMorning.Size = New Size(72, 19)
        chkMorning.TabIndex = 6
        chkMorning.Text = "Morning"
        chkMorning.UseVisualStyleBackColor = True
        ' 
        ' chkAfternoon
        ' 
        chkAfternoon.AutoSize = True
        chkAfternoon.Location = New Point(12, 217)
        chkAfternoon.Name = "chkAfternoon"
        chkAfternoon.Size = New Size(80, 19)
        chkAfternoon.TabIndex = 7
        chkAfternoon.Text = "Afternoon"
        chkAfternoon.UseVisualStyleBackColor = True
        ' 
        ' chkEvening
        ' 
        chkEvening.AutoSize = True
        chkEvening.Location = New Point(12, 242)
        chkEvening.Name = "chkEvening"
        chkEvening.Size = New Size(68, 19)
        chkEvening.TabIndex = 8
        chkEvening.Text = "Evening"
        chkEvening.UseVisualStyleBackColor = True
        ' 
        ' lblQ4
        ' 
        lblQ4.AutoSize = True
        lblQ4.Font = New Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblQ4.Location = New Point(5, 14)
        lblQ4.Name = "lblQ4"
        lblQ4.Size = New Size(234, 32)
        lblQ4.TabIndex = 9
        lblQ4.Text = "Select the number of times each pill " & vbCrLf & "should be taken a day."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(3, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(231, 15)
        Label3.TabIndex = 10
        Label3.Text = "(you  can select more than one check box)"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(cmbPills)
        Panel1.Controls.Add(lblQ3)
        Panel1.Location = New Point(44, 62)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(236, 100)
        Panel1.TabIndex = 11
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lblstatement1)
        Panel2.Controls.Add(lblQ4)
        Panel2.Controls.Add(rd1)
        Panel2.Controls.Add(chkEvening)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(chkAfternoon)
        Panel2.Controls.Add(rd2)
        Panel2.Controls.Add(chkMorning)
        Panel2.Controls.Add(rd3)
        Panel2.Location = New Point(44, 179)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(248, 286)
        Panel2.TabIndex = 12
        ' 
        ' lblQ2
        ' 
        lblQ2.AutoSize = True
        lblQ2.Font = New Font("Mongolian Baiti", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblQ2.Location = New Point(161, 28)
        lblQ2.Name = "lblQ2"
        lblQ2.Size = New Size(359, 20)
        lblQ2.TabIndex = 13
        lblQ2.Text = "Set a reminder for your daily medication"
        ' 
        ' btnSubmitR
        ' 
        btnSubmitR.BackColor = Color.PowderBlue
        btnSubmitR.Location = New Point(616, 437)
        btnSubmitR.Name = "btnSubmitR"
        btnSubmitR.Size = New Size(103, 42)
        btnSubmitR.TabIndex = 14
        btnSubmitR.Text = "SUBMIT"
        btnSubmitR.UseVisualStyleBackColor = False
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.PowderBlue
        btnHome.Location = New Point(12, 3)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(75, 23)
        btnHome.TabIndex = 15
        btnHome.Text = "HOME"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' lblstatement1
        ' 
        lblstatement1.AutoSize = True
        lblstatement1.Font = New Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblstatement1.Location = New Point(3, 151)
        lblstatement1.Name = "lblstatement1"
        lblstatement1.Size = New Size(99, 16)
        lblstatement1.TabIndex = 11
        lblstatement1.Text = "Period per pill:"
        ' 
        ' BOOKING_CONFIRMATION
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(733, 491)
        Controls.Add(btnHome)
        Controls.Add(btnSubmitR)
        Controls.Add(lblQ2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(ListBox1)
        Name = "BOOKING_CONFIRMATION"
        Text = "BOOKING_CONFIRMATION"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbPills As ComboBox
    Friend WithEvents lblQ3 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents rd1 As RadioButton
    Friend WithEvents rd2 As RadioButton
    Friend WithEvents rd3 As RadioButton
    Friend WithEvents chkMorning As CheckBox
    Friend WithEvents chkAfternoon As CheckBox
    Friend WithEvents chkEvening As CheckBox
    Friend WithEvents lblQ4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblQ2 As Label
    Friend WithEvents btnSubmitR As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents lblstatement1 As Label
End Class
