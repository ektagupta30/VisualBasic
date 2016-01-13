Public Class MainForm

    
    
    Private Sub beforeDiscount_Click(sender As Object, e As EventArgs) Handles beforeDiscount.Click
        Dim showTotal As New frmShowTotal
        Try
            price = CDbl(txtPrice.Text)
            quantity = CInt(txtQuantity.Text)
            calculateBefore()
            showTotal.txtItem.Text = txtItem.Text
            showTotal.txtBeforeDiscount.Text = total
            showTotal.lblBeforeDiscount.Visible = True
            showTotal.txtBeforeDiscount.Visible = True
            showTotal.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Please enter the numeric value", "Error")
        End Try
    End Sub

    Private Sub afterDiscount_Click(sender As Object, e As EventArgs) Handles afterDiscount.Click
        Dim showTotal As New frmShowTotal
        Try
            price = CDbl(txtPrice.Text)
            quantity = CInt(txtQuantity.Text)
            calculateDiscount()
            showTotal.txtItem.Text = txtItem.Text
            showTotal.txtAfterDiscount.Text = total
            showTotal.lblAfterDiscount.Visible = True
            showTotal.txtAfterDiscount.Visible = True
            showTotal.Show()
        Catch ex As Exception
            MessageBox.Show("Please enter the numeric value", "Error")
        End Try
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        txtItem.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
