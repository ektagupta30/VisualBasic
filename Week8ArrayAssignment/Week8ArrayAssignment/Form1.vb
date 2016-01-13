Public Class frmArray
    Dim arrayId(5) As String
    Dim arrayName(5) As String
    Dim id As String
    Private Sub frmArray_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.Text = Today().ToString("d")
        arrayId(0) = "012343"
        arrayId(1) = "023450"
        arrayId(2) = "034568"
        arrayId(3) = "045675"
        arrayId(4) = "123455"
        arrayId(5) = "123501"
        arrayName(0) = "Walt/Sarah M"
        arrayName(1) = "Mudd/Smith G"
        arrayName(2) = "Garg/Veena"
        arrayName(3) = "Alison/Diane K"
        arrayName(4) = "James/Janet M"
        arrayName(5) = "Joshi/Indu V"
    End Sub
    
    Private Sub mod11()
        Dim intId As Integer
        Try
            intId = CInt(id)
            Dim splitID(id.Length - 1) As String
            Dim i As Integer
            Dim count As Integer
            count = id.Length
            Dim checkDigit As Integer
            checkDigit = 0
            Dim x As Integer
            x = 0
            For i = 0 To id.Length - 1
                splitID(i) = id.Substring(i, 1)
                splitID(i) = splitID(i) * count  'multiplying numbers 
                count = count - 1
            Next
            For i = 0 To splitID.Length - 1
                x = x + splitID(i) 'x is total of numbers
            Next
            checkDigit = x Mod 11

            If Not checkDigit = 0 Then
                MessageBox.Show("Not a valid ID  " + vbCrLf + id, "Student ID")
            End If
        Catch
            MessageBox.Show("Invalid ID")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        radID.Checked = False
        radName.Checked = False
        txtResult.Clear()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If radID.Checked = True Then

            Dim name As String
            Dim position As Integer

            id = InputBox("Enter ID", "Student ID")

            Dim idFound As String = "N"
            Dim wkSub As Integer = 0
            Do While idFound = "N" And wkSub < arrayId.Length
                If id = arrayId(wkSub) Then
                    idFound = "Y"
                Else
                    wkSub = wkSub + 1
                End If
            Loop

            If idFound = "Y" Then
                MessageBox.Show("Student is enrolled for this course", "CIS156")
                name = arrayName(wkSub)
                position = name.IndexOf("/")
                name = name.Substring(position + 1) + " " + name.Substring(0, position)
                txtResult.Text = "ID: " + arrayId(wkSub) + "   " + "Name:  " + name
                txtResult.Visible = True
                mod11()
            Else
                MessageBox.Show("Student is not enrolled for this course", "CIS156")
                mod11()
            End If
        ElseIf radName.Checked = True Then
            Dim name As String
            ' Dim id As String
            Dim position As Integer
            name = InputBox("Enter Name", "Student name")
            Dim idFound As String = "N"
            Dim wkSub As Integer = 0
            Do While idFound = "N" And wkSub < arrayId.Length
                If name = arrayName(wkSub) Then
                    idFound = "Y"
                Else
                    wkSub = wkSub + 1
                End If
            Loop
            If idFound = "Y" Then
                MessageBox.Show("Student is enrolled for this course", "CIS156")

                position = name.IndexOf("/")
                name = name.Substring(position + 1) + " " + name.Substring(0, position)
                txtResult.Text = "ID: " + arrayId(wkSub) + "   " + "Name:  " + name
                txtResult.Visible = True

            Else
                MessageBox.Show("Student is not enrolled for this course", "CIS156")
            End If
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class
