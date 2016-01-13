Public Class Form1
    Dim arrayStudent(4) As String
    Dim arrayExam(3) As String
    Dim arrayGrades(4, 3) As Double

    Dim n As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        arrayStudent(0) = "Student1"
        arrayStudent(1) = "Student2"
        arrayStudent(2) = "Student3"
        arrayStudent(3) = "Student4"
        arrayStudent(4) = "Student5"
        arrayExam(0) = "CIS156"
        arrayExam(1) = "CIS159"
        arrayExam(2) = "JAVA"
        arrayExam(3) = "CIS150"

        n = 0
        txtNextStudent.Text = ("Enter grades for " & arrayStudent(n))
    End Sub

    'calculating each student average
    Function displayStudentAvg(ByVal arrayGrades(,) As Double)
        Dim i As Integer
        Dim avg(4) As Double
        For i = 0 To 4
            avg(i) = (arrayGrades(i, 0) + arrayGrades(i, 1) + arrayGrades(i, 2) + arrayGrades(i, 3)) / 4
        Next
        Return avg
    End Function
    ' getting student average
    Private Sub stripStudentAvg_Click(sender As Object, e As EventArgs) Handles stripStudentAvg.Click
        Dim student As New frmCalculateAvg
        Dim avgStudent() As Double
        Dim i As Integer
        student.lstStudentAverage.Items.Clear()
        avgStudent = displayStudentAvg(arrayGrades)
        For i = 0 To 4
            student.lstStudentAverage.Items.Add("Average score for " & arrayStudent(i) & " is " & avgStudent(i))
        Next
        student.Show()
    End Sub

    'calculating each exam average
    Function displayExamAvg(ByVal arrayGrades(,) As Double)
        Dim i As Integer
        Dim avg(4) As Double
        For i = 0 To 3
            avg(i) = (arrayGrades(0, i) + arrayGrades(1, i) + arrayGrades(2, i) + arrayGrades(3, i) + arrayGrades(4, i)) / 5
        Next
        Return avg
    End Function
    

    'populating grades array
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If IsNumeric(txtCIS156.Text) Then
            arrayGrades(n, 0) = txtCIS156.Text
        Else
            lGrade = txtCIS156.Text
            calcNumGrade()
            arrayGrades(n, 0) = nGrade
        End If
        If IsNumeric(txtCIS159.Text) Then
            arrayGrades(n, 1) = txtCIS159.Text
        Else
            lGrade = txtCIS159.Text
            calcNumGrade()
            arrayGrades(n, 1) = nGrade
        End If
        If IsNumeric(txtJava.Text) Then
            arrayGrades(n, 2) = txtJava.Text
        Else
            lGrade = txtJava.Text
            calcNumGrade()
            arrayGrades(n, 2) = nGrade
        End If
        If IsNumeric(txtCIS150.Text) Then
            arrayGrades(n, 3) = txtCIS150.Text
        Else
            lGrade = txtCIS150.Text
            calcNumGrade()
            arrayGrades(n, 3) = nGrade
        End If
        n = n + 1
        If n = 5 Then
            txtNextStudent.Text = ("Enter grades for " & arrayStudent(n - 1))
            MessageBox.Show("All grades entered" & vbCrLf & "Please select from menu to calculate grades")
            txtNextStudent.Clear()
            txtCIS156.Clear()
            txtCIS159.Clear()
            txtJava.Clear()
            txtCIS150.Clear()

        Else
            txtNextStudent.Text = ("Enter grades for " & arrayStudent(n))
        End If
        txtCIS156.Clear()
        txtCIS159.Clear()
        txtJava.Clear()
        txtCIS150.Clear()


    End Sub
    'getting each exam average
    Private Sub EachSubject_Click(sender As Object, e As EventArgs) Handles EachSubject.Click
        Dim student As New frmCalculateAvg
        Dim avgGrades() As Double
        Dim i As Integer
        student.lstStudentAverage.Items.Clear()
        avgGrades = displayExamAvg(arrayGrades)
        For i = 0 To 3
            student.lstStudentAverage.Items.Add("Average for exam " & arrayExam(i) & " is " & avgGrades(i))
        Next
        student.Show()
    End Sub
    'calculating each exam average
    Function displayWholeClassAvg(ByVal arrayGrades(,) As Double)
        Dim i As Integer
        Dim total(3) As Double
        Dim avg As Double = 0
        For i = 0 To 3
            total(i) = (arrayGrades(0, i) + arrayGrades(1, i) + arrayGrades(2, i) + arrayGrades(3, i) + arrayGrades(4, i))
        Next
        For i = 0 To 3
            avg = total(i) + avg
        Next
        avg = avg / 20
        Return avg
    End Function
    Private Sub WholeClass_Click(sender As Object, e As EventArgs) Handles WholeClass.Click
        Dim student As New frmCalculateAvg
        Dim avg As Double

        student.lstStudentAverage.Items.Clear()
        avg = displayWholeClassAvg(arrayGrades)
        student.lstStudentAverage.Items.Add("Average for whole class " & " is " & avg)
        student.Show()
    End Sub

   

    Private Sub ClearToolStrip_Click(sender As Object, e As EventArgs) Handles ClearToolStrip.Click
        txtCIS156.Clear()
        txtCIS159.Clear()
        txtJava.Clear()
        txtCIS150.Clear()
    End Sub

    Private Sub ExitToolStrip_Click(sender As Object, e As EventArgs) Handles ExitToolStrip.Click
        Me.Close()
    End Sub
End Class
