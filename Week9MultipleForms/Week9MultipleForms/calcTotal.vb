Module calcTotal
    Public price As Double
    Public quantity As Integer
    Public total As Double
    Sub calculateBefore()
        total = price * quantity
    End Sub
    Sub calculateDiscount()
        If quantity >= 10 And quantity < 20 Then
            total = price * quantity
            total = total - (total * 0.05)
        ElseIf quantity >= 20 And quantity < 50 Then
            total = price * quantity
            total = total - (total * 0.07)
        ElseIf quantity >= 50 Then
            total = price * quantity
            total = total - (total * 0.2)
        Else
            total = price * quantity
        End If
    End Sub
End Module
