<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editMovies
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.MediaDataBaseDataSet = New Media_Database.MediaDataBaseDataSet()
        Me.Film_TitleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Film_TitleTableAdapter = New Media_Database.MediaDataBaseDataSetTableAdapters.Film_TitleTableAdapter()
        Me.TableAdapterManager = New Media_Database.MediaDataBaseDataSetTableAdapters.TableAdapterManager()
        Me.Film_TitleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MediaDataBaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Film_TitleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Film_TitleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(357, 11)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(100, 50)
        Me.btn_exit.TabIndex = 11
        Me.btn_exit.Text = "Back"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(242, 12)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(100, 50)
        Me.btn_save.TabIndex = 10
        Me.btn_save.Text = "Save Changes"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_remove
        '
        Me.btn_remove.Location = New System.Drawing.Point(127, 12)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(100, 50)
        Me.btn_remove.TabIndex = 9
        Me.btn_remove.Text = "Remove Movie"
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'btn_Add
        '
        Me.btn_Add.Location = New System.Drawing.Point(12, 12)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(100, 50)
        Me.btn_Add.TabIndex = 8
        Me.btn_Add.Text = "Add Movie"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'MediaDataBaseDataSet
        '
        Me.MediaDataBaseDataSet.DataSetName = "MediaDataBaseDataSet"
        Me.MediaDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Film_TitleBindingSource
        '
        Me.Film_TitleBindingSource.DataMember = "Film_Title"
        Me.Film_TitleBindingSource.DataSource = Me.MediaDataBaseDataSet
        '
        'Film_TitleTableAdapter
        '
        Me.Film_TitleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Book_TitleTableAdapter = Nothing
        Me.TableAdapterManager.Film_TitleTableAdapter = Me.Film_TitleTableAdapter
        Me.TableAdapterManager.Game_TitleTableAdapter = Nothing
        Me.TableAdapterManager.Music_TracksTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Media_Database.MediaDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Film_TitleDataGridView
        '
        Me.Film_TitleDataGridView.AutoGenerateColumns = False
        Me.Film_TitleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Film_TitleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Film_TitleDataGridView.DataSource = Me.Film_TitleBindingSource
        Me.Film_TitleDataGridView.Location = New System.Drawing.Point(12, 68)
        Me.Film_TitleDataGridView.Name = "Film_TitleDataGridView"
        Me.Film_TitleDataGridView.Size = New System.Drawing.Size(445, 220)
        Me.Film_TitleDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FilmTitle"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FilmTitle"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MediaType"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MediaType"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UPC"
        Me.DataGridViewTextBoxColumn4.HeaderText = "UPC"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'editMovies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 303)
        Me.Controls.Add(Me.Film_TitleDataGridView)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_remove)
        Me.Controls.Add(Me.btn_Add)
        Me.Name = "editMovies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Movies"
        CType(Me.MediaDataBaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Film_TitleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Film_TitleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_remove As System.Windows.Forms.Button
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents MediaDataBaseDataSet As Media_Database.MediaDataBaseDataSet
    Friend WithEvents Film_TitleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Film_TitleTableAdapter As Media_Database.MediaDataBaseDataSetTableAdapters.Film_TitleTableAdapter
    Friend WithEvents TableAdapterManager As Media_Database.MediaDataBaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Film_TitleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
