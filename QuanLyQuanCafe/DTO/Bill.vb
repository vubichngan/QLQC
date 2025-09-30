Imports System.Runtime.CompilerServices

Public Class Bill
    Private _id As Integer
    Private _dateCheckIn As DateTime?
    Private _dateCheckOut As DateTime?
    Private _idTable As Integer
    Private _idAccount As Integer
    Private _status As String
    Public Sub New(id As Integer, dateCheckIn As DateTime?, dateCheckOut As DateTime?, idTable As Integer, idAccount As Integer, status As String)
        Me._id = id
        Me._dateCheckIn = dateCheckIn
        Me._dateCheckOut = dateCheckOut
        Me._idTable = idTable
        Me._idAccount = idAccount
        Me._status = status
    End Sub

    Public Sub New(row As DataRow)
        Me._id = row("id")
        Me._dateCheckIn = row("dateCheckIn")
        If Not IsDBNull(row("dateCheckOut")) Then
            Me._dateCheckOut = row("dateCheckOut")
        End If
        Me._idTable = row("idTable")
        Me._idAccount = row("idAccount")
        Me._status = row("status")
    End Sub
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            Me._id = value
        End Set
    End Property
    Public Property DateCheckIn() As DateTime?
        Get
            Return _dateCheckIn
        End Get
        Set(value As DateTime?)
            Me._dateCheckIn = value
        End Set
    End Property
    Public Property DateCheckOut() As DateTime?
        Get
            Return _dateCheckOut
        End Get
        Set(value As DateTime?)
            Me._dateCheckOut = value
        End Set
    End Property
    Public Property IdTable() As Integer
        Get
            Return _idTable
        End Get
        Set(value As Integer)
            Me._idTable = value
        End Set
    End Property
    Public Property IdAccount() As Integer
        Get
            Return _idAccount
        End Get
        Set(value As Integer)
            Me._idAccount = value
        End Set
    End Property
    Public Property Status() As String
        Get
            Return _status
        End Get
        Set(value As String)
            Me._status = value
        End Set
    End Property
End Class
