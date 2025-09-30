Public Class RevenueDAO
    Private Shared _instance As RevenueDAO
    Public Shared Property Instance() As RevenueDAO
        Get
            If _instance Is Nothing Then
                _instance = New RevenueDAO()
            End If
            Return _instance
        End Get
        Set(value As RevenueDAO)
            _instance = value
        End Set
    End Property

    Public Function GetBillList() As List(Of Revenue)
        Dim revenueList As List(Of Revenue) = New List(Of Revenue)
        Dim data As DataTable = DataProvider.Instance.ExecuteQuery("USP_GetBillList")
        For Each item As DataRow In data.Rows
            Dim revenue As Revenue = New Revenue(item)
            revenueList.Add(revenue)
        Next
        Return revenueList
    End Function

    Public Function GetBillByDate(dateCheckIn As DateTime, dateCheckOut As DateTime) As List(Of Revenue)
        Dim revenueList As List(Of Revenue) = New List(Of Revenue)
        Dim data As DataTable = DataProvider.Instance.ExecuteQuery("USP_GetBillByDate @dateCheckIn , @dateCheckOut ", New Object() {dateCheckIn, dateCheckOut})
        For Each item As DataRow In data.Rows
            Dim revenue As Revenue = New Revenue(item)
            revenueList.Add(revenue)
        Next
        Return revenueList
    End Function

    Public Function GetBillById(idBill As Integer) As Revenue
        Dim revenue As Revenue = Nothing
        Dim data As DataTable = DataProvider.Instance.ExecuteQuery("USP_GetBillById @idBill ", New Object() {idBill})
        If data.Rows.Count > 0 Then
            revenue = New Revenue(data.Rows(0))
        End If
        Return revenue
    End Function
End Class
