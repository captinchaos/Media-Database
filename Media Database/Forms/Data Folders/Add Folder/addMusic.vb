Public Class addMusic

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        editMusic.Show()
        Me.Hide()
    End Sub

    Private Sub addRecord_Click(sender As Object, e As EventArgs) Handles addRecord.Click
        editMusic.Music_TracksTableAdapter.Insert(Me.AlbumTextBox.Text, _
                                              Me.BandTextBox.Text, _
                                              Me.LabelTextBox.Text, _
                                              Me.UPCTextBox.Text)
        editMusic.Music_TracksTableAdapter.Fill(editMusic.MediaDataBaseDataSet.Music_Tracks)
        MsgBox("Album added Successfully")
        AlbumTextBox.Text = ""
        BandTextBox.Text = ""
        LabelTextBox.Text = ""
        UPCTextBox.Text = ""
    End Sub
End Class