Module letterGrade
    Public lGrade As String
    Public nGrade As Integer
    Sub calcNumGrade()
        If lGrade = "A" Then
            nGrade = 95
        ElseIf lGrade = "B" Then
            nGrade = 85
        ElseIf lGrade = "C" Then
            nGrade = 75
        ElseIf lGrade = "D" Then
            nGrade = 65
        Else
            nGrade = 40
        End If

    End Sub
End Module
