Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frm_sp
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=khoitmpss03314.mssql.somee.com;packet size=4096;user id=khoitmps03314_SQLLogin_1;pwd=d1ghkkqbjy;data source=khoitmpss03314.mssql.somee.com;persist security info=False;initial catalog=khoitmpss03314"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub frm_sp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_Xoa.Enabled = False
    End Sub
    Private Sub btn_timkiem_Click(sender As Object, e As EventArgs) Handles btn_timkiem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MASP as 'Mã SP' ,TenSP as 'Tên SP', MaLoai as 'Mã Loại',  DonGia as 'Đơn giá', Soluong as 'Số Lượng' from san_pham where Masp like'%" & txt_MASP.Text & "%' ", connect)
        Try
            If txt_MASP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgv_Sp.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgv_Sp.DataSource = db.DefaultView
                    txt_MASP.Text = Nothing
                    btn_Xoa.Enabled = True
                Else
                    MessageBox.Show("Không tìm thấy")
                    txt_MASP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dgv_SP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Sp.CellContentClick
        Dim click As Integer = dgv_Sp.CurrentCell.RowIndex
        txt_MASP.Text = dgv_Sp.Item(0, click).Value
        txt_TENSP.Text = dgv_Sp.Item(1, click).Value
        txt_MALOAI.Text = dgv_Sp.Item(2, click).Value
        txt_dongia.Text = dgv_Sp.Item(3, click).Value
        txt_SOLUONG.Text = dgv_Sp.Item(4, click).Value
    End Sub






    Private Sub btn_trolai_Click(sender As Object, e As EventArgs) Handles btn_trolai.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim insert As String = "insert into San_pham values(@MAsp,@TENSP,@MALOAI,@DonGia,@Soluong)"
        Dim save As SqlCommand = New SqlCommand(insert, conn)
        conn.Open()
        Try
            txt_MASP.Focus()
            If txt_MASP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã Sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txt_MASP.Focus()
                If txt_TENSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên Sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txt_TENSP.Focus()
                    If txt_MALOAI.Text = "" Then
                        MessageBox.Show("Vui lòng nhập mã loại", "Nhập Thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txt_MALOAI.Focus()
                        If txt_dongia.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập đơn giá", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txt_dongia.Focus()
                            If txt_SOLUONG.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                txt_SOLUONG.Focus()
                            Else
                                save.Parameters.AddWithValue("@MAsp", txt_MASP.Text)
                                save.Parameters.AddWithValue("@TENSP", txt_TENSP.Text)
                                save.Parameters.AddWithValue("@MALOAI", txt_MALOAI.Text)
                                save.Parameters.AddWithValue("@DonGia", txt_dongia.Text)
                                save.Parameters.AddWithValue("@Soluong", txt_SOLUONG.Text)
                                save.ExecuteNonQuery()
                                conn.Close()
                                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txt_MASP.Text = Nothing
                                txt_TENSP.Text = Nothing
                                txt_MALOAI.Text = Nothing
                                txt_dongia.Text = Nothing
                                txt_SOLUONG.Text = Nothing

                            End If
                        End If
                    End If
                End If
            End If
        Catch Ex As Exception
            MessageBox.Show("Không được trùng mã sản phẩm hoặc nhập quá số ký tự cho phép hoặc sai ký tự sai mã loại", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MASP as 'Mã SP' ,TenSP as 'Tên SP', MaLoai as 'Mã Loại',  DonGia as 'Đơn giá', Soluong as 'Số Lượng' from san_pham", conn)
        db.Clear()
        refesh.Fill(db)
        dgv_Sp.DataSource = db.DefaultView
    End Sub

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim Delete As String = ("DELETE San_pham WHERE Masp = @Masp")
        Dim CONNECT As SqlCommand = New SqlCommand(Delete, conn)
        conn.Open()
        Try
            txt_MASP.Focus()
            If txt_MASP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                CONNECT.Parameters.AddWithValue("@Masp", txt_MASP.Text)
                CONNECT.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch EX As Exception

            MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        db.Clear()
        dgv_Sp.DataSource = db
        dgv_Sp.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MASP as 'Mã SP' ,TenSP as 'Tên SP', MaLoai as 'Mã Loại',  DonGia as 'Đơn giá', Soluong as 'Số Lượng' from san_pham", conn)

        conn.Open()
        load.Fill(db)
        dgv_Sp.DataSource = db.DefaultView
    End Sub

    Private Sub btn_capnhat_Click(sender As Object, e As EventArgs) Handles btn_capnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim update As String = "update San_pham set MASP=@MASP, TENSP=@TENSP, MALOAI=@MALOAI, DONGIA=@DONGIA, SOLUONG=@SOLUONG where MASP=@MASP"
        Dim addupdate As SqlCommand = New SqlCommand(update, conn)
        conn.Open()
        Try
            txt_MASP.Focus()
            If txt_MASP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txt_MASP.Focus()
                If txt_TENSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txt_TENSP.Focus()
                    If txt_MALOAI.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập địa chỉ mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txt_MALOAI.Focus()
                        If txt_dongia.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập đơn giá", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txt_dongia.Focus()
                            If txt_SOLUONG.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else

                                addupdate.Parameters.AddWithValue("@MASP", txt_MASP.Text)
                                addupdate.Parameters.AddWithValue("@TENSP", txt_TENSP.Text)
                                addupdate.Parameters.AddWithValue("@MALOAI", txt_MALOAI.Text)
                                addupdate.Parameters.AddWithValue("@DONGIA", txt_dongia.Text)
                                addupdate.Parameters.AddWithValue("@SOLUONG", txt_SOLUONG.Text)
                                addupdate.ExecuteNonQuery()
                                conn.Close()
                                MessageBox.Show("Cập nhật thành công")
                                txt_MASP.Text = Nothing
                                txt_TENSP.Text = Nothing
                                txt_MALOAI.Text = Nothing
                                txt_dongia.Text = Nothing
                                txt_SOLUONG.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        db.Clear()
        dgv_Sp.DataSource = db
        dgv_Sp.DataSource = Nothing
        LoadData()
    End Sub


End Class