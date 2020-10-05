Public Class Inventory
    Dim id As Integer

    Private Sub Inventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load all products in listview
        PopulateProducts(lvProducts, "")
        'load all category in combobox
        PopulateCategory(cbocategory)
        'doChangeListViewColor(lvProducts)
        cbstatus.Items.Add("New")
        cbstatus.Items.Add("Old")
        'getDate()
    End Sub



    Private Sub tbsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbsearch.TextChanged
        'search products category or name
        SearchProduct(lvProducts, tbsearch.Text)
    End Sub

    Private Sub lvProducts_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvProducts.MouseClick
        ' Dim d As Date
        With lvProducts.SelectedItems(0)
            id = .SubItems(0).Text
            cbocategory.Text = .SubItems(1).Text
            tbname.Text = .SubItems(2).Text
            tbprice.Text = .SubItems(3).Text
            tbstock.Text = .SubItems(4).Text
            tbpurchase.Text = .SubItems(5).Text
            tblocation.Text = .SubItems(6).Text
            cbstatus.Text = .SubItems(7).Text
            tbsupplier.Text = .SubItems(8).Text
        End With
        details.Enabled = True
    End Sub


    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If btnadd.Text = "Add" Then
            btnadd.Text = "Save"
            btnedit.Text = "Cancel"
            btndelete.Visible = False
            btnclear.Visible = False
            details.Enabled = True
            getDate()
            ClearUserInput()
        Else
            If IsUserInputValid() = True Then
                SaveData()
                ClearUserInput()

                MsgBox("Successfully added", MsgBoxStyle.Information)

            End If
        End If
    End Sub


    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If btnedit.Text = "Update" Then
            If id <> 0 Then
                EditData()

                MsgBox("Successfully updated", MsgBoxStyle.Information)
            Else
                MsgBox("Select on product list")
            End If
        Else
            btnadd.Text = "Add"
            btnedit.Text = "Update"
            btndelete.Visible = True
            btnclear.Visible = True
            details.Enabled = False
        End If

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        DeleteData()
        ClearUserInput()
    End Sub


    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        ClearUserInput()
        PopulateProducts(lvProducts, "prod_category")
        details.Enabled = False

    End Sub

    '#Region "Functions and Methods"



    Sub SaveData()
        Connected()
        sql = "INSERT INTO item 
                                    (item_brand,
                                     item_datepurchase,
                                     item_stock,
                                     item_supplier,
                                     item_userID,
                                     item_location,
                                     item_status,
                                     item_price,
                                     item_type ) 
                           VALUES ('" & tbname.Text.ToUpper & "',
                                   '" & tbpurchase.Text.ToString & "',
                                   '" & tbstock.Text & "',
                                   '" & tbsupplier.Text.ToString & "',
                                   '" & " 2 " & "',
                                   '" & tblocation.Text.ToString & "',
                                   '" & cbstatus.Text.ToUpper & "',
                                   '" & tbprice.Text.ToString & "',
                                   '" & cbocategory.Text.ToUpper & "')"
        CommandDB()
        dr = cmd.ExecuteReader()
        PopulateProducts(lvProducts, "type_name")
    End Sub

    Sub EditData()
        Connected()
        sql = "UPDATE Item SET item_brand = '" & cbocategory.Text.ToUpper & "', prod_name = '" & tbname.Text.ToUpper & "', prod_price = " & tbprice.Text & " , prod_stock = " & tbstock.Text & ", prod_purchasedate = '" & tbpurchase.Text.ToString & "', prod_passdate = '" & tblocation.Text.ToString & "' where id = " & id & ""
        CommandDB()
        cmd.ExecuteNonQuery()
        PopulateProducts(lvProducts, "item_brand")
    End Sub

    Sub DeleteData()
        Connected()
        Dim i As Integer
        sql = "DELETE FROM Item WHERE item_id = " & id & ""
        'validattion
        If id = "0" Then
            MsgBox("Select on Item list", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        CommandDB()
        i = MsgBox("Are you sure you want to delete " & tbname.Text.ToUpper & "?", MsgBoxStyle.YesNo)
        If i = MsgBoxResult.Yes Then
            'execute delete query
            cmd.ExecuteNonQuery()
            MsgBox("Succesfully deleted", MsgBoxStyle.Information)
            PopulateProducts(lvProducts, "item_brand")
        End If
    End Sub

    Function IsUserInputValid() As Boolean
        If cbocategory.Text = "" Or cbocategory.Text.ToLower = "select" Or tbname.Text = "" Or tbstock.Text = "" Or tbprice.Text = "" Or tbpurchase.Text = "" Or tblocation.Text = "" Then
            MsgBox("Missing input", MsgBoxStyle.Critical)
            Return False
        ElseIf IsProductExist("Item", "item_brand", tbname.Text) = True Then
            MsgBox("Product " & tbname.Text.ToUpper & " Exist", MsgBoxStyle.Critical)
            Return False
        End If
        Return True
    End Function

    Sub ClearUserInput()
        id = 0
        cbocategory.Text = "Select"
        tbname.Text = ""
        tbprice.Text = ""
        tbstock.Text = ""
        tbsearch.Text = ""
        getDate()
    End Sub


    Sub getDate()
        tbpurchase.Text = Format(Now, "short date")
        tblocation.Text = Format(Now, "short date")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


End Class