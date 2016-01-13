Public Class Form1
    Dim deptCt As Integer = 4
    Dim numArray(deptCt) As department
    
    Structure department
        Dim deptNo As Integer
        Dim deptName As String
        Dim deptBudget As Double
    End Structure
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        deptCt = 4
        numArray(0).deptNo = 11
        numArray(1).deptNo = 15
        numArray(2).deptNo = 17
        numArray(3).deptNo = 20
        numArray(4).deptNo = 25
        numArray(0).deptName = "Sales"
        numArray(1).deptName = "Production"
        numArray(2).deptName = "Technical"
        numArray(3).deptName = "Medical"
        numArray(4).deptName = "Electric"
        numArray(0).deptBudget = 5000
        numArray(1).deptBudget = 6000
        numArray(2).deptBudget = 2000
        numArray(3).deptBudget = 1500
        numArray(4).deptBudget = 3500


    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim id As String
        Dim dept As Integer = 0
        Dim found As String = "NO"
        id = txtID.Text

        Do While dept < numArray.Length And found = "NO"
            If id = numArray(dept).deptNo Then
                found = "YES"
            Else
                dept = dept + 1
            End If
        Loop
        If found = "YES" Then
            txtResult.Text = numArray(dept).deptNo & "  " & numArray(dept).deptName & "  " & numArray(dept).deptBudget

        Else
            txtResult.Text = "Did not find match"
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtID.Clear()
        txtResult.Clear()
        showDept.Items.Clear()
        addDept.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddDept_Click(sender As Object, e As EventArgs) Handles btnAddDept.Click
        Dim inputNum As Integer
        Dim inputName As String
        Dim inputBudget As Integer

        ReDim Preserve numArray(deptCt + 1)
        
        inputNum = InputBox("Enter the dept number", "Dept Number")
        inputName = InputBox("Enter the dept name", "Dept Name")
        inputBudget = InputBox("Enter the budget", "Budget Amount")
        numArray(deptCt + 1).deptNo = inputNum
        numArray(deptCt + 1).deptName = inputName
        numArray(deptCt + 1).deptBudget = inputBudget
        For ct As Integer = deptCt To 0 Step -1
            If inputNum >= numArray(ct).deptNo Then
                Exit For
            Else
                numArray(ct + 1).deptNo = numArray(ct).deptNo
                numArray(ct).deptNo = inputNum
                numArray(ct + 1).deptName = numArray(ct).deptName
                numArray(ct).deptName = inputName
                numArray(ct + 1).deptBudget = numArray(ct).deptBudget
                numArray(ct).deptBudget = inputBudget
            End If
        Next
        deptCt = deptCt + 1
        addDept.Items.Clear()
        For ct = 0 To deptCt
            addDept.Items.Add(numArray(ct).deptNo & "  " & numArray(ct).deptName & "  " & numArray(ct).deptBudget)
        Next
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim info As String
        For ct = 0 To deptCt
            info = numArray(ct).deptNo & "  " & numArray(ct).deptName & "  " & numArray(ct).deptBudget
            showDept.Items.Add(info)
        Next
    End Sub
End Class
