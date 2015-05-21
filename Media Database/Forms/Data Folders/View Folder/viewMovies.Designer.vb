<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Movies
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.FilmTitleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediaDataBaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediaDataBaseDataSet = New Media_Database.MediaDataBaseDataSet()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Film_TitleTableAdapter = New Media_Database.MediaDataBaseDataSetTableAdapters.Film_TitleTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.FilmTitleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaDataBaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaDataBaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.FilmTitleBindingSource
        Me.ListBox1.DisplayMember = "FilmTitle"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(13, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(255, 212)
        Me.ListBox1.TabIndex = 17
        '
        'FilmTitleBindingSource
        '
        Me.FilmTitleBindingSource.DataMember = "Film_Title"
        Me.FilmTitleBindingSource.DataSource = Me.MediaDataBaseDataSetBindingSource
        '
        'MediaDataBaseDataSetBindingSource
        '
        Me.MediaDataBaseDataSetBindingSource.DataSource = Me.MediaDataBaseDataSet
        Me.MediaDataBaseDataSetBindingSource.Position = 0
        '
        'MediaDataBaseDataSet
        '
        Me.MediaDataBaseDataSet.DataSetName = "MediaDataBaseDataSet"
        Me.MediaDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(12, 352)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(125, 50)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "Back to Main Page"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(143, 352)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(125, 50)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Edit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Film_TitleTableAdapter
        '
        Me.Film_TitleTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FilmTitleBindingSource, "UPC", True))
        Me.Label6.Location = New System.Drawing.Point(111, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "UPC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FilmTitleBindingSource, "MediaType", True))
        Me.Label4.Location = New System.Drawing.Point(111, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "UPC:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Media Type:"
        '
        'View_Movies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 415)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Name = "View_Movies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Movies"
        CType(Me.FilmTitleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaDataBaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaDataBaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents MediaDataBaseDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MediaDataBaseDataSet As Media_Database.MediaDataBaseDataSet
    Friend WithEvents FilmTitleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Film_TitleTableAdapter As Media_Database.MediaDataBaseDataSetTableAdapters.Film_TitleTableAdapter
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
