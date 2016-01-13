Public Class Form1

    Dim totalDailyBeforeDiscount, totalDailyAfterDiscount As Double
   

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalDailyBeforeDiscount = 0
        totalDailyAfterDiscount = 0
        Dim todayDate As Date
        todayDate = Today
        lblDate.Text = todayDate
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim price, total, afterDiscount, saving As Double
        Dim quantity, discount As Integer
        discount = 0
        Try
            price = CDbl(txtPrice.Text)
            Try
                quantity = CInt(txtQuantity.Text)

            Catch
                lblError.Text = "Error: Please enter the numeric value for quantity"
            End Try
        Catch
            lblError.Text = "Error: Please enter the numeric value for price"
        End Try

        total = price * quantity
        If quantity > 100 And quantity <= 1000 Then
            afterDiscount = total - (total * 5 / 100)
        ElseIf quantity > 1000 And quantity <= 5000 Then

            afterDiscount = total - (total * 10 / 100)
        ElseIf quantity > 5000 Then

            afterDiscount = total - (total * 15 / 100)
        Else
            total = price * quantity
            afterDiscount = total
        End If



        txtBefDis.Text = total.ToString("c")
        txtAfterDiscount.Text = afterDiscount.ToString("c")
        saving = total - afterDiscount
        If saving > 0 Then
            discount = saving / total * 100
        End If
        totalDailyBeforeDiscount = totalDailyBeforeDiscount + total
        totalDailyAfterDiscount = totalDailyAfterDiscount + afterDiscount

        MessageBox.Show("You saved" + vbCrLf + "$" + saving.ToString + vbCrLf + discount.ToString + "%")

    End Sub

   

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("Total Sales before discount  $" + totalDailyBeforeDiscount.ToString("F") + vbCrLf +
             "Total Sales after discount  $" + totalDailyAfterDiscount.ToString("F"))
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtItem.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        txtAfterDiscount.Clear()
        txtBefDis.Clear()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class
