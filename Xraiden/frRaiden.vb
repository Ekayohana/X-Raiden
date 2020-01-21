Public Class frRaiden
    Dim HP As Integer = 100
    Dim score As Integer = 0
    Dim distance As Integer = 10

    Dim bullets(1024) As PictureBox
    Dim numOfBullets As Integer

    Dim numberOfAliens As Integer = 15
    Dim indexAliens As Integer = numberOfAliens + 1
    Dim aliens(indexAliens) As PictureBox
    Dim alienMove(indexAliens) As Integer
    Dim alienDestroyed As Integer = 0
    Dim spaceRowOdd As Boolean = True

    Dim alien02Move As Integer = 3
    Dim alien02HP As Integer = 25
    Dim alienBullets(2014) As PictureBox
    Dim numOfAlienBullets As Integer
    Dim alien02 As PictureBox = New PictureBox

    Dim alien03 As PictureBox = New PictureBox
    Dim alien03Move As Integer = 2
    Dim alien03HP As Integer = 300




    Private Sub RaidenMoveLeft_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles raidenMoveLeft.Tick
        If Not RaidenZ.Left <= 0 Then
            RaidenZ.Left -= distance
        End If
    End Sub

    Private Sub RaidenMoveRight_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles raidenMoveRight.Tick
        If Not RaidenZ.Left + RaidenZ.Width + 10 >= Me.Width Then
            RaidenZ.Left += distance
        End If
    End Sub

    Private Sub raidenMoveUp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles raidenMoveUp.Tick
        If Not RaidenZ.Top <= 0 Then
            RaidenZ.Top -= distance
        End If
    End Sub

    Private Sub raidenMoveDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles raidenMoveDown.Tick
        If Not RaidenZ.Top + RaidenZ.Height + 35 >= Me.Height Then
            RaidenZ.Top += distance
        End If
    End Sub

    Private Sub frRaiden_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Up Then
            raidenMoveUp.Start()
        End If

        If e.KeyCode = Keys.Down Then
            raidenMoveDown.Start()
        End If

        If e.KeyCode = Keys.Left Then
            RaidenMoveLeft.Start()
        End If

        If e.KeyCode = Keys.Right Then
            RaidenMoveRight.Start()
        End If

        If e.KeyCode = Keys.Space Then
            bulletShootTimer.Start()
        End If

    End Sub

    Private Sub frRaiden_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Space Then
            bulletShootTimer.Stop()
        End If

        If e.KeyCode = Keys.Left Then
            RaidenMoveLeft.Stop()
        End If

        If e.KeyCode = Keys.Right Then
            RaidenMoveRight.Stop()
        End If

        If e.KeyCode = Keys.Up Then
            raidenMoveUp.Stop()
        End If

        If e.KeyCode = Keys.Down Then
            raidenMoveDown.Stop()
        End If
    End Sub


    Private Sub bulletMoveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bulletMoveTimer.Tick
        For x = 1 To numOfBullets
            If stillAlive(bullets(x)) Then

                bullets(x).Top -= 10

                If offside(bullets(x)) Then
                    destroyBullet(bullets(x))
                Else : Call checkCollisionBulletAlien()
                End If


            End If

        Next
    End Sub

    Private Sub bulletShootTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bulletShootTimer.Tick
        numOfBullets += 1
        bullets(numOfBullets) = New PictureBox
        bullets(numOfBullets).BackColor = Color.Blue
        bullets(numOfBullets).Location = New System.Drawing.Point(raidenZ.Left + (raidenZ.Width / 2), RaidenZ.Top - 5)
        bullets(numOfBullets).Size = New System.Drawing.Size(5, 5)
        Me.Controls.Add(bullets(numOfBullets))
    End Sub

    Private Sub alien01MoveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alien01MoveTimer.Tick
        For lc = 0 To numberOfAliens
            mv(aliens(lc), alienMove(lc), 0)
            If aliens(lc).Left < 0 Or aliens(lc).Left + aliens(lc).Width > Me.Width Then
                mv(aliens(lc), 0, aliens(lc).Height + 5)
                alienMove(lc) *= -1
            End If
            Call checkCollisionAlienRaiden()
        Next
    End Sub

    Private Sub checkCollisionAlienRaiden()
        For x = 0 To numberOfAliens
            If collision(RaidenZ, aliens(x)) Then
                destroy(aliens(x))
                alienDestroyed += 1
                HP -= 20
                HPLabel.Text = HP
                If HP <= 0 Then
                    Call lose()
                    Exit For
                End If
                If alienDestroyed = indexAliens Then
                    alien01MoveTimer.Enabled = False
                    Call wave2()
                End If
            End If
        Next

        If collision(RaidenZ, alien02) Then
            HP = 0
            HPLabel.Text = HP
            Call lose()
        End If

        If collision(RaidenZ, alien03) Then
            HP = 0
            HPLabel.Text = HP
            Call lose()
        End If
    End Sub

    Private Sub wave1()
        Dim IncAlien As Integer = -1
        Dim row As Integer = 30
        Dim v As Integer = 1
        For LC = 0 To numberOfAliens
            IncAlien += 1
            If IncAlien = 4 Then
                IncAlien = 0
                spaceRowOdd = Not spaceRowOdd
                If Not spaceRowOdd Then
                    row += 65
                Else : row += 130
                End If
                v *= -1
            End If
            aliens(LC) = New PictureBox
            aliens(LC).Image = My.Resources.alien01
            aliens(LC).Location = New System.Drawing.Point(IncAlien * 100 + 1, row)
            aliens(LC).Size = New System.Drawing.Size(63, 65)
            aliens(LC).SizeMode = PictureBoxSizeMode.StretchImage
            alienMove(LC) = v * 3
            Me.Controls.Add(aliens(LC))
        Next

        alien01MoveTimer.Enabled = True
    End Sub


    Private Sub alien02MoveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alien02MoveTimer.Tick
        checkCollisionAlienRaiden()
        mv(alien02, alien02Move, 0)
        If alien02.Left < 0 Or alien02.Left + alien02.Width > Me.Width Then
            alien02Move *= -1
        End If
    End Sub

    Private Sub alien02BulletShootTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alien02BulletShootTimer.Tick
        numOfAlienBullets += 1
        alienBullets(numOfAlienBullets) = New PictureBox
        alienBullets(numOfAlienBullets).BackColor = Color.Yellow
        alienBullets(numOfAlienBullets).Location = New System.Drawing.Point(alien02.Left + (alien02.Width / 2), alien02.Top + alien02.Height)
        alienBullets(numOfAlienBullets).Size = New System.Drawing.Size(5, 5)
        Me.Controls.Add(alienBullets(numOfAlienBullets))
    End Sub

    Private Sub alienBulletMoveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alienBulletMoveTimer.Tick
        For x = 1 To numOfAlienBullets
            If stillAlive(alienBullets(x)) Then


                alienBullets(x).Top += 13

                If offside(alienBullets(x)) Then
                    destroyBullet(alienBullets(x))
                Else
                    Call checkCollisionBulletAlienRaiden()
                End If

                If HP <= 0 Then
                    For y = 1 To numOfAlienBullets
                        destroyBullet(alienBullets(y))
                    Next
                    Call lose()

                End If

            End If

        Next
    End Sub

    Private Sub checkCollisionBulletAlienRaiden()
        For x = 1 To numOfAlienBullets
            If collision(RaidenZ, alienBullets(x)) Then
                destroyBullet(alienBullets(x))
                HP -= 10
                HPLabel.Text = HP
            End If
        Next
    End Sub

    Public Sub wave2()
        alien01MoveTimer.Enabled = False
        alien02MoveTimer.Enabled = True
        alienBulletMoveTimer.Enabled = True
        alien02BulletShootTimer.Enabled = True

        alien02.Image = My.Resources.alien02
        alien02.Location = New System.Drawing.Point(12, 30)
        alien02.Size = New System.Drawing.Size(82, 130)
        alien02.SizeMode = PictureBoxSizeMode.StretchImage
        Me.Controls.Add(alien02)
    End Sub

    Private Sub alien03MoveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alien03MoveTimer.Tick
        checkCollisionAlienRaiden()
        mv(alien03, alien03Move, 0)
        If alien03.Left < 0 Or alien03.Left + alien03.Width > Me.Width Then
            alien03Move *= -1
        End If
    End Sub

    Private Sub alien03BulletShootTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alien03BulletShootTimer.Tick
        numOfAlienBullets += 1
        alienBullets(numOfAlienBullets) = New PictureBox
        alienBullets(numOfAlienBullets).BackColor = Color.Red
        alienBullets(numOfAlienBullets).Location = New System.Drawing.Point(alien03.Left + (alien03.Width / 2 + 75), alien03.Top + alien03.Height - 10)
        alienBullets(numOfAlienBullets).Size = New System.Drawing.Size(5, 5)
        Me.Controls.Add(alienBullets(numOfAlienBullets))

        numOfAlienBullets += 1
        alienBullets(numOfAlienBullets) = New PictureBox
        alienBullets(numOfAlienBullets).BackColor = Color.Red
        alienBullets(numOfAlienBullets).Location = New System.Drawing.Point(alien03.Left + (alien03.Width / 2 - 75), alien03.Top + alien03.Height - 10)
        alienBullets(numOfAlienBullets).Size = New System.Drawing.Size(5, 5)
        Me.Controls.Add(alienBullets(numOfAlienBullets))

    End Sub

    Public Sub wave3()
        alien03.Image = My.Resources.alien03
        alien03.Location = New System.Drawing.Point(12, 30)
        alien03.Size = New System.Drawing.Point(255, 75)
        alien03.SizeMode = PictureBoxSizeMode.StretchImage
        Me.Controls.Add(alien03)

        alien03BulletShootTimer.Enabled = True
        alien03MoveTimer.Enabled = True
        alienBulletMoveTimer.Enabled = True
    End Sub

    Private Sub checkCollisionBulletAlien()
        For x = 1 To numOfBullets
            For y = 0 To numberOfAliens
                If collision(aliens(y), bullets(x)) Then
                    destroy(aliens(y))
                    destroyBullet(bullets(x))
                    score += 10
                    scoreLabel.Text = score

                    alienDestroyed += 1
                    If alienDestroyed = indexAliens Then
                        alien01MoveTimer.Enabled = False
                        Call wave2()
                    End If
                End If
            Next

            If collision(alien02, bullets(x)) Then
                alien02HP -= 2
                destroyBullet(bullets(x))
                If alien02HP <= 0 Then
                    destroy(alien02)
                    score += 20
                    scoreLabel.Text = score
                    alien02BulletShootTimer.Enabled = False
                    Call wave3()
                End If
            End If

            If collision(alien03, bullets(x)) Then
                alien03HP -= 7
                destroyBullet(bullets(x))
                If alien03HP <= 0 Then
                    destroy(alien03)
                    score += 50
                    scoreLabel.Text = score
                    alien03BulletShootTimer.Enabled = False
                    Call win()
                End If

            End If

        Next
    End Sub

    Private Sub frRaiden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call newGame()
    End Sub

    Public Sub newGame()
        HP = 100
        HPLabel.Text = HP
        score = 0
        scoreLabel.Text = 0
        alienDestroyed = 0
        numOfBullets = 0
        numOfAlienBullets = 0
        spaceRowOdd = True
        alien02HP = 25
        alien03HP = 300
        bulletMoveTimer.Enabled = True

        raidenZ.Location = New System.Drawing.Point(25, 475)
        alien02 = New PictureBox
        alien03 = New PictureBox

        Call wave1()
    End Sub

    Public Sub reset()
        For LC = 0 To numberOfAliens
            destroy(aliens(LC))
        Next
        destroy(alien02)
        destroy(alien03)

    End Sub

End Class
