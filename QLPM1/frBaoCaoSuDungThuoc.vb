Imports System.Data
Imports System.Data.SqlClient
Public Class frBaoCaoSuDungThuoc
    Dim con As New SqlConnection

    Public Sub Taoketnoi()
        Dim str As String = "Data Source=" + SystemInformation.UserDomainName.ToString + ";Initial Catalog=QLPM;Integrated Security=True"
        con.ConnectionString = str
        con.Open()
    End Sub

    Private Sub frBaoCaoSuDungThuoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        Taoketnoi()
        Dim thang As Integer = dtThangBaoCao.Value.Month
        Dim nam As Integer = dtThangBaoCao.Value.Year
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand("SELECT THUOC.TenThuoc,DONVI.TenDonVi, SUM(CHITIETHOADON.SoLuongThuocSuDung)as SoLuongThuocSuDung, COUNT(CHITIETHOADON.MaThuoc)as SoLanDung FROM CHITIETHOADON,THUOC,DONVI,KHAMBENH WHERE CHITIETHOADON.MaThuoc=THUOC.MaThuoc and THUOC.MaDonVi=DONVI.MaDonVi and KHAMBENH.MaKhamBenh=CHITIETHOADON.MaKhamBenh and Month(KHAMBENH.NgayKham)='" & thang & "' and YEAR(KHAMBENH.NgayKham)='" & nam & "' GROUP BY THUOC.TenThuoc,DONVI.TenDonVi", con)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub
End Class