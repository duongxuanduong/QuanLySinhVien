Imports System.Data.SqlClient

Public Class FormTaiKhoan
    Private con As SqlConnection
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String
    Public tentk As String = FormDangNhap.tentk.ToString

    Private Sub FormTaiKhoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New ConnectionDB().connect()
        xuat_taikhoan()
        danh_sach_moi(sender, e)
        tb_tentk.Enabled = False
    End Sub
    Private Sub xuat_taikhoan()
        con.Open()
        Dim dap As SqlDataAdapter = New SqlDataAdapter("select  * from tblTaiKhoan where TenTK = '" & tentk & "'", con)
        Dim table As New DataTable("tblTaiKhoan")
        dap.Fill(table)
        con.Close()
        DataGridView1.DataSource = table
        danh_sach = Me.BindingContext(table)
    End Sub

    Private Sub danh_sach_moi(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        Try
            tb_tentk.Text = danh_sach.Current("TenTK")
            tb_matkhau.Text = danh_sach.Current("MatKhau")
            tb_thongtin.Text = danh_sach.Current("ThongTin")
            tb_sdt.Text = danh_sach.Current("SDT")
            tb_email.Text = danh_sach.Current("email")
        Catch ex As Exception
            MsgBox("Không có dữ liệu")
        End Try
    End Sub


    Private Sub bt_sua_Click(sender As Object, e As EventArgs) Handles bt_sua.Click
        If MsgBox("Bạn có muốn sửa không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            Try
                con.Open()
                lenh = "Update tblTaiKhoan Set  tentk =  '" & Trim(tb_tentk.Text) & "', matkhau ='" & tb_matkhau.Text & "',thongtin = N'" & tb_thongtin.Text & "' ,SDT = '" & tb_sdt.Text & "' ,email = '" & tb_email.Text & "' where tentk =  '" & Trim(tentk) & "'"
                Dim cmd As New SqlCommand(lenh, con)
                cmd.ExecuteNonQuery()
                con.Close()
                xuat_taikhoan()
                MsgBox("Sửa thành công")
            Catch ex As Exception
                con.Close()
                MsgBox("Lỗi giá trị nhập!!!")
            End Try
        End If
    End Sub

    Private Sub bt_xoa_Click(sender As Object, e As EventArgs) Handles bt_xoa.Click
        If MsgBox("Bạn có muốn xóa không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            Try
                con.Open()
                lenh = "delete from tblTaiKhoan where TenTk = '" & Trim(tentk) & "'"
                Dim cmd As New SqlCommand(lenh, con)
                cmd.ExecuteNonQuery()
                con.Close()
                xuat_taikhoan()
                MsgBox("Xóa thành công")
            Catch ex As Exception
                con.Close()
                MsgBox("Vui lòng chọn đúng trường !!!")
            End Try
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

    Private Sub HọcSinhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HọcSinhToolStripMenuItem.Click
        FormSinhVien.Show()
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

    Private Sub FormTaiKhoan_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormDangNhap.Show()
        Me.Hide()
    End Sub
End Class