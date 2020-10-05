
Public Class IndexRow
    Protected dataGridView As DataGridView
    Public listView As ListView
    Protected _index As Integer
    Private _DataGridView As DataGridView

    Public Function GetDataGridView() As DataGridView
        Return _DataGridView
    End Function

    Public Sub SetDataGridView(AutoPropertyValue As DataGridView)
        _DataGridView = AutoPropertyValue
    End Sub

    Public _ListView As ListView

    Public Function GetListView() As ListView
        Return _ListView
    End Function

    Public Sub SetListView(AutoPropertyValue As ListView)
        _ListView = AutoPropertyValue
    End Sub

    Public Property Key As String
    Public Property Column As Integer

    Public Function getListIndex() As Integer

    End Function
    Public Function getDataGridIndex() As Integer

    End Function
    Public Function hasRow() As Boolean

    End Function

End Class
