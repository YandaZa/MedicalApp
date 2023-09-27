Imports System.Net
Imports System.Net.Mail

Public Class Notifications
    Public Shared smtpClient As New SmtpClient()

    Public Shared Sub RegNotify(Email As TextBox)

        'This points to the Simple Mail Transfer Protocola that we are going to use to send emails.

        smtpClient.Host = "smtp.gmail.com"
        smtpClient.Port = 587
        smtpClient.EnableSsl = True
        smtpClient.Credentials = New NetworkCredential("persiville8@gmail.com", "nmhnfzwaojwymnko")

        'Instanciate an object of a mail

        Dim message As New MailMessage()
        message.From = New MailAddress("accounts@philamedicals.co.za")
        message.To.Add(Email.Text.Trim())
        message.Subject = "Welcome to Phila!"
        message.Body = "We will put our message here"


        'Im looking at something php's heredoc equivalent so that we can nicely format our emails

        Try
            smtpClient.Send(message)
        Catch ex As Exception
            MsgBox("Error sending email: " & ex.Message)
        End Try

    End Sub



End Class
