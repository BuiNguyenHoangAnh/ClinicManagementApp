Imports System.Data
Imports System.Data.SqlClient
Public Class frmDanhsachkhambenh
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Public Sub Taoketnoi()
        Dim str As String = "Data Source=" + SystemInformation.UserDomainName.ToString + ";Initial Catalog=QLPM;Integrated Security=True"
        con.ConnectionString = str
        con.Open()
    End Sub

    Private Sub frmDanhsachkhambenh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Taoketnoi()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand("select SoBenhNhanToiDa From THAMSO", con)
        da.Fill(dt)
        txtSoBenhNhanToiDa.DataBindings.Add("text", dt, "SoBenhNhanToiDa")
        con.Close()
    End Sub


    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Taoketnoi()
        Dim sbn As Integer = Integer.Parse(txtSoBenhNhan.Text)
        Dim SoBenhNhanToiDa As Integer = Integer.Parse(txtSoBenhNhanToiDa.Text)
        If (sbn >= SoBenhNhanToiDa) Then
            MessageBox.Show("Vượt quá số lượng bệnh nhân trong ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.SelectedText)
            Dim query As String = " INSERT INTO KHAMBENH(MaKhamBenh,HoTen,GioiTinh,NgaySinh,DiaChi,NgayKham) VALUES('" & txtMaKhamBenh.Text & "',N'" & txtHoTenBenhNhan.Text & "',N'" & cboGioiTinh.Text & "','" & timeNgaySinh.Value & "',N'" & txtDiaChi.Text & "','" & timeNgayKham.Value & "')"
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter
            da.SelectCommand = New SqlCommand("select MaKhamBenh,HoTen,GioiTinh,NgaySinh,DiaChi,NgayKham from KHAMBENH where NgayKham='" & timeNgayKham.Value & "'", con)
            da.Fill(dt)
            gridDanhSachKhamBenh.DataSource = dt
            txtMaKhamBenh.Clear()
            txtHoTenBenhNhan.Clear()
            txtDiaChi.Clear()
            txtMaKhamBenh.Focus()
            Dim query2 As String = " SELECT COUNT(MaKhamBenh) as SoLuongBenhNhan FROM KHAMBENH where NgayKham='" & timeNgayKham.Value & "'"
            cmd = New SqlCommand(query2, con)
            Dim sobenhnhan As Integer = CInt(cmd.ExecuteScalar())
            txtSoBenhNhan.Text = sobenhnhan.ToString
        End If
        
        con.Close()
    End Sub

    Private Sub btnChonNgay_Click(sender As Object, e As EventArgs) Handles btnChonNgay.Click
        Taoketnoi()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand("select MaKhamBenh,HoTen,GioiTinh,NgaySinh,DiaChi,NgayKham from KHAMBENH where NgayKham='" & timeNgayKham.Value & "'", con)
        da.Fill(dt)
        gridDanhSachKhamBenh.DataSource = dt

        Dim query2 As String = " SELECT COUNT(MaKhamBenh) as SoLuongBenhNhan FROM KHAMBENH where NgayKham='" & timeNgayKham.Value & "'"
        cmd = New SqlCommand(query2, con)
        Dim sobenhnhan As Integer = CInt(cmd.ExecuteScalar())
        txtSoBenhNhan.Text = sobenhnhan.ToString

        con.Close()
    End Sub

    Private Sub btnXoaBenhNhan_Click(sender As Object, e As EventArgs) Handles btnXoaBenhNhan.Click
        Taoketnoi()
        Dim query As String = "delete from KHAMBENH where MaKhamBenh='" & txtMaKhamBenh.Text & "'"
        Dim cmd As New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        Dim i = gridDanhSachKhamBenh.CurrentRow.Index
        gridDanhSachKhamBenh.Rows.RemoveAt(i)
        MessageBox.Show("Xóa thành công mã khám bệnh " + txtMaKhamBenh.Text)

        Dim query2 As String = " SELECT COUNT(MaKhamBenh) as SoLuongBenhNhan FROM KHAMBENH where NgayKham='" & timeNgayKham.Value & "'"
        cmd = New SqlCommand(query2, con)
        Dim sobenhnhan As Integer = CInt(cmd.ExecuteScalar())
        txtSoBenhNhan.Text = sobenhnhan.ToString

        con.Close()
    End Sub

    Private Sub gridDanhSachKhamBenh_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridDanhSachKhamBenh.CellClick
        Dim i = gridDanhSachKhamBenh.CurrentRow.Index
        txtMaKhamBenh.Text = gridDanhSachKhamBenh.Item(0, i).Value.ToString
        txtHoTenBenhNhan.Text = gridDanhSachKhamBenh.Item(1, i).Value.ToString
        txtDiaChi.Text = gridDanhSachKhamBenh.Item(4, i).Value.ToString
        timeNgaySinh.Text = gridDanhSachKhamBenh.CurrentRow.Cells(3).Value.ToString
        cboGioiTinh.ResetText()
        cboGioiTinh.Text = gridDanhSachKhamBenh.Item(2, i).Value.ToString
    End Sub

    Private Sub btnSuaBenhNhan_Click(sender As Object, e As EventArgs) Handles btnSuaBenhNhan.Click
        Taoketnoi()
        Dim query As String = "update KHAMBENH  set HoTen='" & txtHoTenBenhNhan.Text & "',DiaChi='" & txtDiaChi.Text & "',NgaySinh='" & timeNgaySinh.Value & "',GioiTinh='" & cboGioiTinh.Text & "' where MaKhamBenh='" & txtMaKhamBenh.Text & "'"
        Dim cmd As New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        con.Close()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand("select MaKhamBenh,HoTen,GioiTinh,NgaySinh,DiaChi,NgayKham from KHAMBENH where NgayKham='" & timeNgayKham.Value & "'", con)
        da.Fill(dt)
        gridDanhSachKhamBenh.DataSource = dt
        MessageBox.Show("Đã sửa thông tin mã khám bệnh " + txtMaKhamBenh.Text)
    End Sub


End Class
