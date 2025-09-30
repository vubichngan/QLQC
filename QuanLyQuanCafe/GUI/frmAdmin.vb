Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class frmAdmin
    Dim categoryList As BindingSource = New BindingSource()
    Dim foodList As BindingSource = New BindingSource()
    Dim tableList As BindingSource = New BindingSource()
    Dim accountList As BindingSource = New BindingSource()

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_()
    End Sub

    Sub Load_()
        dgvCategoryFood.DataSource = categoryList
        dgvFood.DataSource = foodList
        dgvTable.DataSource = tableList
        dgvAccount.DataSource = accountList
        LoadAccountList()
        LoadFoodList()
        LoadCategory()
        LoadTable()
        LoadRevenue()
    End Sub
#Region "Loại thức uống"
    Sub LoadEditFoodCategory()
        txtNameCFood.DataBindings.Clear()
        txtIdCFood.DataBindings.Clear()
        txtNameCFood.DataBindings.Add(New Binding("text", dgvCategoryFood.DataSource, "name", True, DataSourceUpdateMode.Never))
        txtIdCFood.DataBindings.Add(New Binding("text", dgvCategoryFood.DataSource, "id", True, DataSourceUpdateMode.Never))
    End Sub
    Sub LoadCategory()
        categoryList.DataSource = DrinkCategoryDAO.Instance.LoadDrinkCategoryList()
        LoadEditFoodCategory()
    End Sub
    Private Sub btnAddCFood_Click(sender As Object, e As EventArgs) Handles btnAddCFood.Click
        Dim name As String = txtNameCFood.Text
        If DrinkCategoryDAO.Instance.InsertDrinkCategory(name) Then
            LoadCategory()
            LoadFoodList()
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK)
        Else
            MessageBox.Show("Thêm không thành công!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnSaveCFood_Click(sender As Object, e As EventArgs) Handles btnSaveCFood.Click
        Dim name As String = txtNameCFood.Text
        Dim id As Integer = dgvCategoryFood.CurrentRow.Cells(0).Value
        If DrinkCategoryDAO.Instance.UpdateDrinkCategory(name, id) Then
            LoadCategory()
            LoadFoodList()
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK)
        Else
            MessageBox.Show("Lưu không thành công!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnDeleteCFood_Click(sender As Object, e As EventArgs) Handles btnDeleteCFood.Click
        Dim id As Integer = dgvCategoryFood.CurrentRow.Cells(0).Value
        If (MessageBox.Show("Bạn muốn xóa " + txtNameCFood.Text + " ra khỏi loại thức uống ?", "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK) Then
            Try
                If DrinkCategoryDAO.Instance.DeleteDrinkCategory(id) Then
                    LoadCategory()
                    LoadFoodList()
                    MessageBox.Show("Xóa thành công", "Thông báo lỗi", MessageBoxButtons.OK)
                Else
                    MessageBox.Show("Xóa không thành công", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Lỗi: không thể xóa!!!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


    End Sub
    Private Sub btnViewCFood_Click(sender As Object, e As EventArgs) Handles btnViewCFood.Click
        LoadCategory()
    End Sub
    Function SeachCategory(name As String)
        Dim categoryList As List(Of DrinkCategory) = DrinkCategoryDAO.Instance.SeachCategoryByName(name)
        Return categoryList
    End Function
    Private Sub btnSearchCFood_Click(sender As Object, e As EventArgs) Handles btnSearchCFood.Click
        categoryList.DataSource = SeachCategory(txtSearchCFood.Text)
    End Sub

#End Region

#Region "Thức uống"
    Sub LoadCbxCategory()
        cbxFoodCategory.DataSource = DrinkCategoryDAO.Instance.LoadDrinkCategoryList()
        cbxFoodCategory.DisplayMember = "name"
        cbxFoodCategory.ValueMember = "id"
    End Sub
    Sub LoadFoodList()
        foodList.DataSource = DrinksDAO.Instance.LoadDrinkList()
        LoadCbxCategory()
        LoadEditFood()
    End Sub
    Private Sub txtIdFood_TextChanged(sender As Object, e As EventArgs) Handles txtIdFood.TextChanged
        If dgvFood.SelectedCells.Count > 0 Then
            Dim idCategory As Integer = dgvFood.SelectedCells(0).OwningRow.Cells(2).Value
            Dim category As DrinkCategory = DrinkCategoryDAO.Instance.LoadCategoryById(idCategory)
            cbxFoodCategory.SelectedItem = category
            Dim index As Integer = -1
            Dim i As Integer = 0
            For Each item As DrinkCategory In cbxFoodCategory.Items
                If item.Id = category.Id Then
                    index = i
                    Exit For
                End If
                i += 1
            Next
            cbxFoodCategory.SelectedIndex = index
        End If

    End Sub
    Sub LoadEditFood()
        txtNameFood.DataBindings.Clear()
        txtPrice.DataBindings.Clear()
        txtQuantity.DataBindings.Clear()
        txtIdFood.DataBindings.Clear()
        txtNameFood.DataBindings.Add(New Binding("text", dgvFood.DataSource, "name", True, DataSourceUpdateMode.Never))
        'cbxFoodCategory.DataBindings.Add(New Binding("text", dgvFood.DataSource, "idCategory", True, DataSourceUpdateMode.Never))
        txtPrice.DataBindings.Add(New Binding("text", dgvFood.DataSource, "price", True, DataSourceUpdateMode.Never))
        txtQuantity.DataBindings.Add(New Binding("text", dgvFood.DataSource, "quantity", DataSourceUpdateMode.Never))
        txtIdFood.DataBindings.Add(New Binding("text", dgvFood.DataSource, "id", True, DataSourceUpdateMode.Never))
    End Sub
    Private Sub btnAddFood_Click(sender As Object, e As EventArgs) Handles btnAddFood.Click
        Dim name As String = txtNameFood.Text
        Dim idCategory As Integer = cbxFoodCategory.SelectedValue
        Dim price As Integer = txtPrice.Text
        Dim quantity As Integer = txtQuantity.Text
        If DrinksDAO.Instance.InsertDrinks(name, idCategory, price, quantity) Then
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK)
            LoadFoodList()
        Else
            MessageBox.Show("Thêm không thành công", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnSaveFood_Click(sender As Object, e As EventArgs) Handles btnSaveFood.Click
        Dim id As Integer = txtIdFood.Text
        Dim name As String = txtNameFood.Text
        Dim idCategory As Integer = cbxFoodCategory.SelectedValue
        Dim price As Integer = txtPrice.Text
        Dim quantity As Integer = txtQuantity.Text
        If DrinksDAO.Instance.UpdateDrinks(id, name, idCategory, price, quantity) Then
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK)
            LoadFoodList()
        Else
            MessageBox.Show("Cập nhật không thành công", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnDeleteFood_Click(sender As Object, e As EventArgs) Handles btnDeleteFood.Click
        Dim id As Integer = txtIdFood.Text
        If (MessageBox.Show("Bạn muốn xóa " + txtNameFood.Text + " ra khỏi thức uống ?", "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK) Then
            Try
                If DrinksDAO.Instance.DeleteDrinks(id) Then
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK)
                    LoadFoodList()
                Else
                    MessageBox.Show("Xóa không thành công", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Lỗi: Không thể xóa!!!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


    End Sub
    Private Sub btnViewFood_Click(sender As Object, e As EventArgs) Handles btnViewFood.Click
        LoadFoodList()
    End Sub
    Function searhFood(name As String)
        Dim foodlist As List(Of Drinks) = DrinksDAO.Instance.SearchDrinks(name)
        Return foodlist
    End Function
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        foodList.DataSource = searhFood(txtSearch.Text)
    End Sub
#End Region

#Region "Bàn"
    Sub LoadTable()
        tableList.DataSource = TableDAO.Instance.LoadTable()
        'dgvTable.DataSource = TableDAO.Instance.LoadTable()
        EditTable()
    End Sub

    Sub EditTable()
        txtIdTable.DataBindings.Clear()
        txtNameTable.DataBindings.Clear()
        txtStatus.DataBindings.Clear()
        txtIdTable.DataBindings.Add(New Binding("text", dgvTable.DataSource, "id", True, DataSourceUpdateMode.Never))
        txtNameTable.DataBindings.Add(New Binding("text", dgvTable.DataSource, "name", True, DataSourceUpdateMode.Never))
        txtStatus.DataBindings.Add(New Binding("text", dgvTable.DataSource, "status", True, DataSourceUpdateMode.Never))
    End Sub
    Private Sub btnAddTable_Click(sender As Object, e As EventArgs) Handles btnAddTable.Click
        Dim name As String = txtNameTable.Text
        Dim status As String = txtStatus.Text
        If TableDAO.Instance.InsertTable(name, status) Then
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK)
            LoadTable()
        Else
            MessageBox.Show("Thêm không thành công", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnSaveTable_Click(sender As Object, e As EventArgs) Handles btnSaveTable.Click
        Dim id As Integer = txtIdTable.Text
        Dim name As String = txtNameTable.Text
        Dim status As String = txtStatus.Text
        If TableDAO.Instance.UpdateTable(name, status, id) Then
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK)
            LoadTable()
        Else
            MessageBox.Show("Cập nhật không thành công", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnDeleteTable_Click(sender As Object, e As EventArgs) Handles btnDeleteTable.Click
        Dim id As Integer = txtIdTable.Text
        If (MessageBox.Show("Bạn muốn xóa " + txtNameTable.Text + " ?", "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK) Then
            Try
                If TableDAO.Instance.DeleteTable(id) Then
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK)
                    LoadTable()
                Else
                    MessageBox.Show("Xóa không thành công", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Lỗi: không thể xóa!!!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub btnViewTable_Click(sender As Object, e As EventArgs) Handles btnViewTable.Click
        LoadTable()
    End Sub
    Function SearchTable(name As String) As List(Of Table)
        Dim table As List(Of Table) = TableDAO.Instance.SearchTable(name)
        Return table
    End Function
    Private Sub btnSearchTable_Click(sender As Object, e As EventArgs) Handles btnSearchTable.Click

        tableList.DataSource = SearchTable(txtSearchTable.Text)
    End Sub
#End Region

#Region "tài khoản"
    Sub LoadAccountList()
        accountList.DataSource = AccountDAO.Instance.LoadAccount()
        EditAccount()
    End Sub
    Private Sub txtIdAccount_TextChanged(sender As Object, e As EventArgs) Handles txtIdAccount.TextChanged
        If dgvAccount.SelectedCells.Count > 0 Then
            Dim type As Integer = dgvAccount.SelectedCells(0).OwningRow.Cells(3).Value
            cbxType.SelectedIndex = type
        End If
    End Sub
    Sub EditAccount()
        txtIdAccount.DataBindings.Clear()
        txtUserName.DataBindings.Clear()
        txtPassWord.DataBindings.Clear()
        txtIdAccount.DataBindings.Add(New Binding("text", dgvAccount.DataSource, "id", DataSourceUpdateMode.Never))
        txtUserName.DataBindings.Add(New Binding("text", dgvAccount.DataSource, "userName", DataSourceUpdateMode.Never))
        txtPassWord.DataBindings.Add(New Binding("text", dgvAccount.DataSource, "passWord", DataSourceUpdateMode.Never))
        'cbxType.DataBindings.Add(New Binding("text", dgvAccount.DataSource, "type", DataSourceUpdateMode.Never))
    End Sub
    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs) Handles btnAddAccount.Click
        Dim userName As String = txtUserName.Text
        Dim passWord As String = txtPassWord.Text
        Dim type As Integer = cbxType.SelectedIndex
        If AccountDAO.Instance.InsertAccount(userName, passWord, type) Then
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK)
            LoadAccountList()
        Else
            MessageBox.Show("Thêm không thành công", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnSaveAccount_Click(sender As Object, e As EventArgs) Handles btnSaveAccount.Click
        Dim id As Integer = txtIdAccount.Text
        Dim userName As String = txtUserName.Text
        Dim passWord As String = txtPassWord.Text
        Dim type As Integer = cbxType.SelectedIndex
        If AccountDAO.Instance.UpdateAccount(userName, passWord, type, id) Then
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK)
            LoadAccountList()
        Else
            MessageBox.Show("Cập nhật không thành công", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnDeleteAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteAccount.Click
        Dim id As Integer = txtIdAccount.Text
        Dim idAccount As Integer = Me.Tag
        If (MessageBox.Show("Bạn muốn xóa " + txtUserName.Text + " ?", "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK) Then
            If id <> idAccount Then
                Try
                    If AccountDAO.Instance.DeleteAccount(id) Then
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK)
                        LoadAccountList()
                    Else
                        MessageBox.Show("Xóa không thành công", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Lỗi: Không thể xóa", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Bạn đừng xóa chính mình chứ!!!")
            End If
        End If
    End Sub
    Private Sub btnViewAccount_Click(sender As Object, e As EventArgs) Handles btnViewAccount.Click
        LoadAccountList()
    End Sub
    Function SearchAccount(userName As String) As List(Of Account)
        Dim accountList As List(Of Account) = AccountDAO.Instance.SearchAccount(userName)
        Return accountList
    End Function
    Private Sub btnSearchAccount_Click(sender As Object, e As EventArgs) Handles btnSearchAccount.Click
        accountList.DataSource = SearchAccount(txtSearchAccount.Text)
    End Sub
#End Region

#Region "Doanh thu"
    Sub LoadRevenue()
        dgvListBill.DataSource = RevenueDAO.Instance.GetBillList()
    End Sub

    Private Sub btnViewBill_Click(sender As Object, e As EventArgs) Handles btnViewBill.Click
        Dim timeIn As TimeSpan = New TimeSpan(0, 0, 0)
        Dim timeOut As TimeSpan = New TimeSpan(23, 59, 59)
        Dim dateCheckIn As DateTime = dtpCheckIn.Text
        Dim dateCheckOut As DateTime = dtpCheckOut.Text
        Dim dateIn As DateTime = dateCheckIn + timeIn
        Dim dateOut As DateTime = dateCheckOut + timeOut
        dgvListBill.DataSource = RevenueDAO.Instance.GetBillByDate(dateIn, dateOut)
    End Sub

    Private Sub dgvListBill_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListBill.CellClick
        Dim frmBill As frmBillInfo = New frmBillInfo()
        Dim idBill As Integer = dgvListBill.CurrentRow.Cells(0).Value
        'Dim _revenue As Revenue = RevenueDAO.Instance.GetBillById(idBill)
        frmBill.TabIndex = idBill
        frmBill.Tag = "HuyBill"
        frmBill.ShowDialog()
        LoadRevenue()
    End Sub



#End Region
End Class