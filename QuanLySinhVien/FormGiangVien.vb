Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class FormGiangVien
    Private con As SqlConnection
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String

    Private Sub Connection()
        Dim cn As String = "Data Source=DESKTOP-A8F0E3F;Initial Catalog=QuanLySinhVien;Integrated Security=True"
        Try
            con = New SqlConnection(cn)
        Catch ex As Exception
            MessageBox.Show("Lỗi")
        End Try
    End Sub

    Private Sub FormGiaoVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        xuat_giangvien()
        danh_sach_moi(sender, e)
        tb_mgv.Enabled = False
    End Sub
    Private Sub xuat_giangvien()
        con.Open()
        Dim dap As SqlDataAdapter = New SqlDataAdapter("select * from tblGiangVien", con)
        Dim table As New DataTable("tblGiangVien")
        dap.Fill(table)
        con.Close()
        DataGridView1.DataSource = table
        danh_sach = Me.BindingContext(table)
    End Sub
    Private Sub danh_sach_moi(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        Try
            tb_mgv.Text = danh_sach.Current("MaGV")
            tb_hoten.Text = danh_sach.Current("HoTen")
            tb_diachi.Text = danh_sach.Current("DiaChi")
            tb_ngaysinh.Text = danh_sach.Current("NgaySinh")
            cbb_gioitinh.Text = danh_sach.Current("GioiTinh")
            tb_sdt.Text = danh_sach.Current("SDT")
        Catch ex As Exception
            MsgBox("Không có dữ liệu")
        End Try
    End Sub

    Private Sub bt_them_Click(sender As Object, e As EventArgs) Handles bt_them.Click
        tb_mgv.Text = ""
        tb_hoten.Text = ""
        tb_diachi.Text = ""
        tb_ngaysinh.Text = ""
        tb_sdt.Text = ""
        tb_mgv.Enabled = True
    End Sub

    Private Sub bt_luu_Click(sender As Object, e As EventArgs) Handles bt_luu.Click
        If MsgBox("Bạn có muốn lưu không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            Try
                con.Open()
                lenh = "insert into tblGiangVien(magv,hoten,ngaysinh,gioitinh,diachi,sdt) values('" & Trim(tb_mgv.Text) & "', N'" & tb_hoten.Text & "', '" & tb_ngaysinh.Text & "',N'" & cbb_gioitinh.Text & "',N'" & tb_diachi.Text & "','" & Trim(tb_sdt.Text) & "')"
                Dim cmd As New SqlCommand(lenh, con)
                cmd.ExecuteNonQuery()
                con.Close()
                xuat_giangvien()
                MsgBox("Thêm thành công")
            Catch ex As Exception
                con.Close()
                MsgBox("Lỗi giá trị nhập!!!")
            End Try
        End If
        tb_mgv.Enabled = False
    End Sub

    Private Sub bt_sua_click(sender As Object, e As EventArgs) Handles bt_sua.Click
        If MsgBox("Bạn có muốn lưu không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            Try
                con.Open()
                lenh = "Update tblGiangVien Set  magv =  '" & Trim(tb_mgv.Text) & "', hoten =N'" & tb_hoten.Text & "',ngaysinh = '" & tb_ngaysinh.Text & "' ,gioitinh = N'" & cbb_gioitinh.Text & "' ,sdt = '" & Trim(tb_sdt.Text) & "' ,diachi = N'" & tb_diachi.Text & "' where magv =  '" & Trim(tb_mgv.Text) & "'"
                Dim cmd As New SqlCommand(lenh, con)
                cmd.ExecuteNonQuery()
                con.Close()
                xuat_giangvien()
                MsgBox("Sửa thành công")
            Catch ex As Exception
                con.Close()
                MsgBox("Lỗi giá trị nhập!!!!")
            End Try
        End If
        tb_mgv.Enabled = False
    End Sub

    Private Sub bt_xoa_Click(sender As Object, e As EventArgs) Handles bt_xoa.Click
        If MsgBox("Bạn có muốn xóa không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            Try
                con.Open()
                lenh = "Delete from tblGiangVien where magv =  '" & Trim(tb_mgv.Text) & "'"
                Dim cmd As New SqlCommand(lenh, con)
                cmd.ExecuteNonQuery()
                con.Close()
                xuat_giangvien()
                MsgBox("Xóa thành công")
            Catch ex As Exception
                con.Close()
                MsgBox("Vui lòng chọn đúng trường !!!")
            End Try
        End If
        tb_mgv.Enabled = False
    End Sub


    Private Sub bt_vedau_Click(sender As Object, e As EventArgs) Handles bt_vedau.Click
        If danh_sach.Position = 0 Then
            MsgBox("Đã về Đầu")
        Else
            danh_sach.Position = 0
        End If
    End Sub

    Private Sub bt_back_Click(sender As Object, e As EventArgs) Handles bt_back.Click
        If danh_sach.Position = danh_sach.Count - 1 Then
            MsgBox("Đã về cuối")
        Else
            danh_sach.Position += 1
        End If
    End Sub

    Private Sub bt_next_Click(sender As Object, e As EventArgs) Handles bt_next.Click
        If danh_sach.Position = 0 Then
            MsgBox("Đã về đầu")
        Else
            danh_sach.Position -= 1
        End If
    End Sub

    Private Sub bt_vecuoi_Click(sender As Object, e As EventArgs) Handles bt_vecuoi.Click
        If danh_sach.Position = danh_sach.Count - 1 Then
            MsgBox("Đã về cuối")
        Else
            danh_sach.Position = danh_sach.Count - 1
        End If
    End Sub
    Private Sub SearchTeacher(value As String, str As String)
        Try
            con.Open()
            Dim dap As SqlDataAdapter = New SqlDataAdapter("select  * from tblGiangVien where  " & value & " LIKE N'%" & str & "%'", con)
            Dim table As New DataTable("tblGiangVien")
            dap.Fill(table)
            con.Close()
            DataGridView1.DataSource = table
            danh_sach = Me.BindingContext(table)
        Catch ex As Exception
            con.Close()
            MsgBox("Vui lòng chọn trường cần tìm kiếm")
        End Try
        'con.Open()
        'Dim dap As SqlDataAdapter = New SqlDataAdapter("select  * from tblGiaoVien where  " & value & " LIKE N'%" & str & "%'", con)
        'Dim table As New DataTable("tblGiaoVien")
        'dap.Fill(table)
        'con.Close()
        'DataGridView1.DataSource = table
        'danh_sach = Me.BindingContext(table)
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tb_timkiem.TextChanged
        Dim value As String = cbb_timkiem.Text
        Dim str As String = tb_timkiem.Text
        SearchTeacher(value, str)
    End Sub

    Private Sub HọcSinhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HọcSinhToolStripMenuItem.Click
        FormSinhVien.Show()
        Me.Hide()
    End Sub

    Private Sub ThoátToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem2.Click
        Me.Close()
        FormAdmin.Close()
    End Sub

    Private Sub LớpHọcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LớpHọcToolStripMenuItem.Click
        FormLop.Show()
        Me.Hide()
    End Sub



    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        FormAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        FormDangNhap.Show()
        Me.Hide()
    End Sub

    Private Sub TàiKhoảnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TàiKhoảnToolStripMenuItem.Click
        FormTaiKhoan.Show()
        Me.Hide()
    End Sub

    Private Sub TìmKiếmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKiếmToolStripMenuItem.Click
        FormTimKiem.Show()
        Me.Hide()
    End Sub

    Private Sub XuấtXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XuấtXMLToolStripMenuItem.Click
        XuatXML.Show()
        Me.Hide()
    End Sub

End Class