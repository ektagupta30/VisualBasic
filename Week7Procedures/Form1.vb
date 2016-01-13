Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

  
    Private Sub btnVal_Click(sender As Object, e As EventArgs) Handles btnVal.Click
        Dim value As Decimal
        Dim tax As Decimal
        Dim decPay As Decimal
        value = CType(txtValue.Text, Decimal)

        tax = CType(txtTax.Text, Decimal)
        CalcPayVal(value, tax)
        decPay = (value * tax) + value
        byValue.Items.Add("Now value is  " & value)
        byValue.Items.Add("Payment after tax from click event:  " & decPay)


    End Sub
    Sub CalcPayVal(ByVal intVal As Integer, ByVal intTax As Decimal)
        'Dim decPay As Decimal

        byValue.Items.Add("car value:  " & intVal)
        byValue.Items.Add("Tax:  " & intTax)
        intVal = (intVal * intTax) + intVal
        byValue.Items.Add("payment after tax from calcPayVal: " & intVal)
    End Sub

    Private Sub btnRef_Click(sender As Object, e As EventArgs) Handles btnRef.Click
        Dim value As Decimal
        Dim tax As Decimal
        Dim decPay As Decimal
        value = CType(txtValue.Text, Decimal)

        tax = CType(txtTax.Text, Decimal)
        CalcPay(value, tax)
        decPay = (value * tax) + value
        reference.Items.Add("Now value is  " & value)
        reference.Items.Add("Payment after tax from click event:  " & decPay)

    End Sub
    Sub CalcPay(ByRef intVal As Integer, ByRef intTax As Decimal)


        reference.Items.Add("car value:  " & intVal)
        reference.Items.Add("Tax:  " & intTax)
        intVal = (intVal * intTax) + intVal
        reference.Items.Add("payment after tax from calcPay: " & intVal)
    End Sub

   
End Class
