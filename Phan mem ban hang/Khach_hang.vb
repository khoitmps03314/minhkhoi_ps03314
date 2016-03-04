Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frm_kh
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=khoitmpss03314.mssql.somee.com;packet size=4096;user id=khoitmps03314_SQLLogin_1;pwd=d1ghkkqbjy;data source=khoitmpss03314.mssql.somee.com;persist security info=False;initial catalog=khoitmpss03314"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub frm_kh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_xoa.Enabled = False
    End Sub
    Private Sub btn_timkiem_Click(sender As Object, e As EventArgs) Handles btn_timkiem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TenKH as 'Tên KH', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from khach_hang where MaKH like'%" & txt_MaKH.Text & "%' ", connect)
        Try
            If txt_MaKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập MAKH", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgv_KH.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgv_KH.DataSource = db.DefaultView
                    txt_MaKH.Text = Nothing
                    btn_xoa.Enabled = True
                Else
                    MessageBox.Show("Không tìm thấy")
                    txt_MaKH.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dgv_KH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_KH.CellContentClick
        Dim click As Integer = dgv_KH.CurrentCell.RowIndex
        txt_MaKH.Text = dgv_KH.Item(0, click).Value
        txt_Tenkh.Text = dgv_KH.Item(1, click).Value
        txt_diachi.Text = dgv_KH.Item(2, click).Value
        txt_SDT.Text = dgv_KH.Item(3, click).Value
        txt_Email.Text = dgv_KH.Item(4, click).Value
    End Sub






    Private Sub btn_trolai_Click(sender As Object, e As EventArgs) Handles btn_trolai.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim insert As String = "insert into KHACH_HANG values(@MAKH,@TENKH,@DIACHI,@SDT,@EMAIL)"
        Dim save As SqlCommand = New SqlCommand(insert, conn)
        conn.Open()
        Try
            txt_MaKH.Focus()
            If txt_MaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txt_MaKH.Focus()
                If txt_Tenkh.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txt_Tenkh.Focus()
                    If txt_diachi.Text = "" Then
                        MessageBox.Show("Vui lòng nhập địa chỉ", "Nhập Thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txt_diachi.Focus()
                        If txt_SDT.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txt_SDT.Focus()
                            If txt_Email.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                txt_Email.Focus()
                            Else
                                save.Parameters.AddWithValue("@MAKH", txt_MaKH.Text)
                                save.Parameters.AddWithValue("@TENKH", txt_Tenkh.Text)
                                save.Parameters.AddWithValue("@DIACHI", txt_diachi.Text)
                                save.Parameters.AddWithValue("@SDT", txt_SDT.Text)
                                save.Parameters.AddWithValue("@EMAIL", txt_Email.Text)
                                save.ExecuteNonQuery()
                                conn.Close()
                                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txt_MaKH.Text = Nothing
                                txt_Tenkh.Text = Nothing
                                txt_diachi.Text = Nothing
                                txt_SDT.Text = Nothing
                                txt_Email.Text = Nothing

                            End If
                        End If
                    End If
                End If
            End If
        Catch Ex As Exception
            MessageBox.Show("Không được trùng mã khách hàng hoặc nhập quá số ký tự cho phép", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên KH', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHACH_HANG", conn)
        db.Clear()
        refesh.Fill(db)
        dgv_KH.DataSource = db.DefaultView
    End Sub

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim Delete As String = ("DELETE Khach_Hang WHERE MaKH = @MaKH")
        Dim CONNECT As SqlCommand = New SqlCommand(Delete, conn)
        conn.Open()
        Try
            txt_MaKH.Focus()
            If txt_MaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                CONNECT.Parameters.AddWithValue("@MaKH", txt_MaKH.Text)
                CONNECT.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch EX As Exception

            MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        db.Clear()
        dgv_KH.DataSource = db
        dgv_KH.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên KH', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHACH_HANG", conn)

        conn.Open()
        load.Fill(db)
        dgv_KH.DataSource = db.DefaultView
    End Sub

    Private Sub btn_capnhat_Click(sender As Object, e As EventArgs) Handles btn_capnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim update As String = "update KHACH_HANG set MAKH=@MAKH, TENKH=@TENKH, DIACHI=@DIACHI, SDT=@SDT, EMAIL=@EMAIL where MAKH=@MAKH"
        Dim addupdate As SqlCommand = New SqlCommand(update, conn)
        conn.Open()
        Try
            txt_MaKH.Focus()
            If txt_MaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txt_MaKH.Focus()
                If txt_Tenkh.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txt_Tenkh.Focus()
                    If txt_diachi.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txt_diachi.Focus()
                        If txt_SDT.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txt_SDT.Focus()
                            If txt_Email.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else

                                addupdate.Parameters.AddWithValue("@MAKH", txt_MaKH.Text)
                                addupdate.Parameters.AddWithValue("@TENKH", txt_Tenkh.Text)
                                addupdate.Parameters.AddWithValue("@DIACHI", txt_diachi.Text)
                                addupdate.Parameters.AddWithValue("@SDT", txt_SDT.Text)
                                addupdate.Parameters.AddWithValue("@EMAIL", txt_Email.Text)
                                addupdate.ExecuteNonQuery()
                                conn.Close()
                                MessageBox.Show("Cập nhật thành công")
                                txt_MaKH.Text = Nothing
                                txt_Tenkh.Text = Nothing
                                txt_diachi.Text = Nothing
                                txt_SDT.Text = Nothing
                                txt_Email.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        db.Clear()
        dgv_KH.DataSource = db
        dgv_KH.DataSource = Nothing
        LoadData()
    End Sub
End Class