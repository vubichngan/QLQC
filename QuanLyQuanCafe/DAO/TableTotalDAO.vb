Public Class TableTotalDAO
    Private Shared _instance As TableTotalDAO
    Public Shared Property Instance As TableTotalDAO
        Get
            If _instance Is Nothing Then
                _instance = New TableTotalDAO
            End If
            Return _instance
        End Get
        Set(value As TableTotalDAO)
            _instance = value
        End Set
    End Property

    Public Shared TableWidth As Integer = 120
    Public Shared TableHeigth As Integer = 120
    'Private TableDAO()

    Public Function LoadTableList() As List(Of TableTotal)
        Dim tableList = New List(Of TableTotal)
        Dim data As DataTable = DataProvider.Instance.ExecuteQuery("USP_GetTableListAndTotal")
        For Each item As DataRow In data.Rows
            Dim table As TableTotal = New TableTotal(item)
            tableList.Add(table)
        Next
        Return tableList
    End Function

    Public Function Load_Status_TableById(id As Integer) As String
        Dim data As DataTable = DataProvider.Instance.ExecuteQuery("USP_GetTableAndTotalById @id", New Object() {id})
        If data.Rows.Count > 0 Then
            Dim table As TableTotal = New TableTotal(data.Rows(0))
            Return table.Status
        End If
        Return 0
    End Function

    Public Function SwichTable(idNewTable As Integer, idOldTable As Integer, status As String) As Integer
        Dim data As Integer = DataProvider.Instance.ExecuteNonQuery("USP_SwichTable @newIdTable , @oldIdTable , @newStatus", New Object() {idNewTable, idOldTable, status})
        If data > 0 Then
            Return data
        End If
        Return 0
    End Function

    Public Function ShareTable(id_NewBill As Integer, id_OldBill As Integer, newCount As Integer, oldCount As Integer, idDrink As Integer) As Integer
        Dim data As Integer = DataProvider.Instance.ExecuteNonQuery("USP_ShareTable @new_idbill , @old_idbill , @newCount , @oldCount , @idfood", New Object() {id_NewBill, id_OldBill, newCount, oldCount, idDrink})
        If data > 0 Then
            Return data
        End If
        Return 0
    End Function
    Public Function Get_Name_TableById(id As Integer) As String
        Dim data As DataTable = DataProvider.Instance.ExecuteQuery("USP_GetTableAndTotalById @id", New Object() {id})
        If data.Rows.Count > 0 Then
            Dim table As TableTotal = New TableTotal(data.Rows(0))
            Return table.Name
        End If
        Return 0
    End Function


End Class
