<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Record_3
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
        Me.main_btn = New System.Windows.Forms.Button()
        Me.forward_btn = New System.Windows.Forms.Button()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'main_btn
        '
        Me.main_btn.Location = New System.Drawing.Point(153, 150)
        Me.main_btn.Name = "main_btn"
        Me.main_btn.Size = New System.Drawing.Size(102, 23)
        Me.main_btn.TabIndex = 29
        Me.main_btn.Text = "How To"
        Me.main_btn.UseVisualStyleBackColor = True
        '
        'forward_btn
        '
        Me.forward_btn.Location = New System.Drawing.Point(294, 150)
        Me.forward_btn.Name = "forward_btn"
        Me.forward_btn.Size = New System.Drawing.Size(102, 23)
        Me.forward_btn.TabIndex = 28
        Me.forward_btn.Text = "Foward"
        Me.forward_btn.UseVisualStyleBackColor = True
        '
        'back_btn
        '
        Me.back_btn.Location = New System.Drawing.Point(12, 150)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(102, 23)
        Me.back_btn.TabIndex = 27
        Me.back_btn.Text = "Back"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 39)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Now highlight the book that you wish to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "edit. The little triangle should be poin" & _
    "ting" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to the book title that you want to delete." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Edit_Record_3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 184)
        Me.Controls.Add(Me.main_btn)
        Me.Controls.Add(Me.forward_btn)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Edit_Record_3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit_Record_3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents main_btn As System.Windows.Forms.Button
    Friend WithEvents forward_btn As System.Windows.Forms.Button
    Friend WithEvents back_btn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
