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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.CalculateAverageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.stripStudentAvg = New System.Windows.Forms.ToolStripMenuItem()
        Me.EachSubject = New System.Windows.Forms.ToolStripMenuItem()
        Me.WholeClass = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.txtNextStudent = New System.Windows.Forms.TextBox()
        Me.txtCIS156 = New System.Windows.Forms.TextBox()
        Me.txtCIS159 = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.txtJava = New System.Windows.Forms.TextBox()
        Me.txtCIS150 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(786, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateAverageToolStripMenuItem, Me.ClearToolStrip, Me.ExitToolStrip})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(786, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'CalculateAverageToolStripMenuItem
        '
        Me.CalculateAverageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stripStudentAvg, Me.EachSubject, Me.WholeClass})
        Me.CalculateAverageToolStripMenuItem.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateAverageToolStripMenuItem.Name = "CalculateAverageToolStripMenuItem"
        Me.CalculateAverageToolStripMenuItem.Size = New System.Drawing.Size(137, 20)
        Me.CalculateAverageToolStripMenuItem.Text = "Calculate Average"
        '
        'stripStudentAvg
        '
        Me.stripStudentAvg.Name = "stripStudentAvg"
        Me.stripStudentAvg.Size = New System.Drawing.Size(157, 22)
        Me.stripStudentAvg.Text = "Each Student"
        '
        'EachSubject
        '
        Me.EachSubject.Name = "EachSubject"
        Me.EachSubject.Size = New System.Drawing.Size(157, 22)
        Me.EachSubject.Text = "Each Subject"
        '
        'WholeClass
        '
        Me.WholeClass.Name = "WholeClass"
        Me.WholeClass.Size = New System.Drawing.Size(157, 22)
        Me.WholeClass.Text = "Whole Class"
        '
        'ClearToolStrip
        '
        Me.ClearToolStrip.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearToolStrip.Name = "ClearToolStrip"
        Me.ClearToolStrip.Size = New System.Drawing.Size(55, 20)
        Me.ClearToolStrip.Text = "Clear"
        '
        'ExitToolStrip
        '
        Me.ExitToolStrip.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStrip.Name = "ExitToolStrip"
        Me.ExitToolStrip.Size = New System.Drawing.Size(45, 20)
        Me.ExitToolStrip.Text = "Exit"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(171, 325)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblMessage.TabIndex = 11
        Me.lblMessage.Visible = False
        '
        'txtNextStudent
        '
        Me.txtNextStudent.Location = New System.Drawing.Point(248, 67)
        Me.txtNextStudent.Name = "txtNextStudent"
        Me.txtNextStudent.Size = New System.Drawing.Size(220, 20)
        Me.txtNextStudent.TabIndex = 12
        '
        'txtCIS156
        '
        Me.txtCIS156.Location = New System.Drawing.Point(368, 136)
        Me.txtCIS156.Name = "txtCIS156"
        Me.txtCIS156.Size = New System.Drawing.Size(100, 20)
        Me.txtCIS156.TabIndex = 0
        '
        'txtCIS159
        '
        Me.txtCIS159.Location = New System.Drawing.Point(368, 182)
        Me.txtCIS159.Name = "txtCIS159"
        Me.txtCIS159.Size = New System.Drawing.Size(100, 20)
        Me.txtCIS159.TabIndex = 1
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(300, 374)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 15
        Me.btnEnter.Text = "ENTER"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'txtJava
        '
        Me.txtJava.Location = New System.Drawing.Point(368, 226)
        Me.txtJava.Name = "txtJava"
        Me.txtJava.Size = New System.Drawing.Size(100, 20)
        Me.txtJava.TabIndex = 2
        '
        'txtCIS150
        '
        Me.txtCIS150.Location = New System.Drawing.Point(368, 269)
        Me.txtCIS150.Name = "txtCIS150"
        Me.txtCIS150.Size = New System.Drawing.Size(100, 20)
        Me.txtCIS150.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(245, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "CIS156"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(245, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "CIS159"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "JAVA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(245, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "CIS150"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(174, 495)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 24
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 597)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCIS150)
        Me.Controls.Add(Me.txtJava)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtCIS159)
        Me.Controls.Add(Me.txtCIS156)
        Me.Controls.Add(Me.txtNextStudent)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Grades"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents CalculateAverageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents stripStudentAvg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EachSubject As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WholeClass As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents txtNextStudent As System.Windows.Forms.TextBox
    Friend WithEvents txtCIS156 As System.Windows.Forms.TextBox
    Friend WithEvents txtCIS159 As System.Windows.Forms.TextBox
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents txtJava As System.Windows.Forms.TextBox
    Friend WithEvents txtCIS150 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
