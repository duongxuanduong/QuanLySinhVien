Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class FormSinhVien
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
    Private Sub xuat_sinhvien()
        con.Open()
        Dim dap As SqlDataAdapter = New SqlDataAdapter("select  * from tblSinhVien", con)
        Dim table As New DataTable("tblSinhVien")
        dap.Fill(table)
        con.Close()
        DataGridView1.DataSource = table
        danh_sach = Me.BindingContext(table)
    End Sub
    Private Sub xuat_malop()
        con.Open()
        Dim dap As SqlDataAdapter = New SqlDataAdapter("select  MaLop from tblLop", con)
        Dim table As New DataTable("tblLop")
        dap.Fill(table)
        con.Close()
        cbb_malop.DisplayMember = "MaLop"
        cbb_malop.ValueMember = "MaLop"
        cbb_malop.DataSource = table
    End Sub
    Private Sub danh_sach_moi(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        Try
            tb_mhs.Text = danh_sach.Current("MaSV")
            tb_hoten.Text = danh_sach.Current("HoTen")
            tb_diachi.Text = danh_sach.Current("DiaChi")
            tb_ngaysinh.Text = danh_sach.Current("NgaySinh")
            cbb_gioitinh.Text = danh_sach.Current("GioiTinh")
            cbb_malop.Text = danh_sach.Current("MaLop")
            tb_sdt.Text = danh_sach.Current("SDT")
        Catch ex As Exception
            MsgBox("Không có dữ liệu")
        End Try
    End Sub
    Private Sub SearchStudent(value As String, str As String)
        Try
            con.Open()
            Dim dap As SqlDataAdapter = New SqlDataAdapter("select  * from tblSinhVien where  " & value & " LIKE N'%" & str & "%'", con)
            Dim table As New DataTable("tblSinhVien")
            dap.Fill(table)
            con.Close()
            DataGridView1.DataSource = table
            danh_sach = Me.BindingContext(table)
        Catch ex As Exception
            con.Close()
            MsgBox("Vui lòng chọn trường cần tìm kiếm")
        End Try
    End Sub
    Private Sub FormHocSinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        xuat_sinhvien()
        xuat_malop()
        danh_sach_moi(sender, e)
        tb_mhs.Enabled = False
    End Sub
    Private Sub bt_them_Click(sender As Object, e As EventArgs) Handles bt_them.Click
        xuat_malop()
        tb_mhs.Text = ""
        tb_hoten.Text = ""
        tb_diachi.Text = ""
        tb_ngaysinh.Text = ""
        tb_sdt.Text = ""
        tb_mhs.Enabled = True
    End Sub

    Private Sub bt_luu_Click(sender As Object, e As EventArgs) Handles bt_luu.Click
        If MsgBox("Bạn có muốn lưu không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            Try
                con.Open()
                lenh = "insert into tblSinhVien(masv,hoten,ngaysinh,gioitinh,diachi,sdt,malop) values('" & Trim(tb_mhs.Text) & "',
                                            N'" & tb_hoten.Text & "', '" & tb_ngaysinh.Text & "',N'" & cbb_gioitinh.Text & "',N'" & tb_diachi.Text & "'
                                            ,'" & Trim(tb_sdt.Text) & "','" & cbb_malop.Text & "')"
                Dim cmd As New SqlCommand(lenh, con)
                cmd.ExecuteNonQuery()
                con.Close()
                xuat_sinhvien()
                MsgBox("Thêm thành công")
            Catch ex As Exception
                con.Close()
                MsgBox("Lỗi giá trị nhập!!!")
            End Try
        End If
        tb_mhs.Enabled = False
    End Sub

    Private Sub bt_sua_Click(sender As Object, e As EventArgs) Handles bt_sua.Click
        If MsgBox("Bạn có muốn sửa không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            Try
                con.Open()
                lenh = "Update tblSinhVien Set  masv =  '" & Trim(tb_mhs.Text) & "', hoten =N'" & tb_hoten.Text & "',ngaysinh = '" & tb_ngaysinh.Text & "' ,
                                                        gioitinh = N'" & cbb_gioitinh.Text & "' ,sdt = '" & tb_sdt.Text & "' ,malop = '" & cbb_malop.Text & "'
                                                        ,diachi = N'" & Trim(tb_diachi.Text) & "' where mahs =  '" & Trim(tb_mhs.Text) & "'"
                Dim cmd As New SqlCommand(lenh, con)
                cmd.ExecuteNonQuery()
                con.Close()
                xuat_sinhvien()
                MsgBox("Sửa thành công")
            Catch ex As Exception
                con.Close()
                MsgBox("Lỗi giá trị nhập!!!")
            End Try
        End If
        tb_mhs.Enabled = False
    End Sub

    Private Sub bt_xoa_Click(sender As Object, e As EventArgs) Handles bt_xoa.Click
        If MsgBox("Bạn có muốn xóa không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            Try
                con.Open()
                lenh = "delete from tblSinhVien where MaSV = '" & Trim(tb_mhs.Text) & "'"
                Dim cmd As New SqlCommand(lenh, con)
                cmd.ExecuteNonQuery()
                con.Close()
                xuat_sinhvien()
                MsgBox("Xóa thành công")
            Catch ex As Exception
                con.Close()
                MsgBox("Vui lòng chọn đúng trường !!!")
            End Try
        End If
        tb_mhs.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tb_timkiem.TextChanged
        Dim value As String = cbb_timkiem.Text
        Dim str As String = tb_timkiem.Text
        SearchStudent(value, str)
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


    Private Sub ThoátToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem2.Click
        Me.Close()
        FormAdmin.Close()
    End Sub

    Private Sub GiáoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiáoToolStripMenuItem.Click
        FormGiangVien.Show()
        Me.Hide()
    End Sub

    Private Sub LớpHọcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LớpHọcToolStripMenuItem.Click
        FormLop.Show()
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


    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        FormAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub HọcSinhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HọcSinhToolStripMenuItem.Click
        xuat_malop()
    End Sub

    Private Sub TimKiếmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimKiếmToolStripMenuItem.Click
        FormTimKiem.Show()
        Me.Hide()
    End Sub

    Private Sub XuấtXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XuấtXMLToolStripMenuItem.Click
        XuatXML.Show()
        Me.Hide()
    End Sub
End Class