Public Class DrinkCategory
    Private _id As Integer
    Private _name As String

    Public Sub New(id As Integer, name As String)
        Me._id = id
        Me._name = name
    End Sub

    Public Sub New(row As DataRow)
        Me._id = row("id")
        Me._name = row("name")
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
End Class
