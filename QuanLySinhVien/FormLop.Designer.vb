<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLop))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbb_timkiemp = New System.Windows.Forms.ComboBox()
        Me.tb_timkiem = New System.Windows.Forms.TextBox()
        Me.cbb_timkieml = New System.Windows.Forms.ComboBox()
        Me.cbb_mphong = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_socho = New System.Windows.Forms.TextBox()
        Me.tb_namhoc = New System.Windows.Forms.TextBox()
        Me.tb_tenlop = New System.Windows.Forms.TextBox()
        Me.tb_mlop = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_mphong = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbt_lop = New System.Windows.Forms.RadioButton()
        Me.rbt_phong = New System.Windows.Forms.RadioButton()
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
        Me.bt_vecuoi = New System.Windows.Forms.Button()
        Me.bt_next = New System.Windows.Forms.Button()
        Me.bt_vedau = New System.Windows.Forms.Button()
        Me.bt_back = New System.Windows.Forms.Button()
        Me.bt_xoa = New System.Windows.Forms.Button()
        Me.bt_sua = New System.Windows.Forms.Button()
        Me.bt_luu = New System.Windows.Forms.Button()
        Me.bt_them = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbb_timkiemp)
        Me.GroupBox1.Controls.Add(Me.tb_timkiem)
        Me.GroupBox1.Controls.Add(Me.cbb_timkieml)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox1.Location = New System.Drawing.Point(539, 241)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(501, 48)
        Me.GroupBox1.TabIndex = 104
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tìm kiếm"
        '
        'cbb_timkiemp
        '
        Me.cbb_timkiemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_timkiemp.FormattingEnabled = True
        Me.cbb_timkiemp.Items.AddRange(New Object() {"MaPhong"})
        Me.cbb_timkiemp.Location = New System.Drawing.Point(27, 15)
        Me.cbb_timkiemp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbb_timkiemp.Name = "cbb_timkiemp"
        Me.cbb_timkiemp.Size = New System.Drawing.Size(139, 24)
        Me.cbb_timkiemp.TabIndex = 63
        '
        'tb_timkiem
        '
        Me.tb_timkiem.Location = New System.Drawing.Point(195, 15)
        Me.tb_timkiem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_timkiem.Name = "tb_timkiem"
        Me.tb_timkiem.Size = New System.Drawing.Size(297, 22)
        Me.tb_timkiem.TabIndex = 62
        '
        'cbb_timkieml
        '
        Me.cbb_timkieml.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_timkieml.FormattingEnabled = True
        Me.cbb_timkieml.Items.AddRange(New Object() {"MaLop", "NienKhoa"})
        Me.cbb_timkieml.Location = New System.Drawing.Point(27, 15)
        Me.cbb_timkieml.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbb_timkieml.Name = "cbb_timkieml"
        Me.cbb_timkieml.Size = New System.Drawing.Size(139, 24)
        Me.cbb_timkieml.TabIndex = 61
        '
        'cbb_mphong
        '
        Me.cbb_mphong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_mphong.FormattingEnabled = True
        Me.cbb_mphong.Location = New System.Drawing.Point(521, 95)
        Me.cbb_mphong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbb_mphong.Name = "cbb_mphong"
        Me.cbb_mphong.Size = New System.Drawing.Size(124, 24)
        Me.cbb_mphong.TabIndex = 103
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label7.Location = New System.Drawing.Point(773, 95)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 24)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Số chỗ"
        '
        'tb_socho
        '
        Me.tb_socho.Location = New System.Drawing.Point(863, 97)
        Me.tb_socho.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_socho.Name = "tb_socho"
        Me.tb_socho.Size = New System.Drawing.Size(141, 22)
        Me.tb_socho.TabIndex = 101
        '
        'tb_namhoc
        '
        Me.tb_namhoc.Location = New System.Drawing.Point(521, 49)
        Me.tb_namhoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_namhoc.Name = "tb_namhoc"
        Me.tb_namhoc.Size = New System.Drawing.Size(124, 22)
        Me.tb_namhoc.TabIndex = 100
        '
        'tb_tenlop
        '
        Me.tb_tenlop.Location = New System.Drawing.Point(193, 95)
        Me.tb_tenlop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_tenlop.Name = "tb_tenlop"
        Me.tb_tenlop.Size = New System.Drawing.Size(111, 22)
        Me.tb_tenlop.TabIndex = 98
        '
        'tb_mlop
        '
        Me.tb_mlop.Location = New System.Drawing.Point(195, 52)
        Me.tb_mlop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_mlop.Name = "tb_mlop"
        Me.tb_mlop.Size = New System.Drawing.Size(111, 22)
        Me.tb_mlop.TabIndex = 97
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(413, 49)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 24)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Niên Khóa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(71, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 24)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Tên Lớp"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(72, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 24)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Mã Lớp"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 302)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(500, 238)
        Me.DataGridView1.TabIndex = 110
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(539, 302)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(500, 238)
        Me.DataGridView2.TabIndex = 111
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label6.Location = New System.Drawing.Point(71, 142)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 24)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "Chọn đối tượng thao tác:"
        '
        'tb_mphong
        '
        Me.tb_mphong.Location = New System.Drawing.Point(521, 95)
        Me.tb_mphong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_mphong.Name = "tb_mphong"
        Me.tb_mphong.Size = New System.Drawing.Size(124, 22)
        Me.tb_mphong.TabIndex = 116
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Location = New System.Drawing.Point(416, 92)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 24)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Mã phòng"
        '
        'rbt_lop
        '
        Me.rbt_lop.AutoSize = True
        Me.rbt_lop.Checked = True
        Me.rbt_lop.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_lop.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.rbt_lop.Location = New System.Drawing.Point(401, 139)
        Me.rbt_lop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbt_lop.Name = "rbt_lop"
        Me.rbt_lop.Size = New System.Drawing.Size(116, 28)
        Me.rbt_lop.TabIndex = 113
        Me.rbt_lop.TabStop = True
        Me.rbt_lop.Text = "Quản lý Lớp"
        Me.rbt_lop.UseVisualStyleBackColor = True
        '
        'rbt_phong
        '
        Me.rbt_phong.AutoSize = True
        Me.rbt_phong.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_phong.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.rbt_phong.Location = New System.Drawing.Point(620, 139)
        Me.rbt_phong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbt_phong.Name = "rbt_phong"
        Me.rbt_phong.Size = New System.Drawing.Size(136, 28)
        Me.rbt_phong.TabIndex = 114
        Me.rbt_phong.Text = "Quản lý Phòng"
        Me.rbt_phong.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.QuảnLýToolStripMenuItem, Me.ThoátToolStripMenuItem, Me.TìmKiếmToolStripMenuItem, Me.XuấtXMLToolStripMenuItem, Me.ThoátToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 28)
        Me.MenuStrip1.TabIndex = 118
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
        'bt_vecuoi
        '
        Me.bt_vecuoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_vecuoi.Image = CType(resources.GetObject("bt_vecuoi.Image"), System.Drawing.Image)
        Me.bt_vecuoi.Location = New System.Drawing.Point(200, 255)
        Me.bt_vecuoi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bt_vecuoi.Name = "bt_vecuoi"
        Me.bt_vecuoi.Size = New System.Drawing.Size(39, 34)
        Me.bt_vecuoi.TabIndex = 108
        Me.bt_vecuoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_vecuoi.UseVisualStyleBackColor = True
        '
        'bt_next
        '
        Me.bt_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_next.Image = Global.QuanLySinhVien.My.Resources.Resources.Annotation_2020_07_11_150957
        Me.bt_next.Location = New System.Drawing.Point(140, 255)
        Me.bt_next.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bt_next.Name = "bt_next"
        Me.bt_next.Size = New System.Drawing.Size(39, 34)
        Me.bt_next.TabIndex = 107
        Me.bt_next.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_next.UseVisualStyleBackColor = True
        '
        'bt_vedau
        '
        Me.bt_vedau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_vedau.Image = Global.QuanLySinhVien.My.Resources.Resources.double_back
        Me.bt_vedau.Location = New System.Drawing.Point(23, 255)
        Me.bt_vedau.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bt_vedau.Name = "bt_vedau"
        Me.bt_vedau.Size = New System.Drawing.Size(39, 34)
        Me.bt_vedau.TabIndex = 106
        Me.bt_vedau.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_vedau.UseVisualStyleBackColor = True
        '
        'bt_back
        '
        Me.bt_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_back.Image = Global.QuanLySinhVien.My.Resources.Resources.icons8_back_161
        Me.bt_back.Location = New System.Drawing.Point(80, 255)
        Me.bt_back.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bt_back.Name = "bt_back"
        Me.bt_back.Size = New System.Drawing.Size(39, 34)
        Me.bt_back.TabIndex = 105
        Me.bt_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_back.UseVisualStyleBackColor = True
        '
        'bt_xoa
        '
        Me.bt_xoa.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bt_xoa.ForeColor = System.Drawing.Color.Black
        Me.bt_xoa.Image = Global.QuanLySinhVien.My.Resources.Resources.icons8_delete_view_40
        Me.bt_xoa.Location = New System.Drawing.Point(820, 187)
        Me.bt_xoa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bt_xoa.Name = "bt_xoa"
        Me.bt_xoa.Size = New System.Drawing.Size(113, 52)
        Me.bt_xoa.TabIndex = 90
        Me.bt_xoa.UseVisualStyleBackColor = False
        '
        'bt_sua
        '
        Me.bt_sua.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bt_sua.ForeColor = System.Drawing.Color.Black
        Me.bt_sua.Image = Global.QuanLySinhVien.My.Resources.Resources.update
        Me.bt_sua.Location = New System.Drawing.Point(592, 187)
        Me.bt_sua.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bt_sua.Name = "bt_sua"
        Me.bt_sua.Size = New System.Drawing.Size(113, 52)
        Me.bt_sua.TabIndex = 89
        Me.bt_sua.UseVisualStyleBackColor = False
        '
        'bt_luu
        '
        Me.bt_luu.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bt_luu.ForeColor = System.Drawing.Color.Black
        Me.bt_luu.Image = Global.QuanLySinhVien.My.Resources.Resources.icons8_save_48
        Me.bt_luu.Location = New System.Drawing.Point(379, 187)
        Me.bt_luu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bt_luu.Name = "bt_luu"
        Me.bt_luu.Size = New System.Drawing.Size(113, 52)
        Me.bt_luu.TabIndex = 88
        Me.bt_luu.UseVisualStyleBackColor = False
        '
        'bt_them
        '
        Me.bt_them.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bt_them.ForeColor = System.Drawing.Color.Black
        Me.bt_them.Image = Global.QuanLySinhVien.My.Resources.Resources.icons8_add_property_40
        Me.bt_them.Location = New System.Drawing.Point(165, 187)
        Me.bt_them.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bt_them.Name = "bt_them"
        Me.bt_them.Size = New System.Drawing.Size(113, 52)
        Me.bt_them.TabIndex = 87
        Me.bt_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_them.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(773, 47)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 24)
        Me.Label3.TabIndex = 119
        '
        'FormLop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.rbt_phong)
        Me.Controls.Add(Me.rbt_lop)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_mphong)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bt_vecuoi)
        Me.Controls.Add(Me.bt_next)
        Me.Controls.Add(Me.bt_vedau)
        Me.Controls.Add(Me.bt_back)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbb_mphong)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tb_socho)
        Me.Controls.Add(Me.tb_namhoc)
        Me.Controls.Add(Me.tb_tenlop)
        Me.Controls.Add(Me.tb_mlop)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_xoa)
        Me.Controls.Add(Me.bt_sua)
        Me.Controls.Add(Me.bt_luu)
        Me.Controls.Add(Me.bt_them)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormLop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLop"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_vecuoi As Button
    Friend WithEvents bt_next As Button
    Friend WithEvents bt_vedau As Button
    Friend WithEvents bt_back As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tb_timkiem As TextBox
    Friend WithEvents cbb_timkieml As ComboBox
    Friend WithEvents cbb_mphong As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tb_socho As TextBox
    Friend WithEvents tb_namhoc As TextBox
    Friend WithEvents tb_tenlop As TextBox
    Friend WithEvents tb_mlop As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_xoa As Button
    Friend WithEvents bt_sua As Button
    Friend WithEvents bt_luu As Button
    Friend WithEvents bt_them As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_mphong As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents rbt_lop As RadioButton
    Friend WithEvents rbt_phong As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HọcSinhToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GiáoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LớpHọcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TàiKhoảnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents cbb_timkiemp As ComboBox
    Friend WithEvents TìmKiếmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents XuấtXMLToolStripMenuItem As ToolStripMenuItem
End Class
