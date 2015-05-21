<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editMusic
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
        Me.Music_TracksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Music_TracksTableAdapter = New Media_Database.MediaDataBaseDataSetTableAdapters.Music_TracksTableAdapter()
        Me.TableAdapterManager = New Media_Database.MediaDataBaseDataSetTableAdapters.TableAdapterManager()
        Me.Music_TracksDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MediaDataBaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Music_TracksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Music_TracksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(357, 11)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(100, 50)
        Me.btn_exit.TabIndex = 7
        Me.btn_exit.Text = "Back"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(242, 12)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(100, 50)
        Me.btn_save.TabIndex = 6
        Me.btn_save.Text = "Save Changes"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_remove
        '
        Me.btn_remove.Location = New System.Drawing.Point(127, 12)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(100, 50)
        Me.btn_remove.TabIndex = 5
        Me.btn_remove.Text = "Remove Album"
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'btn_Add
        '
        Me.btn_Add.Location = New System.Drawing.Point(12, 12)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(100, 50)
        Me.btn_Add.TabIndex = 4
        Me.btn_Add.Text = "Add Album"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'MediaDataBaseDataSet
        '
        Me.MediaDataBaseDataSet.DataSetName = "MediaDataBaseDataSet"
        Me.MediaDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Music_TracksBindingSource
        '
        Me.Music_TracksBindingSource.DataMember = "Music_Tracks"
        Me.Music_TracksBindingSource.DataSource = Me.MediaDataBaseDataSet
        '
        'Music_TracksTableAdapter
        '
        Me.Music_TracksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Book_TitleTableAdapter = Nothing
        Me.TableAdapterManager.Film_TitleTableAdapter = Nothing
        Me.TableAdapterManager.Game_TitleTableAdapter = Nothing
        Me.TableAdapterManager.Music_TracksTableAdapter = Me.Music_TracksTableAdapter
        Me.TableAdapterManager.UpdateOrder = Media_Database.MediaDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Music_TracksDataGridView
        '
        Me.Music_TracksDataGridView.AutoGenerateColumns = False
        Me.Music_TracksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Music_TracksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Music_TracksDataGridView.DataSource = Me.Music_TracksBindingSource
        Me.Music_TracksDataGridView.Location = New System.Drawing.Point(12, 68)
        Me.Music_TracksDataGridView.Name = "Music_TracksDataGridView"
        Me.Music_TracksDataGridView.Size = New System.Drawing.Size(445, 220)
        Me.Music_TracksDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Album"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Album"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Band"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Band"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Label"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Label"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UPC"
        Me.DataGridViewTextBoxColumn5.HeaderText = "UPC"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'editMusic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 302)
        Me.Controls.Add(Me.Music_TracksDataGridView)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_remove)
        Me.Controls.Add(Me.btn_Add)
        Me.Name = "editMusic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Music"
        CType(Me.MediaDataBaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Music_TracksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Music_TracksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_remove As System.Windows.Forms.Button
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents MediaDataBaseDataSet As Media_Database.MediaDataBaseDataSet
    Friend WithEvents Music_TracksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Music_TracksTableAdapter As Media_Database.MediaDataBaseDataSetTableAdapters.Music_TracksTableAdapter
    Friend WithEvents TableAdapterManager As Media_Database.MediaDataBaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Music_TracksDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
