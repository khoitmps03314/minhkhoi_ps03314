Imports System.Data.SqlClient
Imports System.Data
Public Class frm_dssp
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=khoitmpss03314.mssql.somee.com;packet size=4096;user id=khoitmps03314_SQLLogin_1;pwd=d1ghkkqbjy;data source=khoitmpss03314.mssql.somee.com;persist security info=False;initial catalog=khoitmpss03314"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub btn_trolai_Click(sender As Object, e As EventArgs) Handles btn_trolai.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub btn_dssp_Click(sender As Object, e As EventArgs) Handles btn_dssp.Click
        Dim hienthi As New Class1
        dgv_dssp.DataSource = hienthi.dssanpham.Tables(0)
    End Sub
End Class