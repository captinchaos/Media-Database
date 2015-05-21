Public Class editMusic

    Private Sub editMusic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MediaDataBaseDataSet.Music_Tracks' table. You can move, or remove it, as needed.
        Me.Music_TracksTableAdapter.Fill(Me.MediaDataBaseDataSet.Music_Tracks)

    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        addMusic.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        View_Music.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        If MsgBox("Are you sure you want to remove the book?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Music_TracksBindingSource.RemoveCurrent()
            Me.Validate()
            Me.Music_TracksBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MediaDataBaseDataSet)
            MsgBox("Saved")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            Me.Validate()
            Me.Music_TracksBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MediaDataBaseDataSet)
            MsgBox("Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Music_TitleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Music_TracksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MediaDataBaseDataSet)

    End Sub
End Class