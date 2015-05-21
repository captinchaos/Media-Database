Public Class View_Movies

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        editMovies.Show()
        Me.Hide()
    End Sub

    Private Sub View_Movies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MediaDataBaseDataSet.Film_Title' table. You can move, or remove it, as needed.
        Me.Film_TitleTableAdapter.Fill(Me.MediaDataBaseDataSet.Film_Title)

    End Sub
End Class