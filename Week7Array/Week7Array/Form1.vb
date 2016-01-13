Public Class Form1

    Dim arrayId(5) As String
    Dim arrayName(5) As String



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        arrayId(0) = "CIS156"
        arrayId(1) = "CIS150"
        arrayId(2) = "CIS159"
        arrayId(3) = "CIS157"
        arrayId(4) = "CIS257"
        arrayId(5) = "CIS122"
        arrayName(0) = "Visual basic"
        arrayName(1) = "Oracle and SQL "
        arrayName(2) = "MySQL and PHP "
        arrayName(3) = "JavaI"
        arrayName(4) = "JavaII"
        arrayName(5) = "Internet Developer"

    End Sub

   

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim indFound As String = "N"
        Dim wkSub As Integer = 0
        Do While indFound = "N" And wkSub < arrayId.Length
            If CStr(txtID.Text) = arrayId(wkSub) Then
                indFound = "Y"
            Else
                wkSub = wkSub + 1
            End If
        Loop
        If indFound = "Y" Then
            txtName.Visible = True
            txtName.Text = arrayName(wkSub)
        Else
            txtName.Visible = True
            txtName.Text = "No match found"
        End If
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
