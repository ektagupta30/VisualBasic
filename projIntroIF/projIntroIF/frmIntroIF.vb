Public Class frmIntroIF

    Private Sub btnCheckCI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckCI.Click
        If txtFirst.Text = "CI" Then
            txtResult.BackColor = Color.AntiqueWhite
            txtResult.ForeColor = Color.Red
            txtResult.Text = "CI Major"
        Else
            txtResult.BackColor = Color.Beige
            txtResult.ForeColor = Color.Brown
            txtResult.Text = "Not a CI Major"
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtResult.Clear()
        txtFirst.Clear()
        txtSecond.Clear()
        txtThird.Clear()
        txtResult.BackColor = Color.White
        txtResult.ForeColor = Color.Black
    End Sub

    Private Sub btnAnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnd.Click
        If txtFirst.Text = "CI" Then
            If txtSecond.Text > 3.5 Then
                txtResult.Text = "Honors"
            End If
        End If
        'If txtFirst.Text = "CI" And txtSecond.Text > 3.6 Then
        '   txtResult.Text = "Honors"
        'End If
    End Sub

    Private Sub btnAndElse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAndElse.Click
        If txtFirst.Text = "CI" Then
            If txtSecond.Text > 3.5 Then
                txtResult.Text = "Honors"
            Else
                txtResult.Text = "Not honors"
            End If
        Else
            txtResult.Text = "Not honors"
        End If
        'If txtFirst.Text = "CI" And txtSecond.Text > 3.6 Then
        '   txtResult.Text = "Honors"
        'Else
        '   txtResult.Text = "Not honors"
        'End If
    End Sub

    Private Sub btnAndDiffElse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAndDiffElse.Click
        If txtFirst.Text = "CI" Then
            If txtSecond.Text > 3.5 Then
                txtResult.Text = "Honors CI"
            Else
                txtResult.Text = "Not honors GPA"
            End If
        Else
            txtResult.Text = "Not CI student"
        End If
    End Sub

    Private Sub btnOr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOr.Click
        If txtFirst.Text = "CI" Then
            txtResult.Text = "Okay"
        Else
            If txtSecond.Text > 3.5 Then
                txtResult.Text = "Okay"
            End If
        End If
        'If txtFirst.Text = "CI" Or txtSecond.Text > 3.5 Then
        '   txtResult.Text = "OK"
        'End If
    End Sub

    Private Sub btnOrElse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrElse.Click
        If txtFirst.Text = "CI" Then
            txtResult.Text = "Okay"
        Else
            If txtSecond.Text > 3.5 Then
                txtResult.Text = "Okay"
            Else
                txtResult.Text = "Not either"
            End If
        End If
        'If txtFirst.Text = "CI" Or txtSecond.Text > 3.5 Then
        '   txtResult.Text = "OK"
        'Else
        '   txtResult.Text = "Neither"
        'End If
    End Sub

    Private Sub btnOrElseDiff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrElseDiff.Click
        If txtFirst.Text = "CI" Then
            txtResult.Text = "CI major"
        Else
            If txtSecond.Text > 3.5 Then
                txtResult.Text = "Honors GPA"
            Else
                txtResult.Text = "Not either"
            End If
        End If
    End Sub

    Private Sub btnAandBorC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAandBorC.Click
        If txtFirst.Text = "CI" Then
            If txtSecond.Text > 3.5 Then
                txtResult.Text = "Meets Criteria"
            Else
                If txtThird.Text > 30 Then
                    txtResult.Text = "Meets Criteria"
                End If
            End If
        End If
        'If txtFirst.Text = "CI" And (txtSecond.Text > 3.5 Or txtThird.Text > 30) Then
        '   txtResult.Text = "Meets Criteria"
        'End If
    End Sub

    Private Sub btnAandBorCElse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAandBorCElse.Click
        If txtFirst.Text = "CI" Then
            If txtSecond.Text > 3.5 Then
                txtResult.Text = "Meets Criteria"
            Else
                If txtThird.Text > 30 Then
                    txtResult.Text = "Meets Criteria"
                Else
                    txtResult.Text = "Does not meet criteria"
                End If
            End If
        Else
            txtResult.Text = "Does not meet criteria"
        End If
        'If txtFirst.Text = "CI" And (txtSecond.Text > 3.5 Or txtThird.Text > 30) Then
        '   txtResult.Text = "Meets Criteria"
        'else
        '   txtResult.text = "Does not meet criteria"
        'End If
    End Sub

    Private Sub btnAandBorCdiffelse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAandBorCdiffelse.Click
        'The addition of ToUpper will concert the content of txtFirst 
        'to upper case
        If txtFirst.Text.ToUpper() = "CI" Then
            If txtSecond.Text > 3.5 Then
                txtResult.Text = "Meets GPA Criteria"
            Else
                If txtThird.Text > 30 Then
                    txtResult.Text = "Meets Courses Criteria"
                Else
                    txtResult.Text = "Does not meet GPA or courses criteria"
                End If
            End If
        Else
            txtResult.Text = "Does not meet CI criteria"
        End If
    End Sub

    Private Sub frmIntroIF_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
