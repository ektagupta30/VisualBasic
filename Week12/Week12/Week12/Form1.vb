Public Class Emp_Proj_info
    Dim empDB As String
    Dim sqlEmp As String
    Dim sqlEmpProj As String
    Dim rowindex As Integer
    Dim newRecord As DataRow
    Dim dsEmp As New DataTable
    Dim dataAdapterDrive As OleDb.OleDbDataAdapter
    Dim cbEmp As New System.Data.OleDb.OleDbCommandBuilder
    Dim currpath As String = System.Environment.CurrentDirectory


   
    Private Sub Emp_Proj_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        empDB = "Provider=Microsoft.ACE.OLEDB.12.0;" & _
             "Data Source = " & currpath & "\Employee.accdb"
        Dim connEmp As New OleDb.OleDbConnection(empDB)
        Dim sqlStrDrive As String = "Select * from EmployeeProject order by Emp_no"
        dataAdapterDrive = New OleDb.OleDbDataAdapter(sqlStrDrive, connEmp)
        cbEmp = New OleDb.OleDbCommandBuilder(dataAdapterDrive)
        dataAdapterDrive.Fill(dsEmp)
        fillTextBoxes()

    End Sub
    Sub fillTextBoxes()
        txtEmpNo.Text = CStr(dsEmp.Rows(rowindex)("Emp_no"))
        txtProjNo.Text = CStr(dsEmp.Rows(rowindex)("Proj_no"))
        txtDate.Text = CStr(dsEmp.Rows(rowindex)("Proj_Date"))
        txtHours.Text = CStr(dsEmp.Rows(rowindex)("Hours_wkd"))

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        gridEmployeeProject.DataSource = dsEmp
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        newRecord = dsEmp.NewRow
        newRecord("Emp_no") = InputBox("Enter emp_no", "New Record")
        newRecord("Proj_no") = InputBox("Enter proj_no", "New Record")
        newRecord("Proj_Date") = InputBox("Enter Proj_Date", "New Record")
        newRecord("Hours_wkd") = InputBox("Enter Hours_wkd", "New Record")
        dsEmp.Rows.Add(newRecord)
        Try
            dataAdapterDrive.Update(dsEmp)
        Catch ex As Exception
            MsgBox(ex.ToString)
            dsEmp.Rows.Remove(newRecord)
        End Try
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

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If rowindex < dsEmp.Rows.Count - 1 Then
            rowindex = rowindex + 1
            fillTextBoxes()
        Else
            rowindex = 0
            fillTextBoxes()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        dsEmp.Rows(rowindex).Delete()
        dataAdapterDrive.Update(dsEmp)
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        dsEmp.AcceptChanges()
        dsEmp.Rows(rowindex)("Emp_no") = txtEmpNo.Text
        dsEmp.Rows(rowindex)("Proj_no") = txtProjNo.Text
        dsEmp.Rows(rowindex)("Proj_Date") = txtDate.Text
        dsEmp.Rows(rowindex)("Hours_wkd") = txtHours.Text
        Try
            dataAdapterDrive.Update(dsEmp)
        Catch ex As Exception
            MsgBox(ex.ToString)
            dsEmp.Rows.Remove(newRecord)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        dataAdapterDrive.Dispose()
        Me.Close()
    End Sub
End Class
