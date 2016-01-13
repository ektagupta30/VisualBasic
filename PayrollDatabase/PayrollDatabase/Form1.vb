Public Class Payroll

    Dim empDB As String
    Dim sqlEmp As String
    Dim sqlEmpProj As String
    Dim rowindex As Integer
    Dim dsEmp As New DataSet
    Dim currpath As String = System.Environment.CurrentDirectory
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        empDB = "Provider=Microsoft.ACE.OLEDB.12.0;" & _
             "Data Source = " & currpath & "\Employee.accdb"

    End Sub



    Private Sub btnQ1_Click(sender As Object, e As EventArgs) Handles btnQ1.Click
        dsEmp.Reset()
        sqlEmp = "Select Emp_no,Emp_name,salary,dept_no from employee where salary < 6000 and (Dept_no = '123' or Dept_no ='124')"

        Dim daEmpDB As New OleDb.OleDbDataAdapter(sqlEmp, empDB)
        daEmpDB.Fill(dsEmp, "employee")
        empTable.DataSource = dsEmp.Tables("employee")


    End Sub

    Private Sub btnQ2_Click(sender As Object, e As EventArgs) Handles btnQ2.Click
        dsEmp.Reset()
        sqlEmp = "Select  dept_no,sum(salary) as Tot_sal from employee group by dept_no"

        Dim daEmpDB As New OleDb.OleDbDataAdapter(sqlEmp, empDB)
        daEmpDB.Fill(dsEmp, "employee")

        empTable.DataSource = dsEmp.Tables("employee")


    End Sub

    Private Sub btnQ3_Click(sender As Object, e As EventArgs) Handles btnQ3.Click
        dsEmp.Reset()
        sqlEmp = "Select  emp_no,emp_name,department.dept_no,dept_name from employee,department where employee.dept_no = department.dept_no"

        Dim daEmpDB As New OleDb.OleDbDataAdapter(sqlEmp, empDB)
        daEmpDB.Fill(dsEmp)
        empTable.DataSource = dsEmp.Tables(0)

    End Sub

    Private Sub btnQ4_Click(sender As Object, e As EventArgs) Handles btnQ4.Click
        dsEmp.Reset()
        lblEmpNo.Visible = True
        lblName.Visible = True
        txtEmp_no.Visible = True
        txtName.Visible = True
        btnMatch.Visible = True
        btnNext.Visible = True
        btnPrevious.Visible = True
        sqlEmpProj = "Select * from EmployeeProject order by Emp_no"
        Dim daEmpDB As New OleDb.OleDbDataAdapter(sqlEmpProj, empDB)
        daEmpDB.Fill(dsEmp, "EmployeeProject")
        empTable.DataSource = dsEmp.Tables("EmployeeProject")
        fillTextBoxes()
    End Sub
    Sub fillTextBoxes()
        sqlEmp = "Select  Emp_no,Emp_name from employee"
        Dim daEmpDB As New OleDb.OleDbDataAdapter(sqlEmp, empDB)
        daEmpDB.Fill(dsEmp, "employee")
        txtEmp_no.Text = CStr(dsEmp.Tables("employee").Rows(rowindex)("Emp_no"))
        txtName.Text = CStr(dsEmp.Tables("employee").Rows(rowindex)("Emp_name"))
    End Sub

    Private Sub btnMatch_Click(sender As Object, e As EventArgs) Handles btnMatch.Click
        Dim RowFilter As String = "Emp_no = '" & txtEmp_no.Text & "'"
        Dim dvEmpProj As DataView = New DataView(dsEmp.Tables("EmployeeProject"),
                               RowFilter, "Proj_Date", DataViewRowState.CurrentRows)
        empTable.DataSource = dvEmpProj
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If rowindex < dsEmp.Tables(0).Rows.Count - 1 Then
            rowindex = rowindex + 1
            fillTextBoxes()
        Else
            rowindex = 0
            fillTextBoxes()
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If rowindex > 0 Then
            rowindex = rowindex - 1
            fillTextBoxes()
        Else
            rowindex = 0
            fillTextBoxes()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub empTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles empTable.CellContentClick

    End Sub
End Class

