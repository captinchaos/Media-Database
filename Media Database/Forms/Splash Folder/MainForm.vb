Public Class MainForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles books_btn.Click
        View_Books.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles movies_btn.Click
        View_Movies.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles games_btn.Click
        View_Games.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles music_btn.Click
        View_Music.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles extra_btn.Click
        Extras.Show()
        Me.Hide()

    End Sub
End Class
