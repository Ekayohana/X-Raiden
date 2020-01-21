<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frRaiden
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HPLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.scoreLabel = New System.Windows.Forms.Label()
        Me.raidenMoveUp = New System.Windows.Forms.Timer(Me.components)
        Me.raidenMoveDown = New System.Windows.Forms.Timer(Me.components)
        Me.raidenMoveLeft = New System.Windows.Forms.Timer(Me.components)
        Me.raidenMoveRight = New System.Windows.Forms.Timer(Me.components)
        Me.bulletShootTimer = New System.Windows.Forms.Timer(Me.components)
        Me.bulletMoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RaidenZ = New System.Windows.Forms.PictureBox()
        Me.alien01MoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.alien02MoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.alienBulletMoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.alien02BulletShootTimer = New System.Windows.Forms.Timer(Me.components)
        Me.alien03MoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.alien03BulletShootTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.RaidenZ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hidup :"
        '
        'HPLabel
        '
        Me.HPLabel.AutoSize = True
        Me.HPLabel.ForeColor = System.Drawing.Color.White
        Me.HPLabel.Location = New System.Drawing.Point(59, 19)
        Me.HPLabel.Name = "HPLabel"
        Me.HPLabel.Size = New System.Drawing.Size(25, 13)
        Me.HPLabel.TabIndex = 1
        Me.HPLabel.Text = "100"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(307, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nilai"
        '
        'scoreLabel
        '
        Me.scoreLabel.AutoSize = True
        Me.scoreLabel.ForeColor = System.Drawing.Color.White
        Me.scoreLabel.Location = New System.Drawing.Point(360, 18)
        Me.scoreLabel.Name = "scoreLabel"
        Me.scoreLabel.Size = New System.Drawing.Size(13, 13)
        Me.scoreLabel.TabIndex = 3
        Me.scoreLabel.Text = "0"
        '
        'raidenMoveUp
        '
        Me.raidenMoveUp.Interval = 25
        '
        'raidenMoveDown
        '
        Me.raidenMoveDown.Interval = 25
        '
        'raidenMoveLeft
        '
        Me.raidenMoveLeft.Interval = 25
        '
        'raidenMoveRight
        '
        Me.raidenMoveRight.Interval = 25
        '
        'bulletShootTimer
        '
        Me.bulletShootTimer.Interval = 200
        '
        'bulletMoveTimer
        '
        Me.bulletMoveTimer.Interval = 1
        '
        'RaidenZ
        '
        Me.RaidenZ.Image = Global.Xraiden.My.Resources.Resources.RaidenZ
        Me.RaidenZ.Location = New System.Drawing.Point(25, 475)
        Me.RaidenZ.Name = "RaidenZ"
        Me.RaidenZ.Size = New System.Drawing.Size(75, 100)
        Me.RaidenZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RaidenZ.TabIndex = 4
        Me.RaidenZ.TabStop = False
        '
        'alien01MoveTimer
        '
        Me.alien01MoveTimer.Interval = 10
        '
        'alien02MoveTimer
        '
        Me.alien02MoveTimer.Interval = 10
        '
        'alienBulletMoveTimer
        '
        Me.alienBulletMoveTimer.Interval = 20
        '
        'alien02BulletShootTimer
        '
        Me.alien02BulletShootTimer.Interval = 500
        '
        'alien03MoveTimer
        '
        Me.alien03MoveTimer.Interval = 2
        '
        'alien03BulletShootTimer
        '
        Me.alien03BulletShootTimer.Interval = 700
        '
        'frRaiden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(434, 612)
        Me.Controls.Add(Me.RaidenZ)
        Me.Controls.Add(Me.scoreLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.HPLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frRaiden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xraiden"
        CType(Me.RaidenZ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HPLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents scoreLabel As System.Windows.Forms.Label
    Friend WithEvents RaidenZ As System.Windows.Forms.PictureBox
    Friend WithEvents raidenMoveUp As System.Windows.Forms.Timer
    Friend WithEvents raidenMoveDown As System.Windows.Forms.Timer
    Friend WithEvents raidenMoveLeft As System.Windows.Forms.Timer
    Friend WithEvents raidenMoveRight As System.Windows.Forms.Timer
    Friend WithEvents bulletShootTimer As System.Windows.Forms.Timer
    Friend WithEvents bulletMoveTimer As System.Windows.Forms.Timer
    Friend WithEvents alien01MoveTimer As System.Windows.Forms.Timer
    Friend WithEvents alien02MoveTimer As System.Windows.Forms.Timer
    Friend WithEvents alienBulletMoveTimer As System.Windows.Forms.Timer
    Friend WithEvents alien02BulletShootTimer As System.Windows.Forms.Timer
    Friend WithEvents alien03MoveTimer As System.Windows.Forms.Timer
    Friend WithEvents alien03BulletShootTimer As System.Windows.Forms.Timer

End Class
