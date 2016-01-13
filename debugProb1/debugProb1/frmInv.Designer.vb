<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInv
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
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.info = New System.Windows.Forms.TextBox()
        Me.lblOnHand = New System.Windows.Forms.Label()
        Me.txtOnHand = New System.Windows.Forms.TextBox()
        Me.lblOnOrder = New System.Windows.Forms.Label()
        Me.txtOnOrder = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Location = New System.Drawing.Point(61, 23)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(61, 13)
        Me.lblItemName.TabIndex = 0
        Me.lblItemName.Text = "Item Name:"
        '
        'info
        '
        Me.info.BackColor = System.Drawing.Color.White
        Me.info.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.info.Location = New System.Drawing.Point(154, 16)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(132, 20)
        Me.info.TabIndex = 1
        '
        'lblOnHand
        '
        Me.lblOnHand.AutoSize = True
        Me.lblOnHand.Location = New System.Drawing.Point(61, 57)
        Me.lblOnHand.Name = "lblOnHand"
        Me.lblOnHand.Size = New System.Drawing.Size(53, 13)
        Me.lblOnHand.TabIndex = 2
        Me.lblOnHand.Text = "On Hand:"
        '
        'txtOnHand
        '
        Me.txtOnHand.Location = New System.Drawing.Point(154, 50)
        Me.txtOnHand.Name = "txtOnHand"
        Me.txtOnHand.Size = New System.Drawing.Size(129, 20)
        Me.txtOnHand.TabIndex = 3
        '
        'lblOnOrder
        '
        Me.lblOnOrder.AutoSize = True
        Me.lblOnOrder.Location = New System.Drawing.Point(61, 94)
        Me.lblOnOrder.Name = "lblOnOrder"
        Me.lblOnOrder.Size = New System.Drawing.Size(53, 13)
        Me.lblOnOrder.TabIndex = 4
        Me.lblOnOrder.Text = "On Order:"
        '
        'txtOnOrder
        '
        Me.txtOnOrder.Location = New System.Drawing.Point(154, 87)
        Me.txtOnOrder.Name = "txtOnOrder"
        Me.txtOnOrder.Size = New System.Drawing.Size(127, 20)
        Me.txtOnOrder.TabIndex = 5
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(61, 130)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotal.Location = New System.Drawing.Point(154, 123)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(127, 20)
        Me.txtTotal.TabIndex = 7
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCalc.Location = New System.Drawing.Point(103, 210)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(86, 30)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(210, 212)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(76, 26)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(154, 280)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(434, 354)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtOnOrder)
        Me.Controls.Add(Me.lblOnOrder)
        Me.Controls.Add(Me.txtOnHand)
        Me.Controls.Add(Me.lblOnHand)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.lblItemName)
        Me.Name = "frmInv"
        Me.Text = "Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents info As System.Windows.Forms.TextBox
    Friend WithEvents lblOnHand As System.Windows.Forms.Label
    Friend WithEvents txtOnHand As System.Windows.Forms.TextBox
    Friend WithEvents lblOnOrder As System.Windows.Forms.Label
    Friend WithEvents txtOnOrder As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
