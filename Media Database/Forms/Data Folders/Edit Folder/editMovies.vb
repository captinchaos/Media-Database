Public Class editMovies

    Private Sub editMovies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MediaDataBaseDataSet.Film_Title' table. You can move, or remove it, as needed.
        Me.Film_TitleTableAdapter.Fill(Me.MediaDataBaseDataSet.Film_Title)

    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        addMovies.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        View_Movies.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        If MsgBox("Are you sure you want to remove the book?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Film_TitleBindingSource.RemoveCurrent()
            Me.Validate()
            Me.Film_TitleBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MediaDataBaseDataSet)
            MsgBox("Saved")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            Me.Validate()
            Me.Film_TitleBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MediaDataBaseDataSet)
            MsgBox("Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Book_TitleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Film_TitleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MediaDataBaseDataSet)

    End Sub

    Private Sub Book_TitleBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Film_TitleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MediaDataBaseDataSet)

    End Sub
End Class