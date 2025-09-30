Public Class Menu
    Private _name As String
    Private _price As Integer
    Private _count As Integer
    Private _total As Integer

    Public Sub New(name As String, price As Integer, count As Integer, total As Integer)
        Me._name = name
        Me._price = price
        Me._count = count
        Me._total = total
    End Sub
    Public Sub New(row As DataRow)
        Me._name = row("name")
        Me._price = row("price")
        Me._count = row("count")
        Me._total = row("total")
    End Sub

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
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

    Public Property Count() As Integer
        Get
            Return _count
        End Get
        Set(value As Integer)
            _count = value
        End Set
    End Property
    Public Property Total() As Integer
        Get
            Return _total
        End Get
        Set(value As Integer)
            _total = value
        End Set
    End Property

End Class
