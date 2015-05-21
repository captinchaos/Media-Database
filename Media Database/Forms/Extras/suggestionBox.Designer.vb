<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suggestion_Box
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Suggestion_Box))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.send_btn = New System.Windows.Forms.Button()
        Me.FromBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MessageBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(313, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(313, 67)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'send_btn
        '
        Me.send_btn.Location = New System.Drawing.Point(12, 143)
        Me.send_btn.Name = "send_btn"
        Me.send_btn.Size = New System.Drawing.Size(65, 251)
        Me.send_btn.TabIndex = 5
        Me.send_btn.Text = "Send"
        Me.send_btn.UseVisualStyleBackColor = True
        '
        'FromBox
        '
        Me.FromBox.Location = New System.Drawing.Point(82, 85)
        Me.FromBox.Name = "FromBox"
        Me.FromBox.Size = New System.Drawing.Size(243, 20)
        Me.FromBox.TabIndex = 6
        Me.FromBox.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "From:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Medssage:"
        '
        'MessageBox
        '
        Me.MessageBox.Location = New System.Drawing.Point(82, 111)
        Me.MessageBox.Multiline = True
        Me.MessageBox.Name = "MessageBox"
        Me.MessageBox.Size = New System.Drawing.Size(243, 283)
        Me.MessageBox.TabIndex = 18
        '
        'Suggestion_Box
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 435)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MessageBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FromBox)
        Me.Controls.Add(Me.send_btn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Suggestion_Box"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Suggestion Box"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents send_btn As System.Windows.Forms.Button
    Friend WithEvents FromBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MessageBox As System.Windows.Forms.TextBox
End Class
