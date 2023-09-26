<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BOOKING
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
        Panel1 = New Panel()
        btnBook = New Button()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        MonthCalendar1 = New MonthCalendar()
        Panel2 = New Panel()
        RadioButton10 = New RadioButton()
        RadioButton9 = New RadioButton()
        RadioButton8 = New RadioButton()
        RadioButton7 = New RadioButton()
        RadioButton6 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Label2 = New Label()
        btnSubmit = New Button()
        Label3 = New Label()
        ToolTip1 = New ToolTip(components)
        btnHome = New Button()
        btnCancel = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnBook)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(155, 45)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(303, 86)
        Panel1.TabIndex = 0
        ' 
        ' btnBook
        ' 
        btnBook.Cursor = Cursors.Hand
        btnBook.Location = New Point(207, 55)
        btnBook.Name = "btnBook"
        btnBook.Size = New Size(75, 23)
        btnBook.TabIndex = 1
        btnBook.Text = "BOOK"
        ToolTip1.SetToolTip(btnBook, "Click here to book your appointment")
        btnBook.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.rating
        PictureBox2.Location = New Point(102, 42)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(62, 36)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(102, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 30)
        Label1.TabIndex = 2
        Label1.Text = "Dr Kgomotso" & vbCrLf & "Paediatrician"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.pediatrician1
        PictureBox1.Location = New Point(20, 17)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(65, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(194, 135)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(RadioButton10)
        Panel2.Controls.Add(RadioButton9)
        Panel2.Controls.Add(RadioButton8)
        Panel2.Controls.Add(RadioButton7)
        Panel2.Controls.Add(RadioButton6)
        Panel2.Controls.Add(RadioButton5)
        Panel2.Controls.Add(RadioButton4)
        Panel2.Controls.Add(RadioButton3)
        Panel2.Controls.Add(RadioButton2)
        Panel2.Controls.Add(RadioButton1)
        Panel2.Cursor = Cursors.Hand
        Panel2.Location = New Point(144, 329)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(336, 136)
        Panel2.TabIndex = 2
        ToolTip1.SetToolTip(Panel2, "Pick your time")
        ' 
        ' RadioButton10
        ' 
        RadioButton10.AutoSize = True
        RadioButton10.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton10.Location = New Point(97, 99)
        RadioButton10.Name = "RadioButton10"
        RadioButton10.Size = New Size(62, 24)
        RadioButton10.TabIndex = 9
        RadioButton10.TabStop = True
        RadioButton10.Text = "12:35"
        RadioButton10.UseVisualStyleBackColor = True
        ' 
        ' RadioButton9
        ' 
        RadioButton9.AutoSize = True
        RadioButton9.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton9.Location = New Point(12, 99)
        RadioButton9.Name = "RadioButton9"
        RadioButton9.Size = New Size(62, 24)
        RadioButton9.TabIndex = 8
        RadioButton9.TabStop = True
        RadioButton9.Text = "12:00"
        RadioButton9.UseVisualStyleBackColor = True
        ' 
        ' RadioButton8
        ' 
        RadioButton8.AutoSize = True
        RadioButton8.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton8.Location = New Point(258, 62)
        RadioButton8.Name = "RadioButton8"
        RadioButton8.Size = New Size(62, 24)
        RadioButton8.TabIndex = 7
        RadioButton8.TabStop = True
        RadioButton8.Text = "11:35"
        RadioButton8.UseVisualStyleBackColor = True
        ' 
        ' RadioButton7
        ' 
        RadioButton7.AutoSize = True
        RadioButton7.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton7.Location = New Point(184, 62)
        RadioButton7.Name = "RadioButton7"
        RadioButton7.Size = New Size(62, 24)
        RadioButton7.TabIndex = 6
        RadioButton7.TabStop = True
        RadioButton7.Text = "11:00"
        RadioButton7.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton6.Location = New Point(97, 62)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(62, 24)
        RadioButton6.TabIndex = 5
        RadioButton6.TabStop = True
        RadioButton6.Text = "10:35"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton5.Location = New Point(12, 62)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(62, 24)
        RadioButton5.TabIndex = 4
        RadioButton5.TabStop = True
        RadioButton5.Text = "10:00"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton4.Location = New Point(258, 23)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(62, 24)
        RadioButton4.TabIndex = 3
        RadioButton4.TabStop = True
        RadioButton4.Text = "09:35"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton3.Location = New Point(184, 23)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(62, 24)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "09:00"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton2.Location = New Point(97, 23)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(62, 24)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "08:30"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton1.Location = New Point(12, 23)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(62, 24)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "08:00"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(433, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(185, 45)
        Label2.TabIndex = 3
        Label2.Text = "When you click the book button, " & vbCrLf & "the calender should then pop up.." & vbCrLf & "to see available dates"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Cursor = Cursors.Hand
        btnSubmit.Location = New Point(546, 427)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(75, 23)
        btnSubmit.TabIndex = 4
        btnSubmit.Text = "SUBMIT"
        ToolTip1.SetToolTip(btnSubmit, "Click to submit")
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(277, 306)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 20)
        Label3.TabIndex = 5
        Label3.Text = "TIME"
        ' 
        ' btnHome
        ' 
        btnHome.Location = New Point(22, 12)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(75, 23)
        btnHome.TabIndex = 6
        btnHome.Text = "HOME"
        ToolTip1.SetToolTip(btnHome, "Return to home page")
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Cursor = Cursors.Hand
        btnCancel.Location = New Point(544, 370)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 7
        btnCancel.Text = "CANCEL"
        ToolTip1.SetToolTip(btnCancel, "Click to cancel")
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' BOOKING
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(662, 483)
        Controls.Add(btnCancel)
        Controls.Add(btnHome)
        Controls.Add(Label3)
        Controls.Add(btnSubmit)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(MonthCalendar1)
        Controls.Add(Panel1)
        Name = "BOOKING"
        Text = "BOOKING"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBook As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnHome As Button
    Friend WithEvents btnCancel As Button
End Class
