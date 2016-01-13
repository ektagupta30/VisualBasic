Public Class Form1

    Private Sub InventoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles InventoryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InventoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InventoryTransactionDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventoryTransactionDataSet.Transaction' table. You can move, or remove it, as needed.
        Me.TransactionTableAdapter.Fill(Me.InventoryTransactionDataSet.Transaction)
        'TODO: This line of code loads data into the 'InventoryTransactionDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.InventoryTransactionDataSet.Inventory)

    End Sub

    Private Sub btnMatch_Click(sender As Object, e As EventArgs) Handles btnMatch.Click
        Dim RowFilter As String = "itemno = '" & txtItemno.Text & "'"
        Dim itemTrans As DataView = New DataView(InventoryTransactionDataSet.Tables("Transaction"),
                               RowFilter, "itemno", DataViewRowState.CurrentRows)
        TransactionDataGridView.DataSource = itemTrans
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub
End Class
