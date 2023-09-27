Public Class DASHBOARD

    Public loggedUser As New User

    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLoggedUser.Text = loggedUser.Title + ". " + loggedUser.Names + " " + loggedUser.Surname
    End Sub

    Private Sub btnHotline_Click(sender As Object, e As EventArgs) Handles btnHotline.Click
        HOTLINE.Show()
        Me.Hide()
    End Sub

    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click
        BOOKING_OT.activeUser = loggedUser
        BOOKING_OT.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Me.Dispose()
    End Sub
End Class