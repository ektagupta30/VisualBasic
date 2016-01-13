<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsurance
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.gpYear = New System.Windows.Forms.GroupBox()
        Me.radOther = New System.Windows.Forms.RadioButton()
        Me.rad2013 = New System.Windows.Forms.RadioButton()
        Me.rad2012 = New System.Windows.Forms.RadioButton()
        Me.rad2010 = New System.Windows.Forms.RadioButton()
        Me.rad2009 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.chkGood = New System.Windows.Forms.CheckBox()
        Me.chkAccident = New System.Windows.Forms.CheckBox()
        Me.chkMoving = New System.Windows.Forms.CheckBox()
        Me.chkNonMoving = New System.Windows.Forms.CheckBox()
        Me.txtGood = New System.Windows.Forms.TextBox()
        Me.txtAccident = New System.Windows.Forms.TextBox()
        Me.txtMoving = New System.Windows.Forms.TextBox()
        Me.txtNonMoving = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.summary = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnFile = New System.Windows.Forms.Button()
        Me.gpYear.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(33, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Vehicle identification number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(96, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Vehicle name"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(181, 27)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(181, 53)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 4
        '
        'gpYear
        '
        Me.gpYear.BackColor = System.Drawing.Color.Snow
        Me.gpYear.Controls.Add(Me.radOther)
        Me.gpYear.Controls.Add(Me.rad2013)
        Me.gpYear.Controls.Add(Me.rad2012)
        Me.gpYear.Controls.Add(Me.rad2010)
        Me.gpYear.Controls.Add(Me.rad2009)
        Me.gpYear.Location = New System.Drawing.Point(120, 97)
        Me.gpYear.Name = "gpYear"
        Me.gpYear.Size = New System.Drawing.Size(161, 142)
        Me.gpYear.TabIndex = 5
        Me.gpYear.TabStop = False
        Me.gpYear.Text = "YEAR"
        '
        'radOther
        '
        Me.radOther.AutoSize = True
        Me.radOther.Location = New System.Drawing.Point(48, 115)
        Me.radOther.Name = "radOther"
        Me.radOther.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.radOther.Size = New System.Drawing.Size(49, 17)
        Me.radOther.TabIndex = 4
        Me.radOther.TabStop = True
        Me.radOther.Text = "other"
        Me.radOther.UseVisualStyleBackColor = True
        '
        'rad2013
        '
        Me.rad2013.AutoSize = True
        Me.rad2013.Location = New System.Drawing.Point(48, 19)
        Me.rad2013.Name = "rad2013"
        Me.rad2013.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rad2013.Size = New System.Drawing.Size(49, 17)
        Me.rad2013.TabIndex = 3
        Me.rad2013.TabStop = True
        Me.rad2013.Text = "2013"
        Me.rad2013.UseVisualStyleBackColor = True
        '
        'rad2012
        '
        Me.rad2012.AutoSize = True
        Me.rad2012.Location = New System.Drawing.Point(48, 46)
        Me.rad2012.Name = "rad2012"
        Me.rad2012.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rad2012.Size = New System.Drawing.Size(49, 17)
        Me.rad2012.TabIndex = 2
        Me.rad2012.TabStop = True
        Me.rad2012.Text = "2012"
        Me.rad2012.UseVisualStyleBackColor = True
        '
        'rad2010
        '
        Me.rad2010.AutoSize = True
        Me.rad2010.Location = New System.Drawing.Point(48, 69)
        Me.rad2010.Name = "rad2010"
        Me.rad2010.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rad2010.Size = New System.Drawing.Size(49, 17)
        Me.rad2010.TabIndex = 1
        Me.rad2010.TabStop = True
        Me.rad2010.Text = "2010"
        Me.rad2010.UseVisualStyleBackColor = True
        '
        'rad2009
        '
        Me.rad2009.AutoSize = True
        Me.rad2009.Location = New System.Drawing.Point(48, 92)
        Me.rad2009.Name = "rad2009"
        Me.rad2009.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rad2009.Size = New System.Drawing.Size(49, 17)
        Me.rad2009.TabIndex = 0
        Me.rad2009.TabStop = True
        Me.rad2009.Text = "2009"
        Me.rad2009.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rad2009.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(114, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Value"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(181, 271)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(100, 20)
        Me.txtValue.TabIndex = 7
        '
        'chkGood
        '
        Me.chkGood.AutoSize = True
        Me.chkGood.BackColor = System.Drawing.Color.Snow
        Me.chkGood.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGood.Location = New System.Drawing.Point(414, 30)
        Me.chkGood.Name = "chkGood"
        Me.chkGood.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkGood.Size = New System.Drawing.Size(149, 21)
        Me.chkGood.TabIndex = 5
        Me.chkGood.Text = "Good driving points"
        Me.chkGood.UseVisualStyleBackColor = False
        '
        'chkAccident
        '
        Me.chkAccident.AutoSize = True
        Me.chkAccident.BackColor = System.Drawing.Color.Snow
        Me.chkAccident.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAccident.Location = New System.Drawing.Point(440, 61)
        Me.chkAccident.Name = "chkAccident"
        Me.chkAccident.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkAccident.Size = New System.Drawing.Size(123, 21)
        Me.chkAccident.TabIndex = 6
        Me.chkAccident.Text = "Accident points"
        Me.chkAccident.UseVisualStyleBackColor = False
        '
        'chkMoving
        '
        Me.chkMoving.AutoSize = True
        Me.chkMoving.BackColor = System.Drawing.Color.Snow
        Me.chkMoving.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMoving.Location = New System.Drawing.Point(433, 93)
        Me.chkMoving.Name = "chkMoving"
        Me.chkMoving.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkMoving.Size = New System.Drawing.Size(130, 21)
        Me.chkMoving.TabIndex = 10
        Me.chkMoving.Text = "Moving violation"
        Me.chkMoving.UseVisualStyleBackColor = False
        '
        'chkNonMoving
        '
        Me.chkNonMoving.AutoSize = True
        Me.chkNonMoving.BackColor = System.Drawing.Color.Snow
        Me.chkNonMoving.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNonMoving.Location = New System.Drawing.Point(401, 124)
        Me.chkNonMoving.Name = "chkNonMoving"
        Me.chkNonMoving.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkNonMoving.Size = New System.Drawing.Size(162, 21)
        Me.chkNonMoving.TabIndex = 11
        Me.chkNonMoving.Text = "Non-moving violation"
        Me.chkNonMoving.UseVisualStyleBackColor = False
        '
        'txtGood
        '
        Me.txtGood.Location = New System.Drawing.Point(581, 30)
        Me.txtGood.Name = "txtGood"
        Me.txtGood.Size = New System.Drawing.Size(50, 20)
        Me.txtGood.TabIndex = 12
        Me.txtGood.Visible = False
        '
        'txtAccident
        '
        Me.txtAccident.Location = New System.Drawing.Point(581, 60)
        Me.txtAccident.Name = "txtAccident"
        Me.txtAccident.Size = New System.Drawing.Size(50, 20)
        Me.txtAccident.TabIndex = 13
        Me.txtAccident.Visible = False
        '
        'txtMoving
        '
        Me.txtMoving.Location = New System.Drawing.Point(581, 94)
        Me.txtMoving.Name = "txtMoving"
        Me.txtMoving.Size = New System.Drawing.Size(50, 20)
        Me.txtMoving.TabIndex = 14
        Me.txtMoving.Visible = False
        '
        'txtNonMoving
        '
        Me.txtNonMoving.Location = New System.Drawing.Point(581, 124)
        Me.txtNonMoving.Name = "txtNonMoving"
        Me.txtNonMoving.Size = New System.Drawing.Size(50, 20)
        Me.txtNonMoving.TabIndex = 15
        Me.txtNonMoving.Visible = False
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(531, 271)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(100, 20)
        Me.txtResult.TabIndex = 16
        '
        'btncalculate
        '
        Me.btncalculate.BackColor = System.Drawing.Color.Snow
        Me.btncalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalculate.Location = New System.Drawing.Point(451, 389)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(160, 23)
        Me.btncalculate.TabIndex = 17
        Me.btncalculate.Text = "Calculate insurance"
        Me.btncalculate.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Snow
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(421, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Amount due"
        '
        'summary
        '
        Me.summary.FormattingEnabled = True
        Me.summary.Location = New System.Drawing.Point(108, 342)
        Me.summary.Name = "summary"
        Me.summary.Size = New System.Drawing.Size(294, 160)
        Me.summary.TabIndex = 19
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Snow
        Me.btnClear.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(451, 465)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Snow
        Me.btnExit.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(604, 465)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnFile
        '
        Me.btnFile.BackColor = System.Drawing.Color.Snow
        Me.btnFile.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFile.Location = New System.Drawing.Point(181, 556)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(100, 23)
        Me.btnFile.TabIndex = 22
        Me.btnFile.Text = "Write to file"
        Me.btnFile.UseVisualStyleBackColor = False
        '
        'frmInsurance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(785, 613)
        Me.Controls.Add(Me.btnFile)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.summary)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtNonMoving)
        Me.Controls.Add(Me.txtMoving)
        Me.Controls.Add(Me.txtAccident)
        Me.Controls.Add(Me.txtGood)
        Me.Controls.Add(Me.chkNonMoving)
        Me.Controls.Add(Me.chkMoving)
        Me.Controls.Add(Me.chkAccident)
        Me.Controls.Add(Me.chkGood)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gpYear)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmInsurance"
        Me.Text = "Insurance"
        Me.gpYear.ResumeLayout(False)
        Me.gpYear.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents gpYear As System.Windows.Forms.GroupBox
    Friend WithEvents radOther As System.Windows.Forms.RadioButton
    Friend WithEvents rad2013 As System.Windows.Forms.RadioButton
    Friend WithEvents rad2012 As System.Windows.Forms.RadioButton
    Friend WithEvents rad2010 As System.Windows.Forms.RadioButton
    Friend WithEvents rad2009 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents chkGood As System.Windows.Forms.CheckBox
    Friend WithEvents chkAccident As System.Windows.Forms.CheckBox
    Friend WithEvents chkMoving As System.Windows.Forms.CheckBox
    Friend WithEvents chkNonMoving As System.Windows.Forms.CheckBox
    Friend WithEvents txtGood As System.Windows.Forms.TextBox
    Friend WithEvents txtAccident As System.Windows.Forms.TextBox
    Friend WithEvents txtMoving As System.Windows.Forms.TextBox
    Friend WithEvents txtNonMoving As System.Windows.Forms.TextBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents btncalculate As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents summary As System.Windows.Forms.ListBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnFile As System.Windows.Forms.Button

End Class
