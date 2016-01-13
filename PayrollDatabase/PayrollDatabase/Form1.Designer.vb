<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payroll
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
        Me.empTable = New System.Windows.Forms.DataGridView()
        Me.btnQ1 = New System.Windows.Forms.Button()
        Me.btnQ2 = New System.Windows.Forms.Button()
        Me.btnQ3 = New System.Windows.Forms.Button()
        Me.btnQ4 = New System.Windows.Forms.Button()
        Me.lblEmpNo = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnMatch = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmp_no = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.empTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'empTable
        '
        Me.empTable.AllowUserToDeleteRows = False
        Me.empTable.BackgroundColor = System.Drawing.Color.Snow
        Me.empTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.empTable.Location = New System.Drawing.Point(0, 0)
        Me.empTable.Name = "empTable"
        Me.empTable.ReadOnly = True
        Me.empTable.Size = New System.Drawing.Size(551, 213)
        Me.empTable.TabIndex = 0
        '
        'btnQ1
        '
        Me.btnQ1.Location = New System.Drawing.Point(12, 266)
        Me.btnQ1.Name = "btnQ1"
        Me.btnQ1.Size = New System.Drawing.Size(122, 43)
        Me.btnQ1.TabIndex = 1
        Me.btnQ1.Text = "Question#1"
        Me.btnQ1.UseVisualStyleBackColor = True
        '
        'btnQ2
        '
        Me.btnQ2.Location = New System.Drawing.Point(159, 266)
        Me.btnQ2.Name = "btnQ2"
        Me.btnQ2.Size = New System.Drawing.Size(119, 43)
        Me.btnQ2.TabIndex = 2
        Me.btnQ2.Text = "Question#2"
        Me.btnQ2.UseVisualStyleBackColor = True
        '
        'btnQ3
        '
        Me.btnQ3.Location = New System.Drawing.Point(299, 266)
        Me.btnQ3.Name = "btnQ3"
        Me.btnQ3.Size = New System.Drawing.Size(129, 43)
        Me.btnQ3.TabIndex = 3
        Me.btnQ3.Text = "Question#3"
        Me.btnQ3.UseVisualStyleBackColor = True
        '
        'btnQ4
        '
        Me.btnQ4.Location = New System.Drawing.Point(454, 266)
        Me.btnQ4.Name = "btnQ4"
        Me.btnQ4.Size = New System.Drawing.Size(119, 43)
        Me.btnQ4.TabIndex = 4
        Me.btnQ4.Text = "Question#4"
        Me.btnQ4.UseVisualStyleBackColor = True
        '
        'lblEmpNo
        '
        Me.lblEmpNo.AutoSize = True
        Me.lblEmpNo.Location = New System.Drawing.Point(557, 22)
        Me.lblEmpNo.Name = "lblEmpNo"
        Me.lblEmpNo.Size = New System.Drawing.Size(48, 13)
        Me.lblEmpNo.TabIndex = 5
        Me.lblEmpNo.Text = "Emp_No"
        Me.lblEmpNo.Visible = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(557, 52)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(62, 13)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Emp_Name"
        Me.lblName.Visible = False
        '
        'btnMatch
        '
        Me.btnMatch.Location = New System.Drawing.Point(631, 114)
        Me.btnMatch.Name = "btnMatch"
        Me.btnMatch.Size = New System.Drawing.Size(75, 23)
        Me.btnMatch.TabIndex = 7
        Me.btnMatch.Text = "Match"
        Me.btnMatch.UseVisualStyleBackColor = True
        Me.btnMatch.Visible = False
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(580, 160)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 8
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.Visible = False
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(688, 160)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 9
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        Me.btnPrevious.Visible = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(631, 52)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 10
        Me.txtName.Visible = False
        '
        'txtEmp_no
        '
        Me.txtEmp_no.Location = New System.Drawing.Point(631, 19)
        Me.txtEmp_no.Name = "txtEmp_no"
        Me.txtEmp_no.Size = New System.Drawing.Size(100, 20)
        Me.txtEmp_no.TabIndex = 11
        Me.txtEmp_no.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(324, 382)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(803, 478)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtEmp_no)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnMatch)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblEmpNo)
        Me.Controls.Add(Me.btnQ4)
        Me.Controls.Add(Me.btnQ3)
        Me.Controls.Add(Me.btnQ2)
        Me.Controls.Add(Me.btnQ1)
        Me.Controls.Add(Me.empTable)
        Me.Name = "Payroll"
        Me.Text = "PayrollDB"
        CType(Me.empTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents empTable As System.Windows.Forms.DataGridView
    Friend WithEvents btnQ1 As System.Windows.Forms.Button
    Friend WithEvents btnQ2 As System.Windows.Forms.Button
    Friend WithEvents btnQ3 As System.Windows.Forms.Button
    Friend WithEvents btnQ4 As System.Windows.Forms.Button
    Friend WithEvents lblEmpNo As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnMatch As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmp_no As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
