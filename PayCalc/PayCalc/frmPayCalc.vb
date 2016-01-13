Public Class frmPayCalc

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        txtGrossPay.Text = txtPayHr.Text * txtHrsWk.Text
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtGrossPay.Clear()
        txtHrsWk.Clear()
        txtPayHr.Clear()
        txtName.Clear()

    End Sub

    Private Sub cmdCalcMore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalcMore.Click
        Dim wkPayHr As Double, wkHrsWk As Double
        Dim wkGrossPay As Double
        wkHrsWk = CDbl(txtHrsWk.Text)
        wkPayHr = CDbl(txtPayHr.Text)
        wkGrossPay = wkHrsWk + wkPayHr
        txtGrossPay.Text = wkGrossPay.ToString("C")
    End Sub

    Private Sub txtHrsWk_TextChanged(sender As Object, e As EventArgs) Handles txtHrsWk.TextChanged

    End Sub

    Private Sub frmPayCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
