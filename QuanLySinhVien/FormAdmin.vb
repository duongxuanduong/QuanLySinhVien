Public Class FormAdmin
    Private Sub HọcSinhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HọcSinhToolStripMenuItem.Click
        FormSinhVien.Show()
        Me.Hide()
    End Sub

    Private Sub ThoátToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem2.Click
        Me.Close()
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

    Private Sub TìmKiếmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKiếmToolStripMenuItem.Click
        FormTimKiem.Show()
        Me.Hide()
    End Sub

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub XuấtXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XuấtXMLToolStripMenuItem.Click
        XuatXML.Show()
        Me.Hide()
    End Sub

    Private Sub FormAdmin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormDangNhap.Show()
    End Sub
End Class
