<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.books_btn = New System.Windows.Forms.Button()
        Me.movies_btn = New System.Windows.Forms.Button()
        Me.games_btn = New System.Windows.Forms.Button()
        Me.music_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.extra_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'books_btn
        '
        Me.books_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.books_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.books_btn.Location = New System.Drawing.Point(12, 12)
        Me.books_btn.Name = "books_btn"
        Me.books_btn.Size = New System.Drawing.Size(125, 125)
        Me.books_btn.TabIndex = 0
        Me.books_btn.Text = "Books"
        Me.books_btn.UseVisualStyleBackColor = True
        '
        'movies_btn
        '
        Me.movies_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movies_btn.Location = New System.Drawing.Point(143, 12)
        Me.movies_btn.Name = "movies_btn"
        Me.movies_btn.Size = New System.Drawing.Size(125, 125)
        Me.movies_btn.TabIndex = 1
        Me.movies_btn.Text = "Movies"
        Me.movies_btn.UseVisualStyleBackColor = True
        '
        'games_btn
        '
        Me.games_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.games_btn.Location = New System.Drawing.Point(12, 143)
        Me.games_btn.Name = "games_btn"
        Me.games_btn.Size = New System.Drawing.Size(125, 125)
        Me.games_btn.TabIndex = 2
        Me.games_btn.Text = "Games"
        Me.games_btn.UseVisualStyleBackColor = True
        '
        'music_btn
        '
        Me.music_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.music_btn.Location = New System.Drawing.Point(143, 143)
        Me.music_btn.Name = "music_btn"
        Me.music_btn.Size = New System.Drawing.Size(125, 125)
        Me.music_btn.TabIndex = 3
        Me.music_btn.Text = "Music"
        Me.music_btn.UseVisualStyleBackColor = True
        '
        'exit_btn
        '
        Me.exit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_btn.Location = New System.Drawing.Point(143, 274)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(125, 125)
        Me.exit_btn.TabIndex = 4
        Me.exit_btn.Text = "Exit"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'extra_btn
        '
        Me.extra_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extra_btn.Location = New System.Drawing.Point(12, 274)
        Me.extra_btn.Name = "extra_btn"
        Me.extra_btn.Size = New System.Drawing.Size(125, 125)
        Me.extra_btn.TabIndex = 5
        Me.extra_btn.Text = "Extra"
        Me.extra_btn.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 413)
        Me.Controls.Add(Me.extra_btn)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.music_btn)
        Me.Controls.Add(Me.games_btn)
        Me.Controls.Add(Me.movies_btn)
        Me.Controls.Add(Me.books_btn)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Page"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents books_btn As System.Windows.Forms.Button
    Friend WithEvents movies_btn As System.Windows.Forms.Button
    Friend WithEvents games_btn As System.Windows.Forms.Button
    Friend WithEvents music_btn As System.Windows.Forms.Button
    Friend WithEvents exit_btn As System.Windows.Forms.Button
    Friend WithEvents extra_btn As System.Windows.Forms.Button

End Class
