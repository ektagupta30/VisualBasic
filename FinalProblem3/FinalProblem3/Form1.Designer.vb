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
        Me.lstItemNo = New System.Windows.Forms.ListBox()
        Me.lstItemName = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lstSelected = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstItemNo
        '
        Me.lstItemNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItemNo.FormattingEnabled = True
        Me.lstItemNo.ItemHeight = 20
        Me.lstItemNo.Items.AddRange(New Object() {"101", "102", "103", "104", "105", "106", "107", "108"})
        Me.lstItemNo.Location = New System.Drawing.Point(71, 105)
        Me.lstItemNo.Name = "lstItemNo"
        Me.lstItemNo.Size = New System.Drawing.Size(57, 184)
        Me.lstItemNo.TabIndex = 0
        '
        'lstItemName
        '
        Me.lstItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItemName.FormattingEnabled = True
        Me.lstItemName.ItemHeight = 16
        Me.lstItemName.Items.AddRange(New Object() {"Books", "pencils", "pens", "glue", "binders", "notebooks", "markers", "crayons"})
        Me.lstItemName.Location = New System.Drawing.Point(202, 103)
        Me.lstItemName.Name = "lstItemName"
        Me.lstItemName.Size = New System.Drawing.Size(84, 180)
        Me.lstItemName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ItemNo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ItemName"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(266, 337)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Quantity"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(165, 390)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit item"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(368, 390)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(123, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "calculate total owed"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lstSelected
        '
        Me.lstSelected.FormattingEnabled = True
        Me.lstSelected.Items.AddRange(New Object() {"ItemNo    Itemname    Price    Quantity     Total"})
        Me.lstSelected.Location = New System.Drawing.Point(391, 90)
        Me.lstSelected.Name = "lstSelected"
        Me.lstSelected.Size = New System.Drawing.Size(283, 199)
        Me.lstSelected.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 466)
        Me.Controls.Add(Me.lstSelected)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstItemName)
        Me.Controls.Add(Me.lstItemNo)
        Me.Name = "Form1"
        Me.Text = "Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstItemNo As System.Windows.Forms.ListBox
    Friend WithEvents lstItemName As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lstSelected As System.Windows.Forms.ListBox

End Class
