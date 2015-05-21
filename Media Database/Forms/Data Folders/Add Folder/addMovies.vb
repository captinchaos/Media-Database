Public Class addMovies

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        editMovies.Show()
        Me.Hide()
    End Sub

    Private Sub addRecord_Click(sender As Object, e As EventArgs) Handles addRecord.Click
        editMovies.Film_TitleTableAdapter.Insert(Me.TitleTextBox.Text, _
                                              Me.MediaTextBox.Text, _
                                              Me.UPCTextBox.Text)
        editMovies.Film_TitleTableAdapter.Fill(editMovies.MediaDataBaseDataSet.Film_Title)
        MsgBox("Movie added Successfully")
        TitleTextBox.Text = ""
        MediaTextBox.Text = ""
        UPCTextBox.Text = ""
    End Sub

End Class