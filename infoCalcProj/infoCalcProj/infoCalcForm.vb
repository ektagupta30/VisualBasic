Public Class infoCalcForm

    Private Sub btnGreet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGreet.Click
        lblGreet.Text = "Hello " & txtName.Text
        txtGreet.Text = "Hello " & txtName.Text
        MessageBox.Show("Hello " & txtName.Text)
        txtName.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalcInches_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcInches.Click
        'Note that txtInches is ReadOnly so I can display result but user
        'cannot change
        'Dim intInchesinFoot As Integer = 12
        Dim intInchesinFoot As Integer
        Dim strNote As String
        strNote = "There are 12 inches in a foot"
        intInchesinFoot = 12
        txtInches.Text = txtFeet.Text * intInchesinFoot
        txtNote.Text = strNote
    End Sub

    Private Sub btnDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDate.Click
        Dim datDateShow As Date
        datDateShow = #1/24/2010#
        txtDate.Text = datDateShow
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        txtFullName.Text = txtName.Text & " " & txtLastName.Text
    End Sub

    Private Sub infoCalcForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
