<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAllTable
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
    Protected Overridable Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAllTable))
        Me.tbpUse = New System.Windows.Forms.TabPage()
        Me.flpUse = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpAll = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabUser = New System.Windows.Forms.TabControl()
        Me.tbpAll = New System.Windows.Forms.TabPage()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAdmin = New System.Windows.Forms.ToolStripButton()
        Me.tbpUse.SuspendLayout()
        Me.tabUser.SuspendLayout()
        Me.tbpAll.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpUse
        '
        Me.tbpUse.Controls.Add(Me.flpUse)
        Me.tbpUse.Location = New System.Drawing.Point(4, 25)
        Me.tbpUse.Name = "tbpUse"
        Me.tbpUse.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpUse.Size = New System.Drawing.Size(1030, 664)
        Me.tbpUse.TabIndex = 1
        Me.tbpUse.Text = "Bàn đang dùng"
        Me.tbpUse.UseVisualStyleBackColor = True
        '
        'flpUse
        '
        Me.flpUse.Location = New System.Drawing.Point(5, 6)
        Me.flpUse.Name = "flpUse"
        Me.flpUse.Size = New System.Drawing.Size(1011, 664)
        Me.flpUse.TabIndex = 1
        '
        'flpAll
        '
        Me.flpAll.AutoScroll = True
        Me.flpAll.Location = New System.Drawing.Point(6, 6)
        Me.flpAll.Name = "flpAll"
        Me.flpAll.Size = New System.Drawing.Size(1021, 664)
        Me.flpAll.TabIndex = 0
        '
        'tabUser
        '
        Me.tabUser.Controls.Add(Me.tbpAll)
        Me.tabUser.Controls.Add(Me.tbpUse)
        Me.tabUser.Location = New System.Drawing.Point(2, 12)
        Me.tabUser.Name = "tabUser"
        Me.tabUser.SelectedIndex = 0
        Me.tabUser.Size = New System.Drawing.Size(1038, 693)
        Me.tabUser.TabIndex = 2
        '
        'tbpAll
        '
        Me.tbpAll.Controls.Add(Me.flpAll)
        Me.tbpAll.Location = New System.Drawing.Point(4, 25)
        Me.tbpAll.Name = "tbpAll"
        Me.tbpAll.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAll.Size = New System.Drawing.Size(1030, 664)
        Me.tbpAll.TabIndex = 0
        Me.tbpAll.Text = "Tất cả bàn"
        Me.tbpAll.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdmin})
        Me.ToolStrip1.Location = New System.Drawing.Point(924, 7)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(73, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAdmin
        '
        Me.btnAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.Image = CType(resources.GetObject("btnAdmin.Image"), System.Drawing.Image)
        Me.btnAdmin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(60, 24)
        Me.btnAdmin.Text = "Admin"
        '
        'frmAllTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 713)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tabUser)
        Me.Name = "frmAllTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý quán cafe"
        Me.tbpUse.ResumeLayout(False)
        Me.tabUser.ResumeLayout(False)
        Me.tbpAll.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbpUse As TabPage
    Friend WithEvents flpUse As FlowLayoutPanel
    Friend WithEvents flpAll As FlowLayoutPanel
    Friend WithEvents tabUser As TabControl
    Friend WithEvents tbpAll As TabPage
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnAdmin As ToolStripButton
End Class
