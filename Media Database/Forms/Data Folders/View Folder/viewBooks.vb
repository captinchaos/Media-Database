Public Class View_Books

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        editBook.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub View_Books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MediaDataBaseDataSet.Book_Title' table. You can move, or remove it, as needed.
        Me.Book_TitleTableAdapter.Fill(Me.MediaDataBaseDataSet.Book_Title)

    End Sub
End Class