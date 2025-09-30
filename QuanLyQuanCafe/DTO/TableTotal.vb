Public Class TableTotal
    Private _Id As Integer
    Private _Name As String
    Private _Status As String
    Private _Total As Integer
    Public Sub New(id As Integer, name As String, status As String, total As Integer)
        Me._Id = id
        Me._Name = name
        Me._Status = status
        Me._Total = total
    End Sub

    'Public Sub New(row As DataRow)
    '    Me._Id = row("id")
    '    Me._Name = row("name")
    '    Me._Status = row("status")
    'End Sub

    Public Sub New(row As DataRow)
        Me._Id = row("id")
        Me._Name = row("name")
        Me._Status = row("status")
        Me._Total = row("total")
    End Sub

    Public Property Total() As Integer
        Get
            Return _Total
        End Get
        Set(value As Integer)
            _Total = value
        End Set
    End Property
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
