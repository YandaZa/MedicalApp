Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'Boolean flag to monitor the status of the login action
        'Target the loggedUser object from the dash and equate.
        'if login and instanciation are successful, show dashboard

        Dim loginStatus As Boolean
        DASHBOARD.loggedUser = User.Login(txtID, txtPassword, loginStatus)

        If loginStatus Then
            DASHBOARD.Show()
            Me.Hide()
        End If



    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub pbClossApp_Click(sender As Object, e As EventArgs) Handles pbClossApp.Click
        If MessageBox.Show("Are you sure you want to exit app?", "Exit App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub

End Class