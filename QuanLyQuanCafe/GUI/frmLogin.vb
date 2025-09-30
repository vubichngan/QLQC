Imports Microsoft.VisualBasic.ApplicationServices

Public Class frmLogin
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Application.Exit()
    End Sub


    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        Dim userName As String = txtMaND.Text
        Dim passWord As String = txtMatKhau.Text
        Dim idAccount As Integer = AccountDAO.Instance.Login(userName, passWord)
        If idAccount <> -1 Then
            Dim type As Integer = AccountDAO.Instance.TypeAccount(userName, passWord)
            Dim frmUF = New frmMain()
            frmUF.Tag = idAccount
            frmUF.TabIndex = type
            Me.Hide()
            frmUF.ShowDialog()
            Me.Show()
        Else
            MessageBox.Show("Tên hoặc mật khẩu đã nhập không đúng!")
        End If
    End Sub


End Class