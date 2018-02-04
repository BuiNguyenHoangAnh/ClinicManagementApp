<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frLapPhieukhambenh
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaKhamBenh = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.txtGioiTinh = New System.Windows.Forms.TextBox()
        Me.txtNgaySinh = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTrieuChung = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboLoaiBenh = New System.Windows.Forms.ComboBox()
        Me.LOAIBENHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QLPMDataSet = New QLPM1.QLPMDataSet()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.btnNhapThuoc = New System.Windows.Forms.Button()
        Me.btnLapPhieu = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboTenThuoc = New System.Windows.Forms.ComboBox()
        Me.THUOCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.cboDonVi = New System.Windows.Forms.ComboBox()
        Me.cboCachDung = New System.Windows.Forms.ComboBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.gridThuoc = New System.Windows.Forms.DataGridView()
        Me.QLPMDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.LOAIBENHTableAdapter = New QLPM1.QLPMDataSetTableAdapters.LOAIBENHTableAdapter()
        Me.THUOCTableAdapter = New QLPM1.QLPMDataSetTableAdapters.THUOCTableAdapter()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMaThuoc = New System.Windows.Forms.TextBox()
        Me.txtMaLoaiBenh = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        CType(Me.LOAIBENHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLPMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.THUOCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridThuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLPMDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(24, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã khám bệnh"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(24, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Họ tên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(24, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Giới tính"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(24, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ngày sinh"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(24, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Địa chỉ"
        '
        'txtMaKhamBenh
        '
        Me.txtMaKhamBenh.Location = New System.Drawing.Point(148, 33)
        Me.txtMaKhamBenh.Name = "txtMaKhamBenh"
        Me.txtMaKhamBenh.Size = New System.Drawing.Size(276, 23)
        Me.txtMaKhamBenh.TabIndex = 0
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(148, 69)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.ReadOnly = True
        Me.txtHoTen.Size = New System.Drawing.Size(276, 23)
        Me.txtHoTen.TabIndex = 1
        Me.txtHoTen.TabStop = False
        '
        'txtGioiTinh
        '
        Me.txtGioiTinh.Location = New System.Drawing.Point(148, 148)
        Me.txtGioiTinh.Name = "txtGioiTinh"
        Me.txtGioiTinh.ReadOnly = True
        Me.txtGioiTinh.Size = New System.Drawing.Size(147, 23)
        Me.txtGioiTinh.TabIndex = 3
        Me.txtGioiTinh.TabStop = False
        '
        'txtNgaySinh
        '
        Me.txtNgaySinh.Location = New System.Drawing.Point(148, 182)
        Me.txtNgaySinh.Name = "txtNgaySinh"
        Me.txtNgaySinh.ReadOnly = True
        Me.txtNgaySinh.Size = New System.Drawing.Size(147, 23)
        Me.txtNgaySinh.TabIndex = 4
        Me.txtNgaySinh.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(23, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Triệu chứng"
        '
        'txtTrieuChung
        '
        Me.txtTrieuChung.Location = New System.Drawing.Point(138, 26)
        Me.txtTrieuChung.Name = "txtTrieuChung"
        Me.txtTrieuChung.Size = New System.Drawing.Size(276, 23)
        Me.txtTrieuChung.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(23, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Loại bệnh"
        '
        'cboLoaiBenh
        '
        Me.cboLoaiBenh.FormattingEnabled = True
        Me.cboLoaiBenh.Location = New System.Drawing.Point(138, 62)
        Me.cboLoaiBenh.Name = "cboLoaiBenh"
        Me.cboLoaiBenh.Size = New System.Drawing.Size(276, 24)
        Me.cboLoaiBenh.TabIndex = 6
        '
        'LOAIBENHBindingSource
        '
        Me.LOAIBENHBindingSource.DataMember = "LOAIBENH"
        Me.LOAIBENHBindingSource.DataSource = Me.QLPMDataSet
        '
        'QLPMDataSet
        '
        Me.QLPMDataSet.DataSetName = "QLPMDataSet"
        Me.QLPMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(148, 108)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.ReadOnly = True
        Me.txtDiaChi.Size = New System.Drawing.Size(276, 23)
        Me.txtDiaChi.TabIndex = 2
        Me.txtDiaChi.TabStop = False
        '
        'btnTim
        '
        Me.btnTim.Location = New System.Drawing.Point(346, 148)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(78, 57)
        Me.btnTim.TabIndex = 1
        Me.btnTim.Text = "Tìm"
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'btnNhapThuoc
        '
        Me.btnNhapThuoc.Location = New System.Drawing.Point(326, 70)
        Me.btnNhapThuoc.Name = "btnNhapThuoc"
        Me.btnNhapThuoc.Size = New System.Drawing.Size(96, 60)
        Me.btnNhapThuoc.TabIndex = 12
        Me.btnNhapThuoc.Text = "Nhập Thuốc"
        Me.btnNhapThuoc.UseVisualStyleBackColor = True
        '
        'btnLapPhieu
        '
        Me.btnLapPhieu.Location = New System.Drawing.Point(25, 25)
        Me.btnLapPhieu.Name = "btnLapPhieu"
        Me.btnLapPhieu.Size = New System.Drawing.Size(95, 45)
        Me.btnLapPhieu.TabIndex = 14
        Me.btnLapPhieu.Text = "Lập phiếu"
        Me.btnLapPhieu.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(31, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Tên thuốc:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(31, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Số lượng"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(31, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 17)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Đơn vị"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(31, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 17)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Cách dùng"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(31, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 17)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Đơn giá"
        '
        'cboTenThuoc
        '
        Me.cboTenThuoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTenThuoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTenThuoc.FormattingEnabled = True
        Me.cboTenThuoc.Location = New System.Drawing.Point(146, 32)
        Me.cboTenThuoc.Name = "cboTenThuoc"
        Me.cboTenThuoc.Size = New System.Drawing.Size(276, 24)
        Me.cboTenThuoc.TabIndex = 7
        '
        'THUOCBindingSource
        '
        Me.THUOCBindingSource.DataMember = "THUOC"
        Me.THUOCBindingSource.DataSource = Me.QLPMDataSet
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(146, 107)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(155, 23)
        Me.txtSoLuong.TabIndex = 8
        '
        'cboDonVi
        '
        Me.cboDonVi.FormattingEnabled = True
        Me.cboDonVi.Location = New System.Drawing.Point(146, 70)
        Me.cboDonVi.Name = "cboDonVi"
        Me.cboDonVi.Size = New System.Drawing.Size(155, 24)
        Me.cboDonVi.TabIndex = 9
        '
        'cboCachDung
        '
        Me.cboCachDung.FormattingEnabled = True
        Me.cboCachDung.Location = New System.Drawing.Point(146, 150)
        Me.cboCachDung.Name = "cboCachDung"
        Me.cboCachDung.Size = New System.Drawing.Size(155, 24)
        Me.cboCachDung.TabIndex = 10
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(146, 185)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(155, 23)
        Me.txtDonGia.TabIndex = 11
        '
        'gridThuoc
        '
        Me.gridThuoc.AllowUserToAddRows = False
        Me.gridThuoc.AllowUserToDeleteRows = False
        Me.gridThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridThuoc.Location = New System.Drawing.Point(26, 42)
        Me.gridThuoc.Name = "gridThuoc"
        Me.gridThuoc.ReadOnly = True
        Me.gridThuoc.RowTemplate.Height = 24
        Me.gridThuoc.Size = New System.Drawing.Size(902, 301)
        Me.gridThuoc.TabIndex = 17
        '
        'QLPMDataSetBindingSource
        '
        Me.QLPMDataSetBindingSource.DataSource = Me.QLPMDataSet
        Me.QLPMDataSetBindingSource.Position = 0
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(327, 153)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(95, 55)
        Me.btnXoa.TabIndex = 13
        Me.btnXoa.Text = "Xóa Thuốc"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'LOAIBENHTableAdapter
        '
        Me.LOAIBENHTableAdapter.ClearBeforeFill = True
        '
        'THUOCTableAdapter
        '
        Me.THUOCTableAdapter.ClearBeforeFill = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(449, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(308, 36)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Lập Phiếu Khám Bệnh"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtMaKhamBenh)
        Me.GroupBox3.Controls.Add(Me.txtHoTen)
        Me.GroupBox3.Controls.Add(Me.btnTim)
        Me.GroupBox3.Controls.Add(Me.txtGioiTinh)
        Me.GroupBox3.Controls.Add(Me.txtNgaySinh)
        Me.GroupBox3.Controls.Add(Me.txtDiaChi)
        Me.GroupBox3.Location = New System.Drawing.Point(84, 86)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(448, 235)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Thông tin bệnh nhân"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtTrieuChung)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cboLoaiBenh)
        Me.GroupBox1.Location = New System.Drawing.Point(84, 340)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 108)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mô tả bệnh"
        '
        'txtMaThuoc
        '
        Me.txtMaThuoc.Location = New System.Drawing.Point(1054, 125)
        Me.txtMaThuoc.Name = "txtMaThuoc"
        Me.txtMaThuoc.ReadOnly = True
        Me.txtMaThuoc.Size = New System.Drawing.Size(89, 23)
        Me.txtMaThuoc.TabIndex = 18
        Me.txtMaThuoc.Visible = False
        '
        'txtMaLoaiBenh
        '
        Me.txtMaLoaiBenh.Location = New System.Drawing.Point(21, 408)
        Me.txtMaLoaiBenh.Name = "txtMaLoaiBenh"
        Me.txtMaLoaiBenh.ReadOnly = True
        Me.txtMaLoaiBenh.Size = New System.Drawing.Size(48, 23)
        Me.txtMaLoaiBenh.TabIndex = 18
        Me.txtMaLoaiBenh.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtSoLuong)
        Me.GroupBox2.Controls.Add(Me.txtDonGia)
        Me.GroupBox2.Controls.Add(Me.btnXoa)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cboTenThuoc)
        Me.GroupBox2.Controls.Add(Me.btnNhapThuoc)
        Me.GroupBox2.Controls.Add(Me.cboDonVi)
        Me.GroupBox2.Controls.Add(Me.cboCachDung)
        Me.GroupBox2.Location = New System.Drawing.Point(590, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 229)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kê toa"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btnLapPhieu)
        Me.GroupBox4.Location = New System.Drawing.Point(892, 366)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(146, 82)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Lập Phiếu"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.gridThuoc)
        Me.GroupBox5.Location = New System.Drawing.Point(84, 476)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(954, 365)
        Me.GroupBox5.TabIndex = 30
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Danh sách thuốc"
        '
        'frLapPhieukhambenh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch
        Me.BackgroundImageStore = Global.QLPM1.My.Resources.Resources.blurred_background_8
        Me.ClientSize = New System.Drawing.Size(1168, 870)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtMaLoaiBenh)
        Me.Controls.Add(Me.txtMaThuoc)
        Me.Controls.Add(Me.Label13)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frLapPhieukhambenh"
        Me.Text = "Lập phiếu khám bệnh"
        CType(Me.LOAIBENHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLPMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.THUOCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridThuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLPMDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMaKhamBenh As System.Windows.Forms.TextBox
    Friend WithEvents txtHoTen As System.Windows.Forms.TextBox
    Friend WithEvents txtGioiTinh As System.Windows.Forms.TextBox
    Friend WithEvents txtNgaySinh As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTrieuChung As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboLoaiBenh As System.Windows.Forms.ComboBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents btnTim As System.Windows.Forms.Button
    Friend WithEvents btnNhapThuoc As System.Windows.Forms.Button
    Friend WithEvents btnLapPhieu As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboTenThuoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtSoLuong As System.Windows.Forms.TextBox
    Friend WithEvents cboDonVi As System.Windows.Forms.ComboBox
    Friend WithEvents cboCachDung As System.Windows.Forms.ComboBox
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents gridThuoc As System.Windows.Forms.DataGridView
    Friend WithEvents QLPMDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QLPMDataSet As QLPM1.QLPMDataSet
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents LOAIBENHBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOAIBENHTableAdapter As QLPM1.QLPMDataSetTableAdapters.LOAIBENHTableAdapter
    Friend WithEvents THUOCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents THUOCTableAdapter As QLPM1.QLPMDataSetTableAdapters.THUOCTableAdapter
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMaThuoc As System.Windows.Forms.TextBox
    Friend WithEvents txtMaLoaiBenh As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
End Class
