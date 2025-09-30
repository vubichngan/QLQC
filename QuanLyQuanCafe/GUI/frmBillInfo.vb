Imports System.Globalization

Public Class frmBillInfo
    Private Sub frmBillInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id As Integer = Me.TabIndex
        If BillDAO.Instance.UpdateBillStatus(2, id) Then
            MessageBox.Show("Hủy hóa đơn thành công")
            Me.Close()
        End If
    End Sub

    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        Me.Close()
    End Sub


#Region "Method"
    Sub Load_()
        Dim culture As CultureInfo = New CultureInfo("vi-VN")
        Dim revenue As Revenue = RevenueDAO.Instance.GetBillById(Me.TabIndex)
        lblNameTable.Text = revenue.NameTable
        lblIdBill.Text = revenue.IdBill
        lblTotal.Text = revenue.Total.ToString("c", culture)
        lblCheckIn.Text = revenue.DateCheckIn
        lblCheckOut.Text = revenue.DateCheckOut
        lblStatus.Text = revenue.StatusBill
        If lblStatus.Text = "Hoàn thành" Then
            lblStatus.ForeColor = System.Drawing.Color.LimeGreen
        Else
            lblStatus.ForeColor = System.Drawing.Color.Red
            btnDelete.Enabled = False
        End If
        lblTotal1.Text = revenue.Total.ToString("c", culture)
        ShowBill()
        If Me.Tag = "ThanhToan" Then
            btnDelete.Visible = False
            btnCancle.Visible = True
        Else
            btnDelete.Visible = True
            btnCancle.Visible = False
        End If
    End Sub
    Sub ShowBill()
        Dim culture As CultureInfo = New CultureInfo("vi-VN")
        Dim menuList As List(Of Menu) = MenuDAO.Instance.LoadMenuByIdBill(Me.TabIndex)
        For Each item As Menu In menuList
            Dim flp As FlowLayoutPanel = New FlowLayoutPanel()
            flp.Height = 40
            flp.Width = flpBillList.Width
            flp.BackColor = Color.White
            Dim lblName As Label = New Label()
            Dim lblTotal As Label = New Label()
            Dim lblCount As Label = New Label()

            lblName.Height = 40
            lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            lblName.Text = item.Name

            lblCount.Width = 150
            lblCount.Height = 40
            lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            lblCount.Text = item.Count.ToString() + Environment.NewLine + item.Price.ToString("c", culture)

            lblTotal.Width = 60
            lblTotal.Height = 40
            lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            lblTotal.Text = item.Total.ToString("c", culture)

            flp.Controls.Add(lblName)
            flp.Controls.Add(lblCount)
            flp.Controls.Add(lblTotal)
            flpBillList.Controls.Add(flp)
        Next

    End Sub



#End Region
End Class