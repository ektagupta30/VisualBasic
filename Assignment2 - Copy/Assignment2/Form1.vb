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

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub btnNoDiscount_Click(sender As Object, e As EventArgs) Handles btnNoDiscount.Click
        Dim price, total As Double
        Dim quantity As Integer
        Try
            price = CDbl(txtPrice.Text)
            Try
                quantity = CDbl(txtQuantity.Text)

            Catch
                lblError.Text = "Error: Please enter the numeric value for quantity"
            End Try
        Catch
            lblError.Text = "Error: Please enter the numeric value for price"
        End Try
            
            total = price * quantity
            txtBefDis.Text = total.ToString("c")
            txtAfterDiscount.Text = total.ToString("c")
            totalDailyBeforeDiscount = totalDailyBeforeDiscount + total
            totalDailyAfterDiscount = totalDailyAfterDiscount + total

    End Sub

    Private Sub btnDis5_Click(sender As Object, e As EventArgs) Handles btnDis5.Click
        Dim price, total, afterDiscount, saving As Double
        Dim quantity As Integer
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
        afterDiscount = total - (total * 5 / 100)
        txtBefDis.Text = total.ToString("c")
        txtAfterDiscount.Text = afterDiscount.ToString("c")
        saving = total - afterDiscount
        totalDailyBeforeDiscount = totalDailyBeforeDiscount + total
        totalDailyAfterDiscount = totalDailyAfterDiscount + afterDiscount

        MessageBox.Show("You saved" + vbCrLf + "$" + saving.ToString)

    End Sub

    Private Sub btnDis10_Click(sender As Object, e As EventArgs) Handles btnDis10.Click
        Dim price, total, afterDiscount, saving As Double
        Dim quantity As Integer

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
        afterDiscount = total - (total * 10 / 100)
        txtBefDis.Text = total.ToString("c")
        txtAfterDiscount.Text = afterDiscount.ToString("c")
        saving = total - afterDiscount
        totalDailyBeforeDiscount = totalDailyBeforeDiscount + total
        totalDailyAfterDiscount = totalDailyAfterDiscount + afterDiscount

        MessageBox.Show("You saved" + vbCrLf + "$" + saving.ToString)


    End Sub

    Private Sub btnDis15_Click(sender As Object, e As EventArgs) Handles btnDis15.Click
        Dim price, total, afterDiscount, saving As Double
        Dim quantity As Integer
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
        afterDiscount = total - (total * 15 / 100)
        txtBefDis.Text = total.ToString("c")
        txtAfterDiscount.Text = afterDiscount.ToString("c")
        saving = total - afterDiscount
        totalDailyBeforeDiscount = totalDailyBeforeDiscount + total
        totalDailyAfterDiscount = totalDailyAfterDiscount + afterDiscount

        MessageBox.Show("You saved" + vbCrLf + "$" + saving.ToString)


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
