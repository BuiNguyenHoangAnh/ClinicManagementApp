Imports System.Data
Imports System.Data.SqlClient
Public Class frThongTinNhanVien
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

    Private Sub frThongTinNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Taoketnoi()
        Dim dt As New DataTable
        dt = LayDulieu()
        GridThongTinNV.DataSource = dt
        txtMaNhanVien.DataBindings.Clear()
        txtHoTenNhanVien.DataBindings.Clear()
        txtDiaChi.DataBindings.Clear()
        txtMaNhanVien.DataBindings.Add("text", dt, "MaNV")
        txtHoTenNhanVien.DataBindings.Add("text", dt, "HoTenNV")
        txtDiaChi.DataBindings.Add("text", dt, "DiaChi")
        timeNgaySinh.Text = GridThongTinNV.CurrentRow.Cells(2).Value.ToString()
        cboGioiTinh.SelectedItem = GridThongTinNV.CurrentRow.Cells(3).Value()
        cboHocVi.SelectedItem = GridThongTinNV.CurrentRow.Cells(5).Value()
        cboViTri.SelectedItem = GridThongTinNV.CurrentRow.Cells(6).Value()
    End Sub

    Private Sub btnUpdateNV_Click(sender As Object, e As EventArgs) Handles btnUpdateNV.Click
        Dim MaNhanVien As String = txtMaNhanVien.Text
        Dim TenNV As String = txtHoTenNhanVien.Text
        Dim DiaChi As String = txtDiaChi.Text
        Dim GioiTinh As String = cboGioiTinh.SelectedItem.ToString
        Dim HocVi As String = cboHocVi.SelectedItem.ToString
        Dim ViTri As String = cboViTri.SelectedItem.ToString

        Dim sql As String = "update NHANVIEN set HoTenNV=N'" & TenNV & "', DiaChi=N'" & DiaChi & "', NgaySinh=N'" & timeNgaySinh.Value & "', GioiTinh=N'" & GioiTinh & "',HocVi=N'" & HocVi & "',ViTri=N'" & ViTri & "' where MaNV='" & MaNhanVien & "'"
        Dim cmd As New SqlCommand(sql, con)
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        dt = LayDulieu()
        GridThongTinNV.DataSource = dt
        txtMaNhanVien.DataBindings.Clear()
        txtHoTenNhanVien.DataBindings.Clear()
        txtDiaChi.DataBindings.Clear()
        txtMaNhanVien.DataBindings.Add("text", dt, "MaNV")
        txtHoTenNhanVien.DataBindings.Add("text", dt, "HoTenNV")
        txtDiaChi.DataBindings.Add("text", dt, "DiaChi")


    End Sub

    Private Sub GridThongTinNV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles GridThongTinNV.CellMouseClick
        cboGioiTinh.Text = GridThongTinNV.CurrentRow.Cells(3).Value.ToString()
        cboHocVi.Text = GridThongTinNV.CurrentRow.Cells(5).Value.ToString()
        cboViTri.Text = GridThongTinNV.CurrentRow.Cells(6).Value.ToString()
        timeNgaySinh.Text = GridThongTinNV.CurrentRow.Cells(2).Value.ToString()
    End Sub
End Class