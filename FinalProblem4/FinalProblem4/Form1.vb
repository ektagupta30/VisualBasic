Public Class formcellPhone
    Dim minutes As Integer
    Dim model As String
    Dim cost As Double
    Dim years As Integer
    Private Sub formcellPhone_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        cost = 0
        If chkEmail.Checked Then
            cost = cost + 10
        End If
        If chkTextMessages.Checked Then
            cost = cost + 10
        End If

        If rad600.Checked Then
            cost = cost + 50
        ElseIf rad1000.Checked Then
            cost = cost + 60
        ElseIf rad1200.Checked Then
            cost = cost + 80
        Else
            MessageBox.Show("Please pick minutes", "Minutes")
        End If
        If radGalaxy.Checked Then
            cost = cost + 50
        ElseIf radIphone.Checked Then
            cost = cost + 60
        ElseIf radSamsung.Checked Then
            cost = cost + 55
        Else
            MessageBox.Show("Please pick the model")
        End If

        If txtYears.Text = String.Empty Then
            MessageBox.Show("Please enter the duration")
        Else
            years = CInt(txtYears.Text)
        End If
        MessageBox.Show("Request submited", "Cell phone package")
    End Sub
    Function yearly(ByVal cost As Double)
        Dim yearlyCost As Double
        yearlyCost = cost * 12
        Return yearlyCost
    End Function
    Function duration(ByVal cost As Double, ByVal years As Integer)
        Dim durationCost As Double
        durationCost = cost * years * 12
        Return durationCost
    End Function

    Private Sub btnYearly_Click(sender As Object, e As EventArgs) Handles btnYearly.Click
        Dim yearlyCost As Double
        yearlyCost = yearly(cost) 'calling  Function yearly(ByVal cost As Double)
        txtMessage.Visible = True
        txtMessage.Text = ("Your yearly total is " + yearlyCost.ToString)
    End Sub

    Private Sub btnDuration_Click(sender As Object, e As EventArgs) Handles btnDuration.Click
        Dim durationCost As Double
        durationCost = duration(cost, years) 'calling  Function yearly(ByVal cost As Double)
        txtMessage.Visible = True
        txtMessage.Text = ("Your total duration cost is " + durationCost.ToString)
    End Sub

    Private Sub btnMonthly_Click(sender As Object, e As EventArgs) Handles btnMonthly.Click
        txtMessage.Visible = True
        txtMessage.Text = ("Your monthly cost is " + cost.ToString)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cost = 0
        chkEmail.Checked = False
        chkTextMessages.Checked = False
        rad1000.Checked = False
        rad1200.Checked = False
        rad600.Checked = False
        radGalaxy.Checked = False
        radIphone.Checked = False
        radSamsung.Checked = False
        txtMessage.Clear()
        txtYears.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
