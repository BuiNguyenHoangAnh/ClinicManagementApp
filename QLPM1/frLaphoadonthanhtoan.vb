Imports System.Data
Imports System.Data.SqlClient
Public Class frmLaphoadonthanhtoan
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Public Sub Taoketnoi()
        Dim str As String = "Data Source=" + SystemInformation.UserDomainName.ToString + ";Initial Catalog=QLPM;Integrated Security=True"
        con.ConnectionString = str
        con.Open()
    End Sub
    Private Sub btnTinhTien_Click(sender As Object, e As EventArgs) Handles btnTinhTien.Click
        If (txtMaKhamBenh.Text = "") Then
            MessageBox.Show("Vui lòng nhập mã khám bệnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Taoketnoi()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter
            da.SelectCommand = New SqlCommand("select SUM(ThanhTienThuoc) as TongTienThuoc from CHITIETHOADON where MaKhamBenh='" & txtMakhambenh.Text & "'", con)
            da.Fill(dt)
            txtTongTienThuoc.DataBindings.Clear()
            txtTongTienThuoc.DataBindings.Add("text", dt, "TongTienThuoc")

            Dim dt2 As New DataTable
            Dim da2 As New SqlDataAdapter
            da2.SelectCommand = New SqlCommand("select TienKhamQuiDinh from THAMSO ", con)
            da2.Fill(dt2)
            txtTienKham.DataBindings.Clear()
            txtTienKham.DataBindings.Add("text", dt2, "TienKhamQuiDinh")
            Dim tongtien As Double
            Dim tienkham As Double = Double.Parse(txtTienKham.Text)
            Dim tienthuoc As Double = 0
            If (txtTongTienThuoc.Text = "") Then
                tienthuoc = 0
                txtTongTienThuoc.Text = tienthuoc.ToString
            Else
                tienthuoc = Double.Parse(txtTongTienThuoc.Text)

            End If
            tongtien = tienkham + tienthuoc
            txtTongTien.Text = tongtien.ToString

            Dim dt3 As New DataTable
            Dim da3 As New SqlDataAdapter
            da3.SelectCommand = New SqlCommand("select THUOC.TenThuoc,CHITIETHOADON.SoLuongThuocSuDung,DONVI.TenDonVi,CACHDUNG.TenCachDung,CHITIETHOADON.TienThuocThucTe,CHITIETHOADON.ThanhTienThuoc from CHITIETHOADON,THUOC,DONVI,CACHDUNG where CHITIETHOADON.MaThuoc=THUOC.MaThuoc and CACHDUNG.MaCachDung=THUOC.MaCachDung and DONVI.MaDonVi=THUOC.MaDonVi and MaKhamBenh='" & txtMaKhamBenh.Text & "' ", con)
            da3.Fill(dt3)
            DataGridView1.DataSource = dt3
            con.Close()
        End If

    End Sub

    Private Sub btnLapHoaDon_Click(sender As Object, e As EventArgs) Handles btnLapHoaDon.Click
        If (txtMaKhamBenh.Text = "") Then

            MessageBox.Show("Vui lòng nhập mã khám bệnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMaKhamBenh.Focus()
        Else
            Taoketnoi()
            Dim sql As String = "UPDATE KHAMBENH SET TongTienThuoc='" & txtTongTienThuoc.Text & "',TienKhamThucTe='" & txtTienKham.Text & "',TongTienHoaDon='" & txtTongTien.Text & "'where MaKhamBenh='" & txtMaKhamBenh.Text & "'"
            Dim cmd As New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Đã lập hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMaKhamBenh.Focus()
            con.Close()
        End If
    End Sub

    Private Sub btnTim_Click(sender As Object, e As EventArgs) Handles btnTim.Click
        Taoketnoi()
        Dim dt4 As New DataTable
        Dim da4 As New SqlDataAdapter
        da4.SelectCommand = New SqlCommand("select HoTen,GioiTinh,NgaySinh,DiaChi from KHAMBENH where KHAMBENH.MaKhamBenh='" & txtMaKhamBenh.Text & "'", con)
        da4.Fill(dt4)
        txtMaKhamBenh.DataBindings.Clear()
        txtHoTen.DataBindings.Clear()
        txtDiaChi.DataBindings.Clear()
        txtGioiTinh.DataBindings.Clear()
        txtNgaySinh.DataBindings.Clear()
        txtHoTen.DataBindings.Add("text", dt4, "HoTen")
        txtDiaChi.DataBindings.Add("text", dt4, "DiaChi")
        txtGioiTinh.DataBindings.Add("text", dt4, "GioiTinh")
        txtNgaySinh.DataBindings.Add("text", dt4, "NgaySinh")
        con.Close()

    End Sub

End Class
