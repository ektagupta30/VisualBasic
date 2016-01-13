Public Class Form1

    Private Sub ProjectBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProjectBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProjectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EmployeeDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeDataSet.Project' table. You can move, or remove it, as needed.
        Me.ProjectTableAdapter.Fill(Me.EmployeeDataSet.Project)

    End Sub

    Private Sub ProjectDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProjectDataGridView.CellContentClick

    End Sub
End Class
