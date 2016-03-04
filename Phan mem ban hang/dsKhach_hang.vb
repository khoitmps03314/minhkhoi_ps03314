Imports System.Data.SqlClient
Imports System.Data
Public Class frm_dsKH
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=khoitmpss03314.mssql.somee.com;packet size=4096;user id=khoitmps03314_SQLLogin_1;pwd=d1ghkkqbjy;data source=khoitmpss03314.mssql.somee.com;persist security info=False;initial catalog=khoitmpss03314"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    
    Private Sub btn_trolai_Click(sender As Object, e As EventArgs) Handles btn_trolai.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub btn_dskh_Click(sender As Object, e As EventArgs) Handles btn_dskh.Click
        Dim hienthi As New Class1
        dgv_dskh.DataSource = hienthi.DSkhachang.Tables(0)
    End Sub
End Class