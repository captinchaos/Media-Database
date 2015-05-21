Public Class Extras

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles about_btn.Click
        About_Page.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles how_btn.Click
        How_To.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles suggection_btn.Click, suggection_btn.Click
        Suggestion_Box.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles settings_btn.Click
        Settings.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles license_btn.Click
        License.Show()
        Me.Hide()
    End Sub
End Class