<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnStartGame = New System.Windows.Forms.Button
        Me.btnSpinWheel = New System.Windows.Forms.Button
        Me.lblSpinWheel = New System.Windows.Forms.Label
        Me.btnSolveWord = New System.Windows.Forms.Button
        Me.lblPlayerScore = New System.Windows.Forms.Label
        Me.lblCurrentWord = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnEditWordList = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.ListBoxLetters = New System.Windows.Forms.ListBox
        Me.ListBoxVowels = New System.Windows.Forms.ListBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblCurrentPlayer = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnStartGame
        '
        Me.btnStartGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartGame.Location = New System.Drawing.Point(13, 14)
        Me.btnStartGame.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(117, 34)
        Me.btnStartGame.TabIndex = 0
        Me.btnStartGame.Text = "Start Game"
        Me.btnStartGame.UseVisualStyleBackColor = True
        '
        'btnSpinWheel
        '
        Me.btnSpinWheel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpinWheel.Location = New System.Drawing.Point(269, 14)
        Me.btnSpinWheel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSpinWheel.Name = "btnSpinWheel"
        Me.btnSpinWheel.Size = New System.Drawing.Size(117, 34)
        Me.btnSpinWheel.TabIndex = 1
        Me.btnSpinWheel.Text = "Spin Wheel"
        Me.btnSpinWheel.UseVisualStyleBackColor = True
        '
        'lblSpinWheel
        '
        Me.lblSpinWheel.AutoSize = True
        Me.lblSpinWheel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSpinWheel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpinWheel.ForeColor = System.Drawing.Color.Gold
        Me.lblSpinWheel.Location = New System.Drawing.Point(269, 84)
        Me.lblSpinWheel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSpinWheel.Name = "lblSpinWheel"
        Me.lblSpinWheel.Size = New System.Drawing.Size(32, 33)
        Me.lblSpinWheel.TabIndex = 2
        Me.lblSpinWheel.Text = "0"
        '
        'btnSolveWord
        '
        Me.btnSolveWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolveWord.Location = New System.Drawing.Point(505, 14)
        Me.btnSolveWord.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSolveWord.Name = "btnSolveWord"
        Me.btnSolveWord.Size = New System.Drawing.Size(117, 34)
        Me.btnSolveWord.TabIndex = 10
        Me.btnSolveWord.Text = "Solve Word/Phrase"
        Me.btnSolveWord.UseVisualStyleBackColor = True
        '
        'lblPlayerScore
        '
        Me.lblPlayerScore.AutoSize = True
        Me.lblPlayerScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlayerScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerScore.ForeColor = System.Drawing.Color.Blue
        Me.lblPlayerScore.Location = New System.Drawing.Point(13, 84)
        Me.lblPlayerScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlayerScore.Name = "lblPlayerScore"
        Me.lblPlayerScore.Size = New System.Drawing.Size(32, 33)
        Me.lblPlayerScore.TabIndex = 11
        Me.lblPlayerScore.Text = "0"
        '
        'lblCurrentWord
        '
        Me.lblCurrentWord.AutoSize = True
        Me.lblCurrentWord.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblCurrentWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrentWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentWord.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCurrentWord.Location = New System.Drawing.Point(505, 84)
        Me.lblCurrentWord.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentWord.Name = "lblCurrentWord"
        Me.lblCurrentWord.Size = New System.Drawing.Size(2, 33)
        Me.lblCurrentWord.TabIndex = 13
        '
        'btnExit
        '
        Me.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(676, 362)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(117, 34)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnEditWordList
        '
        Me.btnEditWordList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEditWordList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditWordList.Location = New System.Drawing.Point(10, 383)
        Me.btnEditWordList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEditWordList.Name = "btnEditWordList"
        Me.btnEditWordList.Size = New System.Drawing.Size(117, 34)
        Me.btnEditWordList.TabIndex = 17
        Me.btnEditWordList.Text = "Remove/Add Words"
        Me.btnEditWordList.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(7, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 31)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Player One Score"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(263, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 31)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Spin Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(499, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(233, 31)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "The Secret Word"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 361)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Edit word list"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(4, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(244, 31)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Player Two Score"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(13, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 33)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "0"
        '
        'ListBoxLetters
        '
        Me.ListBoxLetters.FormattingEnabled = True
        Me.ListBoxLetters.ItemHeight = 20
        Me.ListBoxLetters.Location = New System.Drawing.Point(316, 222)
        Me.ListBoxLetters.MultiColumn = True
        Me.ListBoxLetters.Name = "ListBoxLetters"
        Me.ListBoxLetters.Size = New System.Drawing.Size(477, 84)
        Me.ListBoxLetters.TabIndex = 34
        '
        'ListBoxVowels
        '
        Me.ListBoxVowels.FormattingEnabled = True
        Me.ListBoxVowels.ItemHeight = 20
        Me.ListBoxVowels.Location = New System.Drawing.Point(13, 222)
        Me.ListBoxVowels.Name = "ListBoxVowels"
        Me.ListBoxVowels.Size = New System.Drawing.Size(279, 84)
        Me.ListBoxVowels.TabIndex = 35
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label10.Location = New System.Drawing.Point(7, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 31)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Vowels"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label11.Location = New System.Drawing.Point(310, 188)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 31)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Letters"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(421, 198)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(269, 20)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Double click a specific letter or vowel!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(329, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 20)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Current player is..."
        '
        'lblCurrentPlayer
        '
        Me.lblCurrentPlayer.AutoSize = True
        Me.lblCurrentPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPlayer.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.lblCurrentPlayer.Location = New System.Drawing.Point(333, 158)
        Me.lblCurrentPlayer.Name = "lblCurrentPlayer"
        Me.lblCurrentPlayer.Size = New System.Drawing.Size(63, 20)
        Me.lblCurrentPlayer.TabIndex = 40
        Me.lblCurrentPlayer.Text = "Label6"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(805, 431)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCurrentPlayer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ListBoxVowels)
        Me.Controls.Add(Me.ListBoxLetters)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEditWordList)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblCurrentWord)
        Me.Controls.Add(Me.lblPlayerScore)
        Me.Controls.Add(Me.btnSolveWord)
        Me.Controls.Add(Me.lblSpinWheel)
        Me.Controls.Add(Me.btnSpinWheel)
        Me.Controls.Add(Me.btnStartGame)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wheel Of Fortune"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStartGame As System.Windows.Forms.Button
    Friend WithEvents btnSpinWheel As System.Windows.Forms.Button
    Friend WithEvents lblSpinWheel As System.Windows.Forms.Label
    Friend WithEvents btnSolveWord As System.Windows.Forms.Button
    Friend WithEvents lblPlayerScore As System.Windows.Forms.Label
    Friend WithEvents lblCurrentWord As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnEditWordList As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ListBoxLetters As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxVowels As System.Windows.Forms.ListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCurrentPlayer As System.Windows.Forms.Label

End Class
