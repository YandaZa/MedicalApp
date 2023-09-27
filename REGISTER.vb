Public Class Register
    Private Sub pbCloseApp_Click(sender As Object, e As EventArgs) Handles pbCloseApp.Click
        If MessageBox.Show("Are you sure you want to close?", "Close App?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Dispose()
            Login.Dispose()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login.Show()
        Me.Dispose()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click



        If cbUserGroup.SelectedItem.ToString = "Patient" Then
            Dim newPatient As New User(txtNames, txtLastName, txtID, txtEmail, txtMobile, cbTitle, txtPass)
            If newPatient.Register Then
                Notifications.RegNotify(txtEmail)
                DASHBOARD.loggedUser = newPatient
                DASHBOARD.Show()
                Me.Dispose()
            End If
        End If


    End Sub
End Class