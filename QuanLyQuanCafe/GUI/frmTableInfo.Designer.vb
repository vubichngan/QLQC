<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTableInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.flpBill = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.lblAllTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTableName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tlsMenu = New System.Windows.Forms.ToolStripDropDownButton()
        Me.menuItemCB = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemTB = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnThanhToan = New System.Windows.Forms.Button()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnReply = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Linen
        Me.Panel3.Controls.Add(Me.flpBill)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.lblTableName)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Location = New System.Drawing.Point(732, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(476, 624)
        Me.Panel3.TabIndex = 2
        '
        'flpBill
        '
        Me.flpBill.AutoScroll = True
        Me.flpBill.BackColor = System.Drawing.Color.Linen
        Me.flpBill.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpBill.Location = New System.Drawing.Point(0, 50)
        Me.flpBill.Name = "flpBill"
        Me.flpBill.Size = New System.Drawing.Size(473, 459)
        Me.flpBill.TabIndex = 3
        Me.flpBill.WrapContents = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel2.Controls.Add(Me.btnCount)
        Me.Panel2.Controls.Add(Me.lblAllTotal)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(3, 515)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(474, 53)
        Me.Panel2.TabIndex = 4
        '
        'btnCount
        '
        Me.btnCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCount.Location = New System.Drawing.Point(145, 14)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(42, 30)
        Me.btnCount.TabIndex = 0
        Me.btnCount.Text = "10"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'lblAllTotal
        '
        Me.lblAllTotal.AutoSize = True
        Me.lblAllTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllTotal.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblAllTotal.Location = New System.Drawing.Point(349, 19)
        Me.lblAllTotal.Name = "lblAllTotal"
        Me.lblAllTotal.Size = New System.Drawing.Size(19, 20)
        Me.lblAllTotal.TabIndex = 1
        Me.lblAllTotal.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tổng thành tiền"
        '
        'lblTableName
        '
        Me.lblTableName.AutoSize = True
        Me.lblTableName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableName.Location = New System.Drawing.Point(200, 12)
        Me.lblTableName.Name = "lblTableName"
        Me.lblTableName.Size = New System.Drawing.Size(74, 25)
        Me.lblTableName.TabIndex = 2
        Me.lblTableName.Text = "BÀN 1"
        Me.lblTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btnThanhToan)
        Me.Panel1.Location = New System.Drawing.Point(3, 571)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(474, 53)
        Me.Panel1.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.PeachPuff
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsMenu})
        Me.ToolStrip1.Location = New System.Drawing.Point(7, 5)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(55, 35)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tlsMenu
        '
        Me.tlsMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemCB, Me.MenuItemTB})
        Me.tlsMenu.Image = Global.QuanLyQuanCafe.My.Resources.Resources.menu
        Me.tlsMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsMenu.Name = "tlsMenu"
        Me.tlsMenu.Size = New System.Drawing.Size(42, 32)
        Me.tlsMenu.Text = "Menu"
        '
        'menuItemCB
        '
        Me.menuItemCB.Name = "menuItemCB"
        Me.menuItemCB.Size = New System.Drawing.Size(169, 26)
        Me.menuItemCB.Text = "Chuyển bàn"
        '
        'MenuItemTB
        '
        Me.MenuItemTB.Name = "MenuItemTB"
        Me.MenuItemTB.Size = New System.Drawing.Size(169, 26)
        Me.MenuItemTB.Text = "Tách bàn"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.OrangeRed
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Snow
        Me.Button2.Location = New System.Drawing.Point(98, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 45)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Báo chế biến"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnThanhToan
        '
        Me.btnThanhToan.BackColor = System.Drawing.Color.OrangeRed
        Me.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThanhToan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThanhToan.ForeColor = System.Drawing.Color.Snow
        Me.btnThanhToan.Location = New System.Drawing.Point(302, 3)
        Me.btnThanhToan.Name = "btnThanhToan"
        Me.btnThanhToan.Size = New System.Drawing.Size(162, 45)
        Me.btnThanhToan.TabIndex = 1
        Me.btnThanhToan.Text = "Thanh toán"
        Me.btnThanhToan.UseVisualStyleBackColor = False
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.Linen
        Me.pnlMenu.Location = New System.Drawing.Point(0, 50)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(726, 624)
        Me.pnlMenu.TabIndex = 6
        '
        'btnReply
        '
        Me.btnReply.BackColor = System.Drawing.Color.Linen
        Me.btnReply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReply.ForeColor = System.Drawing.Color.Linen
        Me.btnReply.Image = Global.QuanLyQuanCafe.My.Resources.Resources.back
        Me.btnReply.Location = New System.Drawing.Point(12, 6)
        Me.btnReply.Name = "btnReply"
        Me.btnReply.Size = New System.Drawing.Size(46, 38)
        Me.btnReply.TabIndex = 7
        Me.btnReply.UseVisualStyleBackColor = False
        '
        'frmTableInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(1211, 686)
        Me.Controls.Add(Me.btnReply)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "frmTableInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnThanhToan As Button
    Friend WithEvents lblTableName As Label
    Friend WithEvents flpBill As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblAllTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCount As Button
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tlsMenu As ToolStripDropDownButton
    Friend WithEvents menuItemCB As ToolStripMenuItem
    Friend WithEvents MenuItemTB As ToolStripMenuItem
    Friend WithEvents btnReply As Button
End Class
