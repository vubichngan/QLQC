Imports System.CodeDom.Compiler
Imports System.Security.Cryptography
Imports System.Text

Public Class AccountDAO
    Private Shared _instance As AccountDAO
    Public Shared Property Instance As AccountDAO
        Get
            If _instance Is Nothing Then
                _instance = New AccountDAO()
            End If
            Return _instance
        End Get
        Set(value As AccountDAO)
            _instance = value
        End Set
    End Property
    Private AccountDAO()

    Public Function HasPass(passWord As String) As String
        Dim temp As Array = ASCIIEncoding.ASCII.GetBytes(passWord)
        Dim hasData As Array = New MD5CryptoServiceProvider().ComputeHash(temp)
        Dim _hasPass As String = ""
        For Each item As Byte In hasData
            _hasPass += item.ToString()
        Next
        Return _hasPass
    End Function
    Public Function Login(userName As String, passWord As String) As Integer
        Dim _hasPass As String = HasPass(passWord)
        Dim query = "USP_Login @userName , @passWord"
        Dim result As DataTable
        result = DataProvider.Instance.ExecuteQuery(query, New Object() {userName, _hasPass})
        If result.Rows.Count > 0 Then
            Dim account As Account = New Account(result.Rows(0))
            Return account.Id
        End If
        Return -1
    End Function

    Public Function TypeAccount(userName As String, passWord As String) As Integer
        Dim _hasPass As String = HasPass(passWord)
        Dim query = "USP_Login @userName , @passWord"
        Dim result As DataTable
        result = DataProvider.Instance.ExecuteQuery(query, New Object() {userName, _hasPass})
        If result.Rows.Count > 0 Then
            Dim account As Account = New Account(result.Rows(0))
            Return account.Type
        End If
        Return -1
    End Function

    Public Function LoadAccount() As List(Of Account)
        Dim accountList As List(Of Account) = New List(Of Account)
        Dim query As String = "select * from Account"
        Dim data As DataTable = DataProvider.Instance.ExecuteQuery(query)
        For Each item As DataRow In data.Rows
            Dim account As Account = New Account(item)
            accountList.Add(account)
        Next
        Return accountList
    End Function

    Public Function InsertAccount(userName As String, passWord As String, type As Integer) As Boolean
        Dim _hasPass As String = HasPass(passWord)
        Dim query As String = String.Format("insert into Account (userName, passWord, type) values (N'{0}','{1}',{2})", userName, _hasPass, type)
        Dim data As Integer = DataProvider.Instance.ExecuteNonQuery(query)
        Return data > 0
    End Function
    Public Function UpdateAccount(userName As String, passWord As String, type As Integer, id As Integer) As Boolean
        Dim _hasPass As String = HasPass(passWord)
        Dim query As String = String.Format("update Account set userName = N'{0}', passWord = '{1}', type = {2} where id = {3}", userName, _hasPass, type, id)
        Dim data As Integer = DataProvider.Instance.ExecuteNonQuery(query)
        Return data > 0
    End Function
    Public Function DeleteAccount(id As Integer) As Boolean
        Dim query As String = String.Format("Delete Account where id = {0}", id)
        Dim data As Integer = DataProvider.Instance.ExecuteNonQuery(query)
        Return data > 0
    End Function
    Public Function SearchAccount(userName As String) As List(Of Account)
        Dim accountList As List(Of Account) = New List(Of Account)
        Dim query As String = String.Format("select * from Account where userName like '%{0}%'", userName)
        Dim data As DataTable = DataProvider.Instance.ExecuteQuery(query)
        For Each item As DataRow In data.Rows
            Dim account As Account = New Account(item)
            accountList.Add(account)
        Next
        Return accountList
    End Function
End Class
