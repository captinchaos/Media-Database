<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addMusic
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
        Dim AlbumLabel As System.Windows.Forms.Label
        Dim BandLabel As System.Windows.Forms.Label
        Dim LabelLabel As System.Windows.Forms.Label
        Dim UPCLabel As System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button()
        Me.addRecord = New System.Windows.Forms.Button()
        Me.MediaDataBaseDataSet = New Media_Database.MediaDataBaseDataSet()
        Me.Music_TracksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Music_TracksTableAdapter = New Media_Database.MediaDataBaseDataSetTableAdapters.Music_TracksTableAdapter()
        Me.TableAdapterManager = New Media_Database.MediaDataBaseDataSetTableAdapters.TableAdapterManager()
        Me.AlbumTextBox = New System.Windows.Forms.TextBox()
        Me.BandTextBox = New System.Windows.Forms.TextBox()
        Me.LabelTextBox = New System.Windows.Forms.TextBox()
        Me.UPCTextBox = New System.Windows.Forms.TextBox()
        AlbumLabel = New System.Windows.Forms.Label()
        BandLabel = New System.Windows.Forms.Label()
        LabelLabel = New System.Windows.Forms.Label()
        UPCLabel = New System.Windows.Forms.Label()
        CType(Me.MediaDataBaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Music_TracksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlbumLabel
        '
        AlbumLabel.AutoSize = True
        AlbumLabel.Location = New System.Drawing.Point(7, 15)
        AlbumLabel.Name = "AlbumLabel"
        AlbumLabel.Size = New System.Drawing.Size(39, 13)
        AlbumLabel.TabIndex = 29
        AlbumLabel.Text = "Album:"
        '
        'BandLabel
        '
        BandLabel.AutoSize = True
        BandLabel.Location = New System.Drawing.Point(11, 41)
        BandLabel.Name = "BandLabel"
        BandLabel.Size = New System.Drawing.Size(35, 13)
        BandLabel.TabIndex = 30
        BandLabel.Text = "Band:"
        '
        'LabelLabel
        '
        LabelLabel.AutoSize = True
        LabelLabel.Location = New System.Drawing.Point(10, 67)
        LabelLabel.Name = "LabelLabel"
        LabelLabel.Size = New System.Drawing.Size(36, 13)
        LabelLabel.TabIndex = 31
        LabelLabel.Text = "Label:"
        '
        'UPCLabel
        '
        UPCLabel.AutoSize = True
        UPCLabel.Location = New System.Drawing.Point(14, 93)
        UPCLabel.Name = "UPCLabel"
        UPCLabel.Size = New System.Drawing.Size(32, 13)
        UPCLabel.TabIndex = 32
        UPCLabel.Text = "UPC:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(239, 67)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 46)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'addRecord
        '
        Me.addRecord.Location = New System.Drawing.Point(239, 12)
        Me.addRecord.Name = "addRecord"
        Me.addRecord.Size = New System.Drawing.Size(104, 43)
        Me.addRecord.TabIndex = 27
        Me.addRecord.Text = "Add"
        Me.addRecord.UseVisualStyleBackColor = True
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
        'AlbumTextBox
        '
        Me.AlbumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Music_TracksBindingSource, "Album", True))
        Me.AlbumTextBox.Location = New System.Drawing.Point(52, 12)
        Me.AlbumTextBox.Name = "AlbumTextBox"
        Me.AlbumTextBox.Size = New System.Drawing.Size(181, 20)
        Me.AlbumTextBox.TabIndex = 30
        '
        'BandTextBox
        '
        Me.BandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Music_TracksBindingSource, "Band", True))
        Me.BandTextBox.Location = New System.Drawing.Point(52, 38)
        Me.BandTextBox.Name = "BandTextBox"
        Me.BandTextBox.Size = New System.Drawing.Size(181, 20)
        Me.BandTextBox.TabIndex = 31
        '
        'LabelTextBox
        '
        Me.LabelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Music_TracksBindingSource, "Label", True))
        Me.LabelTextBox.Location = New System.Drawing.Point(52, 64)
        Me.LabelTextBox.Name = "LabelTextBox"
        Me.LabelTextBox.Size = New System.Drawing.Size(181, 20)
        Me.LabelTextBox.TabIndex = 32
        '
        'UPCTextBox
        '
        Me.UPCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Music_TracksBindingSource, "UPC", True))
        Me.UPCTextBox.Location = New System.Drawing.Point(52, 90)
        Me.UPCTextBox.Name = "UPCTextBox"
        Me.UPCTextBox.Size = New System.Drawing.Size(181, 20)
        Me.UPCTextBox.TabIndex = 33
        '
        'addMusic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 124)
        Me.Controls.Add(UPCLabel)
        Me.Controls.Add(Me.UPCTextBox)
        Me.Controls.Add(LabelLabel)
        Me.Controls.Add(Me.LabelTextBox)
        Me.Controls.Add(BandLabel)
        Me.Controls.Add(Me.BandTextBox)
        Me.Controls.Add(AlbumLabel)
        Me.Controls.Add(Me.AlbumTextBox)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.addRecord)
        Me.Name = "addMusic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Music"
        CType(Me.MediaDataBaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Music_TracksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents addRecord As System.Windows.Forms.Button
    Friend WithEvents MediaDataBaseDataSet As Media_Database.MediaDataBaseDataSet
    Friend WithEvents Music_TracksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Music_TracksTableAdapter As Media_Database.MediaDataBaseDataSetTableAdapters.Music_TracksTableAdapter
    Friend WithEvents TableAdapterManager As Media_Database.MediaDataBaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AlbumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LabelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UPCTextBox As System.Windows.Forms.TextBox
End Class
