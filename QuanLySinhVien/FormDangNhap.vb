Imports System.Data.SqlClient
Public Class FormDangNhap
    Private con As SqlConnection
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String
    Public tentk As String
    Private Sub bt_dangnhap_Click(sender As Object, e As EventArgs) Handles bt_dangnhap.Click
        con = New ConnectionDB().connect()
        Try
            con.Open()
            Dim dap As SqlDataAdapter = New SqlDataAdapter("select * from tblTaiKhoan where TenTK = '" & tb_taikhoan.Text & "' And MatKhau = '" & tb_matkhau.Text & "'", con)
            Dim table As New DataTable("tblTaiKhoan")
            dap.Fill(table)
            con.Close()
            danh_sach = Me.BindingContext(table)
            tentk = danh_sach.Current("TenTk")
            If table.Rows.Count > 0 Then
                FormAdmin.Show()
                Me.Hide()
            Else
                MsgBox("Tài khoản mật khẩu sai")
            End If
        Catch ex As Exception
            MsgBox("Tài khoản mật khẩu sai")
        End Try
    End Sub

    Private Sub tb_thoat_Click(sender As Object, e As EventArgs) Handles tb_thoat.Click
        Me.Close()
    End Sub

    Private Sub FormDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class