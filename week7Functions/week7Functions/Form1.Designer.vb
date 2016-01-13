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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.calcByRef = New System.Windows.Forms.Button()
        Me.btnCalByVal = New System.Windows.Forms.Button()
        Me.byRefrence = New System.Windows.Forms.ListBox()
        Me.byValue = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Sienna
        Me.Label1.Location = New System.Drawing.Point(37, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Car_value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Sienna
        Me.Label2.Location = New System.Drawing.Point(37, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tax"
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(127, 64)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(100, 20)
        Me.txtTax.TabIndex = 2
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(127, 23)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(100, 20)
        Me.txtValue.TabIndex = 1
        '
        'calcByRef
        '
        Me.calcByRef.BackColor = System.Drawing.Color.LemonChiffon
        Me.calcByRef.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calcByRef.ForeColor = System.Drawing.Color.Sienna
        Me.calcByRef.Location = New System.Drawing.Point(31, 207)
        Me.calcByRef.Name = "calcByRef"
        Me.calcByRef.Size = New System.Drawing.Size(93, 23)
        Me.calcByRef.TabIndex = 3
        Me.calcByRef.Text = "calcByRef"
        Me.calcByRef.UseVisualStyleBackColor = False
        '
        'btnCalByVal
        '
        Me.btnCalByVal.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnCalByVal.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalByVal.ForeColor = System.Drawing.Color.Sienna
        Me.btnCalByVal.Location = New System.Drawing.Point(31, 330)
        Me.btnCalByVal.Name = "btnCalByVal"
        Me.btnCalByVal.Size = New System.Drawing.Size(75, 23)
        Me.btnCalByVal.TabIndex = 4
        Me.btnCalByVal.Text = "calByVal"
        Me.btnCalByVal.UseVisualStyleBackColor = False
        '
        'byRefrence
        '
        Me.byRefrence.FormattingEnabled = True
        Me.byRefrence.Location = New System.Drawing.Point(145, 176)
        Me.byRefrence.Name = "byRefrence"
        Me.byRefrence.Size = New System.Drawing.Size(285, 95)
        Me.byRefrence.TabIndex = 6
        '
        'byValue
        '
        Me.byValue.FormattingEnabled = True
        Me.byValue.Location = New System.Drawing.Point(145, 300)
        Me.byValue.Name = "byValue"
        Me.byValue.Size = New System.Drawing.Size(285, 95)
        Me.byValue.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(553, 461)
        Me.Controls.Add(Me.byValue)
        Me.Controls.Add(Me.byRefrence)
        Me.Controls.Add(Me.btnCalByVal)
        Me.Controls.Add(Me.calcByRef)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "functions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents calcByRef As System.Windows.Forms.Button
    Friend WithEvents btnCalByVal As System.Windows.Forms.Button
    Friend WithEvents byRefrence As System.Windows.Forms.ListBox
    Friend WithEvents byValue As System.Windows.Forms.ListBox

End Class
