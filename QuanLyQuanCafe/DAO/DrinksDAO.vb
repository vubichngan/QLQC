Public Class DrinksDAO
    Private Shared _instance As DrinksDAO
    Public Shared btnFoodWidth As Integer = 100
    Public Shared btnFoodHeigth As Integer = 100
    Public Shared Property Instance As DrinksDAO
        Get
            If _instance Is Nothing Then
                _instance = New DrinksDAO
            End If
            Return _instance
        End Get
        Set(value As DrinksDAO)
            _instance = value
        End Set
    End Property
    Public Function LoadDrinkByIdCategory(idCategory As Integer) As List(Of Drinks)
        Dim drinkList = New List(Of Drinks)
        Dim data = DataProvider.Instance.ExecuteQuery("USP_GetDrinkByIdCategory @idCategory", New Object() {idCategory})
        For Each item As DataRow In data.Rows
            Dim drink As Drinks = New Drinks(item)
            drinkList.Add(drink)
        Next
        Return drinkList
    End Function

    Public Function GetIdDrinkByName(name As String) As Integer
        Return DataProvider.Instance.ExecuteScalar("select id from Drinks where name= N'" + name + "'")
    End Function

    Public Function LoadDrinkList() As List(Of Drinks)
        Dim drinkList = New List(Of Drinks)
        Dim data As DataTable = DataProvider.Instance.ExecuteQuery("select * from Drinks")
        For Each item As DataRow In data.Rows
            Dim drink As Drinks = New Drinks(item)
            drinkList.Add(drink)
        Next
        Return drinkList
    End Function

    Public Function InsertDrinks(name As String, idCategory As Integer, price As Integer, quantity As Integer) As Boolean
        Dim query As String = String.Format("insert into Drinks (name, idCategory, price, quantity) values (N'{0}',{1},{2},{3})", name, idCategory, price, quantity)
        Dim data As Integer = DataProvider.Instance.ExecuteNonQuery(query)
        Return data > 0
    End Function
    Public Function UpdateDrinks(id As Integer, name As String, idCategory As Integer, price As Integer, quantity As Integer) As Boolean
        Dim query As String = String.Format("update Drinks set name = N'{1}', idCategory = {2}, price = {3}, quantity = {4} where id = {0}", id, name, idCategory, price, quantity)
        Dim data As Integer = DataProvider.Instance.ExecuteNonQuery(query)
        Return data > 0
    End Function

    Public Function DeleteDrinks(id As Integer) As Boolean
        Dim query As String = String.Format("Delete Drinks where id = {0}", id)
        Dim data As Integer = DataProvider.Instance.ExecuteNonQuery(query)
        Return data > 0
    End Function

    Public Function SearchDrinks(name As String) As List(Of Drinks)
        Dim drinkList As List(Of Drinks) = New List(Of Drinks)
        Dim query As String = String.Format("select * from Drinks where name like N'%{0}%'", name)
        Dim data As DataTable = DataProvider.Instance.ExecuteQuery(query)
        For Each item As DataRow In data.Rows
            Dim drink As Drinks = New Drinks(item)
            drinkList.Add(drink)
        Next
        Return drinkList
    End Function
End Class
