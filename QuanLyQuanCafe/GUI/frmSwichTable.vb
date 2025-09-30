Imports System.Diagnostics.Eventing.Reader
Imports System.Globalization

Public Class frmSwichTable
    Private Sub frmSwichTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim newTable As TableTotal = sender.tag
        Dim oldTable As TableTotal = Me.Tag
        If newTable.Id = oldTable.Id Then
            MessageBox.Show(newTable.Name + " là bàn hiện tại!!!")
        Else
            If (MessageBox.Show("Bạn muốn chuyển từ " + oldTable.Name + " sang " + newTable.Name + "?", "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK) Then
                Dim data As Integer = TableTotalDAO.Instance.SwichTable(newTable.Id, oldTable.Id, newTable.Status)
                If (data > 0) Then
                    Me.Close()
                End If
            End If
        End If
    End Sub

    'Private Sub InitializeComponent()
    '    Me.SuspendLayout()
    '    '
    '    'frmSwichTable
    '    '
    '    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    '    Me.ClientSize = New System.Drawing.Size(1039, 713)
    '    Me.Name = "frmSwichTable"
    '    Me.ResumeLayout(False)
    '    Me.PerformLayout()

    'End Sub



    'Private Sub InitializeComponent()
    '    Me.SuspendLayout()
    '    '
    '    'frmSwichTable
    '    '
    '    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    '    Me.ClientSize = New System.Drawing.Size(1039, 713)
    '    Me.Name = "frmSwichTable"
    '    Me.ResumeLayout(False)
    '    Me.PerformLayout()

    'End Sub

#End Region

End Class
