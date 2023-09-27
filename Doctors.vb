Imports System.Data.OleDb

Public Class Doctors
    Inherits User
    Public Speciality As String
    Public Qualification As String
    Public Base As String
    Private Availability As Boolean


    Public Sub New()
        MyBase.New
    End Sub

    Public Sub New(FirstName As TextBox, Surname As TextBox, Email As TextBox, Mobile As TextBox, Title As ComboBox,
                   Id As TextBox, Password As TextBox, Expertise As TextBox, Qual As TextBox, DrBase As TextBox)
        MyBase.New(FirstName, Surname, Id, Email, Mobile, Title, Password)

        If Not Validate.Names(Expertise) Then Exit Sub
        Speciality = Expertise.Text.Trim

        If Not Validate.Names(Qual) Then Exit Sub
        Qualification = Qual.Text.Trim

        If Not Validate.Names(DrBase) Then Exit Sub
        Base = DrBase.Text.Trim
    End Sub

    Public Function createReport(Petient As String, Diagnose As TextBox, Meds As TextBox, Procedure As TextBox, DrNote As TextBox, Test As TextBox) As Boolean


        Dim conn As New OleDbConnection(ConnectionString)
        Dim cmd As New OleDbCommand

        Dim randomReportID As String = Util.generateOTP(8)
        Dim visitDate As New Date
        visitDate = Now

        Dim Drname As String = Title + ". " + Names + " " + Surname

        conn.Open()

        cmd = conn.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into medicals (IDnumber,ReportID,DateOfVisit,DoctorName,Diagnosis,Medications,Procedures,TestResults,Notes)values('" + Petient + "','" + randomReportID + "','" + visitDate.ToString + "','" + Drname + "','" + Diagnose.Text.Trim + "','" + Meds.Text.Trim + "','" + Procedure.Text.Trim + "','" + Test.Text.Trim + "','" + DrNote.Text.Trim + "')"

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            conn.Close()
        End Try

    End Function







End Class
