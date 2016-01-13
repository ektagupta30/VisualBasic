<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowTotal
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
        Me.lblBeforeDiscount = New System.Windows.Forms.Label()
        Me.lblAfterDiscount = New System.Windows.Forms.Label()
        Me.txtAfterDiscount = New System.Windows.Forms.TextBox()
        Me.txtBeforeDiscount = New System.Windows.Forms.TextBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item"
        '
        'lblBeforeDiscount
        '
        Me.lblBeforeDiscount.AutoSize = True
        Me.lblBeforeDiscount.Location = New System.Drawing.Point(24, 79)
        Me.lblBeforeDiscount.Name = "lblBeforeDiscount"
        Me.lblBeforeDiscount.Size = New System.Drawing.Size(140, 15)
        Me.lblBeforeDiscount.TabIndex = 1
        Me.lblBeforeDiscount.Text = "Total before discount"
        Me.lblBeforeDiscount.Visible = False
        '
        'lblAfterDiscount
        '
        Me.lblAfterDiscount.AutoSize = True
        Me.lblAfterDiscount.Location = New System.Drawing.Point(24, 123)
        Me.lblAfterDiscount.Name = "lblAfterDiscount"
        Me.lblAfterDiscount.Size = New System.Drawing.Size(129, 15)
        Me.lblAfterDiscount.TabIndex = 2
        Me.lblAfterDiscount.Text = "Total after discount"
        Me.lblAfterDiscount.Visible = False
        '
        'txtAfterDiscount
        '
        Me.txtAfterDiscount.Location = New System.Drawing.Point(182, 120)
        Me.txtAfterDiscount.Name = "txtAfterDiscount"
        Me.txtAfterDiscount.Size = New System.Drawing.Size(100, 23)
        Me.txtAfterDiscount.TabIndex = 3
        Me.txtAfterDiscount.Visible = False
        '
        'txtBeforeDiscount
        '
        Me.txtBeforeDiscount.Location = New System.Drawing.Point(182, 76)
        Me.txtBeforeDiscount.Name = "txtBeforeDiscount"
        Me.txtBeforeDiscount.Size = New System.Drawing.Size(100, 23)
        Me.txtBeforeDiscount.TabIndex = 4
        Me.txtBeforeDiscount.Visible = False
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(182, 30)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(100, 23)
        Me.txtItem.TabIndex = 5
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(144, 202)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 6
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmShowTotal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(379, 302)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.txtBeforeDiscount)
        Me.Controls.Add(Me.txtAfterDiscount)
        Me.Controls.Add(Me.lblAfterDiscount)
        Me.Controls.Add(Me.lblBeforeDiscount)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmShowTotal"
        Me.Text = "showBonus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblBeforeDiscount As System.Windows.Forms.Label
    Friend WithEvents lblAfterDiscount As System.Windows.Forms.Label
    Friend WithEvents txtAfterDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtBeforeDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents btnReturn As System.Windows.Forms.Button
End Class
