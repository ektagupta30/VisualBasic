Public Class frmChk

    Private Sub frmChk_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblMsg.Text = "These are 5 numbers to add " + vbCrLf + "and average, you should " + vbCrLf + "tab to each in order."

    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnGetAverage.Click
        Dim num1, num2, num3, num4, num5, average As Double
        num1 = txtNum1.Text
        num2 = txtNum2.Text
        num3 = txtNum3.Text
        num4 = txtNum4.Text
        num5 = txtNum5.Text
        average = (num1 + num2 + num3 + num4 + num5) / 5
        txtAverage.Text = average

    End Sub

    Private Sub lblMsg_Click(sender As Object, e As EventArgs) Handles lblMsg.Click

    End Sub

    Private Sub txtNum4_TextChanged(sender As Object, e As EventArgs) Handles txtNum4.TextChanged

    End Sub

    Private Sub txtNum2_TextChanged(sender As Object, e As EventArgs) Handles txtNum2.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
