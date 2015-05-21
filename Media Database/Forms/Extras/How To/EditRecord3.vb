Public Class Edit_Record_3

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles main_btn.Click
        How_To.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        Edit_Record_2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles forward_btn.Click
        Edit_Record_4.Show()
        Me.Hide()
    End Sub
End Class