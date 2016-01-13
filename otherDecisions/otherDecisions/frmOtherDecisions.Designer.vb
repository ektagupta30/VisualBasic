<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOtherDecisions
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
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.btnGrade = New System.Windows.Forms.Button()
        Me.txtGradeWord = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnGetName = New System.Windows.Forms.Button()
        Me.txtNameTrim = New System.Windows.Forms.TextBox()
        Me.txtNameUntrimmed = New System.Windows.Forms.TextBox()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.btnGetNum = New System.Windows.Forms.Button()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.btnCase = New System.Windows.Forms.Button()
        Me.txtCaseGrade = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(13, 180)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(39, 13)
        Me.lblGrade.TabIndex = 0
        Me.lblGrade.Text = "Grade:"
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(81, 177)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(36, 20)
        Me.txtGrade.TabIndex = 1
        '
        'btnGrade
        '
        Me.btnGrade.Location = New System.Drawing.Point(16, 203)
        Me.btnGrade.Name = "btnGrade"
        Me.btnGrade.Size = New System.Drawing.Size(116, 28)
        Me.btnGrade.TabIndex = 2
        Me.btnGrade.Text = "Click for Grade"
        Me.btnGrade.UseVisualStyleBackColor = True
        '
        'txtGradeWord
        '
        Me.txtGradeWord.Location = New System.Drawing.Point(134, 178)
        Me.txtGradeWord.Name = "txtGradeWord"
        Me.txtGradeWord.ReadOnly = True
        Me.txtGradeWord.Size = New System.Drawing.Size(124, 20)
        Me.txtGradeWord.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 10)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(113, 7)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(163, 20)
        Me.txtName.TabIndex = 5
        '
        'btnGetName
        '
        Me.btnGetName.Location = New System.Drawing.Point(12, 34)
        Me.btnGetName.Name = "btnGetName"
        Me.btnGetName.Size = New System.Drawing.Size(77, 25)
        Me.btnGetName.TabIndex = 6
        Me.btnGetName.Text = "Get Name"
        Me.btnGetName.UseVisualStyleBackColor = True
        '
        'txtNameTrim
        '
        Me.txtNameTrim.Location = New System.Drawing.Point(113, 39)
        Me.txtNameTrim.Name = "txtNameTrim"
        Me.txtNameTrim.Size = New System.Drawing.Size(163, 20)
        Me.txtNameTrim.TabIndex = 7
        '
        'txtNameUntrimmed
        '
        Me.txtNameUntrimmed.Location = New System.Drawing.Point(114, 70)
        Me.txtNameUntrimmed.Name = "txtNameUntrimmed"
        Me.txtNameUntrimmed.Size = New System.Drawing.Size(161, 20)
        Me.txtNameUntrimmed.TabIndex = 8
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Location = New System.Drawing.Point(15, 104)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(170, 13)
        Me.lblRoom.TabIndex = 9
        Me.lblRoom.Text = "Room: Enter Building hyphen room"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(191, 101)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(70, 20)
        Me.txtLocation.TabIndex = 10
        '
        'btnGetNum
        '
        Me.btnGetNum.Location = New System.Drawing.Point(22, 132)
        Me.btnGetNum.Name = "btnGetNum"
        Me.btnGetNum.Size = New System.Drawing.Size(128, 23)
        Me.btnGetNum.TabIndex = 11
        Me.btnGetNum.Text = "Get Just Number"
        Me.btnGetNum.UseVisualStyleBackColor = True
        '
        'txtRoom
        '
        Me.txtRoom.Location = New System.Drawing.Point(191, 133)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(66, 20)
        Me.txtRoom.TabIndex = 12
        '
        'btnCase
        '
        Me.btnCase.Location = New System.Drawing.Point(18, 244)
        Me.btnCase.Name = "btnCase"
        Me.btnCase.Size = New System.Drawing.Size(113, 23)
        Me.btnCase.TabIndex = 13
        Me.btnCase.Text = "Use Case"
        Me.btnCase.UseVisualStyleBackColor = True
        '
        'txtCaseGrade
        '
        Me.txtCaseGrade.Location = New System.Drawing.Point(145, 246)
        Me.txtCaseGrade.Name = "txtCaseGrade"
        Me.txtCaseGrade.Size = New System.Drawing.Size(111, 20)
        Me.txtCaseGrade.TabIndex = 14
        '
        'frmOtherDecisions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 380)
        Me.Controls.Add(Me.txtCaseGrade)
        Me.Controls.Add(Me.btnCase)
        Me.Controls.Add(Me.txtRoom)
        Me.Controls.Add(Me.btnGetNum)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.txtNameUntrimmed)
        Me.Controls.Add(Me.txtNameTrim)
        Me.Controls.Add(Me.btnGetName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtGradeWord)
        Me.Controls.Add(Me.btnGrade)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.lblGrade)
        Me.Name = "frmOtherDecisions"
        Me.Text = "Other Decisions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents txtGrade As System.Windows.Forms.TextBox
    Friend WithEvents btnGrade As System.Windows.Forms.Button
    Friend WithEvents txtGradeWord As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnGetName As System.Windows.Forms.Button
    Friend WithEvents txtNameTrim As System.Windows.Forms.TextBox
    Friend WithEvents txtNameUntrimmed As System.Windows.Forms.TextBox
    Friend WithEvents lblRoom As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents btnGetNum As System.Windows.Forms.Button
    Friend WithEvents txtRoom As System.Windows.Forms.TextBox
    Friend WithEvents btnCase As System.Windows.Forms.Button
    Friend WithEvents txtCaseGrade As System.Windows.Forms.TextBox

End Class
