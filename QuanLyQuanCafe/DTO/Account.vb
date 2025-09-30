Public Class Account
    Private _id As Integer
    Private _userName As String
    Private _passWord As String
    Private _type As Integer
    Public Sub New(id As Integer, userName As String, passWord As String, type As Integer)
        Me._id = id
        Me._userName = userName
        Me._passWord = passWord
        Me._type = type
    End Sub
    Public Sub New(row As DataRow)
        Me._id = row("id")
        Me._userName = row("userName")
        Me._passWord = row("passWord")
        Me._type = row("type")
    End Sub
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property UserName() As String
        Get
            Return _userName
        End Get
        Set(value As String)
            _userName = value
        End Set
    End Property
    Public Property PassWord() As String
        Get
            Return _passWord
        End Get
        Set(value As String)
            _passWord = value
        End Set
    End Property

    Public Property Type() As Integer
        Get
            Return _type
        End Get
        Set(value As Integer)
            Me._type = value
        End Set
    End Property
End Class
