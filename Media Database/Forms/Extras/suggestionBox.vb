Imports System.Net.Mail

Public Class Suggestion_Box
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Extras.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles send_btn.Click
        Dim EmailMessage As New MailMessage()
        Try
            EmailMessage.From = New MailAddress("MediaLibrary.captinchaos@gmail.com")

            EmailMessage.Bcc.Add(FromBox.Text)
            EmailMessage.Bcc.Add("MediaLibrary.captinchaos@gmail.com")
            EmailMessage.Subject = "Email from Suggestion Box"
            EmailMessage.Body = MessageBox.Text
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("MediaLibrary.captinchaos@gmail.com", "ttSwFf^b8t*W")
            SMTP.Send(EmailMessage)
            MsgBox("The email has been sent!")
        Catch ex As Exception
            MsgBox("The email failed to send!")
        End Try
    End Sub

    Private Sub MessageBox_TextChanged(sender As Object, e As EventArgs) Handles MessageBox.TextChanged

    End Sub
End Class