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
        Dim Proj_noLabel As System.Windows.Forms.Label
        Dim Proj_nameLabel As System.Windows.Forms.Label
        Dim Proj_ManagerLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.EmployeeDataSet = New Week13Wizard.EmployeeDataSet()
        Me.ProjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectTableAdapter = New Week13Wizard.EmployeeDataSetTableAdapters.ProjectTableAdapter()
        Me.TableAdapterManager = New Week13Wizard.EmployeeDataSetTableAdapters.TableAdapterManager()
        Me.ProjectBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProjectBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProjectDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proj_noTextBox = New System.Windows.Forms.TextBox()
        Me.Proj_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Proj_ManagerTextBox = New System.Windows.Forms.TextBox()
        Proj_noLabel = New System.Windows.Forms.Label()
        Proj_nameLabel = New System.Windows.Forms.Label()
        Proj_ManagerLabel = New System.Windows.Forms.Label()
        CType(Me.EmployeeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProjectBindingNavigator.SuspendLayout()
        CType(Me.ProjectDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Proj_noLabel
        '
        Proj_noLabel.AutoSize = True
        Proj_noLabel.Location = New System.Drawing.Point(208, 75)
        Proj_noLabel.Name = "Proj_noLabel"
        Proj_noLabel.Size = New System.Drawing.Size(43, 13)
        Proj_noLabel.TabIndex = 2
        Proj_noLabel.Text = "Proj no:"
        '
        'Proj_nameLabel
        '
        Proj_nameLabel.AutoSize = True
        Proj_nameLabel.Location = New System.Drawing.Point(208, 101)
        Proj_nameLabel.Name = "Proj_nameLabel"
        Proj_nameLabel.Size = New System.Drawing.Size(57, 13)
        Proj_nameLabel.TabIndex = 4
        Proj_nameLabel.Text = "Proj name:"
        '
        'Proj_ManagerLabel
        '
        Proj_ManagerLabel.AutoSize = True
        Proj_ManagerLabel.Location = New System.Drawing.Point(208, 127)
        Proj_ManagerLabel.Name = "Proj_ManagerLabel"
        Proj_ManagerLabel.Size = New System.Drawing.Size(73, 13)
        Proj_ManagerLabel.TabIndex = 6
        Proj_ManagerLabel.Text = "Proj Manager:"
        '
        'EmployeeDataSet
        '
        Me.EmployeeDataSet.DataSetName = "EmployeeDataSet"
        Me.EmployeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProjectBindingSource
        '
        Me.ProjectBindingSource.DataMember = "Project"
        Me.ProjectBindingSource.DataSource = Me.EmployeeDataSet
        '
        'ProjectTableAdapter
        '
        Me.ProjectTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProjectTableAdapter = Me.ProjectTableAdapter
        Me.TableAdapterManager.UpdateOrder = Week13Wizard.EmployeeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProjectBindingNavigator
        '
        Me.ProjectBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProjectBindingNavigator.BindingSource = Me.ProjectBindingSource
        Me.ProjectBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProjectBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProjectBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProjectBindingNavigatorSaveItem})
        Me.ProjectBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProjectBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProjectBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProjectBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProjectBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProjectBindingNavigator.Name = "ProjectBindingNavigator"
        Me.ProjectBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProjectBindingNavigator.Size = New System.Drawing.Size(484, 25)
        Me.ProjectBindingNavigator.TabIndex = 0
        Me.ProjectBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ProjectBindingNavigatorSaveItem
        '
        Me.ProjectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProjectBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProjectBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProjectBindingNavigatorSaveItem.Name = "ProjectBindingNavigatorSaveItem"
        Me.ProjectBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProjectBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProjectDataGridView
        '
        Me.ProjectDataGridView.AutoGenerateColumns = False
        Me.ProjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProjectDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.ProjectDataGridView.DataSource = Me.ProjectBindingSource
        Me.ProjectDataGridView.Location = New System.Drawing.Point(76, 225)
        Me.ProjectDataGridView.Name = "ProjectDataGridView"
        Me.ProjectDataGridView.Size = New System.Drawing.Size(345, 220)
        Me.ProjectDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Proj_no"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Proj_no"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Proj_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Proj_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Proj_Manager"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Proj_Manager"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Proj_noTextBox
        '
        Me.Proj_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProjectBindingSource, "Proj_no", True))
        Me.Proj_noTextBox.Location = New System.Drawing.Point(287, 72)
        Me.Proj_noTextBox.Name = "Proj_noTextBox"
        Me.Proj_noTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Proj_noTextBox.TabIndex = 3
        '
        'Proj_nameTextBox
        '
        Me.Proj_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProjectBindingSource, "Proj_name", True))
        Me.Proj_nameTextBox.Location = New System.Drawing.Point(287, 98)
        Me.Proj_nameTextBox.Name = "Proj_nameTextBox"
        Me.Proj_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Proj_nameTextBox.TabIndex = 5
        '
        'Proj_ManagerTextBox
        '
        Me.Proj_ManagerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProjectBindingSource, "Proj_Manager", True))
        Me.Proj_ManagerTextBox.Location = New System.Drawing.Point(287, 124)
        Me.Proj_ManagerTextBox.Name = "Proj_ManagerTextBox"
        Me.Proj_ManagerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Proj_ManagerTextBox.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 465)
        Me.Controls.Add(Proj_noLabel)
        Me.Controls.Add(Me.Proj_noTextBox)
        Me.Controls.Add(Proj_nameLabel)
        Me.Controls.Add(Me.Proj_nameTextBox)
        Me.Controls.Add(Proj_ManagerLabel)
        Me.Controls.Add(Me.Proj_ManagerTextBox)
        Me.Controls.Add(Me.ProjectDataGridView)
        Me.Controls.Add(Me.ProjectBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.EmployeeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProjectBindingNavigator.ResumeLayout(False)
        Me.ProjectBindingNavigator.PerformLayout()
        CType(Me.ProjectDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmployeeDataSet As Week13Wizard.EmployeeDataSet
    Friend WithEvents ProjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProjectTableAdapter As Week13Wizard.EmployeeDataSetTableAdapters.ProjectTableAdapter
    Friend WithEvents TableAdapterManager As Week13Wizard.EmployeeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProjectBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProjectBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProjectDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proj_noTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Proj_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Proj_ManagerTextBox As System.Windows.Forms.TextBox

End Class
