Public Class Form1

    Private Sub calcByRef_Click(sender As Object, e As EventArgs) Handles calcByRef.Click
        Dim value As Decimal
        Dim tax As Decimal
        Dim payment As Decimal
        value = CType(txtValue.Text, Decimal)
        tax = CType(txtTax.Text, Decimal)
        payment = calcPayRef(value, tax)
        byRefrence.Items.Add("payment due:   " & payment)
        byRefrence.Items.Add("value now:   " & value)
    End Sub
    Function calcPayRef(ByRef intVal As Integer, ByRef intTax As Decimal)
        byRefrence.Items.Add("car value:  " & intVal)
        byRefrence.Items.Add("Tax:  " & intTax)
        intVal = (intVal * intTax) + intVal
        Return intVal
    End Function

    Private Sub btnCalByVal_Click(sender As Object, e As EventArgs) Handles btnCalByVal.Click
        Dim value As Decimal
        Dim tax As Decimal
        Dim payment As Decimal
        value = CType(txtValue.Text, Decimal)
        tax = CType(txtTax.Text, Decimal)
        payment = calcPayVal(value, tax)
        byValue.Items.Add("payment due:   " & payment)
        byValue.Items.Add("value now:   " & value)

    End Sub
    Function calcPayVal(ByVal intVal As Decimal, ByVal intTax As Decimal)
        byValue.Items.Add("car value:  " & intVal)
        byValue.Items.Add("Tax:  " & intTax)
        intVal = (intVal * intTax) + intVal
        Return intVal
    End Function
End Class
