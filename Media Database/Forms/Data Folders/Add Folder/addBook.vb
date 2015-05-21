Public Class addBook

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        editBook.Show()
        Me.Hide()
    End Sub

    Private Sub addRecord_Click(sender As Object, e As EventArgs) Handles addRecord.Click
        editBook.Book_TitleTableAdapter.Insert(Me.TitleTextBox.Text, _
                                              Me.PublisherTextBox.Text, _
                                              Me.EditionTextBox.Text, _
                                              Me.ISBNTextBox.Text)
        editBook.Book_TitleTableAdapter.Update(editBook.MediaDataBaseDataSet.Book_Title)
        editBook.Book_TitleTableAdapter.Fill(editBook.MediaDataBaseDataSet.Book_Title)
        MsgBox("Book added Successfully")
        TitleTextBox.Text = ""
        PublisherTextBox.Text = ""
        EditionTextBox.Text = ""
        ISBNTextBox.Text = ""
    End Sub

    Private Sub addBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class