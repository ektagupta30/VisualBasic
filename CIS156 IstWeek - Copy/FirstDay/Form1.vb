Public Class FirstDay

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

  

    Private Sub btnFah_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtTemp_TextChanged(sender As Object, e As EventArgs) Handles txtTemp.TextChanged

    End Sub

    Private Sub textResult_TextChanged(sender As Object, e As EventArgs) Handles textResult.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        textResult.Clear()
        txtTemp.Clear()

    End Sub

    Private Sub btnCel_Click(sender As Object, e As EventArgs) Handles btnCel.Click
        Dim temp As Double, result As Decimal
        temp = txtTemp.Text
        result = (temp - 32) * 5 / 9
        result = Decimal.Round(result, 2)
        textResult.Text = result.ToString + " C"

    End Sub

    Private Sub btnFah_Click(sender As Object, e As EventArgs) Handles btnFah.Click
        Dim temp As Double, result As Decimal
        temp = txtTemp.Text
        result = temp * 9 / 5 + 32
        result = Decimal.Round(result, 2)
        textResult.Text = result.ToString + " F"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
