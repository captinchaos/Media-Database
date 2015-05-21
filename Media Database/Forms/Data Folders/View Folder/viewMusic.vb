Public Class View_Music

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        editMusic.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub View_Music_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MediaDataBaseDataSet.Music_Tracks' table. You can move, or remove it, as needed.
        Me.Music_TracksTableAdapter.Fill(Me.MediaDataBaseDataSet.Music_Tracks)

    End Sub
End Class