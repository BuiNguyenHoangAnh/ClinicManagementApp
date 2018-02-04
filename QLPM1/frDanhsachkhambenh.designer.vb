<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhsachkhambenh
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
        Me.lbNgaykham = New System.Windows.Forms.Label()
        Me.cboGioiTinh = New System.Windows.Forms.ComboBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtHoTenBenhNhan = New System.Windows.Forms.TextBox()
        Me.txtMaKhamBenh = New System.Windows.Forms.TextBox()
        Me.lblDiaChi = New System.Windows.Forms.Label()
        Me.lblGioiTinh = New System.Windows.Forms.Label()
        Me.lblNgaySinh = New System.Windows.Forms.Label()
        Me.lblHoTenBenhNhan = New System.Windows.Forms.Label()
        Me.lblMaKhamBenh = New System.Windows.Forms.Label()
        Me.gridDanhSachKhamBenh = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSuaBenhNhan = New System.Windows.Forms.Button()
        Me.btnXoaBenhNhan = New System.Windows.Forms.Button()
        Me.timeNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.timeNgayKham = New System.Windows.Forms.DateTimePicker()
        Me.btnChonNgay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSoBenhNhan = New System.Windows.Forms.TextBox()
        Me.txtSoBenhNhanToiDa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        CType(Me.gridDanhSachKhamBenh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.BackColor = System.Drawing.Color.Transparent
        Me.lbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(337, 9)
        Me.lbName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(303, 31)
        Me.lbName.TabIndex = 0
        Me.lbName.Text = "Danh sách khám bệnh"
        '
        'lbNgaykham
        '
        Me.lbNgaykham.AutoSize = True
        Me.lbNgaykham.BackColor = System.Drawing.Color.Transparent
        Me.lbNgaykham.Location = New System.Drawing.Point(302, 55)
        Me.lbNgaykham.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNgaykham.Name = "lbNgaykham"
        Me.lbNgaykham.Size = New System.Drawing.Size(79, 17)
        Me.lbNgaykham.TabIndex = 1
        Me.lbNgaykham.Text = "Ngày khám"
        '
        'cboGioiTinh
        '
        Me.cboGioiTinh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboGioiTinh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboGioiTinh.FormattingEnabled = True
        Me.cboGioiTinh.Items.AddRange(New Object() {"Nam", "Nu"})
        Me.cboGioiTinh.Location = New System.Drawing.Point(184, 163)
        Me.cboGioiTinh.Name = "cboGioiTinh"
        Me.cboGioiTinh.Size = New System.Drawing.Size(134, 24)
        Me.cboGioiTinh.TabIndex = 5
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(184, 91)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(261, 22)
        Me.txtDiaChi.TabIndex = 3
        '
        'txtHoTenBenhNhan
        '
        Me.txtHoTenBenhNhan.Location = New System.Drawing.Point(184, 56)
        Me.txtHoTenBenhNhan.Name = "txtHoTenBenhNhan"
        Me.txtHoTenBenhNhan.Size = New System.Drawing.Size(261, 22)
        Me.txtHoTenBenhNhan.TabIndex = 2
        '
        'txtMaKhamBenh
        '
        Me.txtMaKhamBenh.Location = New System.Drawing.Point(184, 23)
        Me.txtMaKhamBenh.Name = "txtMaKhamBenh"
        Me.txtMaKhamBenh.Size = New System.Drawing.Size(261, 22)
        Me.txtMaKhamBenh.TabIndex = 1
        '
        'lblDiaChi
        '
        Me.lblDiaChi.AutoSize = True
        Me.lblDiaChi.BackColor = System.Drawing.Color.Transparent
        Me.lblDiaChi.Location = New System.Drawing.Point(31, 96)
        Me.lblDiaChi.Name = "lblDiaChi"
        Me.lblDiaChi.Size = New System.Drawing.Size(55, 17)
        Me.lblDiaChi.TabIndex = 8
        Me.lblDiaChi.Text = "Địa chỉ:"
        '
        'lblGioiTinh
        '
        Me.lblGioiTinh.AutoSize = True
        Me.lblGioiTinh.BackColor = System.Drawing.Color.Transparent
        Me.lblGioiTinh.Location = New System.Drawing.Point(31, 166)
        Me.lblGioiTinh.Name = "lblGioiTinh"
        Me.lblGioiTinh.Size = New System.Drawing.Size(68, 17)
        Me.lblGioiTinh.TabIndex = 9
        Me.lblGioiTinh.Text = "Giới tính: "
        '
        'lblNgaySinh
        '
        Me.lblNgaySinh.AutoSize = True
        Me.lblNgaySinh.BackColor = System.Drawing.Color.Transparent
        Me.lblNgaySinh.Location = New System.Drawing.Point(31, 130)
        Me.lblNgaySinh.Name = "lblNgaySinh"
        Me.lblNgaySinh.Size = New System.Drawing.Size(75, 17)
        Me.lblNgaySinh.TabIndex = 10
        Me.lblNgaySinh.Text = "Ngày sinh:"
        '
        'lblHoTenBenhNhan
        '
        Me.lblHoTenBenhNhan.AutoSize = True
        Me.lblHoTenBenhNhan.BackColor = System.Drawing.Color.Transparent
        Me.lblHoTenBenhNhan.Location = New System.Drawing.Point(31, 61)
        Me.lblHoTenBenhNhan.Name = "lblHoTenBenhNhan"
        Me.lblHoTenBenhNhan.Size = New System.Drawing.Size(126, 17)
        Me.lblHoTenBenhNhan.TabIndex = 11
        Me.lblHoTenBenhNhan.Text = "Họ tên bệnh nhân:"
        '
        'lblMaKhamBenh
        '
        Me.lblMaKhamBenh.AutoSize = True
        Me.lblMaKhamBenh.BackColor = System.Drawing.Color.Transparent
        Me.lblMaKhamBenh.Location = New System.Drawing.Point(31, 28)
        Me.lblMaKhamBenh.Name = "lblMaKhamBenh"
        Me.lblMaKhamBenh.Size = New System.Drawing.Size(101, 17)
        Me.lblMaKhamBenh.TabIndex = 12
        Me.lblMaKhamBenh.Text = "Mã khám bệnh"
        '
        'gridDanhSachKhamBenh
        '
        Me.gridDanhSachKhamBenh.AllowUserToAddRows = False
        Me.gridDanhSachKhamBenh.AllowUserToDeleteRows = False
        Me.gridDanhSachKhamBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDanhSachKhamBenh.Location = New System.Drawing.Point(7, 21)
        Me.gridDanhSachKhamBenh.Name = "gridDanhSachKhamBenh"
        Me.gridDanhSachKhamBenh.ReadOnly = True
        Me.gridDanhSachKhamBenh.RowTemplate.Height = 24
        Me.gridDanhSachKhamBenh.Size = New System.Drawing.Size(884, 348)
        Me.gridDanhSachKhamBenh.TabIndex = 18
        Me.gridDanhSachKhamBenh.TabStop = False
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(28, 28)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(87, 62)
        Me.btnThem.TabIndex = 6
        Me.btnThem.Text = "Thêm bệnh nhân"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSuaBenhNhan
        '
        Me.btnSuaBenhNhan.Location = New System.Drawing.Point(130, 28)
        Me.btnSuaBenhNhan.Name = "btnSuaBenhNhan"
        Me.btnSuaBenhNhan.Size = New System.Drawing.Size(87, 62)
        Me.btnSuaBenhNhan.TabIndex = 19
        Me.btnSuaBenhNhan.TabStop = False
        Me.btnSuaBenhNhan.Text = "    Sửa      Thông Tin"
        Me.btnSuaBenhNhan.UseVisualStyleBackColor = True
        '
        'btnXoaBenhNhan
        '
        Me.btnXoaBenhNhan.Location = New System.Drawing.Point(228, 28)
        Me.btnXoaBenhNhan.Name = "btnXoaBenhNhan"
        Me.btnXoaBenhNhan.Size = New System.Drawing.Size(85, 62)
        Me.btnXoaBenhNhan.TabIndex = 19
        Me.btnXoaBenhNhan.TabStop = False
        Me.btnXoaBenhNhan.Text = "    Xóa     bệnh nhân"
        Me.btnXoaBenhNhan.UseVisualStyleBackColor = True
        '
        'timeNgaySinh
        '
        Me.timeNgaySinh.Cursor = System.Windows.Forms.Cursors.Default
        Me.timeNgaySinh.CustomFormat = "dd-MM-yyyy"
        Me.timeNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.timeNgaySinh.Location = New System.Drawing.Point(184, 125)
        Me.timeNgaySinh.Name = "timeNgaySinh"
        Me.timeNgaySinh.Size = New System.Drawing.Size(134, 22)
        Me.timeNgaySinh.TabIndex = 4
        '
        'timeNgayKham
        '
        Me.timeNgayKham.Cursor = System.Windows.Forms.Cursors.Default
        Me.timeNgayKham.CustomFormat = "dd-MM-yyyy"
        Me.timeNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.timeNgayKham.Location = New System.Drawing.Point(388, 55)
        Me.timeNgayKham.Name = "timeNgayKham"
        Me.timeNgayKham.Size = New System.Drawing.Size(158, 22)
        Me.timeNgayKham.TabIndex = 6
        '
        'btnChonNgay
        '
        Me.btnChonNgay.Location = New System.Drawing.Point(563, 55)
        Me.btnChonNgay.Name = "btnChonNgay"
        Me.btnChonNgay.Size = New System.Drawing.Size(205, 26)
        Me.btnChonNgay.TabIndex = 20
        Me.btnChonNgay.Text = "Xem danh sách khám bệnh"
        Me.btnChonNgay.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(6, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Số lượng bệnh nhân:"
        '
        'txtSoBenhNhan
        '
        Me.txtSoBenhNhan.Location = New System.Drawing.Point(213, 59)
        Me.txtSoBenhNhan.Name = "txtSoBenhNhan"
        Me.txtSoBenhNhan.ReadOnly = True
        Me.txtSoBenhNhan.Size = New System.Drawing.Size(100, 22)
        Me.txtSoBenhNhan.TabIndex = 22
        '
        'txtSoBenhNhanToiDa
        '
        Me.txtSoBenhNhanToiDa.Location = New System.Drawing.Point(213, 31)
        Me.txtSoBenhNhanToiDa.Name = "txtSoBenhNhanToiDa"
        Me.txtSoBenhNhanToiDa.ReadOnly = True
        Me.txtSoBenhNhanToiDa.Size = New System.Drawing.Size(100, 22)
        Me.txtSoBenhNhanToiDa.TabIndex = 23
        Me.txtSoBenhNhanToiDa.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Số lượng bệnh nhân tối đa:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblMaKhamBenh)
        Me.GroupBox1.Controls.Add(Me.lblHoTenBenhNhan)
        Me.GroupBox1.Controls.Add(Me.lblNgaySinh)
        Me.GroupBox1.Controls.Add(Me.lblGioiTinh)
        Me.GroupBox1.Controls.Add(Me.lblDiaChi)
        Me.GroupBox1.Controls.Add(Me.txtMaKhamBenh)
        Me.GroupBox1.Controls.Add(Me.txtHoTenBenhNhan)
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.cboGioiTinh)
        Me.GroupBox1.Controls.Add(Me.timeNgaySinh)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 206)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin bệnh nhân"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.gridDanhSachKhamBenh)
        Me.GroupBox2.Location = New System.Drawing.Point(55, 337)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(907, 387)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Danh sách bệnh nhân"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnThem)
        Me.GroupBox3.Controls.Add(Me.btnSuaBenhNhan)
        Me.GroupBox3.Controls.Add(Me.btnXoaBenhNhan)
        Me.GroupBox3.Location = New System.Drawing.Point(633, 106)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(329, 100)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chức năng"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtSoBenhNhanToiDa)
        Me.GroupBox4.Controls.Add(Me.txtSoBenhNhan)
        Me.GroupBox4.Location = New System.Drawing.Point(633, 231)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(329, 100)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Thông tin qui định"
        '
        'frmDanhsachkhambenh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QLPM1.My.Resources.Resources.blurred_background_8
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(989, 748)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnChonNgay)
        Me.Controls.Add(Me.timeNgayKham)
        Me.Controls.Add(Me.lbNgaykham)
        Me.Controls.Add(Me.lbName)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDanhsachkhambenh"
        Me.Text = "Danh sách khám bệnh"
        CType(Me.gridDanhSachKhamBenh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents lbNgaykham As System.Windows.Forms.Label
    Friend WithEvents cboGioiTinh As System.Windows.Forms.ComboBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtHoTenBenhNhan As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKhamBenh As System.Windows.Forms.TextBox
    Friend WithEvents lblDiaChi As System.Windows.Forms.Label
    Friend WithEvents lblGioiTinh As System.Windows.Forms.Label
    Friend WithEvents lblNgaySinh As System.Windows.Forms.Label
    Friend WithEvents lblHoTenBenhNhan As System.Windows.Forms.Label
    Friend WithEvents lblMaKhamBenh As System.Windows.Forms.Label
    Friend WithEvents gridDanhSachKhamBenh As System.Windows.Forms.DataGridView
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnSuaBenhNhan As System.Windows.Forms.Button
    Friend WithEvents btnXoaBenhNhan As System.Windows.Forms.Button
    Friend WithEvents timeNgaySinh As System.Windows.Forms.DateTimePicker
    Friend WithEvents timeNgayKham As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnChonNgay As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSoBenhNhan As System.Windows.Forms.TextBox
    Friend WithEvents txtSoBenhNhanToiDa As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
End Class
