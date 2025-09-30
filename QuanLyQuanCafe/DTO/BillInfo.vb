Public Class BillInfo
    Private _id As Integer
    Private _idBill As Integer
    Private _idDrink As Integer
    Private _count As Integer
    Public Sub New(id, idBill, idDrink, count)
        Me._id = id
        Me._idBill = idBill
        Me._idDrink = idDrink
        Me._count = count
    End Sub

    Public Sub New(row As DataRow)
        Me._id = row("id")
        Me._idBill = row("idBill")
        Me._idDrink = row("idDrink")
        Me._count = row("count")
    End Sub

    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            Me._id = value
        End Set
    End Property

    Public Property IdBill() As Integer
        Get
            Return _idBill
        End Get
        Set(value As Integer)
            Me._idBill = value
        End Set
    End Property

    Public Property Count() As Integer
        Get
            Return _count
        End Get
        Set(value As Integer)
            Me._count = Count
        End Set
    End Property

    Public Property IdDrink As Integer
        Get
            Return _idDrink
        End Get
        Set(value As Integer)
            _idDrink = value
        End Set
    End Property
End Class
