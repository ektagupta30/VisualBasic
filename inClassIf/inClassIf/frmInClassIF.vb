Public Class frmInClassIF
    Dim field1, field2, field3 As Double
    

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        
        If txtCode.Text = "A" Then
            If txtField1.Text = String.Empty Then
                txtResult.Text = "No data in field1"
            ElseIf txtField1.Text > 5000 Then
                txtResult.Text = "OK"
            Else
                txtResult.Text = "Problem"
            End If
        ElseIf txtCode.Text = "B" Then
            If txtField2.Text = String.Empty Then
                txtResult.Text = "No data in field2"
            ElseIf txtField2.Text > 2500 Then
                txtResult.Text = "OK"
            Else
                txtResult.Text = "Problem"
            End If
        Else
            txtResult.Text = "Enter A or B in code"
        End If


        'Write the code to check code for A and field1 > 5000 OR
        'check the code for B and field2 > 2500
        'Respond with OK or Problem
        'Do it once with separate if statements and then in btnSecond
        'do it using one if statement
    End Sub

    Private Sub btnSecond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSecond.Click
        'If ((txtCode.Text = "A" And txtField1.Text > 5000) Or (txtCode.Text = "B" And txtField2.Text > 2500)) Then
        If ((txtCode.Text = "A" And txtField1.Text > 5000) Or (txtCode.Text = "B" And txtField2.Text > 2500)) Then
            txtResult.Text = "OK"
        Else
            txtResult.Text = "Problem"
        End If

    End Sub

    Private Sub btnThird_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThird.Click
        If txtCode.Text = "A" Then
            If (txtField1.Text > 5) Then
                txtResult.Text = "Conditions matched"
            ElseIf (txtField2.Text > 8) Then
                txtResult.Text = "Conditions matched"
            ElseIf (txtField3.Text > 12) Then
                txtResult.Text = "Conditions matched"
            Else
                txtResult.Text = "Conditions not matched"
            End If
        Else
            txtResult.Text = "Problem"
        End If

        'Write the code to check for code = A and either field1 greater 
        'than 5 or field2 greater than 8 or field3 greater than 12
        'Write it with separate if statements and then in btnFourth
        'do it one if statement
        'Write appropriate message
    End Sub

    Private Sub btnFourth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFourth.Click

        If (txtCode.Text = "A" And (txtField1.Text > 5 Or txtField2.Text > 8 Or txtField3.Text > 12)) Then
            txtResult.Text = "Conditions matched"
        Else
            txtResult.Text = "Problem"
        End If





    End Sub

    Private Sub btnFifth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFifth.Click
        If txtCode.Text = "A" Then
            MessageBox.Show("Code is A")
            If txtField3.Text > 40 Then
                MessageBox.Show("Code is A and field3 > 40")
                If (txtField1.Text > 10) Then
                    MessageBox.Show("Code is A , field3 is >40 and field1>10 ")
                ElseIf (txtField2.Text > 20) Then
                    MessageBox.Show("Code is A and field2 is >20")
                Else : MessageBox.Show("Code is A , field3 is >40 but field1<10 and field <20")
                End If
            Else : MessageBox.Show("Code is A but field3 < 40")
            End If
        Else : MessageBox.Show("Code is not A")
        End If

        'Write the code to test for code = A and either field1 > 10 or
        'field2 > 20 and field3 > 40
        'Write different message for each of the options meeting the
        'criteria and different messages for each of the options not
        'meeting the criteria
    End Sub

    Private Sub btnSixth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSixth.Click
        If (txtCode.Text = "A" And (txtField1.Text > 100 Or txtField2.Text > 200)) Then
            MessageBox.Show("Code is A , field1 is >100 or field2 >200 ")
        ElseIf (txtCode.Text = "B" And (txtField1.Text > 100 Or txtField2.Text > 100)) Then
            MessageBox.Show("Code is B , field1 is >100 or field2 >100 ")
        ElseIf (txtCode.Text = "C" And txtField3.Text > 50) Then
            MessageBox.Show("Code is C and field3 >50 ")
        Else
            MessageBox.Show("None of the contitions matched ")
        End If
        'Write the code for code A and eiher field1 > 100 or field2 > 200 or
        'code B and either field1 or field2 greater than 100 or
        'code C and field3 < 50
    End Sub


    Private Sub btnSeventh_Click(sender As System.Object, e As System.EventArgs) Handles btnSeventh.Click
        Select Case txtCode.Text
            Case "A"
                MessageBox.Show("Code is A")
            Case "B"
                MessageBox.Show("Code is B")
            Case "C"
                MessageBox.Show("Code is C")
            Case "D"
                MessageBox.Show("Code is D")
            Case Else
                MessageBox.Show("Invalid Code")
        End Select


        'Use the case structure to test the code for A, B, C or D.
    End Sub



    Private Sub txtResult_TextChanged(sender As Object, e As EventArgs) Handles txtResult.TextChanged

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtCode.Clear()
        txtResult.Clear()
        txtField1.Clear()
        txtField2.Clear()
        txtField3.Clear()
        


    End Sub

    Private Sub frmInClassIF_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
