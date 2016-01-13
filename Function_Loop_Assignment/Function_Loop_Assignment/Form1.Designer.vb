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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEnterName = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnShowName = New System.Windows.Forms.Button()
        Me.radMR = New System.Windows.Forms.RadioButton()
        Me.radMRS = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEnterAddress = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.btnShowAddress = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnShowID = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCost = New System.Windows.Forms.Button()
        Me.City = New System.Windows.Forms.ListBox()
        Me.Conferences = New System.Windows.Forms.ListBox()
        Me.ConferenceCost = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClearName = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter name in format last/First Middle"
        '
        'txtEnterName
        '
        Me.txtEnterName.Location = New System.Drawing.Point(223, 39)
        Me.txtEnterName.Name = "txtEnterName"
        Me.txtEnterName.Size = New System.Drawing.Size(178, 20)
        Me.txtEnterName.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtEnterName, "Enter name in format last/first m")
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(248, 80)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name"
        '
        'btnShowName
        '
        Me.btnShowName.Location = New System.Drawing.Point(142, 123)
        Me.btnShowName.Name = "btnShowName"
        Me.btnShowName.Size = New System.Drawing.Size(75, 23)
        Me.btnShowName.TabIndex = 4
        Me.btnShowName.Text = "Show name"
        Me.btnShowName.UseVisualStyleBackColor = True
        '
        'radMR
        '
        Me.radMR.AutoSize = True
        Me.radMR.Location = New System.Drawing.Point(248, 12)
        Me.radMR.Name = "radMR"
        Me.radMR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.radMR.Size = New System.Drawing.Size(42, 17)
        Me.radMR.TabIndex = 5
        Me.radMR.TabStop = True
        Me.radMR.Text = "MR"
        Me.radMR.UseVisualStyleBackColor = True
        '
        'radMRS
        '
        Me.radMRS.AutoSize = True
        Me.radMRS.Location = New System.Drawing.Point(307, 12)
        Me.radMRS.Name = "radMRS"
        Me.radMRS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.radMRS.Size = New System.Drawing.Size(49, 17)
        Me.radMRS.TabIndex = 6
        Me.radMRS.TabStop = True
        Me.radMRS.Text = "MRS"
        Me.radMRS.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(508, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Street Adress"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(562, 12)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(281, 17)
        Me.label4.TabIndex = 8
        Me.label4.Text = "Write Address in format street/city/state/zip"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(525, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Adress"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(166, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Title"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtAddress.Location = New System.Drawing.Point(616, 158)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(196, 20)
        Me.txtAddress.TabIndex = 13
        '
        'txtEnterAddress
        '
        Me.txtEnterAddress.Location = New System.Drawing.Point(549, 42)
        Me.txtEnterAddress.Name = "txtEnterAddress"
        Me.txtEnterAddress.Size = New System.Drawing.Size(277, 20)
        Me.txtEnterAddress.TabIndex = 14
        '
        'txtStreet
        '
        Me.txtStreet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtStreet.Location = New System.Drawing.Point(616, 126)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.ReadOnly = True
        Me.txtStreet.Size = New System.Drawing.Size(100, 20)
        Me.txtStreet.TabIndex = 15
        '
        'btnShowAddress
        '
        Me.btnShowAddress.Location = New System.Drawing.Point(619, 78)
        Me.btnShowAddress.Name = "btnShowAddress"
        Me.btnShowAddress.Size = New System.Drawing.Size(97, 23)
        Me.btnShowAddress.TabIndex = 16
        Me.btnShowAddress.Text = "Show Adress"
        Me.ToolTip1.SetToolTip(Me.btnShowAddress, "Click to see street address and full address")
        Me.btnShowAddress.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(522, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Address id"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtID.Location = New System.Drawing.Point(616, 203)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 18
        '
        'btnShowID
        '
        Me.btnShowID.Location = New System.Drawing.Point(737, 201)
        Me.btnShowID.Name = "btnShowID"
        Me.btnShowID.Size = New System.Drawing.Size(75, 23)
        Me.btnShowID.TabIndex = 19
        Me.btnShowID.Text = "Show ID"
        Me.ToolTip1.SetToolTip(Me.btnShowID, "Click to see address id")
        Me.btnShowID.UseVisualStyleBackColor = True
        '
        'btnCost
        '
        Me.btnCost.Location = New System.Drawing.Point(349, 446)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(75, 23)
        Me.btnCost.TabIndex = 25
        Me.btnCost.Text = "Show Cost"
        Me.ToolTip1.SetToolTip(Me.btnCost, "Click to show cost of conferences")
        Me.btnCost.UseVisualStyleBackColor = True
        '
        'City
        '
        Me.City.BackColor = System.Drawing.SystemColors.Info
        Me.City.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.City.ForeColor = System.Drawing.Color.Chocolate
        Me.City.FormattingEnabled = True
        Me.City.ItemHeight = 17
        Me.City.Items.AddRange(New Object() {"Manhattan", "Dallas", "Los Angles"})
        Me.City.Location = New System.Drawing.Point(50, 290)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(109, 72)
        Me.City.TabIndex = 20
        '
        'Conferences
        '
        Me.Conferences.BackColor = System.Drawing.SystemColors.Info
        Me.Conferences.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conferences.ForeColor = System.Drawing.Color.Chocolate
        Me.Conferences.FormattingEnabled = True
        Me.Conferences.ItemHeight = 17
        Me.Conferences.Items.AddRange(New Object() {"Business Plan", "Sales and Marketing", "Buyers", "Distributors", "Software"})
        Me.Conferences.Location = New System.Drawing.Point(195, 290)
        Me.Conferences.Name = "Conferences"
        Me.Conferences.Size = New System.Drawing.Size(161, 89)
        Me.Conferences.TabIndex = 21
        '
        'ConferenceCost
        '
        Me.ConferenceCost.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConferenceCost.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ConferenceCost.FormattingEnabled = True
        Me.ConferenceCost.ItemHeight = 14
        Me.ConferenceCost.Items.AddRange(New Object() {"City                  Conference              Cost"})
        Me.ConferenceCost.Location = New System.Drawing.Point(73, 417)
        Me.ConferenceCost.Name = "ConferenceCost"
        Me.ConferenceCost.Size = New System.Drawing.Size(255, 102)
        Me.ConferenceCost.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(60, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 17)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Select City"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(212, 259)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 17)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Select Conference"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MistyRose
        Me.btnExit.Location = New System.Drawing.Point(539, 446)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClearName
        '
        Me.btnClearName.Location = New System.Drawing.Point(253, 123)
        Me.btnClearName.Name = "btnClearName"
        Me.btnClearName.Size = New System.Drawing.Size(75, 23)
        Me.btnClearName.TabIndex = 27
        Me.btnClearName.Text = "Clear Name"
        Me.btnClearName.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.SeaShell
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(41, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 19)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "QUESTION#1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.SeaShell
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(460, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 19)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "QUESTION#2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.SeaShell
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(403, 204)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 16)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "QUESTION#3"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.SeaShell
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 226)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 19)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "QUESTION#4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(881, 642)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnClearName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ConferenceCost)
        Me.Controls.Add(Me.Conferences)
        Me.Controls.Add(Me.City)
        Me.Controls.Add(Me.btnShowID)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnShowAddress)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.txtEnterAddress)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.radMRS)
        Me.Controls.Add(Me.radMR)
        Me.Controls.Add(Me.btnShowName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtEnterName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEnterName As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnShowName As System.Windows.Forms.Button
    Friend WithEvents radMR As System.Windows.Forms.RadioButton
    Friend WithEvents radMRS As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtEnterAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents btnShowAddress As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnShowID As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents City As System.Windows.Forms.ListBox
    Friend WithEvents Conferences As System.Windows.Forms.ListBox
    Friend WithEvents ConferenceCost As System.Windows.Forms.ListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnCost As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClearName As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label

End Class
