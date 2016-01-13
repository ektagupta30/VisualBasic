Public Class cisForm

    Private Sub btnWelcome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWelcome.Click
        lblWelcome.Visible = True
        MessageBox.Show("Welcome!")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub picCis_Click(sender As Object, e As EventArgs) Handles picCis.Click

    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub
End Class
