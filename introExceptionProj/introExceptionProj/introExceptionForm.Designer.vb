<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class introExceptionForm
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
        Me.lblToConvert = New System.Windows.Forms.Label()
        Me.txtToConvert = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnConvertOnly = New System.Windows.Forms.Button()
        Me.btnTryCatch = New System.Windows.Forms.Button()
        Me.lblNumbers = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.lblAns = New System.Windows.Forms.Label()
        Me.txtAns = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblToConvert
        '
        Me.lblToConvert.AutoSize = True
        Me.lblToConvert.Location = New System.Drawing.Point(12, 17)
        Me.lblToConvert.Name = "lblToConvert"
        Me.lblToConvert.Size = New System.Drawing.Size(63, 13)
        Me.lblToConvert.TabIndex = 0
        Me.lblToConvert.Text = "To Convert:"
        '
        'txtToConvert
        '
        Me.txtToConvert.Location = New System.Drawing.Point(91, 13)
        Me.txtToConvert.Name = "txtToConvert"
        Me.txtToConvert.Size = New System.Drawing.Size(109, 20)
        Me.txtToConvert.TabIndex = 1
        Me.txtToConvert.Text = "hj"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(12, 55)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(40, 13)
        Me.lblResult.TabIndex = 2
        Me.lblResult.Text = "Result:"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(92, 50)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(107, 20)
        Me.txtResult.TabIndex = 3
        '
        'btnConvertOnly
        '
        Me.btnConvertOnly.Location = New System.Drawing.Point(14, 104)
        Me.btnConvertOnly.Name = "btnConvertOnly"
        Me.btnConvertOnly.Size = New System.Drawing.Size(89, 26)
        Me.btnConvertOnly.TabIndex = 4
        Me.btnConvertOnly.Text = "Convert Only"
        Me.btnConvertOnly.UseVisualStyleBackColor = True
        '
        'btnTryCatch
        '
        Me.btnTryCatch.Location = New System.Drawing.Point(126, 104)
        Me.btnTryCatch.Name = "btnTryCatch"
        Me.btnTryCatch.Size = New System.Drawing.Size(138, 25)
        Me.btnTryCatch.TabIndex = 5
        Me.btnTryCatch.Text = "Convert Try...Catch"
        Me.btnTryCatch.UseVisualStyleBackColor = True
        '
        'lblNumbers
        '
        Me.lblNumbers.AutoSize = True
        Me.lblNumbers.Location = New System.Drawing.Point(8, 151)
        Me.lblNumbers.Name = "lblNumbers"
        Me.lblNumbers.Size = New System.Drawing.Size(52, 13)
        Me.lblNumbers.TabIndex = 6
        Me.lblNumbers.Text = "Numbers:"
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(76, 144)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(74, 20)
        Me.txtNum1.TabIndex = 7
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(77, 172)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(72, 20)
        Me.txtNum2.TabIndex = 8
        '
        'lblAns
        '
        Me.lblAns.AutoSize = True
        Me.lblAns.Location = New System.Drawing.Point(8, 215)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(45, 13)
        Me.lblAns.TabIndex = 9
        Me.lblAns.Text = "Answer:"
        '
        'txtAns
        '
        Me.txtAns.Location = New System.Drawing.Point(76, 210)
        Me.txtAns.Name = "txtAns"
        Me.txtAns.Size = New System.Drawing.Size(124, 20)
        Me.txtAns.TabIndex = 10
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(190, 172)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(74, 24)
        Me.btnCalc.TabIndex = 11
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'introExceptionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 399)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtAns)
        Me.Controls.Add(Me.lblAns)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.lblNumbers)
        Me.Controls.Add(Me.btnTryCatch)
        Me.Controls.Add(Me.btnConvertOnly)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtToConvert)
        Me.Controls.Add(Me.lblToConvert)
        Me.Name = "introExceptionForm"
        Me.Text = "Intro Exception"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblToConvert As System.Windows.Forms.Label
    Friend WithEvents txtToConvert As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents btnConvertOnly As System.Windows.Forms.Button
    Friend WithEvents btnTryCatch As System.Windows.Forms.Button
    Friend WithEvents lblNumbers As System.Windows.Forms.Label
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents lblAns As System.Windows.Forms.Label
    Friend WithEvents txtAns As System.Windows.Forms.TextBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button

End Class
