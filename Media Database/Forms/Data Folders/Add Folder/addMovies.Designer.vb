<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addMovies
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
        Dim MediaLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Me.UPCTextBox = New System.Windows.Forms.TextBox()
        Me.MediaTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.addRecord = New System.Windows.Forms.Button()
        UPCLabel = New System.Windows.Forms.Label()
        MediaLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UPCLabel
        '
        UPCLabel.AutoSize = True
        UPCLabel.Location = New System.Drawing.Point(19, 67)
        UPCLabel.Name = "UPCLabel"
        UPCLabel.Size = New System.Drawing.Size(32, 13)
        UPCLabel.TabIndex = 42
        UPCLabel.Text = "UPC:"
        '
        'MediaLabel
        '
        MediaLabel.AutoSize = True
        MediaLabel.Location = New System.Drawing.Point(15, 41)
        MediaLabel.Name = "MediaLabel"
        MediaLabel.Size = New System.Drawing.Size(39, 13)
        MediaLabel.TabIndex = 40
        MediaLabel.Text = "Media:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(12, 15)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(30, 13)
        TitleLabel.TabIndex = 36
        TitleLabel.Text = "Title:"
        '
        'UPCTextBox
        '
        Me.UPCTextBox.Location = New System.Drawing.Point(57, 64)
        Me.UPCTextBox.Name = "UPCTextBox"
        Me.UPCTextBox.Size = New System.Drawing.Size(181, 20)
        Me.UPCTextBox.TabIndex = 44
        '
        'MediaTextBox
        '
        Me.MediaTextBox.Location = New System.Drawing.Point(57, 38)
        Me.MediaTextBox.Name = "MediaTextBox"
        Me.MediaTextBox.Size = New System.Drawing.Size(181, 20)
        Me.MediaTextBox.TabIndex = 43
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Location = New System.Drawing.Point(57, 12)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(181, 20)
        Me.TitleTextBox.TabIndex = 39
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
        'addRecord
        '
        Me.addRecord.Location = New System.Drawing.Point(244, 12)
        Me.addRecord.Name = "addRecord"
        Me.addRecord.Size = New System.Drawing.Size(104, 43)
        Me.addRecord.TabIndex = 35
        Me.addRecord.Text = "Add"
        Me.addRecord.UseVisualStyleBackColor = True
        '
        'addMovies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 133)
        Me.Controls.Add(UPCLabel)
        Me.Controls.Add(Me.UPCTextBox)
        Me.Controls.Add(MediaLabel)
        Me.Controls.Add(Me.MediaTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.addRecord)
        Me.Name = "addMovies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Movies"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UPCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MediaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents addRecord As System.Windows.Forms.Button
End Class
