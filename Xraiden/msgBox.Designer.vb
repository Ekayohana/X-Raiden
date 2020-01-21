<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class msgBox
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
        Me.messageLabel = New System.Windows.Forms.Label()
        Me.playButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'messageLabel
        '
        Me.messageLabel.AutoSize = True
        Me.messageLabel.Location = New System.Drawing.Point(80, 9)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(48, 13)
        Me.messageLabel.TabIndex = 0
        Me.messageLabel.Text = "XRaiden"
        '
        'playButton
        '
        Me.playButton.Location = New System.Drawing.Point(12, 52)
        Me.playButton.Name = "playButton"
        Me.playButton.Size = New System.Drawing.Size(75, 23)
        Me.playButton.TabIndex = 1
        Me.playButton.Text = "Mulai Lagi"
        Me.playButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(122, 52)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "Keluar"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'msgBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(209, 87)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.playButton)
        Me.Controls.Add(Me.messageLabel)
        Me.Name = "msgBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Pesan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents messageLabel As System.Windows.Forms.Label
    Friend WithEvents playButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
End Class
