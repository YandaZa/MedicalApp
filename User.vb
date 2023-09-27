Imports System.Configuration
Imports System.Data.OleDb
Imports System.Net

Public Class User

    Public Shared ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\persi\Desktop\Records APP\Phila\Phila\Phila.accdb;Persist Security Info=True"
    Public Names As String
    Public Surname As String
    Public IDnumber As String
    Public Email As String
    Public Mobile As String
    Public Title As String
    Private _Password As String

    'Used to instanciate objects of a class
    Public Sub New(FirstNames As TextBox, LastName As TextBox, Id As TextBox, Mail As TextBox,
                   Phone As TextBox, userTitle As ComboBox, Password As TextBox)

        If Not Validate.Names(FirstNames) Then Exit Sub
        Names = FirstNames.Text.Trim

        If Not Validate.Names(LastName) Then Exit Sub
        Surname = LastName.Text.Trim

        If Not Validate.IDNumber(Id) Then Exit Sub
        IDnumber = Id.Text.Trim

        If Not Validate.IsValidEmail(Mail) Then Exit Sub
        Email = Mail.Text.Trim

        If Not Validate.IsAcceptiblePass(Password) Then Exit Sub
        _Password = Password.Text.Trim

        If Not Validate.ValidateContact(Phone) Then Exit Sub
        Mobile = Phone.Text.Trim

        Title = userTitle.SelectedItem.ToString()
    End Sub
    Public Sub New()

    End Sub

    Public Function Register() As Boolean
        Dim conn As New OleDbConnection(ConnectionString)
        Dim cmd As New OleDbCommand

        If Not IsValidReg() Then Return False 'User.Regist

        conn.Open()

        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into users (IDnumber,FistNames,LastName,Email,Mobile,Pword,PersonTitle)values('" + IDnumber + "','" + Names + "','" + Surname + "','" + Email + "','" + Mobile + "','" + _Password + "','" + Title + "')"

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            conn.Close()
        End Try
        Return False
    End Function

    Public Shared Function Login(IDnumber As TextBox, Password As TextBox, ByRef IsAuthentic As Boolean) As User
        Dim conn As New OleDbConnection(ConnectionString)

        Dim myReader As OleDbDataReader

        conn.Open()

        Dim cmd As OleDbCommand

        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from users where IDnumber = @IDnumber and Pword = @Password"
        cmd.Parameters.AddWithValue("@IDnumber", IDnumber.Text.Trim)
        cmd.Parameters.AddWithValue("@Password", Password.Text.Trim)

        Try

            myReader = cmd.ExecuteReader

            If myReader.HasRows Then
                Dim objUser As New User
                While myReader.Read
                    objUser.Names = myReader("FistNames").ToString
                    objUser.Surname = myReader("LastName").ToString
                    objUser.Email = myReader("Email").ToString
                    objUser.Mobile = myReader("Mobile").ToString
                    objUser.Title = myReader("PersonTitle").ToString
                    objUser.IDnumber = myReader("IDnumber").ToString
                End While
                IsAuthentic = True
                Return objUser
            Else
                MessageBox.Show("Invalid Credentials", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error)
                IDnumber.Clear()
                Password.Clear()
                IDnumber.Focus()
                IsAuthentic = False
            End If
        Catch ex As Exception
            IsAuthentic = False
            MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            conn.Close()
        End Try
        Return Nothing
    End Function

    Private Function TextToTextbox(t As String) As TextBox
        Dim value As New TextBox
        value.Text = t
        Return value
    End Function

    Private Function IsValidReg() As Boolean

        If Names = "" Then
            Return False
        End If

        If Surname = "" Then
            Return False
        End If

        If Email = "" Then
            Return False
        End If

        If IDnumber = "" Then
            Return False
        End If

        If _Password = "" Then
            Return False
        End If

        If Title = "" Then
            Return False
        End If

        If Mobile = "" Then
            Return False
        End If

        Return True
    End Function

    'Public Shared Function viewReport(ID As String) As Boolean

    '    If Validate.IDNumber(Util.stringToTextBox(ID)) = False Then Return False

    '    Dim conn As New OleDbConnection(ConnectionString)
    '    Dim myReader As OleDbDataReader

    '    Dim cmd As OleDbCommand
    '    conn.Open()
    '    cmd = conn.CreateCommand
    '    cmd.CommandType = CommandType.Text
    '    cmd.CommandText = "select * from medicals where IDnumber = @IDnumber"
    '    cmd.Parameters.AddWithValue("@IDnumber", ID)


    '    Try

    '        myReader = cmd.ExecuteReader()

    '        If myReader.HasRows Then
    '            While myReader.Read
    '                MedicalReport.txtDr.Text = myReader("DoctorName").ToString
    '                MedicalReport.txtDate.Text = myReader("DateOfVisit").ToString
    '                MedicalReport.txtDiagnosis.Text = myReader("Diagnosis").ToString
    '                MedicalReport.txtMeds.Text = myReader("Medications").ToString
    '                MedicalReport.txtNotes.Text = myReader("Notes").ToString
    '                MedicalReport.lblReportID.Text = myReader("ReportID").ToString
    '            End While
    '            Return True
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '        Return False
    '    Finally
    '        conn.Close()
    '    End Try
    'End Function

    Public Function createAppointment(AppTitle As TextBox, Descript As TextBox, pickedDate As MonthCalendar, pickedTime As String, Speciality As String) As Appointments
        Dim newAppointment As New Appointments

        If Not Validate.Names(AppTitle) Then Return Nothing
        newAppointment.Title = AppTitle.Text.Trim

        If Not Validate.Names(Descript) Then Return Nothing
        newAppointment.Description = Descript.Text.Trim

        newAppointment.User = IDnumber

        newAppointment.ScheduledDay = pickedDate.SelectionRange.Start

        newAppointment.ScheduledTime = pickedTime

        Return newAppointment
    End Function


End Class
