Public Class Drinks
    Private _id As Integer
    Private _name As String
    Private _idCategory As Integer
    Private _price As Integer
    Private _quantity As Integer

    Public Sub New(id As Integer, name As String, idCategory As Integer, price As Integer, quantity As Integer)
        Me._id = id
        Me._name = name
        Me._idCategory = idCategory
        Me._price = price
        Me._quantity = quantity
    End Sub

    Public Sub New(row As DataRow)
        Me._id = row("id")
        Me._name = row("name")
        Me._idCategory = row("idCategory")
        Me._price = row("price")
        Me._quantity = row("quantity")
    End Sub

    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property IdCategory() As Integer
        Get
            Return _idCategory
        End Get
        Set(value As Integer)
            _idCategory = value
        End Set
    End Property
    Public Property Price() As Integer
        Get
            Return _price
        End Get
        Set(value As Integer)
            _price = value
        End Set
    End Property

    Public Property Quantity() As Integer
        Get
            Return _quantity
        End Get
        Set(value As Integer)
            _quantity = value
        End Set
    End Property
End Class
