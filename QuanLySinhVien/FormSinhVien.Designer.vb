<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSinhVien
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_mhs = New System.Windows.Forms.TextBox()
        Me.tb_hoten = New System.Windows.Forms.TextBox()
        Me.tb_ngaysinh = New System.Windows.Forms.TextBox()
        Me.tb_diachi = New System.Windows.Forms.TextBox()
        Me.tb_sdt = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbb_gioitinh = New System.Windows.Forms.ComboBox()
        Me.cbb_timkiem = New System.Windows.Forms.ComboBox()
        Me.tb_timkiem = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbb_malop = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HọcSinhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GiáoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LớpHọcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TàiKhoảnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimKiếmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XuấtXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.bt_xoa = New System.Windows.Forms.Button()
        Me.bt_sua = New System.Windows.Forms.Button()
        Me.bt_luu = New System.Windows.Forms.Button()
        Me.bt_them = New System.Windows.Forms.Button()
        Me.bt_vecuoi = New System.Windows.Forms.Button()
        Me.bt_next = New System.Windows.Forms.Button()
        Me.bt_vedau = New System.Windows.Forms.Button()
        Me.bt_back = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(32, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Mã Sinh Viên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(32, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Họ Tên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(236, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Ngày Sinh"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(236, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Địa chỉ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Location = New System.Drawing.Point(439, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "SĐT PH"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label6.Location = New System.Drawing.Point(650, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 20)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Mã Lớp"
        '
        'tb_mhs
        '
        Me.tb_mhs.Location = New System.Drawing.Point(124, 55)
        Me.tb_mhs.Name = "tb_mhs"
        Me.tb_mhs.Size = New System.Drawing.Size(84, 20)
        Me.tb_mhs.TabIndex = 52
        '
        'tb_hoten
        '
        Me.tb_hoten.Location = New System.Drawing.Point(124, 110)
        Me.tb_hoten.Name = "tb_hoten"
        Me.tb_hoten.Size = New System.Drawing.Size(84, 20)
        Me.tb_hoten.TabIndex = 53
        '
        'tb_ngaysinh
        '
        Me.tb_ngaysinh.Location = New System.Drawing.Point(313, 110)
        Me.tb_ngaysinh.Name = "tb_ngaysinh"
        Me.tb_ngaysinh.Size = New System.Drawing.Size(85, 20)
        Me.tb_ngaysinh.TabIndex = 54
        '
        'tb_diachi
        '
        Me.tb_diachi.Location = New System.Drawing.Point(313, 56)
        Me.tb_diachi.Name = "tb_diachi"
        Me.tb_diachi.Size = New System.Drawing.Size(85, 20)
        Me.tb_diachi.TabIndex = 55
        '
        'tb_sdt
        '
        Me.tb_sdt.Location = New System.Drawing.Point(505, 110)
        Me.tb_sdt.Name = "tb_sdt"
        Me.tb_sdt.Size = New System.Drawing.Size(90, 20)
        Me.tb_sdt.TabIndex = 56
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(31, 245)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(770, 193)
        Me.DataGridView1.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label7.Location = New System.Drawing.Point(439, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 20)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Giới tính"
        '
        'cbb_gioitinh
        '
        Me.cbb_gioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_gioitinh.FormattingEnabled = True
        Me.cbb_gioitinh.Items.AddRange(New Object() {"Nam", "Nữ", "Khác"})
        Me.cbb_gioitinh.Location = New System.Drawing.Point(503, 55)
        Me.cbb_gioitinh.Name = "cbb_gioitinh"
        Me.cbb_gioitinh.Size = New System.Drawing.Size(95, 21)
        Me.cbb_gioitinh.TabIndex = 60
        '
        'cbb_timkiem
        '
        Me.cbb_timkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_timkiem.FormattingEnabled = True
        Me.cbb_timkiem.Items.AddRange(New Object() {"MaSV", "HoTen", "DiaChi", "SDT", "MaLop", "NgaySinh"})
        Me.cbb_timkiem.Location = New System.Drawing.Point(20, 12)
        Me.cbb_timkiem.Name = "cbb_timkiem"
        Me.cbb_timkiem.Size = New System.Drawing.Size(105, 21)
        Me.cbb_timkiem.TabIndex = 61
        '
        'tb_timkiem
        '
        Me.tb_timkiem.Location = New System.Drawing.Point(146, 12)
        Me.tb_timkiem.Name = "tb_timkiem"
        Me.tb_timkiem.Size = New System.Drawing.Size(224, 20)
        Me.tb_timkiem.TabIndex = 62
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_timkiem)
        Me.GroupBox1.Controls.Add(Me.cbb_timkiem)
        Me.GroupBox1.Location = New System.Drawing.Point(425, 200)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 39)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tìm kiếm"
        '
        'cbb_malop
        '
        Me.cbb_malop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_malop.FormattingEnabled = True
        Me.cbb_malop.Location = New System.Drawing.Point(715, 54)
        Me.cbb_malop.Name = "cbb_malop"
        Me.cbb_malop.Size = New System.Drawing.Size(86, 21)
        Me.cbb_malop.TabIndex = 96
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.QuảnLýToolStripMenuItem, Me.ThoátToolStripMenuItem, Me.TimKiếmToolStripMenuItem, Me.XuấtXMLToolStripMenuItem, Me.ThoátToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(834, 24)
        Me.MenuStrip1.TabIndex = 97
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HọcSinhToolStripMenuItem, Me.GiáoToolStripMenuItem, Me.LớpHọcToolStripMenuItem, Me.TàiKhoảnToolStripMenuItem})
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.QuảnLýToolStripMenuItem.Text = "Quản Lý"
        '
        'HọcSinhToolStripMenuItem
        '
        Me.HọcSinhToolStripMenuItem.Name = "HọcSinhToolStripMenuItem"
        Me.HọcSinhToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.HọcSinhToolStripMenuItem.Text = "Sinh Viên"
        '
        'GiáoToolStripMenuItem
        '
        Me.GiáoToolStripMenuItem.Name = "GiáoToolStripMenuItem"
        Me.GiáoToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.GiáoToolStripMenuItem.Text = "Giảng Viên"
        '
        'LớpHọcToolStripMenuItem
        '
        Me.LớpHọcToolStripMenuItem.Name = "LớpHọcToolStripMenuItem"
        Me.LớpHọcToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.LớpHọcToolStripMenuItem.Text = "Lớp Học"
        '
        'TàiKhoảnToolStripMenuItem
        '
        Me.TàiKhoảnToolStripMenuItem.Name = "TàiKhoảnToolStripMenuItem"
        Me.TàiKhoảnToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.TàiKhoảnToolStripMenuItem.Text = "Tài khoản"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.ThoátToolStripMenuItem.Text = "Đăng Xuất"
        '
        'TimKiếmToolStripMenuItem
        '
        Me.TimKiếmToolStripMenuItem.Name = "TimKiếmToolStripMenuItem"
        Me.TimKiếmToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.TimKiếmToolStripMenuItem.Text = "Tim kiếm"
        '
        'XuấtXMLToolStripMenuItem
        '
        Me.XuấtXMLToolStripMenuItem.Name = "XuấtXMLToolStripMenuItem"
        Me.XuấtXMLToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.XuấtXMLToolStripMenuItem.Text = "Xuất XML"
        '
        'ThoátToolStripMenuItem2
        '
        Me.ThoátToolStripMenuItem2.Name = "ThoátToolStripMenuItem2"
        Me.ThoátToolStripMenuItem2.Size = New System.Drawing.Size(49, 20)
        Me.ThoátToolStripMenuItem2.Text = "Thoát"
        '
        'bt_xoa
        '
        Me.bt_xoa.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bt_xoa.ForeColor = System.Drawing.Color.Black
        Me.bt_xoa.Image = Global.QuanLySinhVien.My.Resources.Resources.icons8_delete_view_40
        Me.bt_xoa.Location = New System.Drawing.Point(645, 152)
        Me.bt_xoa.Name = "bt_xoa"
        Me.bt_xoa.Size = New System.Drawing.Size(85, 42)
        Me.bt_xoa.TabIndex = 94
        Me.bt_xoa.UseVisualStyleBackColor = False
        '
        'bt_sua
        '
        Me.bt_sua.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bt_sua.ForeColor = System.Drawing.Color.Black
        Me.bt_sua.Image = Global.QuanLySinhVien.My.Resources.Resources.update
        Me.bt_sua.Location = New System.Drawing.Point(465, 152)
        Me.bt_sua.Name = "bt_sua"
        Me.bt_sua.Size = New System.Drawing.Size(85, 42)
        Me.bt_sua.TabIndex = 93
        Me.bt_sua.UseVisualStyleBackColor = False
        '
        'bt_luu
        '
        Me.bt_luu.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bt_luu.ForeColor = System.Drawing.Color.Black
        Me.bt_luu.Image = Global.QuanLySinhVien.My.Resources.Resources.icons8_save_48
        Me.bt_luu.Location = New System.Drawing.Point(267, 152)
        Me.bt_luu.Name = "bt_luu"
        Me.bt_luu.Size = New System.Drawing.Size(85, 42)
        Me.bt_luu.TabIndex = 92
        Me.bt_luu.UseVisualStyleBackColor = False
        '
        'bt_them
        '
        Me.bt_them.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bt_them.ForeColor = System.Drawing.Color.Black
        Me.bt_them.Image = Global.QuanLySinhVien.My.Resources.Resources.icons8_add_property_40
        Me.bt_them.Location = New System.Drawing.Point(89, 152)
        Me.bt_them.Name = "bt_them"
        Me.bt_them.Size = New System.Drawing.Size(85, 42)
        Me.bt_them.TabIndex = 91
        Me.bt_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_them.UseVisualStyleBackColor = False
        '
        'bt_vecuoi
        '
        Me.bt_vecuoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_vecuoi.Image = Global.QuanLySinhVien.My.Resources.Resources.right
        Me.bt_vecuoi.Location = New System.Drawing.Point(164, 207)
        Me.bt_vecuoi.Name = "bt_vecuoi"
        Me.bt_vecuoi.Size = New System.Drawing.Size(29, 28)
        Me.bt_vecuoi.TabIndex = 90
        Me.bt_vecuoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_vecuoi.UseVisualStyleBackColor = True
        '
        'bt_next
        '
        Me.bt_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_next.Image = Global.QuanLySinhVien.My.Resources.Resources.Annotation_2020_07_11_1509571
        Me.bt_next.Location = New System.Drawing.Point(119, 207)
        Me.bt_next.Name = "bt_next"
        Me.bt_next.Size = New System.Drawing.Size(29, 28)
        Me.bt_next.TabIndex = 89
        Me.bt_next.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_next.UseVisualStyleBackColor = True
        '
        'bt_vedau
        '
        Me.bt_vedau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_vedau.Image = Global.QuanLySinhVien.My.Resources.Resources.double_back
        Me.bt_vedau.Location = New System.Drawing.Point(31, 207)
        Me.bt_vedau.Name = "bt_vedau"
        Me.bt_vedau.Size = New System.Drawing.Size(29, 28)
        Me.bt_vedau.TabIndex = 88
        Me.bt_vedau.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_vedau.UseVisualStyleBackColor = True
        '
        'bt_back
        '
        Me.bt_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_back.Image = Global.QuanLySinhVien.My.Resources.Resources.icons8_back_16
        Me.bt_back.Location = New System.Drawing.Point(74, 207)
        Me.bt_back.Name = "bt_back"
        Me.bt_back.Size = New System.Drawing.Size(29, 28)
        Me.bt_back.TabIndex = 87
        Me.bt_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_back.UseVisualStyleBackColor = True
        '
        'FormSinhVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cbb_malop)
        Me.Controls.Add(Me.bt_xoa)
        Me.Controls.Add(Me.bt_sua)
        Me.Controls.Add(Me.bt_luu)
        Me.Controls.Add(Me.bt_them)
        Me.Controls.Add(Me.bt_vecuoi)
        Me.Controls.Add(Me.bt_next)
        Me.Controls.Add(Me.bt_vedau)
        Me.Controls.Add(Me.bt_back)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbb_gioitinh)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tb_sdt)
        Me.Controls.Add(Me.tb_diachi)
        Me.Controls.Add(Me.tb_ngaysinh)
        Me.Controls.Add(Me.tb_hoten)
        Me.Controls.Add(Me.tb_mhs)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormSinhVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSinhVien"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_mhs As TextBox
    Friend WithEvents tb_hoten As TextBox
    Friend WithEvents tb_ngaysinh As TextBox
    Friend WithEvents tb_diachi As TextBox
    Friend WithEvents tb_sdt As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents cbb_gioitinh As ComboBox
    Friend WithEvents cbb_timkiem As ComboBox
    Friend WithEvents tb_timkiem As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bt_vecuoi As Button
    Friend WithEvents bt_next As Button
    Friend WithEvents bt_vedau As Button
    Friend WithEvents bt_back As Button
    Friend WithEvents bt_xoa As Button
    Friend WithEvents bt_sua As Button
    Friend WithEvents bt_luu As Button
    Friend WithEvents bt_them As Button
    Friend WithEvents cbb_malop As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HọcSinhToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GiáoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LớpHọcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TàiKhoảnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents TimKiếmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XuấtXMLToolStripMenuItem As ToolStripMenuItem
End Class
