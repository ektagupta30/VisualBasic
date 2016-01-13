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
        Me.components = New System.ComponentModel.Container()
        Me.btnRock = New System.Windows.Forms.Button()
        Me.btnPaper = New System.Windows.Forms.Button()
        Me.btnScissors = New System.Windows.Forms.Button()
        Me.lblplayer = New System.Windows.Forms.Label()
        Me.lblComputer = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtPlayer = New System.Windows.Forms.TextBox()
        Me.txtComputer = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRock
        '
        Me.btnRock.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnRock.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRock.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnRock.Location = New System.Drawing.Point(275, 86)
        Me.btnRock.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRock.Name = "btnRock"
        Me.btnRock.Size = New System.Drawing.Size(100, 30)
        Me.btnRock.TabIndex = 0
        Me.btnRock.Text = "Rock"
        Me.ToolTip1.SetToolTip(Me.btnRock, "click to select rock")
        Me.btnRock.UseVisualStyleBackColor = False
        '
        'btnPaper
        '
        Me.btnPaper.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnPaper.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaper.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnPaper.Location = New System.Drawing.Point(275, 154)
        Me.btnPaper.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPaper.Name = "btnPaper"
        Me.btnPaper.Size = New System.Drawing.Size(100, 30)
        Me.btnPaper.TabIndex = 1
        Me.btnPaper.Text = "Paper"
        Me.ToolTip1.SetToolTip(Me.btnPaper, "Click to select paper")
        Me.btnPaper.UseVisualStyleBackColor = False
        '
        'btnScissors
        '
        Me.btnScissors.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnScissors.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScissors.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnScissors.Location = New System.Drawing.Point(275, 227)
        Me.btnScissors.Margin = New System.Windows.Forms.Padding(4)
        Me.btnScissors.Name = "btnScissors"
        Me.btnScissors.Size = New System.Drawing.Size(100, 30)
        Me.btnScissors.TabIndex = 2
        Me.btnScissors.Text = "Scissors"
        Me.ToolTip1.SetToolTip(Me.btnScissors, "click to select scissors")
        Me.btnScissors.UseVisualStyleBackColor = False
        '
        'lblplayer
        '
        Me.lblplayer.AutoSize = True
        Me.lblplayer.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblplayer.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblplayer.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblplayer.Location = New System.Drawing.Point(76, 141)
        Me.lblplayer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblplayer.Name = "lblplayer"
        Me.lblplayer.Size = New System.Drawing.Size(58, 17)
        Me.lblplayer.TabIndex = 3
        Me.lblplayer.Text = "PLAYER"
        '
        'lblComputer
        '
        Me.lblComputer.AutoSize = True
        Me.lblComputer.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblComputer.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputer.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblComputer.Location = New System.Drawing.Point(548, 141)
        Me.lblComputer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblComputer.Name = "lblComputer"
        Me.lblComputer.Size = New System.Drawing.Size(84, 17)
        Me.lblComputer.TabIndex = 4
        Me.lblComputer.Text = "COMPUTER"
        '
        'txtResult
        '
        Me.txtResult.BackColor = System.Drawing.Color.Azure
        Me.txtResult.Location = New System.Drawing.Point(171, 406)
        Me.txtResult.Margin = New System.Windows.Forms.Padding(4)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(376, 24)
        Me.txtResult.TabIndex = 5
        '
        'txtPlayer
        '
        Me.txtPlayer.BackColor = System.Drawing.Color.Azure
        Me.txtPlayer.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtPlayer.Location = New System.Drawing.Point(41, 203)
        Me.txtPlayer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayer.Name = "txtPlayer"
        Me.txtPlayer.Size = New System.Drawing.Size(132, 24)
        Me.txtPlayer.TabIndex = 6
        Me.txtPlayer.Visible = False
        '
        'txtComputer
        '
        Me.txtComputer.BackColor = System.Drawing.Color.Azure
        Me.txtComputer.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtComputer.Location = New System.Drawing.Point(525, 203)
        Me.txtComputer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComputer.Name = "txtComputer"
        Me.txtComputer.Size = New System.Drawing.Size(132, 24)
        Me.txtComputer.TabIndex = 7
        Me.txtComputer.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnExit.Location = New System.Drawing.Point(291, 509)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 30)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "EXIT"
        Me.ToolTip1.SetToolTip(Me.btnExit, "click to exit game")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Location = New System.Drawing.Point(241, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ROCK   PAPER   SCISSORS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(765, 600)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtComputer)
        Me.Controls.Add(Me.txtPlayer)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.lblComputer)
        Me.Controls.Add(Me.lblplayer)
        Me.Controls.Add(Me.btnScissors)
        Me.Controls.Add(Me.btnPaper)
        Me.Controls.Add(Me.btnRock)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.ForestGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Rock,paper,Scissors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRock As System.Windows.Forms.Button
    Friend WithEvents btnPaper As System.Windows.Forms.Button
    Friend WithEvents btnScissors As System.Windows.Forms.Button
    Friend WithEvents lblplayer As System.Windows.Forms.Label
    Friend WithEvents lblComputer As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer As System.Windows.Forms.TextBox
    Friend WithEvents txtComputer As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
