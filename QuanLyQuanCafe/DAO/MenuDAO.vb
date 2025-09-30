Public Class MenuDAO
    Private Shared _instance As MenuDAO
    Public Shared Property Instance As MenuDAO
        Get
            If _instance Is Nothing Then
                _instance = New MenuDAO()
            End If
            Return _instance
        End Get
        Set(value As MenuDAO)
            _instance = value
        End Set
    End Property

    Public Function LoadMenuByIdTable(idTable) As List(Of Menu)
        Dim menuList = New List(Of Menu)
        Dim data = DataProvider.Instance.ExecuteQuery("USP_GetDrinkByIdTable @idTable", New Object() {idTable})
        For Each item As DataRow In data.Rows
            Dim menu = New Menu(item)
            menuList.Add(menu)
        Next
        Return menuList
    End Function

    Public Function LoadMenuByIdBill(idBill As Integer) As List(Of Menu)
        Dim menuList = New List(Of Menu)
        Dim data = DataProvider.Instance.ExecuteQuery("USP_GetDrinkByIdBill @idBill", New Object() {idBill})
        For Each item As DataRow In data.Rows
            Dim menu = New Menu(item)
            menuList.Add(menu)
        Next
        Return menuList
    End Function
End Class
