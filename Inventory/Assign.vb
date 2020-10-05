
Public Class Assign
    Dim itemID As Integer
    Dim itemname As String
    Dim itemstock As Integer
    Dim itemType As String
    Dim id As Integer
    Dim enterQty As Integer
    Dim enterSN As Integer
    Public Property Alert As Object


    Private Sub Ordering_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load all products in listview
        btncancel.Enabled = False
        PopulateProducts(lvProducts, "")
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub lvProducts_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvProducts.KeyDown
        If e.KeyCode = Keys.Enter Then
            EnterQuantity()
        End If
    End Sub

    Private Sub lvProducts_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvProducts.MouseDoubleClick
        EnterQuantity()
    End Sub
    Private Sub lvorder_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvorder.MouseDoubleClick
        'get require data in lvorder
        Dim qtyorder As Integer
        Dim newsubtotal As Integer

        With lvorder.SelectedItems(0)
            itemID = .SubItems(1).Text
            itemname = .SubItems(2).Text
            qtyorder = .SubItems(3).Text
        End With

        Dim enterOrder As Integer = Val(InputBox("Product name: " & itemname & vbNewLine & "", "Enter Quantity Return".ToUpper, 1))
        If enterOrder = Nothing Then
            Exit Sub
        End If
        toggleBtnEnabbled()
    End Sub
    Sub toggleBtnEnabbled()
        btnAssign.Enabled = IsEnabledBtn()
        btncancel.Enabled = IsEnabledBtn()
    End Sub
    Function IsEnabledBtn() As Boolean
        If lvorder.Items.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Sub EnterQuantity()
        'assign data from listview to variables
        With lvProducts.SelectedItems(0)
            id = .SubItems(0).Text
            itemType = .SubItems(1).Text
            itemname = .SubItems(2).Text
            itemstock = .SubItems(3).Text
        End With
        'enter qty order
        enterQty = Val(InputBox("Product name: " & itemname & vbNewLine & "Product Available Stock: " & itemstock, "Enter Quantity".ToUpper, 1))
        If enterQty = Nothing Then
            Exit Sub
        End If
        enterSN = Val(InputBox("Product name: " & id & vbNewLine & "Product Name: " & itemname, "Enter Serial Number".ToUpper, 1))

        'enable button cancel transaction 
        btncancel.Enabled = True
    End Sub

    Function getQuantityOrder(ByVal _itemname As String, ByVal _enterQty As Integer) As Integer
        'instantiate
        Dim indexRow As New IndexRow

        'initialize index row
        'indexRow.ListView = lvorder
        indexRow.Column = 1
        indexRow.Key = _itemname

        If indexRow.hasRow Then
            Dim index As Integer = indexRow.getListIndex()
            Dim quantity As Integer = lvorder.Items(index).SubItems(2).Text
            Return quantity + _enterQty
        Else
            Return getProductStock(_itemname)
        End If
    End Function
    Sub updateQtyListOrder(ByVal _qty As Integer, ByVal _subTotal As Double)
        'instantiate
        Dim indexRow As New IndexRow

        'initialize index row
        indexRow.listView = lvorder
        indexRow.Column = 1
        indexRow.Key = itemname

        'get index row of product by name
        Dim index = indexRow.getListIndex()

        'if product name has already in order list then update qty and subtotal else add new item to order list
        If indexRow.hasRow() Then
            'update qty and subtotal
            lvorder.Items(index).SubItems(2).Text += _qty

            'if qty = 0 then remove to list
            If lvorder.Items(index).SubItems(2).Text = 0 Then
                lvorder.Items.RemoveAt(lvorder.SelectedIndices(0))
            End If
        Else
            'add item
            With lvorder.Items.Add(id)
                .SubItems.Add(itemname)
                .SubItems.Add(enterQty)
                .SubItems.Add(enterSN)
            End With
        End If
    End Sub

End Class