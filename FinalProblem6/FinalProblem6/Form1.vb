Public Class Form1
    Dim empDB As String
    Dim sqlEmp As String
    'Dim sqlEmpProj As String
    ' Dim rowindex As Integer
    Dim dsEmp As New DataSet
    Dim currpath As String = System.Environment.CurrentDirectory
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        empDB = "Provider=Microsoft.ACE.OLEDB.12.0;" & _
             "Data Source = " & currpath & "\Employee.accdb"

    End Sub
    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        dsEmp.Reset()
        sqlEmp = "Select Emp_no,Emp_name,salary,dept_no from employee where salary < 6000 and (Dept_no = '123' or Dept_no ='124')"

        Dim daEmpDB As New OleDb.OleDbDataAdapter(sqlEmp, empDB)
        daEmpDB.Fill(dsEmp, "employee")
        empDataGrid.DataSource = dsEmp.Tables("employee")
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        dsEmp.Reset()
        sqlEmp = "Select * from EmployeeProject where (proj_no = 'p11'and Hours_wkd >10)and(Emp_no ='04' or(emp_no = '02' and hours_wkd = 10))  "

        Dim daEmpDB As New OleDb.OleDbDataAdapter(sqlEmp, empDB)
        daEmpDB.Fill(dsEmp, "EmployeeProject")
        empDataGrid.DataSource = dsEmp.Tables("EmployeeProject")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
