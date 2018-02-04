Imports System.Data.SqlClient
Public Class frmTracuubenhnhan
    Private Sub LoadData()
        Dim strConnectionString As String
        Dim conn As SqlConnection
        Dim dakhambenh As SqlDataAdapter
        Dim dtkhambenh As DataTable
        Try
            'khai bao bien dung de lay gia tri tu textbox va combox
            Dim s1 As String = ""
            Dim s2 As String = ""
            Dim s3 As String = ""
            Dim s4 As String = ""
            Dim s5 As String = ""
            Dim s6 As String = ""
            Dim s7 As String = ""
            Dim s8 As String = ""
            Dim s9 As String = ""
            Dim s10 As String = ""
            Dim s11 As String = ""
            Dim s12 As String = ""
            Dim s13 As String = ""
            Dim b As Boolean = False

            strConnectionString = "Data Source=" + SystemInformation.UserDomainName.ToString + ";Initial Catalog=QLPM;Integrated Security=True"
            conn = New SqlConnection(strConnectionString)

            Dim s As String = "select * from KHAMBENH where "

            'tra cuu theo ma kham benh
            If (ckbMakhambenh.Checked = True) Then
                s1 = tbMakhambenh.Text
                If (b) Then
                    s = s + " and "
                Else : b = True
                End If
                'CutString(s)
                s = s + "KHAMBENH.MaKhamBenh like " + "'%" + s1 + "%'"
                dakhambenh = New SqlDataAdapter(s, conn)
            End If

            'tra cuu theo ho ten
            If (ckbHoten.Checked = True) Then
                s2 = tbHoten.Text
                If (b) Then
                    s = s + " and "
                Else : b = True
                End If
                'CutString(s)
                s = s + "KHAMBENH.HoTen like " + "'%" + s2 + "%'"
                dakhambenh = New SqlDataAdapter(s, conn)
            End If

            'tra cuu theo nam sinh
            If (ckbNamsinh.Checked = True) Then
                s6 = dNamsinh1.Value.Day.ToString() + "/" + dNamsinh1.Value.Month.ToString() + "/" + dNamsinh1.Value.Year.ToString()
                s7 = dNamsinh2.Value.Day.ToString() + "/" + dNamsinh2.Value.Month.ToString() + "/" + dNamsinh2.Value.Year.ToString()
                If (b) Then
                    s = s + " and "
                Else : b = True
                End If
                s = s + "KHAMBENH.NgaySinh between '" + s3 + "' and '" + s4 + "'"
                dakhambenh = New SqlDataAdapter(s, conn)
            End If

            'tra cuu theo dia chi
            If (ckbDiachi.Checked = True) Then
                s5 = RichTextBox1.Text
                If (b) Then
                    s = s + " and "
                Else : b = True
                End If
                s = s + "KHAMBENH.DiaChi like " + "'%" + s5 + "%'"
                dakhambenh = New SqlDataAdapter(s, conn)
            End If
            'tra cuu theo ngay kham
            If (ckbNgaykham.Checked = True) Then
                s6 = dNgaykham1.Value.Day.ToString() + "/" + dNgaykham1.Value.Month.ToString() + "/" + dNgaykham1.Value.Year.ToString()
                s7 = dNgaykham2.Value.Day.ToString() + "/" + dNgaykham2.Value.Month.ToString() + "/" + dNgaykham2.Value.Year.ToString()
                If (b) Then
                    s = s + " and "
                Else : b = True
                End If
                s = s + "KHAMBENH.NgayKham between '" + s6 + "' and '" + s7 + "'"
                dakhambenh = New SqlDataAdapter(s, conn)
            End If

            'tra cuu theo gioi tinh
            If (ckbGioitinh.Checked = True) Then
                s8 = combGioitinh.Text
                If (b) Then
                    s = s + " and "
                Else : b = True
                End If
                s = s + "KHAMBENH.GioiTinh like " + "'%" + s8 + "%'"
                dakhambenh = New SqlDataAdapter(s, conn)
            End If

            'tra cuu theo trieu chung
            If (ckbTrieuchung.Checked = True) Then
                s9 = tbTrieuchung.Text
                If (b) Then
                    s = s + " and "
                Else : b = True
                End If
                s = s + "KHAMBENH.TrieuChung like " + "'%" + s9 + "%'"
                dakhambenh = New SqlDataAdapter(s, conn)
            End If

            'tra cuu theo loai benh
            If (ckbLoaibenh.Checked = True) Then
                s10 = combLoaiBenh.SelectedValue.ToString()
                s = "select KHAMBENH.MaKhamBenh,KHAMBENH.HoTen,KHAMBENH.GioiTinh,KHAMBENH.NgaySinh,KHAMBENH.DiaChi,KHAMBENH.NgayKham,KHAMBENH.MaLoaiBenh,LOAIBENH.TenLoaiBenh,KHAMBENH.TrieuChung,KHAMBENH.TongTienThuoc,KHAMBENH.TienKhamThucTe,KHAMBENH.TongTienHoaDon from KHAMBENH,LOAIBENH where KHAMBENH.MaLoaiBenh=LOAIBENH.MaLoaiBenh and KHAMBENH.MaLoaiBenh ='" + s10 + "' "
                If (b) Then
                    s = s + " and "
                Else : b = True
                End If
                dakhambenh = New SqlDataAdapter(s, conn)

            End If

            'tra cuu theo thuoc su dung
            If (ckbThuocsudung.Checked = True) Then
                s11 = combThuocsudung.Text
                If (b) Then
                    s = s + " and "
                Else : b = True
                End If
                s = s + "KHAMBENH.MaKhamBenh like (select CHITIETHOADON.MaKhamBenh from CHITIETHOADON where CHITIETHOADON.MaThuoc like (select THUOC.TenThuoc from THUOC where THUOC.TenThuoc like '" + s11 + "'))"
                dakhambenh = New SqlDataAdapter(s, conn)
            End If

            'tra cuu theo tong tien
            If (ckbTongtien.Checked) Then
                s12 = tbTongtien1.Text
                s13 = tbTongtien2.Text
                If (b) Then
                    s = s + " and "
                Else : b = True
                End If
                s = s + "KHAMBENH.TongTienHoaDon between " + s12 + " and " + s13
                dakhambenh = New SqlDataAdapter(s, conn)
            End If

            dtkhambenh = New DataTable()
            dtkhambenh.Clear()
            dakhambenh.Fill(dtkhambenh)
            DataGridView1.DataSource = dtkhambenh
        Catch ex As Exception
            MessageBox.Show("Không tìm thấy dữ liệu trong bảng. Lỗi rồi!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnTracuu_Click(sender As Object, e As EventArgs) Handles btnTracuu.Click
        LoadData()
    End Sub

    Private Sub frmTracuubenhnhan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lay ten loai benh tu csdl
        Dim strConnectionString As String = "Data Source=" + SystemInformation.UserDomainName.ToString + ";Initial Catalog=QLPM;Integrated Security=True"
        Dim conn As SqlConnection
        Dim daloaibenh As SqlDataAdapter
        Dim dtloaibenh As DataTable
        conn = New SqlConnection(strConnectionString)
        'lay ten loai benh len combLoaibenh
        daloaibenh = New SqlDataAdapter("select LOAIBENH.TenLoaiBenh from LOAIBENH", conn)
        dtloaibenh = New DataTable()
        dtloaibenh.Clear()
        daloaibenh.Fill(dtloaibenh)
        combLoaiBenh.DataSource = dtloaibenh
        combLoaiBenh.ValueMember = "TenLoaiBenh"
        'lay ten thuoc len combThuoc
        daloaibenh = New SqlDataAdapter("select THUOC.TenThuoc from THUOC", conn)
        dtloaibenh = New DataTable()
        dtloaibenh.Clear()
        daloaibenh.Fill(dtloaibenh)
        combThuocsudung.DataSource = dtloaibenh
        combThuocsudung.ValueMember = "TenThuoc"
    End Sub
End Class