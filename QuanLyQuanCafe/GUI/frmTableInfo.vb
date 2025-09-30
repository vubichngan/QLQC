Imports System.Globalization
Imports System.Net.WebRequestMethods
Imports System.Windows.Forms.VisualStyles

Public Class frmTableInfo
    Private Sub frmTableInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllFoodCategory()
        ShowBill()
    End Sub

#Region "Method"
    Sub ShowBill()
        lblTableName.Text = Me.Tag.name
        Dim total As Integer = 0
        Dim count As Integer = 0
        Dim culture As CultureInfo = New CultureInfo("vi-VN")
        Dim menuList As List(Of Menu) = MenuDAO.Instance.LoadMenuByIdTable(Me.Tag.id)
        For Each item As Menu In menuList
            Dim idFood As Integer = DrinksDAO.Instance.GetIdDrinkByName(item.Name)
            Dim flp As FlowLayoutPanel = New FlowLayoutPanel()
            flp.Height = 40
            flp.Width = flpBill.Width
            flp.BackColor = Color.White
            Dim lblName As Label = New Label()
            Dim lblTotal As Label = New Label()
            Dim lblCount As Label = New Label()
            Dim btnIn As Button = New Button()
            Dim btnDe As Button = New Button()
            Dim btnDelete As Button = New Button()
            lblName.BackColor = Color.Aqua
            'lblName.Width = 80
            lblName.Height = 40
            lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            lblName.Text = item.Name + Environment.NewLine + item.Price.ToString("c", culture)

            lblCount.Width = 20
            lblCount.Height = 40
            lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            lblCount.Text = item.Count

            lblTotal.Width = 60
            lblTotal.Height = 40
            lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            lblTotal.Text = item.Total.ToString("c", culture)

            btnDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            btnDe.Size = New System.Drawing.Size(40, 32)
            btnDe.Text = "-"
            AddHandler btnDe.Click, AddressOf btnDe_Click
            btnDe.Tag = idFood

            btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            btnDelete.Size = New System.Drawing.Size(35, 35)
            btnDelete.Image = Global.QuanLyQuanCafe.My.Resources.Resources.trash_can
            AddHandler btnDelete.Click, AddressOf btnDelete_Click
            btnDelete.Tag = idFood

            btnIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            btnIn.Size = New System.Drawing.Size(40, 32)
            btnIn.Text = "+"
            AddHandler btnIn.Click, AddressOf btnIn_Click
            btnIn.Tag = idFood


            flp.Controls.Add(btnDelete)
            flp.Controls.Add(lblName)
            flp.Controls.Add(btnDe)
            flp.Controls.Add(lblCount)
            flp.Controls.Add(btnIn)
            flp.Controls.Add(lblTotal)
            flpBill.Controls.Add(flp)
            total = total + item.Total
            count = count + item.Count
        Next
        lblAllTotal.Text = total.ToString("c", culture)
        btnCount.Text = count
        'tlsMenu.Tag = ""
    End Sub

    Sub AddFood(idFood As Integer, countFood As Integer)
        Dim idBill As Integer
        Dim idAccount As Integer = tlsMenu.Tag
        idBill = BillDAO.Instance.GetUnCheckBillByTableId(Me.Tag.id)
        If idBill = -1 Then
            BillDAO.Instance.InsertBill(Me.Tag.id, idAccount)
            BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIdBill(), idFood, 1)
        Else
            BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, countFood)
        End If
        flpBill.Controls.Clear()
        ShowBill()
    End Sub
    Sub LoadAllFoodCategory()
        Dim foodCategoryList As List(Of DrinkCategory) = DrinkCategoryDAO.Instance.LoadDrinkCategoryList()
        Dim tabFoodCategory = New TabControl()
        pnlMenu.Controls.Add(tabFoodCategory)
        tabFoodCategory.Width = pnlMenu.Width
        tabFoodCategory.Height = pnlMenu.Height
        For Each item As DrinkCategory In foodCategoryList

            Dim tbpFoodCategory = New TabPage()

            tbpFoodCategory.Tag = item
            tbpFoodCategory.Text = item.Name
            tabFoodCategory.TabPages.Add(tbpFoodCategory)

            Dim flp = New FlowLayoutPanel()
            flp.Width = tbpFoodCategory.Width
            flp.Height = tbpFoodCategory.Height

            LoadFoodByIdCategory(item.Id, flp)

            tbpFoodCategory.Controls.Add(flp)
        Next
    End Sub
    Sub LoadFoodByIdCategory(idCategory As Integer, flp As FlowLayoutPanel)
        Dim culture As CultureInfo = New CultureInfo("vi-VN")
        Dim foodList As List(Of Drinks) = DrinksDAO.Instance.LoadDrinkByIdCategory(idCategory)
        For Each item As Drinks In foodList
            Dim btn As Button
            btn = New Button()
            btn.Width = DrinksDAO.btnFoodWidth
            btn.Height = DrinksDAO.btnFoodHeigth
            'btn.Text = idCategory
            btn.Text = item.Name + Environment.NewLine + item.Price.ToString("c", culture)
            AddHandler btn.Click, AddressOf btnAddFood_Click
            btn.Tag = item.Id
            flp.Controls.Add(btn)
        Next
    End Sub
#End Region

#Region "Events"
    Sub btnAddFood_Click(sender As Object, e As EventArgs)
        AddFood(sender.tag, 1)
    End Sub


    Sub btnIn_Click(sender As Object, e As EventArgs)
        AddFood(sender.tag, 1)
    End Sub

    Sub btnDe_Click(sender As Object, e As EventArgs)
        AddFood(sender.tag, -1)
    End Sub

    Private Sub btnReply_Click(sender As Object, e As EventArgs) Handles btnReply.Click
        Me.Close()
    End Sub

    Sub btnDelete_Click(sender As Object, e As EventArgs)
        Dim idBill As Integer
        idBill = BillDAO.Instance.GetUnCheckBillByTableId(Me.Tag.id)
        BillInfoDAO.Instance.DeleteBillInfo(idBill, sender.tag)
        flpBill.Controls.Clear()
        ShowBill()
    End Sub

    Private Sub btnThanhToan_Click(sender As Object, e As EventArgs) Handles btnThanhToan.Click
        Dim idBill As Integer = BillDAO.Instance.GetUnCheckBillByTableId(Me.Tag.Id)
        If (idBill <> -1) Then
            If (MessageBox.Show("Bạn có chắc muốn thanh toán hóa đơn của bàn " + Me.Tag.Name + "?", "Thông báo", MessageBoxButtons.OKCancel) = System.Windows.Forms.DialogResult.OK) Then
                Dim nameFood As String = BillDAO.Instance.GetCheckCountDrinkByIdBill(idBill)
                If nameFood = "1" Then
                    BillDAO.Instance.checkOut(idBill)
                    Dim frmBillIf As frmBillInfo = New frmBillInfo()
                    frmBillIf.TabIndex = idBill
                    frmBillIf.Tag = "ThanhToan"
                    frmBillIf.ShowDialog()
                    flpBill.Controls.Clear()
                    ShowBill()
                Else
                    MessageBox.Show(nameFood & " không đủ số lượng tồn kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
        'BillDAO.Instance.checkOut(idBill)
    End Sub

    Private Sub menuItemCB_Click(sender As Object, e As EventArgs) Handles menuItemCB.Click
        Dim status As String = TableTotalDAO.Instance.Load_Status_TableById(Me.Tag.id)
        If status <> "0" Then
            Dim frmTable As frmSwichTable = New frmSwichTable()
            frmTable.Tag = Me.Tag
            frmTable.tabUser.TabPages.Remove(frmTable.tbpUse)
            Me.Hide()
            frmTable.ShowDialog()
            Me.Show()
            flpBill.Controls.Clear()
            ShowBill()
        Else
            MessageBox.Show("Bạn hiện tại đang trống không thể chuyển bàn!")
        End If

    End Sub

    Private Sub MenuItemTB_Click(sender As Object, e As EventArgs) Handles MenuItemTB.Click
        Dim status As String = TableTotalDAO.Instance.Load_Status_TableById(Me.Tag.id)
        If status <> "0" Then
            Dim frmShare As frmShareTable = New frmShareTable()
            'Dim menuList As List(Of Menu) = MenuDAO.Instance.LoadMenuByIdTable(Me.Tag.id)
            frmShare.Tag = Me.Tag
            frmShare.btnChuyen.Tag = tlsMenu.Tag
            frmShare.ShowDialog()
            flpBill.Controls.Clear()
            ShowBill()
        Else
            MessageBox.Show("Bạn hiện tại đang trống không thể tách bàn!")
        End If
    End Sub



#End Region
End Class