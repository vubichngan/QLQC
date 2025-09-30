Imports System.Globalization

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllTable()
        LoadUseTable()
        If Me.TabIndex = 0 Then
            btnAdmin.Visible = False
        End If
    End Sub
#Region "Method"
    Sub LoadAllTable()
        Dim tableList As List(Of TableTotal) = TableTotalDAO.Instance.LoadTableList()
        Dim culture As CultureInfo = New CultureInfo("vi-VN")
        For Each item As TableTotal In tableList
            Dim btn As New Button()
            btn.Width = TableTotalDAO.TableWidth
            btn.Height = TableTotalDAO.TableHeigth
            btn.Text = item.Name + Environment.NewLine + item.Total.ToString("c", culture)
            AddHandler btn.Click, AddressOf btn_Click
            btn.Tag = item
            Select Case item.Status
                Case "Có người"
                    btn.BackColor = Color.Gold
            End Select
            flpAll.Controls.Add(btn)
        Next
    End Sub

    Sub LoadUseTable()
        Dim tableList As List(Of TableTotal) = TableTotalDAO.Instance.LoadTableList()
        Dim culture As CultureInfo = New CultureInfo("vi-VN")
        For Each item As TableTotal In tableList
            If item.Status = "Có người" Then
                Dim btn As New Button()
                btn.BackColor = Color.Gold
                btn.Width = TableTotalDAO.TableWidth
                btn.Height = TableTotalDAO.TableHeigth
                btn.Text = item.Name + Environment.NewLine + item.Total.ToString("c", culture)
                AddHandler btn.Click, AddressOf btn_Click
                btn.Tag = item
                flpUse.Controls.Add(btn)
            End If
        Next
    End Sub
#End Region

#Region "Events"
    Sub btn_Click(sender As Object, e As EventArgs)
        Dim frmTI As frmTableInfo
        frmTI = New frmTableInfo()
        frmTI.tlsMenu.Tag = Me.Tag
        frmTI.Tag = sender.tag
        Me.Hide()
        frmTI.ShowDialog()
        Me.Controls.Clear() 'removes all the controls on the form
        Me.InitializeComponent() 'load all the controls again
        Me.frmMain_Load(e, e)
        Me.Show()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim frmAdm As frmAdmin = New frmAdmin()
        frmAdm.Tag = Me.Tag
        frmAdm.ShowDialog()
        Me.Controls.Clear() 'removes all the controls on the form
        Me.InitializeComponent() 'load all the controls again
        Me.frmMain_Load(e, e)
        Me.Show()
    End Sub

#End Region

End Class
