<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formcellPhone
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
        Me.rad600 = New System.Windows.Forms.RadioButton()
        Me.rad1000 = New System.Windows.Forms.RadioButton()
        Me.rad1200 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkEmail = New System.Windows.Forms.CheckBox()
        Me.chkTextMessages = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radGalaxy = New System.Windows.Forms.RadioButton()
        Me.radIphone = New System.Windows.Forms.RadioButton()
        Me.radSamsung = New System.Windows.Forms.RadioButton()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.btnYearly = New System.Windows.Forms.Button()
        Me.btnDuration = New System.Windows.Forms.Button()
        Me.btnMonthly = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rad600
        '
        Me.rad600.AutoSize = True
        Me.rad600.Location = New System.Drawing.Point(29, 19)
        Me.rad600.Name = "rad600"
        Me.rad600.Size = New System.Drawing.Size(83, 17)
        Me.rad600.TabIndex = 0
        Me.rad600.TabStop = True
        Me.rad600.Text = "600 Minutes"
        Me.rad600.UseVisualStyleBackColor = True
        '
        'rad1000
        '
        Me.rad1000.AutoSize = True
        Me.rad1000.Location = New System.Drawing.Point(29, 42)
        Me.rad1000.Name = "rad1000"
        Me.rad1000.Size = New System.Drawing.Size(89, 17)
        Me.rad1000.TabIndex = 1
        Me.rad1000.TabStop = True
        Me.rad1000.Text = "1000 Minutes"
        Me.rad1000.UseVisualStyleBackColor = True
        '
        'rad1200
        '
        Me.rad1200.AutoSize = True
        Me.rad1200.Location = New System.Drawing.Point(29, 77)
        Me.rad1200.Name = "rad1200"
        Me.rad1200.Size = New System.Drawing.Size(89, 17)
        Me.rad1200.TabIndex = 2
        Me.rad1200.TabStop = True
        Me.rad1200.Text = "1200 Minutes"
        Me.rad1200.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pick your minutes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(283, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "choose your plan"
        '
        'chkEmail
        '
        Me.chkEmail.AutoSize = True
        Me.chkEmail.Location = New System.Drawing.Point(270, 86)
        Me.chkEmail.Name = "chkEmail"
        Me.chkEmail.Size = New System.Drawing.Size(89, 17)
        Me.chkEmail.TabIndex = 5
        Me.chkEmail.Text = "Include Email"
        Me.chkEmail.UseVisualStyleBackColor = True
        '
        'chkTextMessages
        '
        Me.chkTextMessages.AutoSize = True
        Me.chkTextMessages.Location = New System.Drawing.Point(270, 110)
        Me.chkTextMessages.Name = "chkTextMessages"
        Me.chkTextMessages.Size = New System.Drawing.Size(143, 17)
        Me.chkTextMessages.TabIndex = 6
        Me.chkTextMessages.Text = "Unlimited Text messages"
        Me.chkTextMessages.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(75, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Pick Model"
        '
        'radGalaxy
        '
        Me.radGalaxy.AutoSize = True
        Me.radGalaxy.Location = New System.Drawing.Point(79, 252)
        Me.radGalaxy.Name = "radGalaxy"
        Me.radGalaxy.Size = New System.Drawing.Size(57, 17)
        Me.radGalaxy.TabIndex = 8
        Me.radGalaxy.TabStop = True
        Me.radGalaxy.Text = "Galaxy"
        Me.radGalaxy.UseVisualStyleBackColor = True
        '
        'radIphone
        '
        Me.radIphone.AutoSize = True
        Me.radIphone.Location = New System.Drawing.Point(79, 287)
        Me.radIphone.Name = "radIphone"
        Me.radIphone.Size = New System.Drawing.Size(58, 17)
        Me.radIphone.TabIndex = 9
        Me.radIphone.TabStop = True
        Me.radIphone.Text = "Iphone"
        Me.radIphone.UseVisualStyleBackColor = True
        '
        'radSamsung
        '
        Me.radSamsung.AutoSize = True
        Me.radSamsung.Location = New System.Drawing.Point(79, 323)
        Me.radSamsung.Name = "radSamsung"
        Me.radSamsung.Size = New System.Drawing.Size(69, 17)
        Me.radSamsung.TabIndex = 10
        Me.radSamsung.TabStop = True
        Me.radSamsung.Text = "Samsung"
        Me.radSamsung.UseVisualStyleBackColor = True
        '
        'txtYears
        '
        Me.txtYears.Location = New System.Drawing.Point(313, 232)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(100, 20)
        Me.txtYears.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(313, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Enter Years"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(270, 297)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 13
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtMessage.Location = New System.Drawing.Point(156, 445)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ReadOnly = True
        Me.txtMessage.Size = New System.Drawing.Size(325, 24)
        Me.txtMessage.TabIndex = 14
        Me.txtMessage.Visible = False
        '
        'btnYearly
        '
        Me.btnYearly.Location = New System.Drawing.Point(116, 390)
        Me.btnYearly.Name = "btnYearly"
        Me.btnYearly.Size = New System.Drawing.Size(116, 23)
        Me.btnYearly.TabIndex = 15
        Me.btnYearly.Text = "Calculate yearly cost"
        Me.btnYearly.UseVisualStyleBackColor = True
        '
        'btnDuration
        '
        Me.btnDuration.Location = New System.Drawing.Point(287, 390)
        Me.btnDuration.Name = "btnDuration"
        Me.btnDuration.Size = New System.Drawing.Size(113, 23)
        Me.btnDuration.TabIndex = 16
        Me.btnDuration.Text = "Calculate duration cost"
        Me.btnDuration.UseVisualStyleBackColor = True
        '
        'btnMonthly
        '
        Me.btnMonthly.Location = New System.Drawing.Point(469, 390)
        Me.btnMonthly.Name = "btnMonthly"
        Me.btnMonthly.Size = New System.Drawing.Size(107, 23)
        Me.btnMonthly.TabIndex = 17
        Me.btnMonthly.Text = "Calculate Monthly"
        Me.btnMonthly.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(390, 297)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 18
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rad600)
        Me.GroupBox1.Controls.Add(Me.rad1000)
        Me.GroupBox1.Controls.Add(Me.rad1200)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Minutes"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(518, 296)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'formcellPhone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 500)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnMonthly)
        Me.Controls.Add(Me.btnDuration)
        Me.Controls.Add(Me.btnYearly)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.radSamsung)
        Me.Controls.Add(Me.radIphone)
        Me.Controls.Add(Me.radGalaxy)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkTextMessages)
        Me.Controls.Add(Me.chkEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formcellPhone"
        Me.Text = "CellPhone"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rad600 As System.Windows.Forms.RadioButton
    Friend WithEvents rad1000 As System.Windows.Forms.RadioButton
    Friend WithEvents rad1200 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkEmail As System.Windows.Forms.CheckBox
    Friend WithEvents chkTextMessages As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents radGalaxy As System.Windows.Forms.RadioButton
    Friend WithEvents radIphone As System.Windows.Forms.RadioButton
    Friend WithEvents radSamsung As System.Windows.Forms.RadioButton
    Friend WithEvents txtYears As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents btnYearly As System.Windows.Forms.Button
    Friend WithEvents btnDuration As System.Windows.Forms.Button
    Friend WithEvents btnMonthly As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
