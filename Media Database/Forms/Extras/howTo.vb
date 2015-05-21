Public Class How_To

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        Extras.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        Add_Record_1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles edit_btn.Click
        Edit_Record_1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Delete_Record_1.Show()
        Me.Hide()
    End Sub
End Class