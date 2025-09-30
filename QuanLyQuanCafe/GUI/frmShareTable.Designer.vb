<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmShareTable
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
        Me.flpShareTable = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnChuyen = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'flpShareTable
        '
        Me.flpShareTable.AutoScroll = True
        Me.flpShareTable.BackColor = System.Drawing.Color.Linen
        Me.flpShareTable.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpShareTable.Location = New System.Drawing.Point(2, 0)
        Me.flpShareTable.Name = "flpShareTable"
        Me.flpShareTable.Size = New System.Drawing.Size(393, 278)
        Me.flpShareTable.TabIndex = 4
        Me.flpShareTable.WrapContents = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.Controls.Add(Me.btnThoat)
        Me.Panel1.Controls.Add(Me.btnChuyen)
        Me.Panel1.Location = New System.Drawing.Point(2, 284)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 72)
        Me.Panel1.TabIndex = 5
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.OrangeRed
        Me.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.White
        Me.btnThoat.Location = New System.Drawing.Point(220, 17)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(134, 37)
        Me.btnThoat.TabIndex = 1
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'btnChuyen
        '
        Me.btnChuyen.BackColor = System.Drawing.Color.OrangeRed
        Me.btnChuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChuyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChuyen.ForeColor = System.Drawing.Color.White
        Me.btnChuyen.Location = New System.Drawing.Point(37, 17)
        Me.btnChuyen.Name = "btnChuyen"
        Me.btnChuyen.Size = New System.Drawing.Size(134, 37)
        Me.btnChuyen.TabIndex = 0
        Me.btnChuyen.Text = "Chuyển"
        Me.btnChuyen.UseVisualStyleBackColor = False
        '
        'frmShareTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 368)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.flpShareTable)
        Me.Name = "frmShareTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tách bàn"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpShareTable As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnChuyen As Button
End Class
