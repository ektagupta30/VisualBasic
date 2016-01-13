
Imports System.IO

Public Class Form1
    Dim nameFile As StreamWriter
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nameFile = File.AppendText("names.txt")
    End Sub

    Private Sub btnShowName_Click(sender As Object, e As EventArgs) Handles btnShowName.Click
        Dim name, title As String
        Dim position As Integer
        If radMR.Checked = True Then
            title = "Mr"
        ElseIf radMRS.Checked = True Then
            title = "Mrs"
        Else
            title = ""
        End If
        name = txtEnterName.Text
        position = name.IndexOf("/")
        name = title + " " + name.Substring(position + 1) + " " + name.Substring(0, position)
        txtName.Text = name
        nameFile.WriteLine(name)
    End Sub

   



    Private Sub btnShowAddress_Click(sender As Object, e As EventArgs) Handles btnShowAddress.Click
        Dim street, address As String
        Dim position As Integer
        address = txtEnterAddress.Text
        position = address.IndexOf("/")
        street = address.Substring(0, position)
        txtStreet.Text = street.ToUpper
        address = address.Substring(position)
        address = address.Replace("/", " ")
        txtAddress.Text = address.ToUpper
    End Sub

    Private Sub btnShowID_Click(sender As Object, e As EventArgs) Handles btnShowID.Click
        Dim street, address, id As String
        Dim position As Integer
        address = txtEnterAddress.Text
        position = address.IndexOf("/")
        street = address.Substring(0, 2) 'first two characters of address
        address = address.Substring(position) 'getting address with no street address
        'extracting first two characters of city,state and zip
        address = address.Substring(address.LastIndexOf("/") + 1, 2) + address.Substring(1, 2) + address.Substring(address.IndexOf("/") + 1, 2)
        id = street + address
        txtID.Text = id.ToUpper



    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        Dim manhattan, dallas, LA, B_plan, sales, buyers, distributors, software, cost As Integer
        manhattan = 1000
        dallas = 750
        LA = 850
        B_plan = 500
        sales = 700
        buyers = 600
        distributors = 1000
        software = 1500
        If City.SelectedIndex = -1 Then
            MessageBox.Show("Select a city")
        ElseIf Conferences.SelectedIndex = -1 Then
            MessageBox.Show("Select a conference")
        End If
        If City.SelectedItem = "Manhattan" Then
            If Conferences.SelectedItem = "Business Plan" Then
                cost = manhattan + B_plan
                ConferenceCost.Items.Add(City.SelectedItem.ToString + "        " + Conferences.SelectedItem.ToString + "      " + cost.ToString)
            ElseIf Conferences.SelectedItem = "Sales and Marketing" Then
                cost = manhattan + sales
                ConferenceCost.Items.Add(City.SelectedItem.ToString + "        " + Conferences.SelectedItem.ToString + "      " + cost.ToString)
            ElseIf Conferences.SelectedItem = "Buyers" Then
                cost = manhattan + buyers
                ConferenceCost.Items.Add(City.SelectedItem.ToString + "        " + Conferences.SelectedItem.ToString + "      " + cost.ToString)
            ElseIf Conferences.SelectedItem = "Distributors" Then
                cost = manhattan + distributors
                ConferenceCost.Items.Add(City.SelectedItem.ToString + "        " + Conferences.SelectedItem.ToString + "      " + cost.ToString)
            ElseIf Conferences.SelectedItem = "Software" Then
                cost = manhattan + software
                ConferenceCost.Items.Add(City.SelectedItem.ToString + "        " + Conferences.SelectedItem.ToString + "      " + cost.ToString)
            End If
        ElseIf City.SelectedItem = "Dallas" Then
            If Conferences.SelectedItem = "Business Plan" Then
                cost = dallas + B_plan
                ConferenceCost.Items.Add(City.SelectedItem.ToString + "        " + Conferences.SelectedItem.ToString + "      " + cost.ToString)
            ElseIf Conferences.SelectedItem = "Sales and Marketing" Then
                cost = dallas + sales
                ConferenceCost.Items.Add(City.SelectedItem.ToString + "        " + Conferences.SelectedItem.ToString + "      " + cost.ToString)
            ElseIf Conferences.SelectedItem = "Buyers" Then
                cost = dallas + buyers
                ConferenceCost.Items.Add(City.SelectedItem.ToString + "        " + Conferences.SelectedItem.ToString + "      " + cost.ToString)
            ElseIf Conferences.SelectedItem = "Distributors" Then
                cost = dallas + distributors
                ConferenceCost.Items.Add(City.SelectedItem.ToString + "        " + Conferences.SelectedItem.ToString + "      " + cost.ToString)
            ElseIf Conferences.SelectedItem = "Software" Then
                cost = dallas + software
                ConferenceCost.Items.Add(City.SelectedItem.ToString + "        " + Conferences.SelectedItem.ToString + "      " + cost.ToString)
            End If
        ElseIf City.SelectedItem = "Los Angles" Then
            If Conferences.SelectedItem = "Business Plan" Then
                cost = LA + B_plan
                ConferenceCost.Items.Add(City.SelectedItem.ToString + "        " + Conferences.SelectedItem.ToString + "      " + cost.ToString)
            ElseIf Conferences.SelectedItem = "Sales and Marketing" Then
                cost = LA + sales
                ConferenceCost.Items.Add(City.SelectedItem.ToString + "        " + Conferences.SelectedItem.ToString + "      " + cost.ToString)
            ElseIf Conferences.SelectedItem = "Buyers" Then
                cost = LA + buyers
                ConferenceCost.Items.Add(City.SelectedItem.ToString + "        " + Conferences.SelectedItem.ToString + "      " + cost.ToString)
            ElseIf Conferences.SelectedItem = "Distributors" Then
                cost = LA + distributors
                ConferenceCost.Items.Add(City.SelectedItem.ToString + "        " + Conferences.SelectedItem.ToString + "      " + cost.ToString)
            ElseIf Conferences.SelectedItem = "Software" Then
                cost = LA + software
                ConferenceCost.Items.Add(City.SelectedItem.ToString + "        " + Conferences.SelectedItem.ToString + "      " + cost.ToString)
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        nameFile.Close()
        Me.Close()
    End Sub

    
    Private Sub btnClearName_Click(sender As Object, e As EventArgs) Handles btnClearName.Click

        txtEnterName.Clear()
        txtName.Clear()

    End Sub
End Class
