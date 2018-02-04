Imports System.Data
Imports System.Data.SqlClient
Public Class frLapPhieukhambenh

    Dim con As New SqlConnection

    Public Sub Taoketnoi()
        Dim str As String = "Data Source=" + SystemInformation.UserDomainName.ToString + ";Initial Catalog=QLPM;Integrated Security=True"
        con.ConnectionString = str
        con.Open()
    End Sub

    Private Sub frLapPhieukhambenh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Taoketnoi()
        Dim dt As New DataTable("LOAIBENH")
        Dim cmd = New SqlCommand("select * from LOAIBENH", con)
        Dim dr = cmd.ExecuteReader()
        dt.Load(dr)
        cboLoaiBenh.DisplayMember = "TenLoaiBenh"
        cboLoaiBenh.ValueMember = "MaLoaiBenh"
        cboLoaiBenh.DataSource = dt

        Dim reader2 As SqlDataReader
        Dim query2 As String = "select DISTINCT TenThuoc from THUOC"
        Dim cmd2 = New SqlCommand(query2, con)
        reader2 = cmd2.ExecuteReader
        While reader2.Read
            Dim tenthuoc = reader2.GetString(0)
            cboTenThuoc.Items.Add(tenthuoc)
        End While
        reader2.Close()
        con.Close()
    End Sub

    Private Sub btnTim_Click(sender As Object, e As EventArgs) Handles btnTim.Click
        Taoketnoi()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand("select KHAMBENH.MaKhamBenh,HoTen,GioiTinh,NgaySinh,DiaChi from KHAMBENH where KHAMBENH.MaKhamBenh='" & txtMaKhamBenh.Text & "'", con)
        da.Fill(dt)
        txtMaKhamBenh.DataBindings.Clear()
        txtHoTen.DataBindings.Clear()
        txtDiaChi.DataBindings.Clear()
        txtGioiTinh.DataBindings.Clear()
        txtNgaySinh.DataBindings.Clear()
        txtHoTen.DataBindings.Add("text", dt, "HoTen")
        txtDiaChi.DataBindings.Add("text", dt, "DiaChi")
        txtGioiTinh.DataBindings.Add("text", dt, "GioiTinh")
        txtNgaySinh.DataBindings.Add("text", dt, "NgaySinh")
        'Đưa dữ liệu thuốc bệnh nhân ra DGV
        Dim dt2 As New DataTable
        Dim da2 As New SqlDataAdapter
        da2.SelectCommand = New SqlCommand("select THUOC.MaThuoc,THUOC.TenThuoc,DONVI.TenDonVi,CHITIETHOADON.SoLuongThuocSuDung,CACHDUNG.TenCachDung,CHITIETHOADON.TienThuocThucTe,CHITIETHOADON.ThanhTienThuoc from CHITIETHOADON,KHAMBENH,THUOC,CACHDUNG,DONVI where KHAMBENH.MaKhamBenh=CHITIETHOADON.MaKhamBenh AND THUOC.MaDonVi=DONVI.MaDonVi AND THUOC.MaCachDung=CACHDUNG.MaCachDung AND CHITIETHOADON.MaThuoc= THUOC.MaThuoc and KHAMBENH.MaKhamBenh='" & txtMaKhamBenh.Text & "'", con)
        da2.Fill(dt2)
        gridThuoc.DataSource = dt2
        con.Close()
    End Sub

    Private Sub gridThuoc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridThuoc.CellClick
        Dim i = gridThuoc.CurrentRow.Index
        txtMaThuoc.Text = gridThuoc.Item(0, i).Value.ToString
        cboTenThuoc.Text = gridThuoc.Item(1, i).Value.ToString
        txtSoLuong.Text = gridThuoc.Item(3, i).Value.ToString
        cboDonVi.Text = gridThuoc.Item(2, i).Value.ToString
        cboCachDung.Text = gridThuoc.Item(4, i).Value.ToString
        txtDonGia.Text = gridThuoc.Item(5, i).Value.ToString
    End Sub

    Private Sub cboLoaiBenh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLoaiBenh.SelectedIndexChanged
        txtMaLoaiBenh.Text = cboLoaiBenh.SelectedValue.ToString()
    End Sub

    Private Sub cboTenThuoc_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboTenThuoc.SelectedValueChanged
        Taoketnoi()
        Dim reader1 As SqlDataReader
        Dim query1 As String = "select DISTINCT TenDonVi from DONVI,THUOC WHERE THUOC.MaDonVi=DONVI.MaDonVi and TenThuoc='" & cboTenThuoc.SelectedItem.ToString & "'"
        Dim cmd1 = New SqlCommand(query1, con)
        reader1 = cmd1.ExecuteReader
        cboDonVi.Items.Clear()
        cboDonVi.ResetText()
        txtDonGia.Clear()
        cboCachDung.Items.Clear()
        cboCachDung.ResetText()
        txtSoLuong.Clear()
        While reader1.Read
            Dim tendonvi = reader1.GetString(0)
            cboDonVi.Items.Add(tendonvi)
        End While
        con.Close()
    End Sub

    Private Sub cboDonVi_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboDonVi.SelectedValueChanged
        Taoketnoi()
        Dim reader2 As SqlDataReader
        Dim query2 As String = "select CACHDUNG.TenCachDung from CACHDUNG,THUOC,DONVI WHERE THUOC.MaDonVi=DONVI.MaDonVi AND THUOC.MaCachDung=CACHDUNG.MaCachDung and TenThuoc='" & cboTenThuoc.SelectedItem.ToString & "'and TenDonVi='" & cboDonVi.SelectedItem.ToString & "'"
        Dim cmd2 = New SqlCommand(query2, con)
        reader2 = cmd2.ExecuteReader
        cboCachDung.Items.Clear()
        While reader2.Read
            Dim cachdung = reader2.GetString(0)
            cboCachDung.Items.Add(cachdung)
        End While
        reader2.Close()
        Dim reader As SqlDataReader
        Dim query As String = "select DonGiaQuiDinh from CACHDUNG,THUOC,DONVI WHERE THUOC.MaDonVi=DONVI.MaDonVi AND THUOC.MaCachDung=CACHDUNG.MaCachDung and TenThuoc='" & cboTenThuoc.SelectedItem.ToString & "'and TenDonVi='" & cboDonVi.SelectedItem.ToString & "'"
        Dim cmd = New SqlCommand(query, con)
        reader = cmd.ExecuteReader
        txtDonGia.Clear()
        While reader.Read
            txtDonGia.Text = reader.GetValue(0).ToString
        End While
        con.Close()
    End Sub

    Private Sub cboCachDung_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboCachDung.SelectedValueChanged
        Taoketnoi()
        Dim reader1 As SqlDataReader
        Dim query1 As String = "Select MaThuoc From THUOC,CACHDUNG,DONVI Where THUOC.MaDonVi=DONVI.MaDonVi AND THUOC.MaCachDung=CACHDUNG.MaCachDung and TenThuoc='" & cboTenThuoc.SelectedItem.ToString & "'and TenDonVi='" & cboDonVi.SelectedItem.ToString & "'AND TenCachDung='" & cboCachDung.SelectedItem.ToString & "'"
        Dim cmd1 = New SqlCommand(query1, con)
        reader1 = cmd1.ExecuteReader
        While reader1.Read
            Dim mt = reader1.GetString(0)
            txtMaThuoc.Text = mt.ToString
        End While
        con.Close()
    End Sub


    Private Sub btnNhapThuoc_Click(sender As Object, e As EventArgs) Handles btnNhapThuoc.Click
        Taoketnoi()
        Dim thanhtienthuoc As Double
        Dim soluong As Integer = Integer.Parse(txtSoLuong.Text)
        Dim tienthuocthucte As Double = Double.Parse(txtDonGia.Text)
        thanhtienthuoc = soluong * tienthuocthucte
        Dim sql As String = "INSERT INTO CHITIETHOADON(MaKhamBenh,MaThuoc,SoLuongThuocSuDung,TienThuocThucTe,ThanhTienThuoc) VALUES ('" + txtMaKhamBenh.Text + "','" + txtMaThuoc.Text + "','" + txtSoLuong.Text + "','" + txtDonGia.Text + "'," & thanhtienthuoc & ")"
        Dim cmd As New SqlCommand(sql, con)
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand("select THUOC.TenThuoc,DONVI.TenDonVi,CHITIETHOADON.SoLuongThuocSuDung,CACHDUNG.TenCachDung,CHITIETHOADON.TienThuocThucTe,CHITIETHOADON.ThanhTienThuoc from CHITIETHOADON,KHAMBENH,THUOC,CACHDUNG,DONVI where KHAMBENH.MaKhamBenh=CHITIETHOADON.MaKhamBenh AND THUOC.MaDonVi=DONVI.MaDonVi AND THUOC.MaCachDung=CACHDUNG.MaCachDung AND CHITIETHOADON.MaThuoc= THUOC.MaThuoc and KHAMBENH.MaKhamBenh='" & txtMaKhamBenh.Text & "'", con)
        da.Fill(dt)
        gridThuoc.DataSource = dt
        cboTenThuoc.Focus()
        con.Close()
    End Sub

    Private Sub btnLapPhieu_Click(sender As Object, e As EventArgs) Handles btnLapPhieu.Click
        Taoketnoi()
        Dim MaKhamBenh As String = txtMaKhamBenh.Text
        Dim TrieuChung As String = txtTrieuChung.Text
        Dim LoaiBenh As String = txtMaLoaiBenh.Text
        Dim query As String = "Update KHAMBENH set MaLoaiBenh='" & LoaiBenh & "',TrieuChung=N'" & TrieuChung & "' where MaKhamBenh='" & MaKhamBenh & "'"
        Dim cmd As New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        txtMaKhamBenh.Focus()
        con.Close()
        MessageBox.Show("Lập phiếu khám bệnh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Taoketnoi()
        Dim query As String = "delete from CHITIETHOADON where MaKhamBenh='" & txtMaKhamBenh.Text & "' and MaThuoc='" & txtMaThuoc.Text & "'"
        Dim cmd As New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        Dim i = gridThuoc.CurrentRow.Index
        gridThuoc.Rows.RemoveAt(i)
        MessageBox.Show("Xóa thành công mã thuốc " + txtMaThuoc.Text)
        con.Close()
    End Sub

   
End Class