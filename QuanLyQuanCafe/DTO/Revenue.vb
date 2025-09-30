Public Class Revenue
    Private _idBill As Integer
    Private _dateCheckIn As DateTime
    Private _dateCheckOut As DateTime
    Private _nameTable As String
    Private _statusBill As String
    Private _total As Integer

    Public Sub New(idBill As Integer, datecheckIn As DateTime, dateCheckOut As DateTime, nameTable As String, statusBill As String, total As Integer)
        Me._idBill = idBill
        Me._dateCheckIn = datecheckIn
        Me._dateCheckOut = dateCheckOut
        Me._nameTable = nameTable
        Me._statusBill = statusBill
        Me._total = total
    End Sub
    Public Sub New(row As DataRow)
        Me._idBill = row("idBill")
        Me._dateCheckIn = row("dateCheckIn")
        Me._dateCheckOut = row("dateCheckOut")
        Me._nameTable = row("nameTable")
        Me._statusBill = row("statusBill")
        Me._total = row("total")
    End Sub

    Public Property IdBill() As Integer
        Get
            Return _idBill
        End Get
        Set(value As Integer)
            Me._idBill = value
        End Set
    End Property
    Public Property DateCheckIn() As DateTime
        Get
            Return _dateCheckIn
        End Get
        Set(value As DateTime)
            Me._dateCheckIn = value
        End Set
    End Property
    Public Property DateCheckOut() As DateTime
        Get
            Return _dateCheckOut
        End Get
        Set(value As DateTime)
            Me._dateCheckOut = value
        End Set
    End Property
    Public Property NameTable() As String
        Get
            Return _nameTable
        End Get
        Set(value As String)
            Me._nameTable = value
        End Set
    End Property
    Public Property StatusBill() As String
        Get
            Return _statusBill
        End Get
        Set(value As String)
            Me._statusBill = value
        End Set
    End Property
    Public Property Total() As Integer
        Get
            Return _total
        End Get
        Set(value As Integer)
            Me._total = value
        End Set
    End Property
End Class
