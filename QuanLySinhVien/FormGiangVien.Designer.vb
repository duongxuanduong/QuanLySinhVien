<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGiangVien
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
        Me.components = New System.ComponentModel.Container()
        Me.cbb_gioitinh = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tb_sdt = New System.Windows.Forms.TextBox()
        Me.tb_diachi = New System.Windows.Forms.TextBox()
        Me.tb_ngaysinh = New System.Windows.Forms.TextBox()
        Me.tb_hoten = New System.Windows.Forms.TextBox()
        Me.tb_mgv = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tb_timkiem = New System.Windows.Forms.TextBox()
        Me.cbb_timkiem = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HọcSinhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GiáoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LớpHọcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TàiKhoảnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TìmKiếmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XuấtXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bt_vecuoi = New System.Windows.Forms.Button()
        Me.bt_next = New System.Windows.Forms.Button()
        Me.bt_vedau = New System.Windows.Forms.Button()
        Me.bt_back = New System.Windows.Forms.Button()
        Me.bt_xoa = New System.Windows.Forms.Button()
        Me.bt_sua = New System.Windows.Forms.Button()
        Me.bt_luu = New System.Windows.Forms.Button()
        Me.bt_them = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbb_gioitinh
        '
        Me.cbb_gioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_gioitinh.FormattingEnabled = True
        Me.cbb_gioitinh.Items.AddRange(New Object() {"Nam", "Nữ", "Khác"})
        Me.cbb_gioitinh.Location = New System.Drawing.Point(855, 107)
        Me.cbb_gioitinh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbb_gioitinh.Name = "cbb_gioitinh"
        Me.cbb_gioitinh.Size = New System.Drawing.Size(140, 24)
        Me.cbb_gioitinh.TabIndex = 80
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label7.Location = New System.Drawing.Point(767, 107)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 24)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Giới tính"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 274)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1027, 238)
        Me.DataGridView1.TabIndex = 78
        '
        'tb_sdt
        '
        Me.tb_sdt.Location = New System.Drawing.Point(853, 42)
        Me.tb_sdt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_sdt.Name = "tb_sdt"
        Me.tb_sdt.Size = New System.Drawing.Size(141, 22)
        Me.tb_sdt.TabIndex = 76
        '
        'tb_diachi
        '
        Me.tb_diachi.Location = New System.Drawing.Point(527, 43)
        Me.tb_diachi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_diachi.Name = "tb_diachi"
        Me.tb_diachi.Size = New System.Drawing.Size(124, 22)
        Me.tb_diachi.TabIndex = 75
        '
        'tb_ngaysinh
        '
        Me.tb_ngaysinh.Location = New System.Drawing.Point(527, 107)
        Me.tb_ngaysinh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_ngaysinh.Name = "tb_ngaysinh"
        Me.tb_ngaysinh.Size = New System.Drawing.Size(124, 22)
        Me.tb_ngaysinh.TabIndex = 74
        '
        'tb_hoten
        '
        Me.tb_hoten.Location = New System.Drawing.Point(187, 107)
        Me.tb_hoten.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_hoten.Name = "tb_hoten"
        Me.tb_hoten.Size = New System.Drawing.Size(135, 22)
        Me.tb_hoten.TabIndex = 73
        '
        'tb_mgv
        '
        Me.tb_mgv.Location = New System.Drawing.Point(187, 46)
        Me.tb_mgv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_mgv.Name = "tb_mgv"
        Me.tb_mgv.Size = New System.Drawing.Size(135, 22)
        Me.tb_mgv.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Location = New System.Drawing.Point(767, 39)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 24)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "SĐT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(421, 43)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 24)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Địa chỉ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(419, 107)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 24)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Ngày Sinh"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(51, 107)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 24)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Họ Tên"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(51, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 24)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Mã Giảng Viên"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_timkiem)
        Me.GroupBox1.Controls.Add(Me.cbb_timkiem)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox1.Location = New System.Drawing.Point(545, 219)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(501, 48)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tìm kiếm"
        '
        'tb_timkiem
        '
        Me.tb_timkiem.Location = New System.Drawing.Point(195, 15)
        Me.tb_timkiem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_timkiem.Name = "tb_timkiem"
        Me.tb_timkiem.Size = New System.Drawing.Size(297, 22)
        Me.tb_timkiem.TabIndex = 62
        '
        'cbb_timkiem
        '
        Me.cbb_timkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_timkiem.FormattingEnabled = True
        Me.cbb_timkiem.Items.AddRange(New Object() {"MaGV", "HoTen", "DiaChi", "GioiTinh", "SDT"})
        Me.cbb_timkiem.Location = New System.Drawing.Point(27, 15)
        Me.cbb_timkiem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbb_timkiem.Name = "cbb_timkiem"
        Me.cbb_timkiem.Size = New System.Drawing.Size(139, 24)
        Me.cbb_timkiem.TabIndex = 61
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.QuảnLýToolStripMenuItem, Me.ThoátToolStripMenuItem, Me.TìmKiếmToolStripMenuItem, Me.XuấtXMLToolStripMenuItem, Me.ThoátToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 28)
        Me.MenuStrip1.TabIndex = 87
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HọcSinhToolStripMenuItem, Me.GiáoToolStripMenuItem, Me.LớpHọcToolStripMenuItem, Me.TàiKhoảnToolStripMenuItem})
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.QuảnLýToolStripMenuItem.Text = "Quản Lý"
        '
        'HọcSinhToolStripMenuItem
        '
        Me.HọcSinhToolStripMenuItem.Name = "HọcSinhToolStripMenuItem"
        Me.HọcSinhToolStripMenuItem.Size = New System.Drawing.Size(155, 26)
        Me.HọcSinhToolStripMenuItem.Text = "Sinh Viên"
        '
        'GiáoToolStripMenuItem
        '
        Me.GiáoToolStripMenuItem.Name = "GiáoToolStripMenuItem"
        Me.GiáoToolStripMenuItem.Size = New System.Drawing.Size(155, 26)
        Me.GiáoToolStripMenuItem.Text = "Giảng Viên"
        '
        'LớpHọcToolStripMenuItem
        '
        Me.LớpHọcToolStripMenuItem.Name = "LớpHọcToolStripMenuItem"
        Me.LớpHọcToolStripMenuItem.Size = New System.Drawing.Size(155, 26)
        Me.LớpHọcToolStripMenuItem.Text = "Lớp Học"
        '
        'TàiKhoảnToolStripMenuItem
        '
        Me.TàiKhoảnToolStripMenuItem.Name = "TàiKhoảnToolStripMenuItem"
        Me.TàiKhoảnToolStripMenuItem.Size = New System.Drawing.Size(155, 26)
        Me.TàiKhoảnToolStripMenuItem.Text = "Tài khoản"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.ThoátToolStripMenuItem.Text = "Đăng Xuất"
        '
        'TìmKiếmToolStripMenuItem
        '
        Me.TìmKiếmToolStripMenuItem.Name = "TìmKiếmToolStripMenuItem"
        Me.TìmKiếmToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.TìmKiếmToolStripMenuItem.Text = "Tìm kiếm"
        '
        'XuấtXMLToolStripMenuItem
        '
        Me.XuấtXMLToolStripMenuItem.Name = "XuấtXMLToolStripMenuItem"
        Me.XuấtXMLToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.XuấtXMLToolStripMenuItem.Text = "Xuất XML"
        '
        'ThoátToolStripMenuItem2
        '
        Me.ThoátToolStripMenuItem2.Name = "ThoátToolStripMenuItem2"
        Me.ThoátToolStripMenuItem2.Size = New System.Drawing.Size(59, 24)
        Me.ThoátToolStripMenuItem2.Text = "Thoát"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'bt_vecuoi
        '
        Me.bt_vecuoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_vecuoi.Image = Global.QuanLySinhVien.My.Resources.Resources.right
        Me.bt_vecuoi.Location = New System.Drawing.Point(200, 228)
        Me.bt_vecuoi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bt_vecuoi.Name = "bt_vecuoi"
        Me.bt_vecuoi.Size = New System.Drawing.Size(39, 34)
        Me.bt_vecuoi.TabIndex = 86
        Me.bt_vecuoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_vecuoi.UseVisualStyleBackColor = True
        '
        'bt_next
        '
        Me.bt_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_next.Image = Global.QuanLySinhVien.My.Resources.Resources.Annotation_2020_07_11_150957
        Me.bt_next.Location = New System.Drawing.Point(140, 228)
        Me.bt_next.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bt_next.Name = "bt_next"
        Me.bt_next.Size = New System.Drawing.Size(39, 34)
        Me.bt_next.TabIndex = 85
        Me.bt_next.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_next.UseVisualStyleBackColor = True
        '
        'bt_vedau
        '
        Me.bt_vedau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_vedau.Image = Global.QuanLySinhVien.My.Resources.Resources.double_back
        Me.bt_vedau.Location = New System.Drawing.Point(23, 228)
        Me.bt_vedau.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bt_vedau.Name = "bt_vedau"
        Me.bt_vedau.Size = New System.Drawing.Size(39, 34)
        Me.bt_vedau.TabIndex = 84
        Me.bt_vedau.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_vedau.UseVisualStyleBackColor = True
        '
        'bt_back
        '
        Me.bt_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_back.Image = Global.QuanLySinhVien.My.Resources.Resources.icons8_back_161
        Me.bt_back.Location = New System.Drawing.Point(80, 228)
        Me.bt_back.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bt_back.Name = "bt_back"
        Me.bt_back.Size = New System.Drawing.Size(39, 34)
        Me.bt_back.TabIndex = 83
        Me.bt_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_back.UseVisualStyleBackColor = True
        '
        'bt_xoa
        '
        Me.bt_xoa.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bt_xoa.ForeColor = System.Drawing.Color.Black
        Me.bt_xoa.Image = Global.QuanLySinhVien.My.Resources.Resources.icons8_delete_view_40
        Me.bt_xoa.Location = New System.Drawing.Point(855, 160)
        Me.bt_xoa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bt_xoa.Name = "bt_xoa"
        Me.bt_xoa.Size = New System.Drawing.Size(113, 52)
        Me.bt_xoa.TabIndex = 64
        Me.bt_xoa.UseVisualStyleBackColor = False
        '
        'bt_sua
        '
        Me.bt_sua.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bt_sua.ForeColor = System.Drawing.Color.Black
        Me.bt_sua.Image = Global.QuanLySinhVien.My.Resources.Resources.update
        Me.bt_sua.Location = New System.Drawing.Point(615, 160)
        Me.bt_sua.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bt_sua.Name = "bt_sua"
        Me.bt_sua.Size = New System.Drawing.Size(113, 52)
        Me.bt_sua.TabIndex = 63
        Me.bt_sua.UseVisualStyleBackColor = False
        '
        'bt_luu
        '
        Me.bt_luu.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bt_luu.ForeColor = System.Drawing.Color.Black
        Me.bt_luu.Image = Global.QuanLySinhVien.My.Resources.Resources.icons8_save_48
        Me.bt_luu.Location = New System.Drawing.Point(373, 160)
        Me.bt_luu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bt_luu.Name = "bt_luu"
        Me.bt_luu.Size = New System.Drawing.Size(113, 52)
        Me.bt_luu.TabIndex = 62
        Me.bt_luu.UseVisualStyleBackColor = False
        '
        'bt_them
        '
        Me.bt_them.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bt_them.ForeColor = System.Drawing.Color.Black
        Me.bt_them.Image = Global.QuanLySinhVien.My.Resources.Resources.icons8_add_property_40
        Me.bt_them.Location = New System.Drawing.Point(125, 160)
        Me.bt_them.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bt_them.Name = "bt_them"
        Me.bt_them.Size = New System.Drawing.Size(113, 52)
        Me.bt_them.TabIndex = 61
        Me.bt_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_them.UseVisualStyleBackColor = False
        '
        'FormGiangVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.MenuStrip1)
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
        Me.Controls.Add(Me.tb_mgv)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_xoa)
        Me.Controls.Add(Me.bt_sua)
        Me.Controls.Add(Me.bt_luu)
        Me.Controls.Add(Me.bt_them)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormGiangVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormGiangVien"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbb_gioitinh As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tb_sdt As TextBox
    Friend WithEvents tb_diachi As TextBox
    Friend WithEvents tb_ngaysinh As TextBox
    Friend WithEvents tb_hoten As TextBox
    Friend WithEvents tb_mgv As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_xoa As Button
    Friend WithEvents bt_sua As Button
    Friend WithEvents bt_luu As Button
    Friend WithEvents bt_them As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tb_timkiem As TextBox
    Friend WithEvents cbb_timkiem As ComboBox
    Friend WithEvents bt_vecuoi As Button
    Friend WithEvents bt_next As Button
    Friend WithEvents bt_vedau As Button
    Friend WithEvents bt_back As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HọcSinhToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GiáoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LớpHọcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TàiKhoảnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TìmKiếmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XuấtXMLToolStripMenuItem As ToolStripMenuItem
End Class
