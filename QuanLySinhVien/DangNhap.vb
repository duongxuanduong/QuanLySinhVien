Imports System.Data.SqlClient

Public Class DangNhap
    Private con As SqlConnection
    Public lenh As String
    Private Sub bt_thoat_Click(sender As Object, e As EventArgs) Handles bt_thoat.Click
        Me.Close()
    End Sub

    Private Sub Connection()
        Dim cn As String = "Data Source=DESKTOP-D5R1A3V;Initial Catalog=QuanLyMamNon;Integrated Security=True"
        Try
            con = New SqlConnection(cn)
        Catch ex As Exception
            MessageBox.Show("Lỗi")
        End Try
    End Sub
    Private Sub DangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim dap As SqlDataAdapter = New SqlDataAdapter("select  * from tblTaKhoan where Taikhoan = '" & t & "'", con)
        Dim table As New DataTable("tblHocSinh")
        dap.Fill(table)
        con.Close()
        If table.Columns.Count > 0 Then

        End If
    End Sub
End Class