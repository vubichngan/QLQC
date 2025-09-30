Public Class DrinkCategoryDAO
    Private Shared _instance As DrinkCategoryDAO
    Public Shared Property Instance As DrinkCategoryDAO
        Get
            If _instance Is Nothing Then
                _instance = New DrinkCategoryDAO()
            End If
            Return _instance
        End Get
        Set(value As DrinkCategoryDAO)
            _instance = value
        End Set
    End Property

    Public Function SeachCategoryByName(name As String) As List(Of DrinkCategory)
        Dim CategoryList As List(Of DrinkCategory) = New List(Of DrinkCategory)
        Dim query As String = String.Format("select * from DrinkCategory where name like N'%{0}%'", name)
        Dim data As DataTable = DataProvider.Instance.ExecuteQuery(query)
        For Each item As DataRow In data.Rows
            Dim category = New DrinkCategory(item)
            CategoryList.Add(category)
        Next
        Return CategoryList
    End Function
    Public Function LoadDrinkCategoryList() As List(Of DrinkCategory)
        Dim drinkCategoryList = New List(Of DrinkCategory)
        Dim data = DataProvider.Instance.ExecuteQuery("USP_GetDrinkCategoryList")
        For Each item As DataRow In data.Rows
            Dim foodCategory = New DrinkCategory(item)
            drinkCategoryList.Add(foodCategory)
        Next
        Return drinkCategoryList
    End Function

    Public Function InsertDrinkCategory(name As String) As Boolean
        Dim query As String = String.Format("insert into DrinkCategory (name) values (N'{0}')", name)
        Dim data As Integer = DataProvider.Instance.ExecuteNonQuery(query)
        Return data > 0
    End Function

    Public Function UpdateDrinkCategory(name As String, id As Integer) As Boolean
        Dim query As String = String.Format("Update DrinkCategory set name=N'{0}' where id={1}", name, id)
        Dim data As Integer = DataProvider.Instance.ExecuteNonQuery(query)
        Return data > 0
    End Function

    Public Function DeleteDrinkCategory(id As Integer) As Boolean
        Dim query As String = String.Format("Delete DrinkCategory where id={0}", id)
        Dim data As String = DataProvider.Instance.ExecuteNonQuery(query)
        Return data > 0
    End Function

    Public Function LoadCategoryById(id As Integer) As DrinkCategory
        Dim category As DrinkCategory = Nothing
        Dim query As String = String.Format("select * from DrinkCategory where id = {0}", id)
        Dim data As DataTable = DataProvider.Instance.ExecuteQuery(query)
        For Each item As DataRow In data.Rows
            category = New DrinkCategory(item)
        Next
        Return category
    End Function
End Class
