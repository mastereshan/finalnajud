Public Class Employees
    Dim id As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Employees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load all products in listview
        PopulateEmployees(lvProducts, "")
    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If btnadd.Text = "Add" Then
            btnadd.Text = "Save"
            btnedit.Text = "Cancel"
            btndelete.Visible = False
            btnclear.Visible = False
            pndetails.Enabled = True
            ClearUserInput()
        Else
            If IsUserInputValid() = True Then
                SaveData()
                ClearUserInput()

                MsgBox("Successfully added", MsgBoxStyle.Information)

            End If
        End If
    End Sub
    Sub SaveData()
        Connected()
        sql = "INSERT INTO employee 
                                (emp_firstname,
                                 emp_lastname,
                                 emp_jobDes,
                                 emp_assignLocation) 
                       VALUES ('" & tbfname.Text.ToUpper & "',
                               '" & tblname.Text.ToString & "',
                               '" & tbtitle.Text & "',
                               '" & tbass.Text.ToString & "')"
        CommandDB()
        dr = cmd.ExecuteReader()
        PopulateEmployees(lvProducts, "type_name")
    End Sub
    Function IsUserInputValid() As Boolean
        If tbfname.Text = "" Or tbfname.Text.ToLower = "select" Or tblname.Text = "" Or tbtitle.Text = "" Or tbass.Text = "" Then
            MsgBox("Missing input", MsgBoxStyle.Critical)
            Return False
        ElseIf IsProductExist("tblproducts", "prod_name", tbfname.Text) = True Then
            MsgBox("Product " & tbfname.Text.ToUpper & " Exist", MsgBoxStyle.Critical)
            Return False
        End If
        Return True
    End Function
    Sub ClearUserInput()
        id = 0
        tbfname.Text = ""
        tblname.Text = ""
        tbtitle.Text = ""
        tbass.Text = ""
    End Sub

End Class