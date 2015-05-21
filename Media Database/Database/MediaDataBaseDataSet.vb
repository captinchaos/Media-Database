

Partial Public Class MediaDataBaseDataSet
    Partial Class Book_TitleDataTable

        Private Sub Book_TitleDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Book_IDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace MediaDataBaseDataSetTableAdapters

    Partial Public Class Book_TitleTableAdapter
    End Class
End Namespace
