<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Extras
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
        Me.suggection_btn = New System.Windows.Forms.Button()
        Me.how_btn = New System.Windows.Forms.Button()
        Me.about_btn = New System.Windows.Forms.Button()
        Me.settings_btn = New System.Windows.Forms.Button()
        Me.license_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'back_btn
        '
        Me.back_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn.Location = New System.Drawing.Point(143, 274)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(125, 125)
        Me.back_btn.TabIndex = 10
        Me.back_btn.Text = "Back"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'suggection_btn
        '
        Me.suggection_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suggection_btn.Location = New System.Drawing.Point(143, 143)
        Me.suggection_btn.Name = "suggection_btn"
        Me.suggection_btn.Size = New System.Drawing.Size(125, 125)
        Me.suggection_btn.TabIndex = 9
        Me.suggection_btn.Text = "Suggestion Box"
        Me.suggection_btn.UseVisualStyleBackColor = True
        '
        'how_btn
        '
        Me.how_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.how_btn.Location = New System.Drawing.Point(12, 143)
        Me.how_btn.Name = "how_btn"
        Me.how_btn.Size = New System.Drawing.Size(125, 125)
        Me.how_btn.TabIndex = 8
        Me.how_btn.Text = "How To"
        Me.how_btn.UseVisualStyleBackColor = True
        '
        'about_btn
        '
        Me.about_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.about_btn.Location = New System.Drawing.Point(143, 12)
        Me.about_btn.Name = "about_btn"
        Me.about_btn.Size = New System.Drawing.Size(125, 125)
        Me.about_btn.TabIndex = 7
        Me.about_btn.Text = "About"
        Me.about_btn.UseVisualStyleBackColor = True
        '
        'settings_btn
        '
        Me.settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settings_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settings_btn.Location = New System.Drawing.Point(12, 12)
        Me.settings_btn.Name = "settings_btn"
        Me.settings_btn.Size = New System.Drawing.Size(125, 125)
        Me.settings_btn.TabIndex = 6
        Me.settings_btn.Text = "Settings"
        Me.settings_btn.UseVisualStyleBackColor = True
        '
        'license_btn
        '
        Me.license_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.license_btn.Location = New System.Drawing.Point(12, 274)
        Me.license_btn.Name = "license_btn"
        Me.license_btn.Size = New System.Drawing.Size(125, 125)
        Me.license_btn.TabIndex = 11
        Me.license_btn.Text = "License Agreement"
        Me.license_btn.UseVisualStyleBackColor = True
        '
        'Extras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 415)
        Me.Controls.Add(Me.license_btn)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.suggection_btn)
        Me.Controls.Add(Me.how_btn)
        Me.Controls.Add(Me.about_btn)
        Me.Controls.Add(Me.settings_btn)
        Me.Name = "Extras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extras Page"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents back_btn As System.Windows.Forms.Button
    Friend WithEvents how_btn As System.Windows.Forms.Button
    Friend WithEvents about_btn As System.Windows.Forms.Button
    Friend WithEvents settings_btn As System.Windows.Forms.Button
    Friend WithEvents license_btn As System.Windows.Forms.Button
    Protected WithEvents suggection_btn As System.Windows.Forms.Button
End Class
