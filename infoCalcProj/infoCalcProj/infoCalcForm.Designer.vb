<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class infoCalcForm
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
        Me.lblGreet = New System.Windows.Forms.Label()
        Me.txtGreet = New System.Windows.Forms.TextBox()
        Me.btnGreet = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblExitNote = New System.Windows.Forms.Label()
        Me.lblFeet = New System.Windows.Forms.Label()
        Me.txtFeet = New System.Windows.Forms.TextBox()
        Me.btnCalcInches = New System.Windows.Forms.Button()
        Me.lblInches = New System.Windows.Forms.Label()
        Me.txtInches = New System.Windows.Forms.TextBox()
        Me.txtNote = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(17, 20)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 15)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(68, 18)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(90, 20)
        Me.txtName.TabIndex = 1
        '
        'lblGreet
        '
        Me.lblGreet.AutoSize = True
        Me.lblGreet.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreet.Location = New System.Drawing.Point(9, 51)
        Me.lblGreet.Name = "lblGreet"
        Me.lblGreet.Size = New System.Drawing.Size(0, 18)
        Me.lblGreet.TabIndex = 2
        '
        'txtGreet
        '
        Me.txtGreet.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGreet.Location = New System.Drawing.Point(146, 50)
        Me.txtGreet.Name = "txtGreet"
        Me.txtGreet.Size = New System.Drawing.Size(134, 26)
        Me.txtGreet.TabIndex = 3
        '
        'btnGreet
        '
        Me.btnGreet.Location = New System.Drawing.Point(273, 13)
        Me.btnGreet.Name = "btnGreet"
        Me.btnGreet.Size = New System.Drawing.Size(56, 25)
        Me.btnGreet.TabIndex = 4
        Me.btnGreet.Text = "Greet"
        Me.btnGreet.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(199, 231)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 22)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblExitNote
        '
        Me.lblExitNote.AutoSize = True
        Me.lblExitNote.Location = New System.Drawing.Point(97, 236)
        Me.lblExitNote.Name = "lblExitNote"
        Me.lblExitNote.Size = New System.Drawing.Size(96, 13)
        Me.lblExitNote.TabIndex = 6
        Me.lblExitNote.Text = "Alt + X will also exit"
        '
        'lblFeet
        '
        Me.lblFeet.AutoSize = True
        Me.lblFeet.Location = New System.Drawing.Point(14, 105)
        Me.lblFeet.Name = "lblFeet"
        Me.lblFeet.Size = New System.Drawing.Size(31, 13)
        Me.lblFeet.TabIndex = 7
        Me.lblFeet.Text = "Feet:"
        '
        'txtFeet
        '
        Me.txtFeet.Location = New System.Drawing.Point(61, 98)
        Me.txtFeet.Name = "txtFeet"
        Me.txtFeet.Size = New System.Drawing.Size(50, 20)
        Me.txtFeet.TabIndex = 8
        '
        'btnCalcInches
        '
        Me.btnCalcInches.Location = New System.Drawing.Point(140, 96)
        Me.btnCalcInches.Name = "btnCalcInches"
        Me.btnCalcInches.Size = New System.Drawing.Size(84, 21)
        Me.btnCalcInches.TabIndex = 9
        Me.btnCalcInches.Text = "Calculate Inches"
        Me.btnCalcInches.UseVisualStyleBackColor = True
        '
        'lblInches
        '
        Me.lblInches.AutoSize = True
        Me.lblInches.Location = New System.Drawing.Point(17, 135)
        Me.lblInches.Name = "lblInches"
        Me.lblInches.Size = New System.Drawing.Size(42, 13)
        Me.lblInches.TabIndex = 10
        Me.lblInches.Text = "Inches:"
        '
        'txtInches
        '
        Me.txtInches.Location = New System.Drawing.Point(75, 131)
        Me.txtInches.Name = "txtInches"
        Me.txtInches.ReadOnly = True
        Me.txtInches.Size = New System.Drawing.Size(56, 20)
        Me.txtInches.TabIndex = 11
        '
        'txtNote
        '
        Me.txtNote.AutoSize = True
        Me.txtNote.Location = New System.Drawing.Point(148, 133)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(0, 13)
        Me.txtNote.TabIndex = 12
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(22, 176)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 13
        Me.lblDate.Text = "Date:"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(88, 171)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(104, 20)
        Me.txtDate.TabIndex = 14
        '
        'btnDate
        '
        Me.btnDate.Location = New System.Drawing.Point(212, 171)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(55, 19)
        Me.btnDate.TabIndex = 15
        Me.btnDate.Text = "Date"
        Me.btnDate.UseVisualStyleBackColor = True
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(176, 18)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(91, 20)
        Me.txtLastName.TabIndex = 16
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(8, 208)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(57, 13)
        Me.lblFullName.TabIndex = 17
        Me.lblFullName.Text = "Full Name:"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(92, 205)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(174, 20)
        Me.txtFullName.TabIndex = 18
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(281, 204)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(47, 20)
        Me.btnShow.TabIndex = 19
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'infoCalcForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 266)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.btnDate)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.txtInches)
        Me.Controls.Add(Me.lblInches)
        Me.Controls.Add(Me.btnCalcInches)
        Me.Controls.Add(Me.txtFeet)
        Me.Controls.Add(Me.lblFeet)
        Me.Controls.Add(Me.lblExitNote)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGreet)
        Me.Controls.Add(Me.txtGreet)
        Me.Controls.Add(Me.lblGreet)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "infoCalcForm"
        Me.Text = "Info & Calc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblGreet As System.Windows.Forms.Label
    Friend WithEvents txtGreet As System.Windows.Forms.TextBox
    Friend WithEvents btnGreet As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblExitNote As System.Windows.Forms.Label
    Friend WithEvents lblFeet As System.Windows.Forms.Label
    Friend WithEvents txtFeet As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcInches As System.Windows.Forms.Button
    Friend WithEvents lblInches As System.Windows.Forms.Label
    Friend WithEvents txtInches As System.Windows.Forms.TextBox
    Friend WithEvents txtNote As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents btnDate As System.Windows.Forms.Button
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents btnShow As System.Windows.Forms.Button

End Class
