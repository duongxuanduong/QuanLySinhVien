<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDangNhap
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_taikhoan = New System.Windows.Forms.TextBox()
        Me.tb_matkhau = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bt_dangnhap = New System.Windows.Forms.Button()
        Me.tb_thoat = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(278, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tài Khoản"
        '
        'tb_taikhoan
        '
        Me.tb_taikhoan.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_taikhoan.Location = New System.Drawing.Point(394, 87)
        Me.tb_taikhoan.Name = "tb_taikhoan"
        Me.tb_taikhoan.Size = New System.Drawing.Size(123, 26)
        Me.tb_taikhoan.TabIndex = 1
        '
        'tb_matkhau
        '
        Me.tb_matkhau.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_matkhau.Location = New System.Drawing.Point(394, 133)
        Me.tb_matkhau.Name = "tb_matkhau"
        Me.tb_matkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_matkhau.Size = New System.Drawing.Size(123, 26)
        Me.tb_matkhau.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(278, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mật khẩu"
        '
        'bt_dangnhap
        '
        Me.bt_dangnhap.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_dangnhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_dangnhap.Location = New System.Drawing.Point(282, 215)
        Me.bt_dangnhap.Name = "bt_dangnhap"
        Me.bt_dangnhap.Size = New System.Drawing.Size(102, 33)
        Me.bt_dangnhap.TabIndex = 4
        Me.bt_dangnhap.Text = "Đăng Nhập"
        Me.bt_dangnhap.UseVisualStyleBackColor = False
        '
        'tb_thoat
        '
        Me.tb_thoat.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_thoat.ForeColor = System.Drawing.Color.Red
        Me.tb_thoat.Location = New System.Drawing.Point(417, 215)
        Me.tb_thoat.Name = "tb_thoat"
        Me.tb_thoat.Size = New System.Drawing.Size(100, 33)
        Me.tb_thoat.TabIndex = 5
        Me.tb_thoat.Text = "Thoát"
        Me.tb_thoat.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.QuanLySinhVien.My.Resources.Resources.unnamed
        Me.PictureBox1.Location = New System.Drawing.Point(11, 24)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(262, 271)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(317, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 36)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ĐĂNG NHẬP"
        '
        'FormDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuanLySinhVien.My.Resources.Resources.simple_blue_background_abstract_photo_blue_background
        Me.ClientSize = New System.Drawing.Size(552, 306)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tb_thoat)
        Me.Controls.Add(Me.bt_dangnhap)
        Me.Controls.Add(Me.tb_matkhau)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_taikhoan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormDangNhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDangNhap"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tb_taikhoan As TextBox
    Friend WithEvents tb_matkhau As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bt_dangnhap As Button
    Friend WithEvents tb_thoat As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
