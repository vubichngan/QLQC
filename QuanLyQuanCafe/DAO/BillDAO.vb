Imports System.Net.Security

Public Class BillDAO
    Private Shared _instance As BillDAO
    Public Shared Property Instance() As BillDAO
        Get
            If _instance Is Nothing Then
                _instance = New BillDAO
            End If
            Return _instance
        End Get
        Set(value As BillDAO)
            _instance = value
        End Set
    End Property
    Public Function GetUnCheckBillByTableId(id As Integer) As Integer
        Dim data = DataProvider.Instance.ExecuteQuery("USP_GetUnCheckBillByTableId @idTable", New Object() {id})
        If data.Rows.Count > 0 Then
            Dim bill As Bill = New Bill(data.Rows(0))
            Return bill.Id
        End If
        Return -1
    End Function
    Public Function GetMaxIdBill() As Integer
        Try
            Return DataProvider.Instance.ExecuteScalar("Select max(id) from Bill")
        Catch ex As Exception
            Return 1
        End Try
    End Function
    Public Sub InsertBill(idTable As Integer, idAccount As Integer)
        Dim data As Integer = DataProvider.Instance.ExecuteNonQuery("USP_InsertBill @idTable , @idAccount", New Object() {idTable, idAccount})
    End Sub

    Public Sub checkOut(idBill As Integer)
        Dim data As Integer = DataProvider.Instance.ExecuteNonQuery("USP_PayMent @idBill", New Object() {idBill})
    End Sub
    Public Function UpdateBillStatus(status As Integer, id As Integer) As Boolean
        Dim query As String = String.Format("Update Bill set status = {0} where id = {1}", status, id)
        Dim data As Integer = DataProvider.Instance.ExecuteNonQuery(query)
        Return data > 0
    End Function

    Public Function GetCheckCountDrinkByIdBill(idBill As Integer) As String
        Dim data As DataTable = DataProvider.Instance.ExecuteQuery("USP_GetUnCheckQuantityDrinkByIdBill @idBill", New Object() {idBill})
        If data.Rows.Count > 0 Then
            If data.Rows(0).Item(2) < 0 Then
                Dim nameFood As String = data.Rows(0).Item(1)
                Return nameFood
            End If
        End If
        Return 1
    End Function

End Class
