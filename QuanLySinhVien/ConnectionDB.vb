Imports System.Data.SqlClient

Public Class ConnectionDB
    Private con As SqlConnection

    Public Sub New()

    End Sub
    Public Function connect()
        Dim cn As String = "Data Source=DESKTOP-4CH846O\NGUYENHUUTUAN;Initial Catalog=QuanLySinhVien;Integrated Security=True"
        Try
            con = New SqlConnection(cn)
        Catch ex As Exception
            MessageBox.Show("Lỗi")
        End Try
        Return con
    End Function

End Class
