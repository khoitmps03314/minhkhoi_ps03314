Imports System.Data.SqlClient
Imports System.Data
Public Class Class1
    Public Function DSkhachang() As DataSet
        Dim chuoiketnoi As String = "workstation id=khoitmpss03314.mssql.somee.com;packet size=4096;user id=khoitmps03314_SQLLogin_1;pwd=d1ghkkqbjy;data source=khoitmpss03314.mssql.somee.com;persist security info=False;initial catalog=khoitmpss03314"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim dskh As New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from Khach_Hang", conn)
        Dim db As New DataSet
        conn.Open()
        dskh.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function dssanpham() As DataSet
        Dim chuoiketnoi As String = "workstation id=khoitmpss03314.mssql.somee.com;packet size=4096;user id=khoitmps03314_SQLLogin_1;pwd=d1ghkkqbjy;data source=khoitmpss03314.mssql.somee.com;persist security info=False;initial catalog=khoitmpss03314"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim dssp As New SqlDataAdapter("select MASP as 'Mã SP',TENSP as 'Tên SP', MALOAI as 'Mã Loại', DonGia as 'đơn giá',SOLUONG as 'Số lượng' from San_Pham ", conn)
        Dim db As New DataSet
        conn.Open()
        dssp.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
