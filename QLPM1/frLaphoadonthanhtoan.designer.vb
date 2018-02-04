<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaphoadonthanhtoan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbMakhambenh = New System.Windows.Forms.Label()
        Me.txtMaKhamBenh = New System.Windows.Forms.TextBox()
        Me.lbHoten = New System.Windows.Forms.Label()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.lbGioitinh = New System.Windows.Forms.Label()
        Me.txtGioiTinh = New System.Windows.Forms.TextBox()
        Me.lbNamsinh = New System.Windows.Forms.Label()
        Me.txtNgaySinh = New System.Windows.Forms.TextBox()
        Me.tbDiachi = New System.Windows.Forms.Label()
        Me.lbTienkham = New System.Windows.Forms.Label()
        Me.lbTongtienthuoc = New System.Windows.Forms.Label()
        Me.lbTongtien = New System.Windows.Forms.Label()
        Me.txtTienKham = New System.Windows.Forms.TextBox()
        Me.txtTongTienThuoc = New System.Windows.Forms.TextBox()
        Me.txtTongTien = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.btnTinhTien = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnLapHoaDon = New System.Windows.Forms.Button()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbName
        '
        Me.lbName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbName.AutoSize = True
        Me.lbName.BackColor = System.Drawing.Color.Transparent
        Me.lbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(305, 20)
        Me.lbName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(320, 31)
        Me.lbName.TabIndex = 0
        Me.lbName.Text = "Lập hóa đơn thanh toán"
        '
        'lbMakhambenh
        '
        Me.lbMakhambenh.AutoSize = True
        Me.lbMakhambenh.BackColor = System.Drawing.Color.Transparent
        Me.lbMakhambenh.Location = New System.Drawing.Point(7, 39)
        Me.lbMakhambenh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMakhambenh.Name = "lbMakhambenh"
        Me.lbMakhambenh.Size = New System.Drawing.Size(101, 17)
        Me.lbMakhambenh.TabIndex = 1
        Me.lbMakhambenh.Text = "Mã khám bệnh"
        '
        'txtMaKhamBenh
        '
        Me.txtMaKhamBenh.Location = New System.Drawing.Point(145, 30)
        Me.txtMaKhamBenh.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaKhamBenh.Name = "txtMaKhamBenh"
        Me.txtMaKhamBenh.Size = New System.Drawing.Size(245, 22)
        Me.txtMaKhamBenh.TabIndex = 0
        '
        'lbHoten
        '
        Me.lbHoten.AutoSize = True
        Me.lbHoten.BackColor = System.Drawing.Color.Transparent
        Me.lbHoten.Location = New System.Drawing.Point(7, 74)
        Me.lbHoten.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbHoten.Name = "lbHoten"
        Me.lbHoten.Size = New System.Drawing.Size(50, 17)
        Me.lbHoten.TabIndex = 3
        Me.lbHoten.Text = "Họ tên"
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(145, 65)
        Me.txtHoTen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.ReadOnly = True
        Me.txtHoTen.Size = New System.Drawing.Size(245, 22)
        Me.txtHoTen.TabIndex = 4
        Me.txtHoTen.TabStop = False
        '
        'lbGioitinh
        '
        Me.lbGioitinh.AutoSize = True
        Me.lbGioitinh.BackColor = System.Drawing.Color.Transparent
        Me.lbGioitinh.Location = New System.Drawing.Point(7, 150)
        Me.lbGioitinh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbGioitinh.Name = "lbGioitinh"
        Me.lbGioitinh.Size = New System.Drawing.Size(60, 17)
        Me.lbGioitinh.TabIndex = 5
        Me.lbGioitinh.Text = "Giới tính"
        '
        'txtGioiTinh
        '
        Me.txtGioiTinh.Location = New System.Drawing.Point(145, 141)
        Me.txtGioiTinh.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGioiTinh.Name = "txtGioiTinh"
        Me.txtGioiTinh.ReadOnly = True
        Me.txtGioiTinh.Size = New System.Drawing.Size(129, 22)
        Me.txtGioiTinh.TabIndex = 6
        Me.txtGioiTinh.TabStop = False
        '
        'lbNamsinh
        '
        Me.lbNamsinh.AutoSize = True
        Me.lbNamsinh.BackColor = System.Drawing.Color.Transparent
        Me.lbNamsinh.Location = New System.Drawing.Point(7, 187)
        Me.lbNamsinh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNamsinh.Name = "lbNamsinh"
        Me.lbNamsinh.Size = New System.Drawing.Size(67, 17)
        Me.lbNamsinh.TabIndex = 7
        Me.lbNamsinh.Text = "Năm sinh"
        '
        'txtNgaySinh
        '
        Me.txtNgaySinh.Location = New System.Drawing.Point(145, 178)
        Me.txtNgaySinh.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNgaySinh.Name = "txtNgaySinh"
        Me.txtNgaySinh.ReadOnly = True
        Me.txtNgaySinh.Size = New System.Drawing.Size(129, 22)
        Me.txtNgaySinh.TabIndex = 8
        Me.txtNgaySinh.TabStop = False
        '
        'tbDiachi
        '
        Me.tbDiachi.AutoSize = True
        Me.tbDiachi.BackColor = System.Drawing.Color.Transparent
        Me.tbDiachi.Location = New System.Drawing.Point(7, 109)
        Me.tbDiachi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tbDiachi.Name = "tbDiachi"
        Me.tbDiachi.Size = New System.Drawing.Size(51, 17)
        Me.tbDiachi.TabIndex = 9
        Me.tbDiachi.Text = "Địa chỉ"
        '
        'lbTienkham
        '
        Me.lbTienkham.AutoSize = True
        Me.lbTienkham.BackColor = System.Drawing.Color.Transparent
        Me.lbTienkham.Location = New System.Drawing.Point(16, 30)
        Me.lbTienkham.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTienkham.Name = "lbTienkham"
        Me.lbTienkham.Size = New System.Drawing.Size(74, 17)
        Me.lbTienkham.TabIndex = 11
        Me.lbTienkham.Text = "Tiền khám"
        '
        'lbTongtienthuoc
        '
        Me.lbTongtienthuoc.AutoSize = True
        Me.lbTongtienthuoc.BackColor = System.Drawing.Color.Transparent
        Me.lbTongtienthuoc.Location = New System.Drawing.Point(16, 65)
        Me.lbTongtienthuoc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTongtienthuoc.Name = "lbTongtienthuoc"
        Me.lbTongtienthuoc.Size = New System.Drawing.Size(107, 17)
        Me.lbTongtienthuoc.TabIndex = 12
        Me.lbTongtienthuoc.Text = "Tổng tiền thuốc"
        '
        'lbTongtien
        '
        Me.lbTongtien.AutoSize = True
        Me.lbTongtien.BackColor = System.Drawing.Color.Transparent
        Me.lbTongtien.Location = New System.Drawing.Point(16, 104)
        Me.lbTongtien.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTongtien.Name = "lbTongtien"
        Me.lbTongtien.Size = New System.Drawing.Size(68, 17)
        Me.lbTongtien.TabIndex = 13
        Me.lbTongtien.Text = "Tổng tiền"
        '
        'txtTienKham
        '
        Me.txtTienKham.Location = New System.Drawing.Point(131, 25)
        Me.txtTienKham.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTienKham.Name = "txtTienKham"
        Me.txtTienKham.ReadOnly = True
        Me.txtTienKham.Size = New System.Drawing.Size(245, 22)
        Me.txtTienKham.TabIndex = 14
        Me.txtTienKham.TabStop = False
        '
        'txtTongTienThuoc
        '
        Me.txtTongTienThuoc.Location = New System.Drawing.Point(131, 65)
        Me.txtTongTienThuoc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTongTienThuoc.Name = "txtTongTienThuoc"
        Me.txtTongTienThuoc.ReadOnly = True
        Me.txtTongTienThuoc.Size = New System.Drawing.Size(245, 22)
        Me.txtTongTienThuoc.TabIndex = 15
        Me.txtTongTienThuoc.TabStop = False
        '
        'txtTongTien
        '
        Me.txtTongTien.Location = New System.Drawing.Point(131, 104)
        Me.txtTongTien.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTongTien.Name = "txtTongTien"
        Me.txtTongTien.ReadOnly = True
        Me.txtTongTien.Size = New System.Drawing.Size(245, 22)
        Me.txtTongTien.TabIndex = 16
        Me.txtTongTien.TabStop = False
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(145, 106)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.ReadOnly = True
        Me.txtDiaChi.Size = New System.Drawing.Size(245, 22)
        Me.txtDiaChi.TabIndex = 4
        Me.txtDiaChi.TabStop = False
        '
        'btnTinhTien
        '
        Me.btnTinhTien.Location = New System.Drawing.Point(9, 21)
        Me.btnTinhTien.Name = "btnTinhTien"
        Me.btnTinhTien.Size = New System.Drawing.Size(75, 56)
        Me.btnTinhTien.TabIndex = 2
        Me.btnTinhTien.Text = "Tính tiền"
        Me.btnTinhTien.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(17, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(879, 334)
        Me.DataGridView1.TabIndex = 18
        '
        'btnLapHoaDon
        '
        Me.btnLapHoaDon.Location = New System.Drawing.Point(110, 21)
        Me.btnLapHoaDon.Name = "btnLapHoaDon"
        Me.btnLapHoaDon.Size = New System.Drawing.Size(75, 56)
        Me.btnLapHoaDon.TabIndex = 3
        Me.btnLapHoaDon.Text = "Lập hóa đơn"
        Me.btnLapHoaDon.UseVisualStyleBackColor = True
        '
        'btnTim
        '
        Me.btnTim.Location = New System.Drawing.Point(315, 141)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(75, 64)
        Me.btnTim.TabIndex = 1
        Me.btnTim.Text = "Tìm"
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.lbMakhambenh)
        Me.GroupBox3.Controls.Add(Me.btnTim)
        Me.GroupBox3.Controls.Add(Me.txtMaKhamBenh)
        Me.GroupBox3.Controls.Add(Me.lbHoten)
        Me.GroupBox3.Controls.Add(Me.txtHoTen)
        Me.GroupBox3.Controls.Add(Me.txtDiaChi)
        Me.GroupBox3.Controls.Add(Me.lbGioitinh)
        Me.GroupBox3.Controls.Add(Me.txtGioiTinh)
        Me.GroupBox3.Controls.Add(Me.lbNamsinh)
        Me.GroupBox3.Controls.Add(Me.txtNgaySinh)
        Me.GroupBox3.Controls.Add(Me.tbDiachi)
        Me.GroupBox3.Location = New System.Drawing.Point(62, 89)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(411, 230)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chi tiết bệnh nhân"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbTienkham)
        Me.GroupBox1.Controls.Add(Me.lbTongtienthuoc)
        Me.GroupBox1.Controls.Add(Me.lbTongtien)
        Me.GroupBox1.Controls.Add(Me.txtTienKham)
        Me.GroupBox1.Controls.Add(Me.txtTongTienThuoc)
        Me.GroupBox1.Controls.Add(Me.txtTongTien)
        Me.GroupBox1.Location = New System.Drawing.Point(612, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 137)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Các loại phí"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnTinhTien)
        Me.GroupBox2.Controls.Add(Me.btnLapHoaDon)
        Me.GroupBox2.Location = New System.Drawing.Point(612, 230)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 89)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức năng"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Location = New System.Drawing.Point(62, 342)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(938, 383)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Các loại thuốc sử dụng"
        '
        'frmLaphoadonthanhtoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QLPM1.My.Resources.Resources.blurred_background_8
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1055, 762)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lbName)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLaphoadonthanhtoan"
        Me.Text = "Lập hóa đơn thanh toán"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents lbMakhambenh As System.Windows.Forms.Label
    Friend WithEvents txtMaKhamBenh As System.Windows.Forms.TextBox
    Friend WithEvents lbHoten As System.Windows.Forms.Label
    Friend WithEvents txtHoTen As System.Windows.Forms.TextBox
    Friend WithEvents lbGioitinh As System.Windows.Forms.Label
    Friend WithEvents txtGioiTinh As System.Windows.Forms.TextBox
    Friend WithEvents lbNamsinh As System.Windows.Forms.Label
    Friend WithEvents txtNgaySinh As System.Windows.Forms.TextBox
    Friend WithEvents tbDiachi As System.Windows.Forms.Label
    Friend WithEvents lbTienkham As System.Windows.Forms.Label
    Friend WithEvents lbTongtienthuoc As System.Windows.Forms.Label
    Friend WithEvents lbTongtien As System.Windows.Forms.Label
    Friend WithEvents txtTienKham As System.Windows.Forms.TextBox
    Friend WithEvents txtTongTienThuoc As System.Windows.Forms.TextBox
    Friend WithEvents txtTongTien As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents btnTinhTien As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnLapHoaDon As System.Windows.Forms.Button
    Friend WithEvents btnTim As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox

End Class
