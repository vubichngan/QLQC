Public Class Table
    Private _Id As Integer
    Private _Name As String
    Private _Status As String
    Public Sub New(id As Integer, name As String, status As String)
        Me._Id = id
        Me._Name = name
        Me._Status = status
    End Sub

    Public Sub New(row As DataRow)
        Me._Id = row("id")
        Me._Name = row("name")
        Me._Status = row("status")
    End Sub

    Public Property Status() As String
        Get
            Return _Status
        End Get
        Set(value As String)
            _Status = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property
End Class
