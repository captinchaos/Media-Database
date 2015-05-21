Public Class View_Games

    Private Sub View_Games_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MediaDataBaseDataSet.Game_Title' table. You can move, or remove it, as needed.
        Me.Game_TitleTableAdapter.Fill(Me.MediaDataBaseDataSet.Game_Title)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        editGames.Show()
        Me.Hide()
    End Sub
End Class