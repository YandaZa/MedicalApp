
Public Class BOOKING_OT

    Public activeUser As New User

    Dim AMP, Speciality As String

    Private Async Sub BOOKING_OT_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        lblActiveUser.Text = activeUser.Title + ". " + activeUser.Names + " " + activeUser.Surname
        lblEmail.Text = activeUser.Email
        lblPhone.Text = activeUser.Mobile
        Await GetWeatherDataAsync("East London")

    End Sub






    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        DASHBOARD.Show()
        Me.Dispose()
    End Sub

    Private Sub btnSubmitOT_Click(sender As Object, e As EventArgs) Handles btnSubmitOT.Click
        Dim realtTime as string = timeHelper(cbTime)
        Dim Ap As New Appointments
        Ap = activeUser.createAppointment(txtAppointmentTitle, txtAppDescription, MonthCalendar1, realtTime, Speciality)
        MsgBox("Success")
    End Sub

    Private Function timeHelper(selectedTime As ComboBox) As String
        Return selectedTime.ToString + " " + AMP
    End Function

    Private Sub btnAM_Click(sender As Object, e As EventArgs) Handles btnAM.Click
        AMP = "AM"
        btnAM.BackColor = Color.Green
        btnPM.BackColor = Color.CadetBlue
    End Sub

    Private Sub btnPM_Click(sender As Object, e As EventArgs) Handles btnPM.Click
        AMP = "PM"
        btnPM.BackColor = Color.Green
        btnAM.BackColor = Color.CadetBlue
    End Sub

    Private Sub btnMD_Click(sender As Object, e As EventArgs) Handles btnMD.Click
        pbMD.BackColor = Color.Gray()
        Speciality = btnMD.Name.Substring(3)
    End Sub

    Private Sub btnPerdiatrician_Click(sender As Object, e As EventArgs) Handles btnPerdiatrician.Click
        pbPerdiatrician.BackColor = Color.Gray()
        Speciality = btnPerdiatrician.Name.Substring(3)
    End Sub

    Private Sub btnDentist_Click(sender As Object, e As EventArgs) Handles btnDentist.Click
        pbDentist.BackColor = Color.Gray()
        Speciality = btnDentist.Name.Substring(3)
    End Sub

    Private Sub btnOptometrist_Click(sender As Object, e As EventArgs) Handles btnOptometrist.Click
        pbDerma.BackColor = Color.Gray()
        Speciality = btnOptometrist.Name.Substring(3)
    End Sub

    Private Sub btnCardialogist_Click(sender As Object, e As EventArgs) Handles btnCardialogist.Click
        pbCardio.BackColor = Color.Gray()
        Speciality = btnCardialogist.Name.Substring(3)
    End Sub

    Private Sub btnDermatologist_Click(sender As Object, e As EventArgs) Handles btnDermatologist.Click
        pbDerma.BackColor = Color.Gray()
        Speciality = btnDermatologist.Name.Substring(3)
    End Sub

    Private Sub btnOtolaryngologist_Click(sender As Object, e As EventArgs) Handles btnOtolaryngologist.Click
        pbEar.BackColor = Color.Gray()
        Speciality = btnOtolaryngologist.Name.Substring(3)
    End Sub
End Class