<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PILL_INFO
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
        Button1 = New Button()
        Button2 = New Button()
        Panel1 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Label4 = New Label()
        Panel3 = New Panel()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label6 = New Label()
        PictureBox2 = New PictureBox()
        Label5 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.PowderBlue
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "CANCEL"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.PowderBlue
        Button2.Location = New Point(441, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 1
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(157, 66)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(206, 163)
        Panel1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 76)
        Label3.Name = "Label3"
        Label3.Size = New Size(157, 15)
        Label3.TabIndex = 7
        Label3.Text = "Brief description Of the pill..."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(71, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 6
        Label2.Text = "vitamin C"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(51, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 36)
        Label1.TabIndex = 5
        Label1.Text = "OMEGA"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.vitamin_c1
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(89, 85)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(217, 38)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(89, 85)
        Panel2.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(143, 244)
        Label4.Name = "Label4"
        Label4.Size = New Size(243, 32)
        Label4.TabIndex = 5
        Label4.Text = "Drink at 13:00 to maintain vitamin C," & vbCrLf & "while drinking 400 grams of water..."
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(PictureBox5)
        Panel3.Controls.Add(PictureBox4)
        Panel3.Controls.Add(PictureBox3)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(67, 305)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(388, 113)
        Panel3.TabIndex = 6
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.friday
        PictureBox5.Location = New Point(296, 39)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(63, 50)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 12
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.wednesday__1_
        PictureBox4.Location = New Point(202, 39)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(63, 50)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.monday__1_
        PictureBox3.Location = New Point(105, 39)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(63, 50)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(34, 82)
        Label6.Name = "Label6"
        Label6.Size = New Size(34, 15)
        Label6.TabIndex = 9
        Label6.Text = "12:30"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.clock
        PictureBox2.Location = New Point(31, 39)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(40, 34)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(34, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(33, 15)
        Label5.TabIndex = 7
        Label5.Text = "TIME"
        ' 
        ' PILL_INFO
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(611, 497)
        Controls.Add(Panel3)
        Controls.Add(Label4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "PILL_INFO"
        Text = "PILL_INFO"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
