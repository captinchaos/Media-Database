Public Class addGames

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        editGames.Show()
        Me.Hide()
    End Sub

    Private Sub addRecord_Click(sender As Object, e As EventArgs) Handles addRecord.Click
        editGames.Game_TitleTableAdapter.Insert(Me.TitleTextBox.Text, _
                                              Me.SystemTextBox.Text, _
                                              Me.TypeTextBox.Text, _
                                              Me.UPCTextBox.Text)
        editGames.Game_TitleTableAdapter.Fill(editGames.MediaDataBaseDataSet.Game_Title)
        MsgBox("Game added Successfully")
        TitleTextBox.Text = ""
        SystemTextBox.Text = ""
        TypeTextBox.Text = ""
        UPCTextBox.Text = ""
    End Sub

    Private Sub addGames_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class