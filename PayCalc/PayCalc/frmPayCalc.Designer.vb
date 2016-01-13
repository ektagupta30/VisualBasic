<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayCalc
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblHrsWk = New System.Windows.Forms.Label()
        Me.txtHrsWk = New System.Windows.Forms.TextBox()
        Me.lblPayHr = New System.Windows.Forms.Label()
        Me.txtPayHr = New System.Windows.Forms.TextBox()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cmdCalcMore = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(17, 18)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(73, 9)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(153, 20)
        Me.txtName.TabIndex = 1
        '
        'lblHrsWk
        '
        Me.lblHrsWk.AutoSize = True
        Me.lblHrsWk.Location = New System.Drawing.Point(51, 50)
        Me.lblHrsWk.Name = "lblHrsWk"
        Me.lblHrsWk.Size = New System.Drawing.Size(79, 13)
        Me.lblHrsWk.TabIndex = 2
        Me.lblHrsWk.Text = "Hours Worked:"
        '
        'txtHrsWk
        '
        Me.txtHrsWk.Location = New System.Drawing.Point(150, 43)
        Me.txtHrsWk.Name = "txtHrsWk"
        Me.txtHrsWk.Size = New System.Drawing.Size(67, 20)
        Me.txtHrsWk.TabIndex = 3
        '
        'lblPayHr
        '
        Me.lblPayHr.AutoSize = True
        Me.lblPayHr.Location = New System.Drawing.Point(51, 83)
        Me.lblPayHr.Name = "lblPayHr"
        Me.lblPayHr.Size = New System.Drawing.Size(72, 13)
        Me.lblPayHr.TabIndex = 4
        Me.lblPayHr.Text = "Pay per Hour:"
        '
        'txtPayHr
        '
        Me.txtPayHr.Location = New System.Drawing.Point(152, 76)
        Me.txtPayHr.Name = "txtPayHr"
        Me.txtPayHr.Size = New System.Drawing.Size(64, 20)
        Me.txtPayHr.TabIndex = 5
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Location = New System.Drawing.Point(53, 116)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(58, 13)
        Me.lblGrossPay.TabIndex = 6
        Me.lblGrossPay.Text = "Gross Pay:"
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Location = New System.Drawing.Point(151, 107)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(64, 20)
        Me.txtGrossPay.TabIndex = 7
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(33, 183)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(77, 34)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "Calculate Gross Pay"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(120, 183)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(66, 33)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(195, 184)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(71, 31)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cmdCalcMore
        '
        Me.cmdCalcMore.Location = New System.Drawing.Point(35, 228)
        Me.cmdCalcMore.Name = "cmdCalcMore"
        Me.cmdCalcMore.Size = New System.Drawing.Size(75, 28)
        Me.cmdCalcMore.TabIndex = 11
        Me.cmdCalcMore.Text = "Calculate Gross Pay"
        Me.cmdCalcMore.UseVisualStyleBackColor = True
        '
        'frmPayCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.cmdCalcMore)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.txtPayHr)
        Me.Controls.Add(Me.lblPayHr)
        Me.Controls.Add(Me.txtHrsWk)
        Me.Controls.Add(Me.lblHrsWk)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmPayCalc"
        Me.Text = "Pay Calculations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblHrsWk As System.Windows.Forms.Label
    Friend WithEvents txtHrsWk As System.Windows.Forms.TextBox
    Friend WithEvents lblPayHr As System.Windows.Forms.Label
    Friend WithEvents txtPayHr As System.Windows.Forms.TextBox
    Friend WithEvents lblGrossPay As System.Windows.Forms.Label
    Friend WithEvents txtGrossPay As System.Windows.Forms.TextBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents cmdCalcMore As System.Windows.Forms.Button

End Class
