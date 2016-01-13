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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.showDept = New System.Windows.Forms.ListBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAddDept = New System.Windows.Forms.Button()
        Me.addDept = New System.Windows.Forms.ListBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter dept id"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(151, 53)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 1
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(94, 156)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(243, 20)
        Me.txtResult.TabIndex = 2
        '
        'showDept
        '
        Me.showDept.ForeColor = System.Drawing.Color.MediumBlue
        Me.showDept.FormattingEnabled = True
        Me.showDept.Location = New System.Drawing.Point(32, 291)
        Me.showDept.Name = "showDept"
        Me.showDept.Size = New System.Drawing.Size(249, 134)
        Me.showDept.TabIndex = 3
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(162, 97)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit ID"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(324, 491)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(227, 491)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAddDept
        '
        Me.btnAddDept.Location = New System.Drawing.Point(162, 229)
        Me.btnAddDept.Name = "btnAddDept"
        Me.btnAddDept.Size = New System.Drawing.Size(75, 23)
        Me.btnAddDept.TabIndex = 7
        Me.btnAddDept.Text = "ADD DEPT"
        Me.btnAddDept.UseVisualStyleBackColor = True
        '
        'addDept
        '
        Me.addDept.ForeColor = System.Drawing.Color.MediumBlue
        Me.addDept.FormattingEnabled = True
        Me.addDept.Location = New System.Drawing.Point(307, 291)
        Me.addDept.Name = "addDept"
        Me.addDept.Size = New System.Drawing.Size(230, 134)
        Me.addDept.TabIndex = 8
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(94, 431)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(117, 23)
        Me.btnShow.TabIndex = 9
        Me.btnShow.Text = "Show Departments"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(575, 550)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.addDept)
        Me.Controls.Add(Me.btnAddDept)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.showDept)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.MediumBlue
        Me.Name = "Form1"
        Me.Text = "Department"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents showDept As System.Windows.Forms.ListBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAddDept As System.Windows.Forms.Button
    Friend WithEvents addDept As System.Windows.Forms.ListBox
    Friend WithEvents btnShow As System.Windows.Forms.Button

End Class
