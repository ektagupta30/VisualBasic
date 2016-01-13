Public Class Form1
    Dim itemCt As Integer = 7
    Dim itemArray(itemCt) As item
    Dim netTotal As Double = 0

    Structure item
        Dim itemNo As Integer
        Dim itemName As String
        Dim itemPrice As Double
    End Structure
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        itemCt = 4
        itemArray(0).itemNo = 101
        itemArray(1).itemNo = 102
        itemArray(2).itemNo = 103
        itemArray(3).itemNo = 104
        itemArray(4).itemNo = 105
        itemArray(5).itemNo = 106
        itemArray(6).itemNo = 107
        itemArray(7).itemNo = 108
        itemArray(0).itemName = "Books"
        itemArray(1).itemName = "pencils"
        itemArray(2).itemName = "pens"
        itemArray(3).itemName = "glue"
        itemArray(4).itemName = "binders"
        itemArray(5).itemName = "notebooks"
        itemArray(6).itemName = "markers"
        itemArray(7).itemName = "crayons"      
        itemArray(0).itemPrice = 50
        itemArray(1).itemPrice = 6.0
        itemArray(2).itemPrice = 2.0
        itemArray(3).itemPrice = 1.5
        itemArray(4).itemPrice = 7.5
        itemArray(5).itemPrice = 8
        itemArray(6).itemPrice = 5
        itemArray(7).itemPrice = 2
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim total As Double
        Dim quantity As Integer
        Dim itemno As Integer = 0
        Dim itemname As String = ""

        'Dim item As integer
        itemno = lstItemNo.SelectedItem
        itemname = lstItemName.SelectedItem
        quantity = txtQuantity.Text
        For i = 0 To itemArray.Length - 1
            If (itemno = itemArray(i).itemNo) Then
                total = itemArray(i).itemPrice * quantity
                lstSelected.Items.Add(itemno & "           " & itemArray(i).itemName & "           " & itemArray(i).itemPrice & "            " & quantity & "          " & total)

            ElseIf (itemname = itemArray(i).itemName) Then
                total = itemArray(i).itemPrice * quantity
                lstSelected.Items.Add(itemArray(i).itemNo & "         " & itemArray(i).itemName & "             " & itemArray(i).itemPrice & "         " & quantity & "            " & total)

            End If

            lstItemNo.ClearSelected()
            lstItemName.ClearSelected()
        Next
        netTotal = total + netTotal
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim afterTax As Double = netTotal + netTotal * 0.06

        lstSelected.Items.Add("Total:  " & netTotal)
        lstSelected.Items.Add("Total after tax:  " & afterTax)

    End Sub
End Class
