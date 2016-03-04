Public Class Frm_Start



    Private Sub bnt_dangnhap_Click(sender As Object, e As EventArgs) Handles bnt_dangnhap.Click
        If txt_dangnhap.Text = "khoitmps03314" And
            txt_matkhau.Text = "12345" Or
            txt_dangnhap.Text = "admin" And
            txt_matkhau.Text = "admin" Then
            frm_menu.Show()
            Me.Hide()
        Else
            MessageBox.Show("Đăng nhập sai", "Đăng nhập sai", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class