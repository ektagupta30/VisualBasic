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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBefDis = New System.Windows.Forms.TextBox()
        Me.txtAfterDiscount = New System.Windows.Forms.TextBox()
        Me.btnNoDiscount = New System.Windows.Forms.Button()
        Me.btnDis5 = New System.Windows.Forms.Button()
        Me.btnDis10 = New System.Windows.Forms.Button()
        Me.btnDis15 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.txtItem)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(455, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(128, 116)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 4
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(128, 85)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 3
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(128, 56)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(100, 20)
        Me.txtItem.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(128, 30)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Item Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ItemNo."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(480, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Total before discount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(483, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total after discount"
        '
        'txtBefDis
        '
        Me.txtBefDis.Location = New System.Drawing.Point(663, 234)
        Me.txtBefDis.Name = "txtBefDis"
        Me.txtBefDis.ReadOnly = True
        Me.txtBefDis.Size = New System.Drawing.Size(100, 20)
        Me.txtBefDis.TabIndex = 10
        '
        'txtAfterDiscount
        '
        Me.txtAfterDiscount.Location = New System.Drawing.Point(663, 282)
        Me.txtAfterDiscount.Name = "txtAfterDiscount"
        Me.txtAfterDiscount.ReadOnly = True
        Me.txtAfterDiscount.Size = New System.Drawing.Size(100, 20)
        Me.txtAfterDiscount.TabIndex = 11
        '
        'btnNoDiscount
        '
        Me.btnNoDiscount.BackColor = System.Drawing.Color.MistyRose
        Me.btnNoDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNoDiscount.Location = New System.Drawing.Point(12, 328)
        Me.btnNoDiscount.Name = "btnNoDiscount"
        Me.btnNoDiscount.Size = New System.Drawing.Size(75, 23)
        Me.btnNoDiscount.TabIndex = 12
        Me.btnNoDiscount.Text = "0-100"
        Me.btnNoDiscount.UseVisualStyleBackColor = False
        '
        'btnDis5
        '
        Me.btnDis5.AutoSize = True
        Me.btnDis5.BackColor = System.Drawing.Color.MistyRose
        Me.btnDis5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDis5.Location = New System.Drawing.Point(113, 326)
        Me.btnDis5.Name = "btnDis5"
        Me.btnDis5.Size = New System.Drawing.Size(79, 26)
        Me.btnDis5.TabIndex = 13
        Me.btnDis5.Text = "101-1000"
        Me.btnDis5.UseVisualStyleBackColor = False
        '
        'btnDis10
        '
        Me.btnDis10.AutoSize = True
        Me.btnDis10.BackColor = System.Drawing.Color.MistyRose
        Me.btnDis10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDis10.Location = New System.Drawing.Point(220, 328)
        Me.btnDis10.Name = "btnDis10"
        Me.btnDis10.Size = New System.Drawing.Size(87, 26)
        Me.btnDis10.TabIndex = 14
        Me.btnDis10.Text = "1001-5000"
        Me.btnDis10.UseVisualStyleBackColor = False
        '
        'btnDis15
        '
        Me.btnDis15.BackColor = System.Drawing.Color.MistyRose
        Me.btnDis15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDis15.Location = New System.Drawing.Point(348, 331)
        Me.btnDis15.Name = "btnDis15"
        Me.btnDis15.Size = New System.Drawing.Size(75, 23)
        Me.btnDis15.TabIndex = 15
        Me.btnDis15.Text = ">5000"
        Me.btnDis15.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.MistyRose
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(85, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 35)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Please select your quantity"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MistyRose
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkRed
        Me.btnExit.Location = New System.Drawing.Point(195, 395)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MistyRose
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.DarkRed
        Me.btnClear.Location = New System.Drawing.Point(68, 395)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Reset"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.MistyRose
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(278, 2)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(107, 19)
        Me.lblDate.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.MistyRose
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Ravie", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.ImageKey = "(none)"
        Me.Label8.Location = New System.Drawing.Point(12, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 65)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "CIS"
        '
        'lblError
        '
        Me.lblError.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblError.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Location = New System.Drawing.Point(250, 520)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(350, 23)
        Me.lblError.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(839, 540)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnDis15)
        Me.Controls.Add(Me.btnDis10)
        Me.Controls.Add(Me.btnDis5)
        Me.Controls.Add(Me.btnNoDiscount)
        Me.Controls.Add(Me.txtAfterDiscount)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtBefDis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Name = "Form1"
        Me.Text = "Discounts"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAfterDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtBefDis As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNoDiscount As System.Windows.Forms.Button
    Friend WithEvents btnDis5 As System.Windows.Forms.Button
    Friend WithEvents btnDis10 As System.Windows.Forms.Button
    Friend WithEvents btnDis15 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label

End Class
