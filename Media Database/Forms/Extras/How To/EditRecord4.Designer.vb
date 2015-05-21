<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Record_4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_Record_4))
        Me.main_btn = New System.Windows.Forms.Button()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.forward_btn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'main_btn
        '
        Me.main_btn.Location = New System.Drawing.Point(142, 148)
        Me.main_btn.Name = "main_btn"
        Me.main_btn.Size = New System.Drawing.Size(125, 23)
        Me.main_btn.TabIndex = 38
        Me.main_btn.Text = "How To"
        Me.main_btn.UseVisualStyleBackColor = True
        '
        'back_btn
        '
        Me.back_btn.Location = New System.Drawing.Point(12, 148)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(125, 23)
        Me.back_btn.TabIndex = 37
        Me.back_btn.Text = "Back"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 78)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Media_Database.My.Resources.Resources.AddRecordEditCells
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'forward_btn
        '
        Me.forward_btn.Location = New System.Drawing.Point(272, 148)
        Me.forward_btn.Name = "forward_btn"
        Me.forward_btn.Size = New System.Drawing.Size(125, 23)
        Me.forward_btn.TabIndex = 39
        Me.forward_btn.Text = "Forward"
        Me.forward_btn.UseVisualStyleBackColor = True
        '
        'Edit_Record_4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 181)
        Me.Controls.Add(Me.forward_btn)
        Me.Controls.Add(Me.main_btn)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Edit_Record_4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit_Record_4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents main_btn As System.Windows.Forms.Button
    Friend WithEvents back_btn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents forward_btn As System.Windows.Forms.Button
End Class
