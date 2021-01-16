Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class FormTimKiem
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
    Private Sub FormTimKiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub xuat()
        Dim DiaChi As String = ""
        Dim GioiTinh As String = ""
        Dim Ten As String = ""
        Dim NgaySinh As String = ""
        Dim sql As String = ""
        If tb_diachi.Text = "" Then
            DiaChi = "%"
        Else
            DiaChi = tb_diachi.Text
        End If

        If cbb_gioitinh.Text = "" Then
            GioiTinh = "%"
        Else
            GioiTinh = cbb_gioitinh.Text
        End If

        If tb_hoten.Text = "" Then
            Ten = "%"
        Else
            Ten = tb_hoten.Text
        End If

        If tb_ngaysinh.Text = "" Then
            NgaySinh = "%"
        Else
            NgaySinh = tb_ngaysinh.Text
        End If

        If Trim(cbb_tk.Text) = Trim("Giảng Viên") Then
            sql = "select  * from tblGiangVien where HoTen like N'%" & Ten & "%' and DiaChi like N'%" & DiaChi & "%' 
                                                            and GioiTinh like N'%" & GioiTinh & "%' and NgaySinh like N'%" & NgaySinh & "%'"
        Else
            sql = "select  * from tblSinhVien where HoTen like N'%" & Ten & "%' and DiaChi like N'%" & DiaChi & "%'
                                                            and GioiTinh like N'%" & GioiTinh & "%' and NgaySinh like N'%" & NgaySinh & "%'"
        End If
        con.Open()
        Dim dap As SqlDataAdapter = New SqlDataAdapter(sql, con)
        Dim table As New DataTable("tblSinhVien")
        dap.Fill(table)
        con.Close()
        DataGridView1.DataSource = table
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Connection()
        xuat()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tb_diachi.Text = ""
        tb_hoten.Text = ""
        tb_ngaysinh.Text = ""
        cbb_gioitinh.Text = ""
    End Sub


    Private Sub ThoátToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem2.Click

        FormAdmin.Close()
    End Sub

    Private Sub HọcSinhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HọcSinhToolStripMenuItem.Click
        FormSinhVien.Show()
        Me.Hide()
    End Sub

    Private Sub GiáoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiáoToolStripMenuItem.Click
        FormGiangVien.Show()
        Me.Hide()
    End Sub

    Private Sub LớpHọcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LớpHọcToolStripMenuItem.Click

    End Sub

    Private Sub TàiKhoảnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TàiKhoảnToolStripMenuItem.Click
        FormTaiKhoan.Show()
        Me.Hide()
    End Sub

    Private Sub XuấtXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XuấtXMLToolStripMenuItem.Click
        XuatXML.Show()
        Me.Hide()
    End Sub

End Class