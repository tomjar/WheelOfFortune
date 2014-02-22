<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WordList
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
        Me.ListBoxWordsPhrases = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnCloseWords = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ListBoxWordsPhrases
        '
        Me.ListBoxWordsPhrases.FormattingEnabled = True
        Me.ListBoxWordsPhrases.Items.AddRange(New Object() {"fire", "spirit", "generation", "disposition", "invention", "attempt", "rocket", "beard", "grandstand", "shrilling", "determinism", "obstinacy", "quadrant", "mousing", "crotch", "taxicab", "roughage", "amazement", "burrow"})
        Me.ListBoxWordsPhrases.Location = New System.Drawing.Point(13, 13)
        Me.ListBoxWordsPhrases.Name = "ListBoxWordsPhrases"
        Me.ListBoxWordsPhrases.Size = New System.Drawing.Size(237, 459)
        Me.ListBoxWordsPhrases.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 479)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(94, 479)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnCloseWords
        '
        Me.btnCloseWords.Location = New System.Drawing.Point(176, 479)
        Me.btnCloseWords.Name = "btnCloseWords"
        Me.btnCloseWords.Size = New System.Drawing.Size(75, 23)
        Me.btnCloseWords.TabIndex = 3
        Me.btnCloseWords.Text = "Close"
        Me.btnCloseWords.UseVisualStyleBackColor = True
        '
        'WordList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 514)
        Me.Controls.Add(Me.btnCloseWords)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBoxWordsPhrases)
        Me.Name = "WordList"
        Me.Text = "WordList"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBoxWordsPhrases As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnCloseWords As System.Windows.Forms.Button
End Class
