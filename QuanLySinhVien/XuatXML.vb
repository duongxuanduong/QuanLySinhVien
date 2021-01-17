Imports System.Xml
Imports System.Data.SqlClient
Public Class XuatXML
    Dim con As New SqlConnection
    Dim con1 As New SqlConnection
    Public Sub taoketnoi()
        Dim str_ketnoi As String = "Data Source=DESKTOP-4CH846O\NGUYENHUUTUAN;Initial Catalog=QuanLySinhVien;Integrated Security=True"
        con.ConnectionString = str_ketnoi
        con.Open()
    End Sub
    Public Sub taoketnoi1()
        Dim str_ketnoi As String = "Data Source=DESKTOP-4CH846O\NGUYENHUUTUAN;Initial Catalog=QuanLySinhVien;Integrated Security=True"
        con1.ConnectionString = str_ketnoi
        con1.Open()
    End Sub
    Public Function loaddulieu() As DataSet
        taoketnoi()
        Dim ds As New DataSet
        Dim sql As String = "SELECT name FROM sys.databases"
        Dim da As New SqlDataAdapter(sql, con)
        da.Fill(ds)
        con.Close()
        Return ds

    End Function
    Public Function load_table(sql As String) As DataSet
        taoketnoi1()
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(sql, con1)
        da.Fill(ds)
        con1.Close()
        Return ds

    End Function

    Private Sub cob_database_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_database.SelectedIndexChanged
        Try
            Dim ds As New DataSet
            ds = load_table("SELECT table_name FROM information_schema.tables")
            cob_table.DataSource = ds.Tables(0)
            cob_table.DisplayMember = "table_name"
            cob_table.ValueMember = "table_name"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_xuatxml_Click(sender As Object, e As EventArgs) Handles btn_xuatxml.Click
        SaveFileDialog1.Filter = "tên file|*.xml"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim ds As New DataSet
            ds = load_table("SELECT * FROM " & cob_table.Text)
            ds.WriteXml(SaveFileDialog1.FileName)
        End If
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet
        ds = loaddulieu()
        cob_database.DataSource = ds.Tables(0)
        cob_database.DisplayMember = "name"
        cob_database.ValueMember = "name"
        txt_database.Text = "Quản Lý Sinh Viên"
        txt_tenserver.Text = "DESKTOP-4CH846O\NGUYENHUUTUAN"

        Try
            Dim ds1 As New DataSet
            ds1 = load_table("SELECT table_name FROM information_schema.tables")
            cob_table.DataSource = ds1.Tables(0)
            cob_table.DisplayMember = "table_name"
            cob_table.ValueMember = "table_name"
        Catch ex As Exception

        End Try
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

    Private Sub XuatXML_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormDangNhap.Show()
        Me.Hide()
    End Sub
End Class