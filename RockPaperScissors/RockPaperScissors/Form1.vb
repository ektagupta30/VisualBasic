Public Class Form1
    Dim rock, paper, scissors, player, computer, winner As String
   
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRock_Click(sender As Object, e As EventArgs) Handles btnRock.Click
        
        txtPlayer.Text = "Rock"
        txtPlayer.Visible = True
        Comp_Play()
        SelectWinner()

    End Sub

    Private Sub btnPaper_Click(sender As Object, e As EventArgs) Handles btnPaper.Click
        txtPlayer.Text = "Paper"
        txtPlayer.Visible = True
        Comp_Play()
        SelectWinner()
    End Sub

    Private Sub btnScissors_Click(sender As Object, e As EventArgs) Handles btnScissors.Click
        txtPlayer.Text = "Scissors"
        txtPlayer.Visible = True
        Comp_Play()
        SelectWinner()
    End Sub

    Private Sub Comp_Play()
        Dim intSelect As Integer
        Dim randSelect As New Random

        intSelect = randSelect.Next(3)
        If intSelect = 0 Then
            txtComputer.Text = "Rock"
            txtComputer.Visible = True
        ElseIf intSelect = 1 Then
            txtComputer.Text = "Paper"
            txtComputer.Visible = True
        ElseIf intSelect = 2 Then
            txtComputer.Text = "Scissors"
            txtComputer.Visible = True
        End If

    End Sub

    Private Sub SelectWinner()

        player = txtPlayer.Text
        computer = txtComputer.Text

        If player = "Paper" Then
            If computer = "Paper" Then
                txtResult.Text = "Paper vs paper: tie"
            ElseIf computer = "Rock" Then
                txtResult.Text = "Paper covers rock: you win"
            ElseIf computer = "Scissors" Then
                txtResult.Text = "Scissors cut paper: computer wins"
            End If
        ElseIf player = "Rock" Then
            If computer = "Paper" Then
                txtResult.Text = "Paper covers Rock: Computer wins"
            ElseIf computer = "Rock" Then
                txtResult.Text = "Rock vs rock: tie"
            ElseIf computer = "Scissors" Then
                txtResult.Text = "Rock can break scissors: you win"
            End If
        ElseIf player = "Scissors" Then
            If computer = "Paper" Then
                txtResult.Text = "Scissors cut paper: you win"
            ElseIf computer = "Rock" Then
                txtResult.Text = "Rock can break scissors: computer wins"
            ElseIf computer = "Scissors" Then
                txtResult.Text = "Scissors vs scissors: tie"
            End If


        End If
    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
