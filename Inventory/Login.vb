Public Class Login

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connected()
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If IsUserAuthentic(username.Text.ToLower, password.Text.ToLower) = True Then
            Main.Show()
            If username.Text = "Employee" Then
                Main.btninventory.Visible = False
                Main.btnreport.Visible = False
            Else
                Main.btninventory.Visible = True
                Main.btnreport.Visible = True
            End If
            Main.lblUser.Text = username.Text
            username.Text = "- Select -"
            password.Text = ""
            MsgBox("Welcome!", MsgBoxStyle.Information)
            Me.Hide()
        Else
            MsgBox("Incorrect passcode", MsgBoxStyle.Critical)
        End If
    End Sub

    'check if user Is valid
    Function IsUserAuthentic(ByVal u As String, ByVal p As String) As Boolean
        Connected()
        sql = "SELECT * FROM tbluser WHERE [position] = '" & u & "' AND [passcode] = '" & p & "' "
        cmd = New OleDb.OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader()
        If (dr.Read() = True) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub


End Class
