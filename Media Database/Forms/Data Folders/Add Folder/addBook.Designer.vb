<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addBook
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
        Dim UPCLabel As System.Windows.Forms.Label
        Dim LabelLabel As System.Windows.Forms.Label
        Dim BandLabel As System.Windows.Forms.Label
        Dim AlbumLabel As System.Windows.Forms.Label
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        Me.EditionTextBox = New System.Windows.Forms.TextBox()
        Me.PublisherTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.addRecord = New System.Windows.Forms.Button()
        UPCLabel = New System.Windows.Forms.Label()
        LabelLabel = New System.Windows.Forms.Label()
        BandLabel = New System.Windows.Forms.Label()
        AlbumLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UPCLabel
        '
        UPCLabel.AutoSize = True
        UPCLabel.Location = New System.Drawing.Point(12, 93)
        UPCLabel.Name = "UPCLabel"
        UPCLabel.Size = New System.Drawing.Size(35, 13)
        UPCLabel.TabIndex = 52
        UPCLabel.Text = "ISBN:"
        '
        'LabelLabel
        '
        LabelLabel.AutoSize = True
        LabelLabel.Location = New System.Drawing.Point(12, 67)
        LabelLabel.Name = "LabelLabel"
        LabelLabel.Size = New System.Drawing.Size(42, 13)
        LabelLabel.TabIndex = 50
        LabelLabel.Text = "Edition:"
        '
        'BandLabel
        '
        BandLabel.AutoSize = True
        BandLabel.Location = New System.Drawing.Point(12, 41)
        BandLabel.Name = "BandLabel"
        BandLabel.Size = New System.Drawing.Size(53, 13)
        BandLabel.TabIndex = 48
        BandLabel.Text = "Publisher:"
        '
        'AlbumLabel
        '
        AlbumLabel.AutoSize = True
        AlbumLabel.Location = New System.Drawing.Point(12, 15)
        AlbumLabel.Name = "AlbumLabel"
        AlbumLabel.Size = New System.Drawing.Size(30, 13)
        AlbumLabel.TabIndex = 46
        AlbumLabel.Text = "Title:"
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.Location = New System.Drawing.Point(71, 90)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(181, 20)
        Me.ISBNTextBox.TabIndex = 54
        '
        'EditionTextBox
        '
        Me.EditionTextBox.Location = New System.Drawing.Point(71, 64)
        Me.EditionTextBox.Name = "EditionTextBox"
        Me.EditionTextBox.Size = New System.Drawing.Size(181, 20)
        Me.EditionTextBox.TabIndex = 53
        '
        'PublisherTextBox
        '
        Me.PublisherTextBox.Location = New System.Drawing.Point(71, 38)
        Me.PublisherTextBox.Name = "PublisherTextBox"
        Me.PublisherTextBox.Size = New System.Drawing.Size(181, 20)
        Me.PublisherTextBox.TabIndex = 51
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Location = New System.Drawing.Point(71, 12)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(181, 20)
        Me.TitleTextBox.TabIndex = 49
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(258, 66)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 46)
        Me.btnClose.TabIndex = 47
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'addRecord
        '
        Me.addRecord.Location = New System.Drawing.Point(258, 11)
        Me.addRecord.Name = "addRecord"
        Me.addRecord.Size = New System.Drawing.Size(104, 43)
        Me.addRecord.TabIndex = 45
        Me.addRecord.Text = "Add"
        Me.addRecord.UseVisualStyleBackColor = True
        '
        'addBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 126)
        Me.Controls.Add(UPCLabel)
        Me.Controls.Add(Me.ISBNTextBox)
        Me.Controls.Add(LabelLabel)
        Me.Controls.Add(Me.EditionTextBox)
        Me.Controls.Add(BandLabel)
        Me.Controls.Add(Me.PublisherTextBox)
        Me.Controls.Add(AlbumLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.addRecord)
        Me.Name = "addBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Books"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ISBNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EditionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PublisherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents addRecord As System.Windows.Forms.Button
End Class
