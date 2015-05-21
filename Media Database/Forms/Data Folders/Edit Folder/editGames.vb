Public Class editGames

    Private Sub Games_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MediaDataBaseDataSet.Game_Title' table. You can move, or remove it, as needed.
        Me.Game_TitleTableAdapter.Fill(Me.MediaDataBaseDataSet.Game_Title)
        'TODO: This line of code loads data into the 'MediaDataBaseDataSet.Game_Title' table. You can move, or remove it, as needed.
        Me.Game_TitleTableAdapter.Fill(Me.MediaDataBaseDataSet.Game_Title)

    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        addGames.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        View_Games.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        If MsgBox("Are you sure you want to remove the book?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.GameTitleBindingSource.RemoveCurrent()
            Me.Validate()
            Me.GameTitleBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MediaDataBaseDataSet)
            MsgBox("Saved")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            Me.Validate()
            Me.GameTitleBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MediaDataBaseDataSet)
            MsgBox("Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Book_TitleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.GameTitleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MediaDataBaseDataSet)

    End Sub
End Class