Imports System.Data.SqlClient

Public Class FormLop
    Private con As SqlConnection
    Private WithEvents danh_sach1 As BindingManagerBase
    Private WithEvents danh_sach2 As BindingManagerBase
    Public lenh As String

    Private Sub Connection()
        Dim cn As String = "Data Source=DESKTOP-A8F0E3F;Initial Catalog=QuanLySinhVien;Integrated Security=True"
        Try
            con = New SqlConnection(cn)
        Catch ex As Exception
            MessageBox.Show("Lỗi")
        End Try
    End Sub


    Private Sub rbt_lop_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_lop.CheckedChanged

        cbb_timkiemp.Visible = False
        cbb_timkieml.Visible = True


        cbb_mphong.Visible = True

        tb_mphong.Visible = False
        tb_mphong.Text = " "

        tb_socho.Text = " "
        tb_socho.Enabled = False

        tb_mlop.Text = " "
        tb_mlop.Enabled = True

        tb_tenlop.Text = " "
        tb_tenlop.Enabled = True


        tb_namhoc.Text = " "
        tb_namhoc.Enabled = True

        Connection()
        xuat_maphong()
        xuat_lop()
        danh_sach_moi1(sender, e)
        tb_mlop.Enabled = False

    End Sub

    Private Sub rbt_phong_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_phong.CheckedChanged

        cbb_timkiemp.Visible = True
        cbb_timkieml.Visible = False

        cbb_mphong.Visible = False

        tb_mphong.Visible = True
        tb_mphong.Text = " "

        tb_socho.Text = " "
        tb_socho.Enabled = True

        tb_mlop.Text = " "
        tb_mlop.Enabled = False

        tb_tenlop.Text = " "
        tb_tenlop.Enabled = False


        tb_namhoc.Text = " "
        tb_namhoc.Enabled = False

        tb_tenlop.Text = " "
        tb_tenlop.Enabled = False

        Connection()
        xuat_phong()
        tb_mphong.Enabled = False

    End Sub

    Private Sub xuat_lop()
        con.Open()
        Dim dap As SqlDataAdapter = New SqlDataAdapter("select * from tblLop", con)
        Dim table As New DataTable("tblLop")
        dap.Fill(table)
        con.Close()
        DataGridView1.DataSource = table
        danh_sach1 = Me.BindingContext(table)
    End Sub

    Private Sub xuat_phong()
        con.Open()
        Dim dap As SqlDataAdapter = New SqlDataAdapter("select * from tblPhongHoc", con)
        Dim table As New DataTable("tblPhongHoc")
        dap.Fill(table)
        con.Close()
        DataGridView2.DataSource = table
        danh_sach2 = Me.BindingContext(table)
    End Sub

    Private Sub danh_sach_moi1(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach1.PositionChanged
        Try
            tb_mlop.Text = danh_sach1.Current("MaLop")
            tb_tenlop.Text = danh_sach1.Current("TenLop")
            tb_namhoc.Text = danh_sach1.Current("NienKhoa")
            cbb_mphong.Text = danh_sach1.Current("MaPhong")
        Catch ex As Exception
            MsgBox("Không có dữ liệu")
        End Try
    End Sub

    Private Sub danh_sach_moi2(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach2.PositionChanged
        Try
            tb_mphong.Text = danh_sach2.Current("MaPhong")
            tb_socho.Text = danh_sach2.Current("SoCho")
        Catch ex As Exception
            MsgBox("Không có dữ liệu")
        End Try
    End Sub

    Private Sub xuat_maphong()
        con.Open()
        Dim dap As SqlDataAdapter = New SqlDataAdapter("select  MaPhong from tblPhongHoc", con)
        Dim table As New DataTable("tblPhongHoc")
        dap.Fill(table)
        con.Close()
        cbb_mphong.DisplayMember = "MaPhong"
        cbb_mphong.ValueMember = "MaPhong"
        cbb_mphong.DataSource = table
    End Sub
    Private Sub FormLop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bt_them_Click(sender As Object, e As EventArgs) Handles bt_them.Click
        If rbt_lop.Checked Then
            tb_mlop.Text = ""
            tb_tenlop.Text = ""
            tb_namhoc.Text = ""
            tb_mlop.Enabled = True
        Else
            tb_mphong.Text = " "
            tb_socho.Text = " "
            tb_mphong.Enabled = True
        End If
    End Sub

    Private Sub bt_luu_Click(sender As Object, e As EventArgs) Handles bt_luu.Click
        If rbt_lop.Checked Then
            If MsgBox("Bạn có muốn lưu không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
                Try
                    con.Open()
                    lenh = " "
                    lenh = "insert into tblLop(MaLop,TenLop,NienKhoa,MaPhong) values('" & Trim(tb_mlop.Text) & "', N'" & tb_tenlop.Text & "', '" & tb_namhoc.Text & "','" & cbb_mphong.Text & "')"
                    Label3.Text = lenh
                    Dim cmd As New SqlCommand(lenh, con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    xuat_lop()
                    MsgBox("Thêm thành công")
                Catch ex As Exception
                    MsgBox("Lỗi giá trị nhập!!!")
                    con.Close()
                End Try
            End If
            tb_mlop.Enabled = False
        Else
            If MsgBox("Bạn có muốn lưu không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
                Try
                    con.Open()
                    lenh = " "
                    lenh = "insert into tblPhongHoc(MaPhong, SoCho) values('" & Trim(tb_mphong.Text) & "', N'" & tb_socho.Text & "')"
                    Dim cmd As New SqlCommand(lenh, con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    xuat_phong()
                    MsgBox("Thêm thành công")
                Catch ex As Exception
                    MsgBox("Lỗi giá trị nhập!!!")
                    con.Close()
                End Try
            End If
            tb_mphong.Enabled = False
        End If
    End Sub

    Private Sub bt_xoa_Click(sender As Object, e As EventArgs) Handles bt_xoa.Click
        If rbt_lop.Checked Then
            If MsgBox("Bạn có muốn xóa không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
                Try
                    con.Open()
                    lenh = "delete from tblLop where MaLop = '" & Trim(tb_mlop.Text) & "'"
                    Dim cmd As New SqlCommand(lenh, con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    xuat_lop()
                    MsgBox("Xóa thành công")
                Catch ex As Exception
                    con.Close()
                    MsgBox("Vui lòng chọn đúng trường !!!")
                End Try
            End If
            tb_mlop.Enabled = False
        Else
            If MsgBox("Bạn có muốn xóa không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
                Try
                    con.Open()
                    lenh = "delete from tblPhongHoc where MaPhong = '" & Trim(tb_mphong.Text) & "'"
                    Dim cmd As New SqlCommand(lenh, con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    xuat_phong()
                    MsgBox("Xóa thành công")
                Catch ex As Exception
                    con.Close()
                    MsgBox("Vui lòng chọn đúng trường !!!")
                End Try
            End If
            tb_mphong.Enabled = False
        End If
    End Sub

    Private Sub bt_sua_Click(sender As Object, e As EventArgs) Handles bt_sua.Click
        If rbt_lop.Checked Then
            If MsgBox("Bạn có muốn sửa không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
                Try
                    con.Open()
                    lenh = "Update tblLop Set  malop =  '" & Trim(tb_mlop.Text) & "', tenlop =N'" & tb_tenlop.Text & "',nienkhoa = '" & tb_namhoc.Text & "' ,maphong = '" & cbb_mphong.Text & "' where malop =  '" & Trim(tb_mlop.Text) & "'"
                    Dim cmd As New SqlCommand(lenh, con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    xuat_lop()
                    MsgBox("Sửa thành công")
                Catch ex As Exception
                    con.Close()
                    MsgBox("Lỗi giá trị nhập!!!")
                End Try
            End If
            tb_mlop.Enabled = False
        Else
            If MsgBox("Bạn có muốn sửa không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
                Try
                    con.Open()
                    lenh = "Update tblPhongHoc Set  maphong =  '" & Trim(tb_mphong.Text) & "', socho =N'" & tb_socho.Text & "' where maphong =  '" & Trim(tb_mphong.Text) & "'"
                    Dim cmd As New SqlCommand(lenh, con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    xuat_phong()
                    MsgBox("Sửa thành công")
                Catch ex As Exception
                    con.Close()
                    MsgBox("Lỗi giá trị nhập!!!")
                End Try
            End If
            tb_mphong.Enabled = False
        End If
    End Sub
    Private Sub Search(value As String, str As String, tb As String)
        Try
            con.Open()
            Dim dap As SqlDataAdapter = New SqlDataAdapter("select  * from " & tb & " where  " & value & " LIKE '%" & str & "%'", con)
            Dim table As New DataTable(tb)
            dap.Fill(table)
            con.Close()
            If tb = "tblLop" Then
                DataGridView1.DataSource = table
            Else
                DataGridView2.DataSource = table
            End If
            danh_sach1 = Me.BindingContext(table)
        Catch ex As Exception
            con.Close()
            Label4.Text = "select  * from " & tb & " where  " & value & " LIKE '%" & str & "%'"
            MsgBox("Vui lòng chọn trường cần tìm kiếm")
        End Try
    End Sub
    Private Sub tb_timkiem_TextChanged(sender As Object, e As EventArgs) Handles tb_timkiem.TextChanged
        If rbt_lop.Checked Then
            Dim value As String = cbb_timkieml.Text
            Dim str As String = tb_timkiem.Text
            Search(value, str, "tblLop")
        Else
            Dim value As String = cbb_timkiemp.Text
            Dim str As String = tb_timkiem.Text
            Search(value, str, "tblPhongHoc")
        End If
    End Sub
    Private Sub bt_vedau_Click(sender As Object, e As EventArgs) Handles bt_vedau.Click
        If rbt_lop.Checked Then
            If danh_sach1.Position = 0 Then
                MsgBox("Đã về Đầu")
            Else
                danh_sach1.Position = 0
            End If
        Else
            If danh_sach2.Position = 0 Then
                MsgBox("Đã về Đầu")
            Else
                danh_sach2.Position = 0
            End If
        End If
    End Sub

    Private Sub bt_back_Click(sender As Object, e As EventArgs) Handles bt_back.Click
        If rbt_lop.Checked Then
            If danh_sach1.Position = danh_sach1.Count - 1 Then
                MsgBox("Đã về cuối")
            Else
                danh_sach1.Position += 1
            End If
        Else
            If danh_sach2.Position = danh_sach2.Count - 1 Then
                MsgBox("Đã về cuối")
            Else
                danh_sach2.Position += 1
            End If
        End If
    End Sub

    Private Sub bt_next_Click(sender As Object, e As EventArgs) Handles bt_next.Click
        If rbt_lop.Checked Then
            If danh_sach1.Position = 0 Then
                MsgBox("Đã về đầu")
            Else
                danh_sach1.Position -= 1
            End If
        Else
            If danh_sach2.Position = 0 Then
                MsgBox("Đã về đầu")
            Else
                danh_sach2.Position -= 1
            End If
        End If
    End Sub

    Private Sub bt_vecuoi_Click(sender As Object, e As EventArgs) Handles bt_vecuoi.Click
        If rbt_lop.Checked Then
            If danh_sach1.Position = danh_sach1.Count - 1 Then
                MsgBox("Đã về cuối")
            Else
                danh_sach1.Position = danh_sach1.Count - 1
            End If
        Else
            If danh_sach2.Position = danh_sach2.Count - 1 Then
                MsgBox("Đã về cuối")
            Else
                danh_sach2.Position = danh_sach2.Count - 1
            End If
        End If
    End Sub
    Private Sub HọcSinhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HọcSinhToolStripMenuItem.Click
        FormSinhVien.Show()
        Me.Hide()
    End Sub

    Private Sub ThoátToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem2.Click
        Me.Close()
        FormAdmin.Close()
    End Sub

    Private Sub GiáoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiáoToolStripMenuItem.Click
        FormGiangVien.Show()
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