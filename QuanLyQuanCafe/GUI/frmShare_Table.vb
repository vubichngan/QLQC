Imports System.Globalization

Public Class frmShare_Table
    Private Sub frmShare_Table_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllTable()
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

#End Region

#Region "Events"
    Sub btn_Click(sender As Object, e As EventArgs)
        Dim idAccount As Integer = flpAll.Tag
        Dim newTable As TableTotal = sender.tag
        Dim id_oldTable As Integer = Me.TabIndex
        Dim name_oldTable As String = TableTotalDAO.Instance.Get_Name_TableById(id_oldTable)
        Dim ListShareFood As List(Of shareDrink) = Me.Tag
        If newTable.Id = id_oldTable Then
            MessageBox.Show(newTable.Name + " là bàn hiện tại!!!")
        Else
            If (MessageBox.Show("Bạn muốn chuyển từ " + name_oldTable + " sang " + newTable.Name + "?", "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK) Then
                For Each item As shareDrink In ListShareFood
                    Dim id_newBill As Integer = BillDAO.Instance.GetUnCheckBillByTableId(newTable.Id)
                    Dim id_oldBill As Integer = BillDAO.Instance.GetUnCheckBillByTableId(id_oldTable)
                    If id_newBill = -1 Then
                        BillDAO.Instance.InsertBill(newTable.Id, idAccount)
                        id_newBill = BillDAO.Instance.GetMaxIdBill()
                    End If
                    Dim data As Integer = TableTotalDAO.Instance.ShareTable(id_newBill, id_oldBill, item.NewCountDrink, item.OldCountDrink, item.IdDrink)
                    If (data = 0) Then
                        MessageBox.Show("tach ban khong thanh cong!!!")
                    End If
                Next
                Me.Close()
            End If
        End If
    End Sub

#End Region
End Class
