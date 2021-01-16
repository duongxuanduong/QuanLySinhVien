<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DangNhap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bt_thoat = New System.Windows.Forms.Button()
        Me.bt_dangnhap = New System.Windows.Forms.Button()
        Me.txbPassword = New System.Windows.Forms.Panel()
        Me.tb_matkhau = New System.Windows.Forms.TextBox()
        Me.lbPassword = New System.Windows.Forms.Label()
        Me.txbTendangnhap = New System.Windows.Forms.Panel()
        Me.tb_tendn = New System.Windows.Forms.TextBox()
        Me.lbtendnhap = New System.Windows.Forms.Label()
        Me.txbPassword.SuspendLayout()
        Me.txbTendangnhap.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt_thoat
        '
        Me.bt_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_thoat.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_thoat.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.bt_thoat.Location = New System.Drawing.Point(343, 199)
        Me.bt_thoat.Name = "bt_thoat"
        Me.bt_thoat.Size = New System.Drawing.Size(126, 34)
        Me.bt_thoat.TabIndex = 8
        Me.bt_thoat.Text = "Thoát"
        Me.bt_thoat.UseVisualStyleBackColor = True
        '
        'bt_dangnhap
        '
        Me.bt_dangnhap.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_dangnhap.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.bt_dangnhap.Location = New System.Drawing.Point(138, 199)
        Me.bt_dangnhap.Name = "bt_dangnhap"
        Me.bt_dangnhap.Size = New System.Drawing.Size(126, 34)
        Me.bt_dangnhap.TabIndex = 7
        Me.bt_dangnhap.Text = "Đăng nhập"
        Me.bt_dangnhap.UseVisualStyleBackColor = True
        '
        'txbPassword
        '
        Me.txbPassword.Controls.Add(Me.tb_matkhau)
        Me.txbPassword.Controls.Add(Me.lbPassword)
        Me.txbPassword.Location = New System.Drawing.Point(24, 120)
        Me.txbPassword.Name = "txbPassword"
        Me.txbPassword.Size = New System.Drawing.Size(545, 51)
        Me.txbPassword.TabIndex = 6
        Me.txbPassword.UseWaitCursor = True
        '
        'tb_matkhau
        '
        Me.tb_matkhau.Location = New System.Drawing.Point(161, 15)
        Me.tb_matkhau.Name = "tb_matkhau"
        Me.tb_matkhau.Size = New System.Drawing.Size(348, 20)
        Me.tb_matkhau.TabIndex = 1
        Me.tb_matkhau.UseSystemPasswordChar = True
        Me.tb_matkhau.UseWaitCursor = True
        '
        'lbPassword
        '
        Me.lbPassword.AutoSize = True
        Me.lbPassword.BackColor = System.Drawing.SystemColors.Control
        Me.lbPassword.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPassword.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lbPassword.Location = New System.Drawing.Point(18, 14)
        Me.lbPassword.Name = "lbPassword"
        Me.lbPassword.Size = New System.Drawing.Size(93, 19)
        Me.lbPassword.TabIndex = 0
        Me.lbPassword.Text = "Password:"
        Me.lbPassword.UseWaitCursor = True
        '
        'txbTendangnhap
        '
        Me.txbTendangnhap.Controls.Add(Me.tb_tendn)
        Me.txbTendangnhap.Controls.Add(Me.lbtendnhap)
        Me.txbTendangnhap.Location = New System.Drawing.Point(24, 46)
        Me.txbTendangnhap.Name = "txbTendangnhap"
        Me.txbTendangnhap.Size = New System.Drawing.Size(545, 51)
        Me.txbTendangnhap.TabIndex = 5
        '
        'tb_tendn
        '
        Me.tb_tendn.Location = New System.Drawing.Point(161, 15)
        Me.tb_tendn.Name = "tb_tendn"
        Me.tb_tendn.Size = New System.Drawing.Size(348, 20)
        Me.tb_tendn.TabIndex = 1
        '
        'lbtendnhap
        '
        Me.lbtendnhap.AutoSize = True
        Me.lbtendnhap.BackColor = System.Drawing.SystemColors.Control
        Me.lbtendnhap.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtendnhap.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lbtendnhap.Location = New System.Drawing.Point(18, 14)
        Me.lbtendnhap.Name = "lbtendnhap"
        Me.lbtendnhap.Size = New System.Drawing.Size(137, 19)
        Me.lbtendnhap.TabIndex = 0
        Me.lbtendnhap.Text = "Tên đăng nhập: "
        '
        'DangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 279)
        Me.Controls.Add(Me.bt_thoat)
        Me.Controls.Add(Me.bt_dangnhap)
        Me.Controls.Add(Me.txbPassword)
        Me.Controls.Add(Me.txbTendangnhap)
        Me.Name = "DangNhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DangNhap"
        Me.txbPassword.ResumeLayout(False)
        Me.txbPassword.PerformLayout()
        Me.txbTendangnhap.ResumeLayout(False)
        Me.txbTendangnhap.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents bt_thoat As Button
    Private WithEvents bt_dangnhap As Button
    Private WithEvents txbPassword As Panel
    Private WithEvents tb_matkhau As TextBox
    Private WithEvents lbPassword As Label
    Private WithEvents txbTendangnhap As Panel
    Private WithEvents tb_tendn As TextBox
    Private WithEvents lbtendnhap As Label
End Class
