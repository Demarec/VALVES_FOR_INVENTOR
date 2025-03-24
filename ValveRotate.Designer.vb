<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmValveRotate
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
        Me.btnTurnPos = New System.Windows.Forms.Button()
        Me.btnTurnNeg = New System.Windows.Forms.Button()
        Me.btnAcceptValveAngle = New System.Windows.Forms.Button()
        Me.cbxValveTurnByAngle = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTurnPos
        '
        Me.btnTurnPos.Location = New System.Drawing.Point(3, 29)
        Me.btnTurnPos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTurnPos.Name = "btnTurnPos"
        Me.btnTurnPos.Size = New System.Drawing.Size(47, 32)
        Me.btnTurnPos.TabIndex = 0
        Me.btnTurnPos.Text = "Turn +"
        Me.btnTurnPos.UseVisualStyleBackColor = True
        '
        'btnTurnNeg
        '
        Me.btnTurnNeg.Location = New System.Drawing.Point(53, 29)
        Me.btnTurnNeg.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTurnNeg.Name = "btnTurnNeg"
        Me.btnTurnNeg.Size = New System.Drawing.Size(49, 32)
        Me.btnTurnNeg.TabIndex = 1
        Me.btnTurnNeg.Text = "Turn -"
        Me.btnTurnNeg.UseVisualStyleBackColor = True
        '
        'btnAcceptValveAngle
        '
        Me.btnAcceptValveAngle.BackColor = System.Drawing.Color.PaleGreen
        Me.btnAcceptValveAngle.Location = New System.Drawing.Point(106, 29)
        Me.btnAcceptValveAngle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAcceptValveAngle.Name = "btnAcceptValveAngle"
        Me.btnAcceptValveAngle.Size = New System.Drawing.Size(57, 32)
        Me.btnAcceptValveAngle.TabIndex = 2
        Me.btnAcceptValveAngle.Text = "Accept"
        Me.btnAcceptValveAngle.UseVisualStyleBackColor = False
        '
        'cbxValveTurnByAngle
        '
        Me.cbxValveTurnByAngle.FormattingEnabled = True
        Me.cbxValveTurnByAngle.Items.AddRange(New Object() {"1", "2", "5", "10", "15", "45", "90"})
        Me.cbxValveTurnByAngle.Location = New System.Drawing.Point(64, 4)
        Me.cbxValveTurnByAngle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxValveTurnByAngle.Name = "cbxValveTurnByAngle"
        Me.cbxValveTurnByAngle.Size = New System.Drawing.Size(81, 21)
        Me.cbxValveTurnByAngle.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "°"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Rotate by"
        '
        'frmValveRotate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(176, 82)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxValveTurnByAngle)
        Me.Controls.Add(Me.btnAcceptValveAngle)
        Me.Controls.Add(Me.btnTurnNeg)
        Me.Controls.Add(Me.btnTurnPos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(192, 121)
        Me.MinimumSize = New System.Drawing.Size(192, 121)
        Me.Name = "frmValveRotate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ROTATE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnTurnPos As Button
    Friend WithEvents btnTurnNeg As Button
    Friend WithEvents btnAcceptValveAngle As Button
    Friend WithEvents cbxValveTurnByAngle As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
