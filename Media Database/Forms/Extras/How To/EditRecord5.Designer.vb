<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Record_5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_Record_5))
        Me.main_btn = New System.Windows.Forms.Button()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'main_btn
        '
        Me.main_btn.Location = New System.Drawing.Point(263, 150)
        Me.main_btn.Name = "main_btn"
        Me.main_btn.Size = New System.Drawing.Size(200, 23)
        Me.main_btn.TabIndex = 27
        Me.main_btn.Text = "How To"
        Me.main_btn.UseVisualStyleBackColor = True
        '
        'back_btn
        '
        Me.back_btn.Location = New System.Drawing.Point(12, 150)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(200, 23)
        Me.back_btn.TabIndex = 26
        Me.back_btn.Text = "Back"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(207, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(249, 104)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Media_Database.My.Resources.Resources.AddRecordClickSaveChanges
        Me.PictureBox4.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(189, 132)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        '
        'Edit_Record_5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 185)
        Me.Controls.Add(Me.main_btn)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox4)
        Me.Name = "Edit_Record_5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit_Record_5"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents main_btn As System.Windows.Forms.Button
    Friend WithEvents back_btn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class
