<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChk
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
        Me.txtNum4 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtNum5 = New System.Windows.Forms.TextBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnGetAverage = New System.Windows.Forms.Button()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtNum3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNum4
        '
        Me.txtNum4.Location = New System.Drawing.Point(342, 117)
        Me.txtNum4.Name = "txtNum4"
        Me.txtNum4.Size = New System.Drawing.Size(56, 20)
        Me.txtNum4.TabIndex = 4
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(343, 65)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(58, 20)
        Me.txtNum2.TabIndex = 2
        '
        'txtNum5
        '
        Me.txtNum5.Location = New System.Drawing.Point(343, 143)
        Me.txtNum5.Name = "txtNum5"
        Me.txtNum5.Size = New System.Drawing.Size(59, 20)
        Me.txtNum5.TabIndex = 5
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(342, 39)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(56, 20)
        Me.txtNum1.TabIndex = 1
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblMsg.Location = New System.Drawing.Point(29, 9)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(138, 61)
        Me.lblMsg.TabIndex = 4
        Me.lblMsg.Text = "Average of five numbers"
        '
        'btnGetAverage
        '
        Me.btnGetAverage.AutoSize = True
        Me.btnGetAverage.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnGetAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetAverage.ForeColor = System.Drawing.Color.Red
        Me.btnGetAverage.Location = New System.Drawing.Point(49, 235)
        Me.btnGetAverage.Name = "btnGetAverage"
        Me.btnGetAverage.Size = New System.Drawing.Size(133, 30)
        Me.btnGetAverage.TabIndex = 0
        Me.btnGetAverage.Text = "Click to get Average"
        Me.btnGetAverage.UseVisualStyleBackColor = False
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(321, 187)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(90, 20)
        Me.txtAverage.TabIndex = 6
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(209, 194)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(71, 16)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Average:"
        '
        'txtNum3
        '
        Me.txtNum3.Location = New System.Drawing.Point(342, 91)
        Me.txtNum3.Name = "txtNum3"
        Me.txtNum3.Size = New System.Drawing.Size(59, 20)
        Me.txtNum3.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label2.Location = New System.Drawing.Point(250, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Num1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label3.Location = New System.Drawing.Point(250, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Num2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label4.Location = New System.Drawing.Point(250, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Num3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label5.Location = New System.Drawing.Point(250, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Num4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label6.Location = New System.Drawing.Point(253, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Num5"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(321, 239)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmChk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(494, 319)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNum3)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.btnGetAverage)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.txtNum5)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum4)
        Me.Name = "frmChk"
        Me.Text = "Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNum4 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum5 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents btnGetAverage As System.Windows.Forms.Button
    Friend WithEvents txtAverage As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents txtNum3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
