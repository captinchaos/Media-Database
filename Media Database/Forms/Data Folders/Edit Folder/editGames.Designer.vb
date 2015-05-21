<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editGames
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
        Me.GameTitleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediaDataBaseDataSet = New Media_Database.MediaDataBaseDataSet()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.Game_TitleTableAdapter = New Media_Database.MediaDataBaseDataSetTableAdapters.Game_TitleTableAdapter()
        Me.TableAdapterManager = New Media_Database.MediaDataBaseDataSetTableAdapters.TableAdapterManager()
        Me.Game_TitleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GameTitleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaDataBaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Game_TitleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GameTitleBindingSource
        '
        Me.GameTitleBindingSource.DataMember = "Game_Title"
        Me.GameTitleBindingSource.DataSource = Me.MediaDataBaseDataSet
        '
        'MediaDataBaseDataSet
        '
        Me.MediaDataBaseDataSet.DataSetName = "MediaDataBaseDataSet"
        Me.MediaDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(357, 11)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(100, 50)
        Me.btn_exit.TabIndex = 9
        Me.btn_exit.Text = "Back"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(242, 12)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(100, 50)
        Me.btn_save.TabIndex = 8
        Me.btn_save.Text = "Save Changes"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_remove
        '
        Me.btn_remove.Location = New System.Drawing.Point(127, 12)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(100, 50)
        Me.btn_remove.TabIndex = 7
        Me.btn_remove.Text = "Remove Game"
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'btn_Add
        '
        Me.btn_Add.Location = New System.Drawing.Point(12, 12)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(100, 50)
        Me.btn_Add.TabIndex = 6
        Me.btn_Add.Text = "Add Game"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'Game_TitleTableAdapter
        '
        Me.Game_TitleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Book_TitleTableAdapter = Nothing
        Me.TableAdapterManager.Film_TitleTableAdapter = Nothing
        Me.TableAdapterManager.Game_TitleTableAdapter = Me.Game_TitleTableAdapter
        Me.TableAdapterManager.Music_TracksTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Media_Database.MediaDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Game_TitleDataGridView
        '
        Me.Game_TitleDataGridView.AutoGenerateColumns = False
        Me.Game_TitleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Game_TitleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Game_TitleDataGridView.DataSource = Me.GameTitleBindingSource
        Me.Game_TitleDataGridView.Location = New System.Drawing.Point(12, 68)
        Me.Game_TitleDataGridView.Name = "Game_TitleDataGridView"
        Me.Game_TitleDataGridView.Size = New System.Drawing.Size(445, 248)
        Me.Game_TitleDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "System"
        Me.DataGridViewTextBoxColumn3.HeaderText = "System"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Type"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UPC"
        Me.DataGridViewTextBoxColumn5.HeaderText = "UPC"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'editGames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 328)
        Me.Controls.Add(Me.Game_TitleDataGridView)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_remove)
        Me.Controls.Add(Me.btn_Add)
        Me.Name = "editGames"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Games"
        CType(Me.GameTitleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaDataBaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Game_TitleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_remove As System.Windows.Forms.Button
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents MediaDataBaseDataSet As Media_Database.MediaDataBaseDataSet
    Friend WithEvents GameTitleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Game_TitleTableAdapter As Media_Database.MediaDataBaseDataSetTableAdapters.Game_TitleTableAdapter
    Friend WithEvents TableAdapterManager As Media_Database.MediaDataBaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Game_TitleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
