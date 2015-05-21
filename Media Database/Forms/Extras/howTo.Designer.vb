<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class How_To
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
        Me.back_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.edit_btn = New System.Windows.Forms.Button()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'back_btn
        '
        Me.back_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn.Location = New System.Drawing.Point(12, 318)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(256, 85)
        Me.back_btn.TabIndex = 15
        Me.back_btn.Text = "Back to Extras"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.Location = New System.Drawing.Point(12, 216)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(256, 85)
        Me.delete_btn.TabIndex = 13
        Me.delete_btn.Text = "How to delete items"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'edit_btn
        '
        Me.edit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_btn.Location = New System.Drawing.Point(12, 114)
        Me.edit_btn.Name = "edit_btn"
        Me.edit_btn.Size = New System.Drawing.Size(256, 85)
        Me.edit_btn.TabIndex = 12
        Me.edit_btn.Text = "How to edit items"
        Me.edit_btn.UseVisualStyleBackColor = True
        '
        'add_btn
        '
        Me.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_btn.Location = New System.Drawing.Point(12, 12)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(256, 85)
        Me.add_btn.TabIndex = 11
        Me.add_btn.Text = "How to add items"
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'How_To
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 415)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.edit_btn)
        Me.Controls.Add(Me.add_btn)
        Me.Name = "How_To"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "How To"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents back_btn As System.Windows.Forms.Button
    Friend WithEvents delete_btn As System.Windows.Forms.Button
    Friend WithEvents edit_btn As System.Windows.Forms.Button
    Friend WithEvents add_btn As System.Windows.Forms.Button
End Class
