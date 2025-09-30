Imports System.Data
Imports System.Data.SqlClient

Public Class DataProvider
    Private Shared _instance As DataProvider = Nothing
    Public Shared Property Instance As DataProvider
        Get
            If _instance Is Nothing Then
                _instance = New DataProvider()
            End If
            Return _instance
        End Get
        Private Set
            _instance = Value
        End Set
    End Property
    Private DataProvider()

    Private connectionSTR As String = "Data Source=LAPTOP-NCI6DRUF\NGANVU;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;Encrypt=False"
    Public Function ExecuteQuery(query As String, parameter() As Object) As DataTable
        Dim data = New DataTable()
        Using conn As New SqlConnection(connectionSTR)
            conn.Open()
            Dim command As SqlCommand
            command = New SqlCommand(query, conn)
            If Not parameter Is Nothing Then
                Dim listPara() As String = query.Split(" ")
                Dim i As Integer = 0
                For Each item As String In listPara
                    If item.Contains("@") Then
                        command.Parameters.AddWithValue(item, parameter(i))
                        i += 1
                    End If
                Next
            End If
            Dim adapter As SqlDataAdapter
            adapter = New SqlDataAdapter(command)
            adapter.Fill(data)
            conn.Close()
        End Using
        Return data
    End Function

    Public Function ExecuteNonQuery(query As String, parameter() As Object) As Integer
        Dim data As Integer = 0
        Using conn As New SqlConnection(connectionSTR)
            conn.Open()
            Dim command As New SqlCommand(query, conn)
            If Not parameter Is Nothing Then
                Dim listPara() As String = query.Split(" ")
                Dim i As Integer = 0
                For Each item As String In listPara
                    If item.Contains("@") Then
                        command.Parameters.AddWithValue(item, parameter(i))
                        i += 1
                    End If
                Next
            End If
            data = command.ExecuteNonQuery()
            conn.Close()
        End Using
        Return data
    End Function

    Public Function ExecuteScalar(query As String, parameter() As Object) As Integer
        Dim data As Integer = 0
        Using conn As New SqlConnection(connectionSTR)
            conn.Open()
            Dim command As New SqlCommand(query, conn)
            If Not parameter Is Nothing Then
                Dim listPara() As String = query.Split(" ")
                Dim i As Integer = 0
                For Each item As String In listPara
                    If item.Contains("@") Then
                        command.Parameters.AddWithValue(item, parameter(i))
                        i += 1
                    End If
                Next
            End If
            data = command.ExecuteScalar()
            conn.Close()
        End Using
        Return data
    End Function

    Public Function ExecuteQuery(query As String) As DataTable
        Dim data = New DataTable()
        Using conn As New SqlConnection(connectionSTR)
            conn.Open()
            Dim command As SqlCommand
            command = New SqlCommand(query, conn)
            Dim adapter As SqlDataAdapter
            adapter = New SqlDataAdapter(command)
            adapter.Fill(data)
            conn.Close()
        End Using
        Return data
    End Function

    Public Function ExecuteNonQuery(query As String) As Integer
        Dim data As Integer = 0
        Using conn As New SqlConnection(connectionSTR)
            conn.Open()
            Dim command As New SqlCommand(query, conn)
            data = command.ExecuteNonQuery()
            conn.Close()
        End Using
        Return data
    End Function

    Public Function ExecuteScalar(query As String) As Integer
        Dim data As Integer = 0
        Using conn As New SqlConnection(connectionSTR)
            conn.Open()
            Dim command As New SqlCommand(query, conn)
            data = command.ExecuteScalar()
            conn.Close()
        End Using
        Return data
    End Function


End Class
