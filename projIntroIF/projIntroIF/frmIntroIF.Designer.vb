<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntroIF
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
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.txtThird = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnCheckCI = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAnd = New System.Windows.Forms.Button()
        Me.btnAndElse = New System.Windows.Forms.Button()
        Me.btnAndDiffElse = New System.Windows.Forms.Button()
        Me.btnOr = New System.Windows.Forms.Button()
        Me.btnOrElse = New System.Windows.Forms.Button()
        Me.btnOrElseDiff = New System.Windows.Forms.Button()
        Me.btnAandBorC = New System.Windows.Forms.Button()
        Me.btnAandBorCElse = New System.Windows.Forms.Button()
        Me.btnAandBorCdiffelse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(13, 14)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(34, 13)
        Me.lblInput.TabIndex = 0
        Me.lblInput.Text = "Input:"
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(61, 11)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(54, 20)
        Me.txtFirst.TabIndex = 1
        '
        'txtSecond
        '
        Me.txtSecond.Location = New System.Drawing.Point(126, 12)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(55, 20)
        Me.txtSecond.TabIndex = 2
        '
        'txtThird
        '
        Me.txtThird.Location = New System.Drawing.Point(195, 14)
        Me.txtThird.Name = "txtThird"
        Me.txtThird.Size = New System.Drawing.Size(58, 20)
        Me.txtThird.TabIndex = 3
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(16, 52)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(40, 13)
        Me.lblResult.TabIndex = 4
        Me.lblResult.Text = "Result:"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(67, 46)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(186, 20)
        Me.txtResult.TabIndex = 5
        '
        'btnCheckCI
        '
        Me.btnCheckCI.Location = New System.Drawing.Point(16, 91)
        Me.btnCheckCI.Name = "btnCheckCI"
        Me.btnCheckCI.Size = New System.Drawing.Size(83, 25)
        Me.btnCheckCI.TabIndex = 6
        Me.btnCheckCI.Text = "Check CI"
        Me.btnCheckCI.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(116, 91)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 24)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAnd
        '
        Me.btnAnd.Location = New System.Drawing.Point(16, 123)
        Me.btnAnd.Name = "btnAnd"
        Me.btnAnd.Size = New System.Drawing.Size(82, 28)
        Me.btnAnd.TabIndex = 8
        Me.btnAnd.Text = "Check AND"
        Me.btnAnd.UseVisualStyleBackColor = True
        '
        'btnAndElse
        '
        Me.btnAndElse.Location = New System.Drawing.Point(119, 123)
        Me.btnAndElse.Name = "btnAndElse"
        Me.btnAndElse.Size = New System.Drawing.Size(111, 28)
        Me.btnAndElse.TabIndex = 9
        Me.btnAndElse.Text = "Check AND (else)"
        Me.btnAndElse.UseVisualStyleBackColor = True
        '
        'btnAndDiffElse
        '
        Me.btnAndDiffElse.Location = New System.Drawing.Point(250, 124)
        Me.btnAndDiffElse.Name = "btnAndDiffElse"
        Me.btnAndDiffElse.Size = New System.Drawing.Size(120, 26)
        Me.btnAndDiffElse.TabIndex = 10
        Me.btnAndDiffElse.Text = "Check AND (diff else)"
        Me.btnAndDiffElse.UseVisualStyleBackColor = True
        '
        'btnOr
        '
        Me.btnOr.Location = New System.Drawing.Point(16, 161)
        Me.btnOr.Name = "btnOr"
        Me.btnOr.Size = New System.Drawing.Size(81, 28)
        Me.btnOr.TabIndex = 11
        Me.btnOr.Text = "Check OR"
        Me.btnOr.UseVisualStyleBackColor = True
        '
        'btnOrElse
        '
        Me.btnOrElse.Location = New System.Drawing.Point(121, 162)
        Me.btnOrElse.Name = "btnOrElse"
        Me.btnOrElse.Size = New System.Drawing.Size(108, 26)
        Me.btnOrElse.TabIndex = 12
        Me.btnOrElse.Text = "Check OR (else)"
        Me.btnOrElse.UseVisualStyleBackColor = True
        '
        'btnOrElseDiff
        '
        Me.btnOrElseDiff.Location = New System.Drawing.Point(252, 166)
        Me.btnOrElseDiff.Name = "btnOrElseDiff"
        Me.btnOrElseDiff.Size = New System.Drawing.Size(117, 22)
        Me.btnOrElseDiff.TabIndex = 13
        Me.btnOrElseDiff.Text = "Check OR (diff else)"
        Me.btnOrElseDiff.UseVisualStyleBackColor = True
        '
        'btnAandBorC
        '
        Me.btnAandBorC.Location = New System.Drawing.Point(17, 206)
        Me.btnAandBorC.Name = "btnAandBorC"
        Me.btnAandBorC.Size = New System.Drawing.Size(127, 28)
        Me.btnAandBorC.TabIndex = 14
        Me.btnAandBorC.Text = "A and either B or C"
        Me.btnAandBorC.UseVisualStyleBackColor = True
        '
        'btnAandBorCElse
        '
        Me.btnAandBorCElse.Location = New System.Drawing.Point(163, 206)
        Me.btnAandBorCElse.Name = "btnAandBorCElse"
        Me.btnAandBorCElse.Size = New System.Drawing.Size(139, 27)
        Me.btnAandBorCElse.TabIndex = 15
        Me.btnAandBorCElse.Text = "A and either B or C (else)"
        Me.btnAandBorCElse.UseVisualStyleBackColor = True
        '
        'btnAandBorCdiffelse
        '
        Me.btnAandBorCdiffelse.Location = New System.Drawing.Point(19, 248)
        Me.btnAandBorCdiffelse.Name = "btnAandBorCdiffelse"
        Me.btnAandBorCdiffelse.Size = New System.Drawing.Size(176, 27)
        Me.btnAandBorCdiffelse.TabIndex = 16
        Me.btnAandBorCdiffelse.Text = "A and either B or C (diff else)"
        Me.btnAandBorCdiffelse.UseVisualStyleBackColor = True
        '
        'frmIntroIF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 366)
        Me.Controls.Add(Me.btnAandBorCdiffelse)
        Me.Controls.Add(Me.btnAandBorCElse)
        Me.Controls.Add(Me.btnAandBorC)
        Me.Controls.Add(Me.btnOrElseDiff)
        Me.Controls.Add(Me.btnOrElse)
        Me.Controls.Add(Me.btnOr)
        Me.Controls.Add(Me.btnAndDiffElse)
        Me.Controls.Add(Me.btnAndElse)
        Me.Controls.Add(Me.btnAnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCheckCI)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtThird)
        Me.Controls.Add(Me.txtSecond)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.lblInput)
        Me.Name = "frmIntroIF"
        Me.Text = "Introduction to IF statements"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents txtSecond As System.Windows.Forms.TextBox
    Friend WithEvents txtThird As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents btnCheckCI As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAnd As System.Windows.Forms.Button
    Friend WithEvents btnAndElse As System.Windows.Forms.Button
    Friend WithEvents btnAndDiffElse As System.Windows.Forms.Button
    Friend WithEvents btnOr As System.Windows.Forms.Button
    Friend WithEvents btnOrElse As System.Windows.Forms.Button
    Friend WithEvents btnOrElseDiff As System.Windows.Forms.Button
    Friend WithEvents btnAandBorC As System.Windows.Forms.Button
    Friend WithEvents btnAandBorCElse As System.Windows.Forms.Button
    Friend WithEvents btnAandBorCdiffelse As System.Windows.Forms.Button

End Class
