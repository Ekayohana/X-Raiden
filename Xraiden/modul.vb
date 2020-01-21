Module Modul
    Public Function stillAlive(ByVal obj As PictureBox)
        If obj.Width = 0 And obj.Height = 0 Then
            Return False
        Else : Return True
        End If
    End Function

    Public Function offside(ByVal obj As PictureBox)
        Return Not obj.Top > 0 And obj.Top < frRaiden.Height And obj.Left > 0 And obj.Left < frRaiden.Width
    End Function

    Public Sub destroyBullet(ByVal bullet As PictureBox)
        bullet.Location = New System.Drawing.Point(-500, -500)
        bullet.Size = New Size(0, 0)
    End Sub
    Public Sub mv(ByVal obj As PictureBox, ByVal dX As Integer, ByVal dY As Integer)
        If stillAlive(obj) Then
            obj.Left += dX
            obj.Top += dY
        End If
    End Sub

    Public Function collision(ByVal obj1 As PictureBox, ByVal obj2 As PictureBox)
        Return Not (obj1.Left > obj2.Left + obj2.Width Or obj1.Left + obj1.Width < obj2.Left Or obj1.Top > obj2.Top + obj2.Height Or obj1.Top + obj1.Height < obj2.Top)
    End Function

    Public Sub destroy(ByVal obj As PictureBox)
        obj.Location = New System.Drawing.Point(-300, -300)
        obj.Size = New Size(0, 0)
    End Sub

    Public Sub win()
        frRaiden.raidenMoveUp.Enabled = False
        frRaiden.raidenMoveDown.Enabled = False
        frRaiden.raidenMoveLeft.Enabled = False
        frRaiden.raidenMoveRight.Enabled = False
        frRaiden.bulletShootTimer.Enabled = False
        msgBox.messageLabel.Text = "Sukses"
        msgBox.playButton.Text = "Mulai Lagi"

        msgBox.ShowDialog()
    End Sub

    Public Sub lose()
        frRaiden.raidenMoveUp.Enabled = False
        frRaiden.raidenMoveDown.Enabled = False
        frRaiden.raidenMoveLeft.Enabled = False
        frRaiden.raidenMoveRight.Enabled = False
        frRaiden.bulletShootTimer.Enabled = False
        frRaiden.alien01MoveTimer.Enabled = False
        frRaiden.alien02MoveTimer.Enabled = False
        frRaiden.alien03MoveTimer.Enabled = False
        frRaiden.alienBulletMoveTimer.Enabled = False
        frRaiden.alien02BulletShootTimer.Enabled = False
        frRaiden.alien03BulletShootTimer.Enabled = False


        msgBox.messageLabel.Text = "Game Berakhir"
        msgBox.playButton.Text = "Ulang"

        MsgBox.showDialog()

    End Sub

End Module

