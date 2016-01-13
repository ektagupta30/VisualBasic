Public Class frmOtherDecisions

    Private Sub btnGrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrade.Click
        If IsNumeric(txtGrade.Text) Then
            If txtGrade.Text > 12 Then
                txtGradeWord.Text = "College"
            ElseIf txtGrade.Text > 8 Then
                txtGradeWord.Text = "High School"
            ElseIf txtGrade.Text > 6 Then
                txtGradeWord.Text = "Middle School"
            Else
                txtGradeWord.Text = "Elementary School"
            End If
        Else
            If txtGrade.Text.ToLower() = "k" Then
                txtGradeWord.Text = "Kindergarten"
            Else
                txtGradeWord.Text = "Invalid entry"
            End If

        End If
    End Sub

    Private Sub btnGetName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetName.Click
        Dim wkName As String, wkLen As Integer
        If txtName.Text = String.Empty Then
            txtNameUntrimmed.Text = "Nothing entered"
        Else
            wkName = txtName.Text.Trim()
            txtNameTrim.Text = wkName
            txtNameUntrimmed.Text = txtName.Text
            wkLen = wkName.Length
            MessageBox.Show(wkLen)
        End If
        If txtName.Text = "" Then
            txtNameTrim.Text = "Nothing in text box"
        End If
    End Sub

    Private Sub btnGetNum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetNum.Click
        Dim wkHyphen As Integer, wkLocation As String, wkRoom As String
        wkLocation = txtLocation.Text
        wkHyphen = wkLocation.IndexOf("-")
        wkRoom = wkLocation.Substring(wkHyphen + 1)
        txtRoom.Text = wkRoom
    End Sub

    Private Sub btnCase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCase.Click
        Dim wkCaseGrade As Integer
        If IsNumeric(txtGrade.Text) Then
            wkCaseGrade = CInt(txtGrade.Text)
            Select Case wkCaseGrade
                Case Is > 12
                    txtCaseGrade.Text = "College"
                Case Is > 8
                    txtCaseGrade.Text = "High School"
                Case 7, 8
                    txtCaseGrade.Text = "Middle School"
                Case 1 To 6
                    txtCaseGrade.Text = "Elementary School"
                Case Else
                    txtCaseGrade.Text = "Need to Check"
            End Select
        Else
            If txtGrade.Text.ToLower() = "k" Then
                txtCaseGrade.Text = "Kindergarten"
            Else
                txtCaseGrade.Text = "Invalid entry"
            End If
        End If
    End Sub

    Private Sub frmOtherDecisions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
