<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMERGENCY_CONTACT
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
        ListBox1 = New ListBox()
        txtInitials = New TextBox()
        txtLastName = New TextBox()
        mskCellphone = New MaskedTextBox()
        lblStatement3 = New Label()
        RadioButton1 = New RadioButton()
        rdOther = New RadioButton()
        rdSibling = New RadioButton()
        rdGaurdian = New RadioButton()
        Panel1 = New Panel()
        btnHome = New Button()
        btnUpdate = New Button()
        btnCancel = New Button()
        ToolTip1 = New ToolTip(components)
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(312, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 25)
        Label1.TabIndex = 0
        Label1.Text = "NEXT OF KIN"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(465, 118)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(323, 274)
        ListBox1.TabIndex = 1
        ' 
        ' txtInitials
        ' 
        txtInitials.Location = New Point(46, 152)
        txtInitials.Name = "txtInitials"
        txtInitials.PlaceholderText = "Initails:"
        txtInitials.Size = New Size(159, 23)
        txtInitials.TabIndex = 2
        ToolTip1.SetToolTip(txtInitials, "Initials")
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(46, 106)
        txtLastName.Name = "txtLastName"
        txtLastName.PlaceholderText = "Last Name:"
        txtLastName.Size = New Size(159, 23)
        txtLastName.TabIndex = 7
        ToolTip1.SetToolTip(txtLastName, "Last name")
        ' 
        ' mskCellphone
        ' 
        mskCellphone.Location = New Point(46, 204)
        mskCellphone.Mask = "(999) 000-0000"
        mskCellphone.Name = "mskCellphone"
        mskCellphone.Size = New Size(159, 23)
        mskCellphone.TabIndex = 8
        ' 
        ' lblStatement3
        ' 
        lblStatement3.AutoSize = True
        lblStatement3.Font = New Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblStatement3.Location = New Point(3, 16)
        lblStatement3.Name = "lblStatement3"
        lblStatement3.Size = New Size(85, 16)
        lblStatement3.TabIndex = 9
        lblStatement3.Text = "Relationship"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Cursor = Cursors.Hand
        RadioButton1.Location = New Point(3, 45)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(59, 19)
        RadioButton1.TabIndex = 10
        RadioButton1.TabStop = True
        RadioButton1.Text = "Parent"
        ToolTip1.SetToolTip(RadioButton1, "Parent")
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' rdOther
        ' 
        rdOther.AutoSize = True
        rdOther.Cursor = Cursors.Hand
        rdOther.Location = New Point(3, 124)
        rdOther.Name = "rdOther"
        rdOther.Size = New Size(55, 19)
        rdOther.TabIndex = 11
        rdOther.TabStop = True
        rdOther.Text = "Other"
        ToolTip1.SetToolTip(rdOther, "Other")
        rdOther.UseVisualStyleBackColor = True
        ' 
        ' rdSibling
        ' 
        rdSibling.AutoSize = True
        rdSibling.Cursor = Cursors.Hand
        rdSibling.Location = New Point(3, 98)
        rdSibling.Name = "rdSibling"
        rdSibling.Size = New Size(61, 19)
        rdSibling.TabIndex = 12
        rdSibling.TabStop = True
        rdSibling.Text = "Sibling"
        ToolTip1.SetToolTip(rdSibling, "Sibling")
        rdSibling.UseVisualStyleBackColor = True
        ' 
        ' rdGaurdian
        ' 
        rdGaurdian.AutoSize = True
        rdGaurdian.Cursor = Cursors.Hand
        rdGaurdian.Location = New Point(3, 70)
        rdGaurdian.Name = "rdGaurdian"
        rdGaurdian.Size = New Size(73, 19)
        rdGaurdian.TabIndex = 13
        rdGaurdian.TabStop = True
        rdGaurdian.Text = "Gaurdian"
        ToolTip1.SetToolTip(rdGaurdian, "Guardian")
        rdGaurdian.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblStatement3)
        Panel1.Controls.Add(rdOther)
        Panel1.Controls.Add(rdSibling)
        Panel1.Controls.Add(rdGaurdian)
        Panel1.Controls.Add(RadioButton1)
        Panel1.Location = New Point(46, 279)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 149)
        Panel1.TabIndex = 14
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.PowderBlue
        btnHome.Cursor = Cursors.Hand
        btnHome.Location = New Point(12, 12)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(75, 23)
        btnHome.TabIndex = 15
        btnHome.Text = "HOME"
        ToolTip1.SetToolTip(btnHome, "Return to home page")
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.PowderBlue
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.Location = New Point(700, 405)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(88, 23)
        btnUpdate.TabIndex = 16
        btnUpdate.Text = "UPDATE"
        ToolTip1.SetToolTip(btnUpdate, "Click to update")
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.PowderBlue
        btnCancel.Cursor = Cursors.Hand
        btnCancel.Location = New Point(465, 401)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(86, 27)
        btnCancel.TabIndex = 17
        btnCancel.Text = "CANCEL"
        ToolTip1.SetToolTip(btnCancel, "Click to cancel")
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' EMERGENCY_CONTACT
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(800, 450)
        Controls.Add(btnCancel)
        Controls.Add(btnUpdate)
        Controls.Add(btnHome)
        Controls.Add(Panel1)
        Controls.Add(mskCellphone)
        Controls.Add(txtLastName)
        Controls.Add(txtInitials)
        Controls.Add(ListBox1)
        Controls.Add(Label1)
        Name = "EMERGENCY_CONTACT"
        Text = "EMERGENCY_CONTACT"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents txtInitials As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents mskCellphone As MaskedTextBox
    Friend WithEvents lblStatement3 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents rdOther As RadioButton
    Friend WithEvents rdSibling As RadioButton
    Friend WithEvents rdGaurdian As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
