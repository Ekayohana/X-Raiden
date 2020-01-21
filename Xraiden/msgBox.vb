Public Class msgBox

    Private Sub playButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playButton.Click
        Call frRaiden.reset()
        Call frRaiden.newGame()
        Me.Close()
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
        frRaiden.Close()
    End Sub
End Class