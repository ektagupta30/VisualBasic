<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculateAvg
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
        Me.lstStudentAverage = New System.Windows.Forms.ListBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstStudentAverage
        '
        Me.lstStudentAverage.BackColor = System.Drawing.Color.Snow
        Me.lstStudentAverage.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStudentAverage.FormattingEnabled = True
        Me.lstStudentAverage.ItemHeight = 15
        Me.lstStudentAverage.Location = New System.Drawing.Point(29, 28)
        Me.lstStudentAverage.Name = "lstStudentAverage"
        Me.lstStudentAverage.Size = New System.Drawing.Size(298, 289)
        Me.lstStudentAverage.TabIndex = 0
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(126, 337)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "RETURN"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmCalculateAvg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(399, 372)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lstStudentAverage)
        Me.Name = "frmCalculateAvg"
        Me.Text = "Average"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstStudentAverage As System.Windows.Forms.ListBox
    Friend WithEvents btnReturn As System.Windows.Forms.Button
End Class
