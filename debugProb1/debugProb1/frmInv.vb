Public Class frmInv


    Private Sub btnCakc_Click(sender As System.Object, e As System.EventArgs) Handles btnCalc.Click
        Dim onHand, onOrder, total As Integer
        onHand = txtOnHand.Text
        onOrder = txtOnOrder.Text
        total = onHand + onOrder
        txtTotal.Text = total
        MessageBox.Show(" Total Inventory:  " & txtTotal.Text)
    End Sub

    Private Sub info_TextChanged(sender As Object, e As EventArgs) Handles info.TextChanged

    End Sub

    Private Sub Textbox1_TextChanged(sender As Object, e As EventArgs) Handles txtOnOrder.TextChanged

    End Sub

    Private Sub txtOnHand_TextChanged(sender As Object, e As EventArgs) Handles txtOnHand.TextChanged

    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOnOrder.Clear()
        txtOnHand.Clear()
        txtTotal.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
