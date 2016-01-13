Public Class introExceptionForm

    Private Sub btnConvertOnly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvertOnly.Click
        Dim dblPrice As Double
        dblPrice = CInt(txtToConvert.Text)
        txtResult.Text = dblPrice.ToString("c")
    End Sub

    Private Sub btnTryCatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTryCatch.Click
        Dim dblPrice As Double
        Try
            dblPrice = CInt(txtToConvert.Text)
            txtResult.Text = dblPrice.ToString("c")
        Catch ex As Exception
            'txtResult.Text = "Data Problem"
            MessageBox.Show("Data problem")
        End Try
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim dblDivideAns As Double
        Try
            intNum1 = CInt(txtNum1.Text)
            intNum2 = CInt(txtNum2.Text)
            dblDivideAns = intNum1 / intNum2
            txtAns.Text = dblDivideAns.ToString("C")
        Catch ex As InvalidCastException
            txtAns.Text = "Data not numeric"
        Catch ex As DivideByZeroException
            txtAns.Text = "Another error"
            'note that it actually gives Infinity as error
        End Try
    End Sub

    Private Sub introExceptionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
