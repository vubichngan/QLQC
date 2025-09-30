Imports System.Globalization

Public Class frmShareTable
    Public newCountFood As List(Of Integer) = New List(Of Integer)
    Public foodId As List(Of Integer) = New List(Of Integer)
    Public oldCountFood As List(Of Integer) = New List(Of Integer)
    Private Sub frmShareTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowBill()
    End Sub

    Sub ShowBill()
        Dim i As Integer = 0
        Dim culture As CultureInfo = New CultureInfo("vi-VN")
        Dim menuList As List(Of Menu) = MenuDAO.Instance.LoadMenuByIdTable(Me.Tag.id)
        For Each item As Menu In menuList
            Dim idFood As Integer = DrinksDAO.Instance.GetIdDrinkByName(item.Name)
            Dim dun As DomainUpDown = New DomainUpDown()
            Dim flp As FlowLayoutPanel = New FlowLayoutPanel()
            flp.Height = 40
            flp.Width = flpShareTable.Width - 10
            flp.BackColor = Color.White
            Dim lblName As Label = New Label()

            Dim btnFood As CheckBox = New CheckBox()
            lblName.BackColor = Color.Aqua
            'lblName.Width = 80
            lblName.Height = 40
            lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            lblName.Text = item.Name '+ Environment.NewLine + item.Price.ToString("c", culture)

            newCountFood.Add(item.Count)
            oldCountFood.Add(item.Count)

            dun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            dun.Size = New System.Drawing.Size(45, 28)
            For j = item.Count To 1 Step -1
                dun.Items.Add(j)
            Next
            dun.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
            dun.Text = item.Count
            dun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            dun.TabIndex = i
            AddHandler dun.SelectedItemChanged, AddressOf dun_SelectedItemChanged


            btnFood.Size = New System.Drawing.Size(35, 35)
            btnFood.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
            AddHandler btnFood.CheckedChanged, AddressOf btnFood_CheckedChanged
            btnFood.Tag = idFood
            btnFood.TabIndex = i
            foodId.Add(0)

            flp.Controls.Add(btnFood)
            flp.Controls.Add(lblName)
            flp.Controls.Add(dun)

            flpShareTable.Controls.Add(flp)
            i = i + 1
        Next

    End Sub
    Sub dun_SelectedItemChanged(sender As Object, e As EventArgs)
        Dim count As Integer = sender.tabIndex
        newCountFood(count) = sender.text
    End Sub
    Sub btnFood_CheckedChanged(sender As Object, e As EventArgs)
        If sender.checked = True Then
            foodId(sender.tabIndex) = sender.tag
        Else
            foodId(sender.tabIndex) = 0
        End If
        'MessageBox.Show(foodId(sender.tabIndex))
    End Sub
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnChuyen_Click(sender As Object, e As EventArgs) Handles btnChuyen.Click
        Dim st As String = ""
        Dim listShareFood As List(Of shareDrink) = New List(Of shareDrink)
        For j = 0 To newCountFood.Count - 1
            If foodId(j) <> 0 Then
                listShareFood.Add(New shareDrink(newCountFood(j), oldCountFood(j), foodId(j)))
            End If
        Next
        Dim frmTable As frmShare_Table = New frmShare_Table()
        frmTable.Tag = listShareFood
        frmTable.TabIndex = Me.Tag.id
        frmTable.flpAll.Tag = btnChuyen.Tag
        frmTable.tabUser.TabPages.Remove(frmTable.tbpUse)
        Me.Hide()
        frmTable.ShowDialog()
        Me.Close()
        flpShareTable.Controls.Clear()
        ShowBill()
        'MessageBox.Show(st)
    End Sub
End Class