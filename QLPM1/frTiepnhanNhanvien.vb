Imports System.Data
Imports System.Data.SqlClient

Public Class frTiepnhanNhanvien
    Dim con As New SqlConnection

    Public Sub Taoketnoi()
        Dim str As String = "Data Source=HOANGNIKON;Initial Catalog=QLPM;Integrated Security=True"
        con.ConnectionString = str
        con.Open()
    End Sub

    Public Function LayDulieu() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand("select * from NHANVIEN ", con)
        da.Fill(dt)
        Return dt
    End Function

    Private Sub frTiepnhanNhanvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Taoketnoi()
        Dim dt As New DataTable
        dt = LayDulieu()
        GridNhanVien.DataSource = dt
        txtMaNhanVien.DataBindings.Clear()
        txtHoTenNhanVien.DataBindings.Clear()
        txtDiaChi.DataBindings.Clear()
        timeNgaySinh.Value = Now()
        'txtMaNhanVien.DataBindings.Add("text", dt, "MaNV")
        'txtHoTenNhanVien.DataBindings.Add("text", dt, "HoTenNV")
        'txtDiaChi.DataBindings.Add("text", dt, "DiaChi")
        'timeNgaySinh.Text = GridNhanVien.CurrentRow.Cells(2).Value.ToString()
        'cboGioiTinh.Text = GridNhanVien.CurrentRow.Cells(3).Value.ToString()
        'cboHocVi.Text = GridNhanVien.CurrentRow.Cells(5).Value.ToString()
        'cboViTri.Text = GridNhanVien.CurrentRow.Cells(6).Value.ToString()
        con.Close()

    End Sub

    Private Sub btnNhapNhanVien_Click(sender As Object, e As EventArgs) Handles btnNhapNhanVien.Click
        Dim sql As String = "set dateformat DMY INSERT INTO NHANVIEN(MaNV, HoTenNV, NgaySinh, GioiTinh, DiaChi,HocVi, ViTri) VALUES('" & txtMaNhanVien.Text & "',N'" & txtHoTenNhanVien.Text & "','" & timeNgaySinh.Text & "',N'" & cboGioiTinh.Text & "',N'" & txtDiaChi.Text & "',N'" & cboHocVi.Text & "',N'" & cboViTri.Text & "')"
        Dim cmd As New SqlCommand(sql, con)
        cmd.ExecuteNonQuery()
        'Load du lieu
        Dim dt As New DataTable
        dt = LayDulieu()
        GridNhanVien.DataSource = dt
        txtMaNhanVien.DataBindings.Clear()
        txtHoTenNhanVien.DataBindings.Clear()
        txtDiaChi.DataBindings.Clear()
        txtMaNhanVien.DataBindings.Add("text", dt, "MaNV")
        txtHoTenNhanVien.DataBindings.Add("text", dt, "HoTenNV")
        txtDiaChi.DataBindings.Add("text", dt, "DiaChi")
        cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.SelectedText)
        cmd.Parameters.AddWithValue("@HocVi", cboGioiTinh.SelectedText)
        cmd.Parameters.AddWithValue("@ViTri", cboViTri.SelectedText)
        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information)
    End Sub

    Private Sub GridNhanVien_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridNhanVien.CellContentClick
       
    End Sub

    Private Sub GridNhanVien_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles GridNhanVien.CellMouseClick
        txtMaNhanVien.Text = GridNhanVien.CurrentRow.Cells(0).Value.ToString()
        txtHoTenNhanVien.Text = GridNhanVien.CurrentRow.Cells(1).Value.ToString()
        txtDiaChi.Text = GridNhanVien.CurrentRow.Cells(4).Value.ToString()
        timeNgaySinh.Text = GridNhanVien.CurrentRow.Cells(2).Value.ToString()
        cboGioiTinh.Text = GridNhanVien.CurrentRow.Cells(3).Value.ToString()
        cboHocVi.Text = GridNhanVien.CurrentRow.Cells(5).Value.ToString()
        cboViTri.Text = GridNhanVien.CurrentRow.Cells(6).Value.ToString()
    End Sub
End Class