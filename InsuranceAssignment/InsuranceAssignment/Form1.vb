Imports System.IO


Public Class frmInsurance
    Dim premium, value, newPremium As Double
    Dim year As String
    Dim goodPoints, accident, moving, nonmoving As Double
    Dim InsuranceFile As StreamWriter


    Private Sub Year_Enter(sender As Object, e As EventArgs) Handles gpYear.Enter

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rad2009.CheckedChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InsuranceFile = File.CreateText("C:\Users\Ekta\Documents\InsuranceFile.txt")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
        premium = 0
        goodPoints = 0
        accident = 0
        moving = 0
        nonmoving = 0
        year = ""
        If txtValue.Text = String.Empty Then
            MessageBox.Show("Please enter the value")
            txtValue.Focus()

        Else
            Try
                value = CDbl(txtValue.Text)
                If rad2009.Checked Then
                    year = "2009"
                    premium = value * 4.5 / 100
                    newPremium = premium
                    If chkGood.Checked Then
                        goodPoints = 35 * txtGood.Text
                        newPremium = newPremium - goodPoints
                    End If
                    If chkAccident.Checked Then
                        accident = (75 * txtAccident.Text)
                        newPremium = newPremium + accident
                    End If
                    If chkMoving.Checked Then
                        moving = 50 * txtMoving.Text
                        newPremium = newPremium + moving
                    End If
                    If chkNonMoving.Checked Then
                        nonmoving = 25 * txtNonMoving.Text
                        newPremium = newPremium + nonmoving
                    End If
                    txtResult.Text = newPremium
                ElseIf rad2010.Checked Then
                    year = "2010"
                    premium = value * 5 / 100
                    newPremium = premium
                    If chkGood.Checked Then
                        goodPoints = 35 * txtGood.Text
                        newPremium = newPremium - goodPoints
                    End If
                    If chkAccident.Checked Then
                        accident = (75 * txtAccident.Text)
                        newPremium = newPremium + accident
                    End If
                    If chkMoving.Checked Then
                        moving = 50 * txtMoving.Text
                        newPremium = newPremium + moving
                    End If
                    If chkNonMoving.Checked Then
                        nonmoving = 25 * txtNonMoving.Text
                        newPremium = newPremium + nonmoving
                    End If

                    txtResult.Text = newPremium
                ElseIf rad2012.Checked Then
                    year = "2012"
                    premium = value * 5.5 / 100
                    newPremium = premium
                    If chkGood.Checked Then
                        goodPoints = 35 * txtGood.Text
                        newPremium = newPremium - goodPoints
                    End If
                    If chkAccident.Checked Then
                        accident = (75 * txtAccident.Text)
                        newPremium = newPremium + accident
                    End If
                    If chkMoving.Checked Then
                        moving = 50 * txtMoving.Text
                        newPremium = newPremium + moving
                    End If
                    If chkNonMoving.Checked Then
                        nonmoving = 25 * txtNonMoving.Text
                        newPremium = newPremium + nonmoving
                    End If

                    txtResult.Text = newPremium
                ElseIf rad2013.Checked Then
                    year = "2013"
                    premium = value * 6 / 100
                    newPremium = premium
                    If chkGood.Checked Then
                        goodPoints = 35 * txtGood.Text
                        newPremium = newPremium - goodPoints
                    End If
                    If chkAccident.Checked Then
                        accident = (75 * txtAccident.Text)
                        newPremium = newPremium + accident
                    End If
                    If chkMoving.Checked Then
                        moving = 50 * txtMoving.Text
                        newPremium = newPremium + moving
                    End If
                    If chkNonMoving.Checked Then
                        nonmoving = 25 * txtNonMoving.Text
                        newPremium = newPremium + nonmoving
                    End If
                    txtResult.Text = newPremium
                ElseIf radOther.Checked Then
                    year = "Before 2009"
                    premium = value * 4 / 100
                    newPremium = premium
                    If chkGood.Checked Then
                        goodPoints = 35 * txtGood.Text
                        newPremium = newPremium - goodPoints
                    End If
                    If chkAccident.Checked Then
                        accident = (75 * txtAccident.Text)
                        newPremium = newPremium + accident
                    End If
                    If chkMoving.Checked Then
                        moving = 50 * txtMoving.Text
                        newPremium = newPremium + moving
                    End If
                    If chkNonMoving.Checked Then
                        nonmoving = 25 * txtNonMoving.Text
                        newPremium = newPremium + nonmoving
                    End If

                    txtResult.Text = newPremium
                End If
                summary.Items.Add("Vehicle Name      " + txtName.Text)
                summary.Items.Add("Vehicle Id:    " + txtID.Text)
                summary.Items.Add("Value:     " + txtValue.Text)
                summary.Items.Add("Year:   " + year)
                summary.Items.Add("premium based on " + year & " =   " & premium)
                summary.Items.Add("Good points:   -  " + goodPoints.ToString)
                summary.Items.Add("Accident points:   +   " + accident.ToString)
                summary.Items.Add("Moving points:   +   " + moving.ToString)
                summary.Items.Add("Non moving points:   +   " + nonmoving.ToString)
                summary.Items.Add("Net Premium:   =   " + txtResult.Text)
            Catch ex As InvalidCastException
                MessageBox.Show("Please check the value you entered")
                txtValue.Focus()
            End Try
        End If

    End Sub

    Private Sub chkGood_CheckedChanged(sender As Object, e As EventArgs) Handles chkGood.CheckedChanged
        If chkGood.Checked Then
            txtGood.Visible = True
            txtGood.Focus()
        End If
    End Sub

    Private Sub chkAccident_CheckedChanged(sender As Object, e As EventArgs) Handles chkAccident.CheckedChanged
        If chkAccident.Checked Then
            txtAccident.Visible = True
            txtAccident.Focus()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles chkMoving.CheckedChanged
        If chkMoving.Checked Then
            txtMoving.Visible = True
            txtMoving.Focus()
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles chkNonMoving.CheckedChanged
        If chkNonMoving.Checked Then
            txtNonMoving.Visible = True
            txtNonMoving.Focus()
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles summary.SelectedIndexChanged

    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        InsuranceFile.Close()
        Me.Close()
    End Sub

    Private Sub btnFile_Click(sender As Object, e As EventArgs) Handles btnFile.Click

        InsuranceFile.WriteLine("Vehicle Name      " + txtName.Text)
        InsuranceFile.WriteLine("Vehicle Id:    " + txtID.Text)
        InsuranceFile.WriteLine("Value:     " + txtValue.Text)
        InsuranceFile.WriteLine("Year:   " + year)
        InsuranceFile.WriteLine("premium based on " + year & " =   " & premium)
        InsuranceFile.WriteLine("Good points:   -  " + goodPoints.ToString)
        InsuranceFile.WriteLine("Accident points:   +   " + accident.ToString)
        InsuranceFile.WriteLine("Moving points:   +   " + moving.ToString)
        InsuranceFile.WriteLine("Non moving points:   +   " + nonmoving.ToString)
        InsuranceFile.WriteLine("Net Premium:   =   " + txtResult.Text)
        InsuranceFile.WriteLine("----------------")
        MessageBox.Show("File Saved")
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAccident.Clear()
        txtGood.Clear()
        txtID.Clear()
        txtMoving.Clear()
        txtName.Clear()
        txtNonMoving.Clear()
        txtResult.Clear()
        txtValue.Clear()
        chkAccident.Checked = False
        chkGood.Checked = False
        chkMoving.Checked = False
        chkNonMoving.Checked = False
        summary.Items.Clear()


    End Sub
End Class
