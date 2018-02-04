Imports System.Data
Imports System.Data.SqlClient

Public Class frBaoCaoDoanhThu
    Dim con As New SqlConnection

    Public Sub Taoketnoi()
        Dim str As String = "Data Source=" + SystemInformation.UserDomainName.ToString + ";Initial Catalog=QLPM;Integrated Security=True"
        con.ConnectionString = str
        con.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        Taoketnoi()
        Dim thang As Integer = dtThangBaoCao.Value.Month
        Dim nam As Integer = dtThangBaoCao.Value.Year
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand("SELECT NgayKham, COUNT(MaKhamBenh)as SoLuongBenhNhan ,Sum(TongTienHoaDon)as DoanhThu  From KHAMBENH WHERE Month(NgayKham)='" & thang & "' and YEAR(NgayKham)='" & nam & "' GROUP BY NgayKham", con)
        da.Fill(dt)

        Dim TongDoanhThu As String = dt.Compute("Sum(DoanhThu)", "").ToString
        DataGridView1.DataSource = dt

        Dim Cot_Ty_Le As New DataColumn("Ty_Le")
        dt.Columns.Add(Cot_Ty_Le)
        For Each KHAMBENH As DataRow In dt.Rows
            'KHAMBENH("Ty_Le") = Math.Round(Double.Parse(KHAMBENH("DoanhThu").ToString) * 100 / Double.Parse(TongDoanhThu)).ToString() & "%"
            KHAMBENH("Ty_Le") = Double.Parse(KHAMBENH("DoanhThu").ToString) * 100 / Double.Parse(TongDoanhThu) & "%"
        Next
        con.Close()
        txtTongDoanhThu.Text = TongDoanhThu.ToString

    End Sub

    Private Sub frBaoCaoDoanhThu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class