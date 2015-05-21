<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addGames
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
        Dim AlbumLabel As System.Windows.Forms.Label
        Dim BandLabel As System.Windows.Forms.Label
        Dim LabelLabel As System.Windows.Forms.Label
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.addRecord = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SystemTextBox = New System.Windows.Forms.TextBox()
        Me.TypeTextBox = New System.Windows.Forms.TextBox()
        Me.UPCTextBox = New System.Windows.Forms.TextBox()
        UPCLabel = New System.Windows.Forms.Label()
        AlbumLabel = New System.Windows.Forms.Label()
        BandLabel = New System.Windows.Forms.Label()
        LabelLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UPCLabel
        '
        UPCLabel.AutoSize = True
        UPCLabel.Location = New System.Drawing.Point(12, 93)
        UPCLabel.Name = "UPCLabel"
        UPCLabel.Size = New System.Drawing.Size(32, 13)
        UPCLabel.TabIndex = 42
        UPCLabel.Text = "UPC:"
        '
        'AlbumLabel
        '
        AlbumLabel.AutoSize = True
        AlbumLabel.Location = New System.Drawing.Point(12, 15)
        AlbumLabel.Name = "AlbumLabel"
        AlbumLabel.Size = New System.Drawing.Size(30, 13)
        AlbumLabel.TabIndex = 36
        AlbumLabel.Text = "Title:"
        '
        'BandLabel
        '
        BandLabel.AutoSize = True
        BandLabel.Location = New System.Drawing.Point(12, 41)
        BandLabel.Name = "BandLabel"
        BandLabel.Size = New System.Drawing.Size(44, 13)
        BandLabel.TabIndex = 38
        BandLabel.Text = "System:"
        '
        'LabelLabel
        '
        LabelLabel.AutoSize = True
        LabelLabel.Location = New System.Drawing.Point(12, 67)
        LabelLabel.Name = "LabelLabel"
        LabelLabel.Size = New System.Drawing.Size(34, 13)
        LabelLabel.TabIndex = 40
        LabelLabel.Text = "Type:"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Location = New System.Drawing.Point(57, 12)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(181, 20)
        Me.TitleTextBox.TabIndex = 39
        '
        'addRecord
        '
        Me.addRecord.Location = New System.Drawing.Point(244, 12)
        Me.addRecord.Name = "addRecord"
        Me.addRecord.Size = New System.Drawing.Size(104, 43)
        Me.addRecord.TabIndex = 35
        Me.addRecord.Text = "Add"
        Me.addRecord.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(244, 67)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 46)
        Me.btnClose.TabIndex = 37
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'SystemTextBox
        '
        Me.SystemTextBox.Location = New System.Drawing.Point(57, 38)
        Me.SystemTextBox.Name = "SystemTextBox"
        Me.SystemTextBox.Size = New System.Drawing.Size(181, 20)
        Me.SystemTextBox.TabIndex = 41
        '
        'TypeTextBox
        '
        Me.TypeTextBox.Location = New System.Drawing.Point(57, 64)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.Size = New System.Drawing.Size(181, 20)
        Me.TypeTextBox.TabIndex = 43
        '
        'UPCTextBox
        '
        Me.UPCTextBox.Location = New System.Drawing.Point(57, 90)
        Me.UPCTextBox.Name = "UPCTextBox"
        Me.UPCTextBox.Size = New System.Drawing.Size(181, 20)
        Me.UPCTextBox.TabIndex = 44
        '
        'addGames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 126)
        Me.Controls.Add(UPCLabel)
        Me.Controls.Add(Me.UPCTextBox)
        Me.Controls.Add(LabelLabel)
        Me.Controls.Add(Me.TypeTextBox)
        Me.Controls.Add(BandLabel)
        Me.Controls.Add(Me.SystemTextBox)
        Me.Controls.Add(AlbumLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.addRecord)
        Me.Name = "addGames"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Games"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents addRecord As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents SystemTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UPCTextBox As System.Windows.Forms.TextBox
End Class
