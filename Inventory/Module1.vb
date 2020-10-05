Module Module1
    Public Function getProductStock(ByVal prodname) As Integer
        Connected()
        Dim stock As Integer
        sql = "SELECT item_stock FROM Item where item_brand = '" & prodname & "'"
        CommandDB()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                stock = dr.Item(0)
            Loop
        End If
        Return stock
    End Function
End Module
