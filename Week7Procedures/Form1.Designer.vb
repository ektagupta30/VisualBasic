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
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.btnRef = New System.Windows.Forms.Button()
        Me.btnVal = New System.Windows.Forms.Button()
        Me.reference = New System.Windows.Forms.ListBox()
        Me.byValue = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Sienna
        Me.Label1.Location = New System.Drawing.Point(21, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "car_value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Sienna
        Me.Label2.Location = New System.Drawing.Point(21, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "tax"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(125, 19)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(100, 20)
        Me.txtValue.TabIndex = 1
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(125, 49)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(100, 20)
        Me.txtTax.TabIndex = 2
        '
        'btnRef
        '
        Me.btnRef.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnRef.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRef.ForeColor = System.Drawing.Color.Sienna
        Me.btnRef.Location = New System.Drawing.Point(4, 224)
        Me.btnRef.Name = "btnRef"
        Me.btnRef.Size = New System.Drawing.Size(95, 23)
        Me.btnRef.TabIndex = 3
        Me.btnRef.Text = "calc_by_ref"
        Me.btnRef.UseVisualStyleBackColor = False
        '
        'btnVal
        '
        Me.btnVal.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnVal.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVal.ForeColor = System.Drawing.Color.Sienna
        Me.btnVal.Location = New System.Drawing.Point(24, 356)
        Me.btnVal.Name = "btnVal"
        Me.btnVal.Size = New System.Drawing.Size(75, 23)
        Me.btnVal.TabIndex = 4
        Me.btnVal.Text = "calc_by_val"
        Me.btnVal.UseVisualStyleBackColor = False
        '
        'reference
        '
        Me.reference.FormattingEnabled = True
        Me.reference.Location = New System.Drawing.Point(125, 182)
        Me.reference.Name = "reference"
        Me.reference.Size = New System.Drawing.Size(329, 95)
        Me.reference.TabIndex = 6
        '
        'byValue
        '
        Me.byValue.FormattingEnabled = True
        Me.byValue.Location = New System.Drawing.Point(131, 311)
        Me.byValue.Name = "byValue"
        Me.byValue.Size = New System.Drawing.Size(323, 95)
        Me.byValue.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(574, 486)
        Me.Controls.Add(Me.byValue)
        Me.Controls.Add(Me.reference)
        Me.Controls.Add(Me.btnVal)
        Me.Controls.Add(Me.btnRef)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "procedures"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents btnRef As System.Windows.Forms.Button
    Friend WithEvents btnVal As System.Windows.Forms.Button
    Friend WithEvents reference As System.Windows.Forms.ListBox
    Friend WithEvents byValue As System.Windows.Forms.ListBox

End Class
