'Imports System.Data.SqlClient

Module modconn
    Public sql As String
    Public conn As New System.Data.OleDb.OleDbConnection
    Public cmd As System.Data.OleDb.OleDbCommand
    Public dr As System.Data.OleDb.OleDbDataReader
    'database
    Public Sub Connected()
        With conn
            Try
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\new\Final\Inventory\Inventory\bin\Debug\Database.mdb;"
                .Open()
            Catch
                MsgBox("Error in Database! Contact Administrator.")
                End
            End Try
        End With
    End Sub
    'cmd use
    Sub CommandDB()
        cmd = New OleDb.OleDbCommand(sql, conn)
    End Sub

End Module

