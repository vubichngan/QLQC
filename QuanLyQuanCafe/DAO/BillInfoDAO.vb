Public Class BillInfoDAO
    Private Shared _instance As BillInfoDAO
    Public Shared Property Instance() As BillInfoDAO
        Get
            If _instance Is Nothing Then
                _instance = New BillInfoDAO
            End If
            Return _instance
        End Get
        Set(value As BillInfoDAO)
            _instance = value
        End Set
    End Property

    Public Sub InsertBillInfo(idBill As Integer, idDrink As Integer, count As Integer)
        DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @idBill , @idFood , @count ", New Object() {idBill, idDrink, count})
    End Sub

    Public Sub DeleteBillInfo(idBill As Integer, idDrink As Integer)
        DataProvider.Instance.ExecuteNonQuery("USP_DeleteBillInfo @idBill , @idFood", New Object() {idBill, idDrink})
    End Sub
End Class
