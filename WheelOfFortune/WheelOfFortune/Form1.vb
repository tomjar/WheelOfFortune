Public Class Form1

    'this is the word from the list of words
    Private word As String
    Property word1() As String
        Get
            Return word
        End Get
        Set(ByVal value As String)
            word = value
        End Set
    End Property

    'this determines whether or not a letter was found
    Private foundLetter As Boolean
    Property foundLetter1() As Boolean
        Get
            Return foundLetter
        End Get
        Set(ByVal value As Boolean)
            foundLetter = value
        End Set
    End Property

    'this determines whether or not a letter was found
    Private foundLetterPlayerTwo As Boolean
    Property foundLetterPlayer2() As Boolean
        Get
            Return foundLetterPlayerTwo
        End Get
        Set(ByVal value As Boolean)
            foundLetterPlayerTwo = value
        End Set
    End Property

    'this determines if it is player one turn
    Private playerOneTurn As Boolean
    Property playerOneTurn1() As Boolean
        Get
            Return playerOneTurn
        End Get
        Set(ByVal value As Boolean)
            playerOneTurn = value
        End Set
    End Property

    'this determines if it is player two turn
    Private playerTwoTurn As Boolean
    Property playerTwoTurn1() As Boolean
        Get
            Return playerTwoTurn
        End Get
        Set(ByVal value As Boolean)
            playerTwoTurn = value
        End Set
    End Property

    'this determines if the round is over
    Private roundOver As Boolean
    Property roundOver1() As Boolean
        Get
            Return roundOver
        End Get
        Set(ByVal value As Boolean)
            roundOver = value
        End Set
    End Property

    'this is player ones score
    Private playerScore As Integer
    Property playerScore1() As Integer
        Get
            Return playerScore
        End Get
        Set(ByVal value As Integer)
            playerScore = value
        End Set
    End Property

    'this is player twos score
    Private playerScoreB As Integer
    Property playerScore2() As Integer
        Get
            Return playerScoreB
        End Get
        Set(ByVal value As Integer)
            playerScoreB = value
        End Set
    End Property

    'the wheel amount
    Dim wheelAmount() As String

    'the letters array
    Dim letters() As Char

    'the vowels array
    Dim vowels() As Char

   

    'this method loads default values into the form
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        SplashScreen1.Show()
        btnSpinWheel.Enabled = False
        btnSolveWord.Enabled = False
        ListBoxLetters.Enabled = False
        ListBoxVowels.Enabled = False

        'player one starts always
        playerOneTurn1 = True
        lblCurrentPlayer.Text = "Player One is active."

        'its not player twos turn
        playerTwoTurn1 = False

        ReDim wheelAmount(23)
        wheelAmount(0) = "5000"
        wheelAmount(1) = "600"
        wheelAmount(2) = "500"
        wheelAmount(3) = "300"
        wheelAmount(4) = "500"
        wheelAmount(5) = "800"
        wheelAmount(6) = "550"
        wheelAmount(7) = "400"
        wheelAmount(8) = "300"
        wheelAmount(9) = "900"
        wheelAmount(10) = "500"
        wheelAmount(11) = "300"
        wheelAmount(12) = "900"
        wheelAmount(13) = "BANKRUPT"
        wheelAmount(14) = "600"
        wheelAmount(15) = "400"
        wheelAmount(16) = "300"
        wheelAmount(17) = "LOSEATURN"
        wheelAmount(18) = "800"
        wheelAmount(19) = "350"
        wheelAmount(20) = "450"
        wheelAmount(21) = "700"
        wheelAmount(22) = "300"
        wheelAmount(23) = "600"

        ReDim letters(20)
        letters(0) = "b"
        letters(1) = "c"
        letters(2) = "d"
        letters(3) = "f"
        letters(4) = "g"
        letters(5) = "h"
        letters(6) = "j"
        letters(7) = "k"
        letters(8) = "l"
        letters(9) = "m"
        letters(10) = "n"
        letters(11) = "p"
        letters(12) = "q"
        letters(13) = "r"
        letters(14) = "s"
        letters(15) = "t"
        letters(16) = "v"
        letters(17) = "w"
        letters(18) = "x"
        letters(19) = "y"
        letters(20) = "z"

        ReDim vowels(4)
        vowels(0) = "a"
        vowels(1) = "e"
        vowels(2) = "i"
        vowels(3) = "o"
        vowels(4) = "u"

    End Sub

    Private Sub btnStartGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartGame.Click
        btnSpinWheel.Enabled = True
        btnSolveWord.Enabled = True
        btnStartGame.Enabled = False

        Randomize()
        Dim random As Integer = Int((WordList.ListBoxWordsPhrases.Items.Count - 0) * Rnd()) + 0
      
        'clear list boxes
        ListBoxLetters.Items.Clear()
        ListBoxVowels.Items.Clear()

        'repopulate
        For Each vowel As Char In vowels
            ListBoxVowels.Items.Add(vowel)
        Next vowel

        For Each letter As Char In letters
            ListBoxLetters.Items.Add(letter)
        Next letter

        lblCurrentWord.Text = String.Empty
        'add dashes to the lbl based on length of word selected
        word1 = WordList.ListBoxWordsPhrases.Items.Item(random).ToString
        Dim dash As String = "-"
        Dim index As Integer
        Do While index < word1.Length
            If Not index = word1.Length Then
                lblCurrentWord.Text = dash + lblCurrentWord.Text
            End If
            index += 1
        Loop

    End Sub

    'exits
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        SplashScreen1.Close()
    End Sub

    'allows user to add/remove words and phrases
    Private Sub btnEditWordList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditWordList.Click
        WordList.Show()
    End Sub

    Private Sub btnSpinWheel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSpinWheel.Click
        ListBoxVowels.Enabled = True
        ListBoxLetters.Enabled = True

        Randomize()
        Dim random As Integer = Int((wheelAmount.Count) * Rnd()) + 0
        lblSpinWheel.Text = wheelAmount.ElementAt(random).ToString

        If lblSpinWheel.Text.Contains("BANKRUPT") Then
            MessageBox.Show("Player goes bankrupt")
            playerScore1 = 0
            lblPlayerScore.Text = playerScore1.ToString()
        ElseIf lblSpinWheel.Text.Contains("LOSEATURN") Then
            MessageBox.Show("Player loses turn!")
        End If

        btnSpinWheel.Enabled = False
    End Sub

    Private Sub btnSolveWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolveWord.Click

        Dim wordGuess As String = InputBox("Please enter your guess at word.")
        Dim index As Integer
        Dim dash As String = "-"

        If wordGuess = word1 Then
            roundOver1 = True
            MessageBox.Show("Good job!")
            btnStartGame.Enabled = True
            btnSpinWheel.Enabled = False
            btnSolveWord.Enabled = False
            Dim amount As Integer = Convert.ToInt32(lblSpinWheel.Text)

            'count how many dashes are left
            Do Until index = word1.Length

                Mid(lblCurrentWord.Text, index + 1) = dash
                index += 1
            Loop
            lblPlayerScore.Text = (index * amount).ToString
        Else
            btnStartGame.Enabled = False
            roundOver1 = False
        End If

    End Sub

    'user double clicks the list box and that determines their guess
    Private Sub ListBoxLetters_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxLetters.DoubleClick
        'get the letter
        Dim letter As String = ListBoxLetters.SelectedItem.ToString().ToLower()
        Dim selected As Integer = ListBoxLetters.SelectedIndex
        Dim index As Integer

        btnSpinWheel.Enabled = True

        'attempt to find letter
        Do While index < word1.Length
            If word1.Substring(index, 1) = letter Then
                Mid(lblCurrentWord.Text, index + 1) = letter
                foundLetter1 = True
                foundLetterPlayer2 = True
                playerScore1 += Convert.ToInt32(lblSpinWheel.Text)
                lblPlayerScore.Text = playerScore1.ToString
            Else
                foundLetter1 = False
                foundLetterPlayer2 = False
            End If
            index += 1
        Loop

        'if no word was found player two turn
        If foundLetter1 = True And playerOneTurn1 = True Then
            playerOneTurn1 = True
        ElseIf foundLetter1 = False Then
            playerTwoTurn1 = True
            lblCurrentPlayer.Text = "Player Two is active."
        End If


        If foundLetterPlayer2 = True And playerTwoTurn1 = True Then
            playerTwoTurn1 = True
        ElseIf foundLetterPlayer2 = False Then
            playerTwoTurn1 = False
            lblCurrentPlayer.Text = "Player One is active."



        End If


        'is the round over?
        If lblCurrentWord.Text.Contains("-") = False Then
            roundOver1 = True
            MessageBox.Show("Good job!" + vbNewLine + _
                            "Please select Start Button for new word.")
            btnStartGame.Enabled = True
            btnSpinWheel.Enabled = False
            btnSolveWord.Enabled = False
        ElseIf foundLetter1 = False Or foundLetter1 = True Then
            ListBoxLetters.Items.RemoveAt(selected)
        ElseIf lblCurrentWord.Text.Contains("-") = True Then
            btnStartGame.Enabled = False
            btnSpinWheel.Enabled = True
            roundOver1 = False
        End If

    End Sub

    Private Sub ListBoxVowels_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxVowels.DoubleClick
        'get the letter
        Dim letter As String = ListBoxVowels.SelectedItem.ToString().ToLower()
        Dim selected As Integer = ListBoxVowels.SelectedIndex

        Dim index As Integer
        'attempt to find letter
        Do While index < word1.Length
            If word1.Substring(index, 1) = letter Then
                Mid(lblCurrentWord.Text, index + 1) = letter
                playerScore1 -= 500
                lblPlayerScore.Text = playerScore1.ToString()
            Else
                foundLetter1 = False
            End If
            index += 1
        Loop

        'is the round over?
        If lblCurrentWord.Text.Contains("-") = False Then
            roundOver1 = True
            MessageBox.Show("Good job!" + vbNewLine + _
                            "Please select Start Button for new word.")
            btnStartGame.Enabled = True
            btnSpinWheel.Enabled = False
            btnSolveWord.Enabled = False
        ElseIf foundLetter1 = False Or foundLetter1 = True Then
            ListBoxVowels.Items.RemoveAt(selected)
        ElseIf lblCurrentWord.Text.Contains("-") = True Then
            btnStartGame.Enabled = False
            roundOver1 = False
        End If

    End Sub
End Class
