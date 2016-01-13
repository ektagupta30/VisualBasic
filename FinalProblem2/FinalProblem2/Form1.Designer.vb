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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ItemnoLabel As System.Windows.Forms.Label
        Dim ItemnameLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim OnhandLabel As System.Windows.Forms.Label
        Dim OnorderLabel As System.Windows.Forms.Label
        Dim ReorderpointLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim CostLabel As System.Windows.Forms.Label
        Me.InventoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.InventoryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtItemno = New System.Windows.Forms.TextBox()
        Me.ItemnameTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.OnhandTextBox = New System.Windows.Forms.TextBox()
        Me.OnorderTextBox = New System.Windows.Forms.TextBox()
        Me.ReorderpointTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryTransactionDataSet = New FinalProblem2.InventoryTransactionDataSet()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryTableAdapter = New FinalProblem2.InventoryTransactionDataSetTableAdapters.InventoryTableAdapter()
        Me.TableAdapterManager = New FinalProblem2.InventoryTransactionDataSetTableAdapters.TableAdapterManager()
        Me.TransactionTableAdapter = New FinalProblem2.InventoryTransactionDataSetTableAdapters.TransactionTableAdapter()
        Me.btnMatch = New System.Windows.Forms.Button()
        ItemnoLabel = New System.Windows.Forms.Label()
        ItemnameLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        OnhandLabel = New System.Windows.Forms.Label()
        OnorderLabel = New System.Windows.Forms.Label()
        ReorderpointLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        CostLabel = New System.Windows.Forms.Label()
        CType(Me.InventoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InventoryBindingNavigator.SuspendLayout()
        CType(Me.TransactionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryTransactionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InventoryBindingNavigator
        '
        Me.InventoryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InventoryBindingNavigator.BindingSource = Me.InventoryBindingSource
        Me.InventoryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InventoryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InventoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.InventoryBindingNavigatorSaveItem})
        Me.InventoryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.InventoryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InventoryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InventoryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InventoryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InventoryBindingNavigator.Name = "InventoryBindingNavigator"
        Me.InventoryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InventoryBindingNavigator.Size = New System.Drawing.Size(1330, 25)
        Me.InventoryBindingNavigator.TabIndex = 0
        Me.InventoryBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'InventoryBindingNavigatorSaveItem
        '
        Me.InventoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InventoryBindingNavigatorSaveItem.Image = CType(resources.GetObject("InventoryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InventoryBindingNavigatorSaveItem.Name = "InventoryBindingNavigatorSaveItem"
        Me.InventoryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.InventoryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ItemnoLabel
        '
        ItemnoLabel.AutoSize = True
        ItemnoLabel.Location = New System.Drawing.Point(76, 44)
        ItemnoLabel.Name = "ItemnoLabel"
        ItemnoLabel.Size = New System.Drawing.Size(41, 13)
        ItemnoLabel.TabIndex = 1
        ItemnoLabel.Text = "itemno:"
        '
        'txtItemno
        '
        Me.txtItemno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "itemno", True))
        Me.txtItemno.Location = New System.Drawing.Point(148, 41)
        Me.txtItemno.Name = "txtItemno"
        Me.txtItemno.Size = New System.Drawing.Size(100, 20)
        Me.txtItemno.TabIndex = 2
        '
        'ItemnameLabel
        '
        ItemnameLabel.AutoSize = True
        ItemnameLabel.Location = New System.Drawing.Point(76, 70)
        ItemnameLabel.Name = "ItemnameLabel"
        ItemnameLabel.Size = New System.Drawing.Size(56, 13)
        ItemnameLabel.TabIndex = 3
        ItemnameLabel.Text = "Itemname:"
        '
        'ItemnameTextBox
        '
        Me.ItemnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "Itemname", True))
        Me.ItemnameTextBox.Location = New System.Drawing.Point(148, 67)
        Me.ItemnameTextBox.Name = "ItemnameTextBox"
        Me.ItemnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ItemnameTextBox.TabIndex = 4
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(76, 96)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(51, 13)
        CategoryLabel.TabIndex = 5
        CategoryLabel.Text = "category:"
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "category", True))
        Me.CategoryTextBox.Location = New System.Drawing.Point(148, 93)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CategoryTextBox.TabIndex = 6
        '
        'OnhandLabel
        '
        OnhandLabel.AutoSize = True
        OnhandLabel.Location = New System.Drawing.Point(76, 122)
        OnhandLabel.Name = "OnhandLabel"
        OnhandLabel.Size = New System.Drawing.Size(46, 13)
        OnhandLabel.TabIndex = 7
        OnhandLabel.Text = "onhand:"
        '
        'OnhandTextBox
        '
        Me.OnhandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "onhand", True))
        Me.OnhandTextBox.Location = New System.Drawing.Point(148, 119)
        Me.OnhandTextBox.Name = "OnhandTextBox"
        Me.OnhandTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OnhandTextBox.TabIndex = 8
        '
        'OnorderLabel
        '
        OnorderLabel.AutoSize = True
        OnorderLabel.Location = New System.Drawing.Point(76, 148)
        OnorderLabel.Name = "OnorderLabel"
        OnorderLabel.Size = New System.Drawing.Size(46, 13)
        OnorderLabel.TabIndex = 9
        OnorderLabel.Text = "onorder:"
        '
        'OnorderTextBox
        '
        Me.OnorderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "onorder", True))
        Me.OnorderTextBox.Location = New System.Drawing.Point(148, 145)
        Me.OnorderTextBox.Name = "OnorderTextBox"
        Me.OnorderTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OnorderTextBox.TabIndex = 10
        '
        'ReorderpointLabel
        '
        ReorderpointLabel.AutoSize = True
        ReorderpointLabel.Location = New System.Drawing.Point(76, 174)
        ReorderpointLabel.Name = "ReorderpointLabel"
        ReorderpointLabel.Size = New System.Drawing.Size(66, 13)
        ReorderpointLabel.TabIndex = 11
        ReorderpointLabel.Text = "reorderpoint:"
        '
        'ReorderpointTextBox
        '
        Me.ReorderpointTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "reorderpoint", True))
        Me.ReorderpointTextBox.Location = New System.Drawing.Point(148, 171)
        Me.ReorderpointTextBox.Name = "ReorderpointTextBox"
        Me.ReorderpointTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ReorderpointTextBox.TabIndex = 12
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(76, 200)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(33, 13)
        PriceLabel.TabIndex = 13
        PriceLabel.Text = "price:"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(148, 197)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTextBox.TabIndex = 14
        '
        'CostLabel
        '
        CostLabel.AutoSize = True
        CostLabel.Location = New System.Drawing.Point(76, 226)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(30, 13)
        CostLabel.TabIndex = 15
        CostLabel.Text = "cost:"
        '
        'CostTextBox
        '
        Me.CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "cost", True))
        Me.CostTextBox.Location = New System.Drawing.Point(148, 223)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CostTextBox.TabIndex = 16
        '
        'TransactionDataGridView
        '
        Me.TransactionDataGridView.AutoGenerateColumns = False
        Me.TransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TransactionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TransactionDataGridView.DataSource = Me.TransactionBindingSource
        Me.TransactionDataGridView.Location = New System.Drawing.Point(29, 283)
        Me.TransactionDataGridView.Name = "TransactionDataGridView"
        Me.TransactionDataGridView.Size = New System.Drawing.Size(543, 220)
        Me.TransactionDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "itemno"
        Me.DataGridViewTextBoxColumn1.HeaderText = "itemno"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "code(SorR)"
        Me.DataGridViewTextBoxColumn2.HeaderText = "code(SorR)"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "saleDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "saleDate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Time"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Time"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "number(SorR)"
        Me.DataGridViewTextBoxColumn5.HeaderText = "number(SorR)"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'TransactionBindingSource
        '
        Me.TransactionBindingSource.DataMember = "Transaction"
        Me.TransactionBindingSource.DataSource = Me.InventoryTransactionDataSet
        '
        'InventoryTransactionDataSet
        '
        Me.InventoryTransactionDataSet.DataSetName = "InventoryTransactionDataSet"
        Me.InventoryTransactionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.InventoryTransactionDataSet
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.InventoryTableAdapter = Me.InventoryTableAdapter
        Me.TableAdapterManager.TransactionTableAdapter = Me.TransactionTableAdapter
        Me.TableAdapterManager.UpdateOrder = FinalProblem2.InventoryTransactionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TransactionTableAdapter
        '
        Me.TransactionTableAdapter.ClearBeforeFill = True
        '
        'btnMatch
        '
        Me.btnMatch.Location = New System.Drawing.Point(411, 122)
        Me.btnMatch.Name = "btnMatch"
        Me.btnMatch.Size = New System.Drawing.Size(75, 23)
        Me.btnMatch.TabIndex = 18
        Me.btnMatch.Text = "Match"
        Me.btnMatch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1330, 731)
        Me.Controls.Add(Me.btnMatch)
        Me.Controls.Add(Me.TransactionDataGridView)
        Me.Controls.Add(ItemnoLabel)
        Me.Controls.Add(Me.txtItemno)
        Me.Controls.Add(ItemnameLabel)
        Me.Controls.Add(Me.ItemnameTextBox)
        Me.Controls.Add(CategoryLabel)
        Me.Controls.Add(Me.CategoryTextBox)
        Me.Controls.Add(OnhandLabel)
        Me.Controls.Add(Me.OnhandTextBox)
        Me.Controls.Add(OnorderLabel)
        Me.Controls.Add(Me.OnorderTextBox)
        Me.Controls.Add(ReorderpointLabel)
        Me.Controls.Add(Me.ReorderpointTextBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(CostLabel)
        Me.Controls.Add(Me.CostTextBox)
        Me.Controls.Add(Me.InventoryBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.InventoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InventoryBindingNavigator.ResumeLayout(False)
        Me.InventoryBindingNavigator.PerformLayout()
        CType(Me.TransactionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryTransactionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InventoryTransactionDataSet As FinalProblem2.InventoryTransactionDataSet
    Friend WithEvents InventoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InventoryTableAdapter As FinalProblem2.InventoryTransactionDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents TableAdapterManager As FinalProblem2.InventoryTransactionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InventoryBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents InventoryBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TransactionTableAdapter As FinalProblem2.InventoryTransactionDataSetTableAdapters.TransactionTableAdapter
    Friend WithEvents txtItemno As System.Windows.Forms.TextBox
    Friend WithEvents ItemnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OnhandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OnorderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReorderpointTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TransactionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransactionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnMatch As System.Windows.Forms.Button

End Class
