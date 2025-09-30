Public Class TableDAO
    Private Shared _instance As TableDAO
    Public Shared Property Instance As TableDAO
        Get
            If _instance Is Nothing Then
                _instance = New TableDAO
            End If
            Return _instance
        End Get
        Set(value As TableDAO)
            _instance = value
        End Set
    End Property
    Public Function LoadTable() As List(Of Table)
        Dim tableList As List(Of Table) = New List(Of Table)
        Dim data As DataTable = DataProvider.Instance.ExecuteQuery("select * from DrinkTable")
        For Each item As DataRow In data.Rows
            Dim table As Table = New Table(item)
            tableList.Add(table)
        Next
        Return tableList
    End Function

    Public Function InsertTable(name As String, status As String) As Boolean
        Dim query As String = String.Format("Insert into DrinkTable (name, status) values (N'{0}',N'{1}')", name, status)
        Dim data As Integer = DataProvider.Instance.ExecuteNonQuery(query)
        Return data > 0
    End Function

    Public Function UpdateTable(name As String, status As String, id As String) As Boolean
        Dim query As String = String.Format("update DrinkTable set name = N'{0}', status = N'{1}' where id = {2}", name, status, id)
        Dim data As Integer = DataProvider.Instance.ExecuteNonQuery(query)
        Return data > 0
    End Function

    Public Function DeleteTable(id As String) As Boolean
        Dim query As String = String.Format("Delete DrinkTable where id = {0}", id)
        Dim data As Integer = DataProvider.Instance.ExecuteNonQuery(query)
        Return data > 0
    End Function

    Public Function SearchTable(name As String) As List(Of Table)
        Dim tableList As List(Of Table) = New List(Of Table)
        Dim query As String = String.Format("select * from DrinkTable where name like N'%{0}%'", name)
        Dim data As DataTable = DataProvider.Instance.ExecuteQuery(query)
        For Each item As DataRow In data.Rows
            Dim table As Table = New Table(item)
            tableList.Add(table)
        Next
        Return tableList
    End Function
End Class
