Public Class WordList

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim input As String = InputBox("Enter new word", "new word")

        If input = String.Empty Then
            MessageBox.Show("Please enter word/phrase.")
            input = InputBox("Enter new word/phrase", "new word")
        ElseIf ListBoxWordsPhrases.Items.Contains(input) Then
            MessageBox.Show("word exists!")
        Else
            ListBoxWordsPhrases.Items.Add(input)
        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        Dim index As Integer = ListBoxWordsPhrases.SelectedIndex
        ListBoxWordsPhrases.Items.RemoveAt(index)

    End Sub

    Private Sub WordList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnRemove.Enabled = False
    End Sub

    Private Sub ListBoxWordsPhrases_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxWordsPhrases.SelectedIndexChanged
        If ListBoxWordsPhrases.SelectedIndex < 0 Then
            btnRemove.Enabled = False
        Else
            btnRemove.Enabled = True

        End If
    End Sub

    Private Sub btnCloseWords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseWords.Click
        Me.Hide()
    End Sub
End Class