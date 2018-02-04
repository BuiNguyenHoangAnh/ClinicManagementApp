<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frThongTinNhanVien
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
        Me.lblThongTinNhanVien = New System.Windows.Forms.Label()
        Me.GridThongTinNV = New System.Windows.Forms.DataGridView()
        Me.MaNVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoTenNVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioiTinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HocViDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViTriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NHANVIENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QLPMDataSet = New QLPM1.QLPMDataSet()
        Me.btnUpdateNV = New System.Windows.Forms.Button()
        Me.NHANVIENTableAdapter = New QLPM1.QLPMDataSetTableAdapters.NHANVIENTableAdapter()
        Me.lblMaNV = New System.Windows.Forms.Label()
        Me.lblHoTenNV = New System.Windows.Forms.Label()
        Me.lblNgaySinh = New System.Windows.Forms.Label()
        Me.lblGioiTinhNhanVien = New System.Windows.Forms.Label()
        Me.lblDiaChiNhanVien = New System.Windows.Forms.Label()
        Me.lblHocVi = New System.Windows.Forms.Label()
        Me.lblViTri = New System.Windows.Forms.Label()
        Me.txtMaNhanVien = New System.Windows.Forms.TextBox()
        Me.txtHoTenNhanVien = New System.Windows.Forms.TextBox()
        Me.timeNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.cboGioiTinh = New System.Windows.Forms.ComboBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.cboHocVi = New System.Windows.Forms.ComboBox()
        Me.cboViTri = New System.Windows.Forms.ComboBox()
        CType(Me.GridThongTinNV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NHANVIENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLPMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblThongTinNhanVien
        '
        Me.lblThongTinNhanVien.AutoSize = True
        Me.lblThongTinNhanVien.Location = New System.Drawing.Point(427, 30)
        Me.lblThongTinNhanVien.Name = "lblThongTinNhanVien"
        Me.lblThongTinNhanVien.Size = New System.Drawing.Size(137, 17)
        Me.lblThongTinNhanVien.TabIndex = 0
        Me.lblThongTinNhanVien.Text = "Thông Tin Nhân VIên"
        '
        'GridThongTinNV
        '
        Me.GridThongTinNV.AutoGenerateColumns = False
        Me.GridThongTinNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridThongTinNV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaNVDataGridViewTextBoxColumn, Me.HoTenNVDataGridViewTextBoxColumn, Me.NgaySinhDataGridViewTextBoxColumn, Me.GioiTinhDataGridViewTextBoxColumn, Me.DiaChiDataGridViewTextBoxColumn, Me.HocViDataGridViewTextBoxColumn, Me.ViTriDataGridViewTextBoxColumn})
        Me.GridThongTinNV.DataSource = Me.NHANVIENBindingSource
        Me.GridThongTinNV.Location = New System.Drawing.Point(66, 239)
        Me.GridThongTinNV.Name = "GridThongTinNV"
        Me.GridThongTinNV.RowTemplate.Height = 24
        Me.GridThongTinNV.Size = New System.Drawing.Size(829, 280)
        Me.GridThongTinNV.TabIndex = 1
        '
        'MaNVDataGridViewTextBoxColumn
        '
        Me.MaNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV"
        Me.MaNVDataGridViewTextBoxColumn.HeaderText = "MaNV"
        Me.MaNVDataGridViewTextBoxColumn.Name = "MaNVDataGridViewTextBoxColumn"
        '
        'HoTenNVDataGridViewTextBoxColumn
        '
        Me.HoTenNVDataGridViewTextBoxColumn.DataPropertyName = "HoTenNV"
        Me.HoTenNVDataGridViewTextBoxColumn.HeaderText = "HoTenNV"
        Me.HoTenNVDataGridViewTextBoxColumn.Name = "HoTenNVDataGridViewTextBoxColumn"
        '
        'NgaySinhDataGridViewTextBoxColumn
        '
        Me.NgaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh"
        Me.NgaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh"
        Me.NgaySinhDataGridViewTextBoxColumn.Name = "NgaySinhDataGridViewTextBoxColumn"
        '
        'GioiTinhDataGridViewTextBoxColumn
        '
        Me.GioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh"
        Me.GioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh"
        Me.GioiTinhDataGridViewTextBoxColumn.Name = "GioiTinhDataGridViewTextBoxColumn"
        '
        'DiaChiDataGridViewTextBoxColumn
        '
        Me.DiaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi"
        Me.DiaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi"
        Me.DiaChiDataGridViewTextBoxColumn.Name = "DiaChiDataGridViewTextBoxColumn"
        '
        'HocViDataGridViewTextBoxColumn
        '
        Me.HocViDataGridViewTextBoxColumn.DataPropertyName = "HocVi"
        Me.HocViDataGridViewTextBoxColumn.HeaderText = "HocVi"
        Me.HocViDataGridViewTextBoxColumn.Name = "HocViDataGridViewTextBoxColumn"
        '
        'ViTriDataGridViewTextBoxColumn
        '
        Me.ViTriDataGridViewTextBoxColumn.DataPropertyName = "ViTri"
        Me.ViTriDataGridViewTextBoxColumn.HeaderText = "ViTri"
        Me.ViTriDataGridViewTextBoxColumn.Name = "ViTriDataGridViewTextBoxColumn"
        '
        'NHANVIENBindingSource
        '
        Me.NHANVIENBindingSource.DataMember = "NHANVIEN"
        Me.NHANVIENBindingSource.DataSource = Me.QLPMDataSet
        '
        'QLPMDataSet
        '
        Me.QLPMDataSet.DataSetName = "QLPMDataSet"
        Me.QLPMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnUpdateNV
        '
        Me.btnUpdateNV.Location = New System.Drawing.Point(912, 379)
        Me.btnUpdateNV.Name = "btnUpdateNV"
        Me.btnUpdateNV.Size = New System.Drawing.Size(91, 41)
        Me.btnUpdateNV.TabIndex = 2
        Me.btnUpdateNV.Text = "Update"
        Me.btnUpdateNV.UseVisualStyleBackColor = True
        '
        'NHANVIENTableAdapter
        '
        Me.NHANVIENTableAdapter.ClearBeforeFill = True
        '
        'lblMaNV
        '
        Me.lblMaNV.AutoSize = True
        Me.lblMaNV.Location = New System.Drawing.Point(63, 76)
        Me.lblMaNV.Name = "lblMaNV"
        Me.lblMaNV.Size = New System.Drawing.Size(94, 17)
        Me.lblMaNV.TabIndex = 3
        Me.lblMaNV.Text = "Mã nhân viên:"
        '
        'lblHoTenNV
        '
        Me.lblHoTenNV.AutoSize = True
        Me.lblHoTenNV.Location = New System.Drawing.Point(63, 110)
        Me.lblHoTenNV.Name = "lblHoTenNV"
        Me.lblHoTenNV.Size = New System.Drawing.Size(118, 17)
        Me.lblHoTenNV.TabIndex = 4
        Me.lblHoTenNV.Text = "Họ tên nhân viên:"
        '
        'lblNgaySinh
        '
        Me.lblNgaySinh.AutoSize = True
        Me.lblNgaySinh.Location = New System.Drawing.Point(63, 141)
        Me.lblNgaySinh.Name = "lblNgaySinh"
        Me.lblNgaySinh.Size = New System.Drawing.Size(73, 17)
        Me.lblNgaySinh.TabIndex = 5
        Me.lblNgaySinh.Text = "Ngày sinh:"
        '
        'lblGioiTinhNhanVien
        '
        Me.lblGioiTinhNhanVien.AutoSize = True
        Me.lblGioiTinhNhanVien.Location = New System.Drawing.Point(63, 173)
        Me.lblGioiTinhNhanVien.Name = "lblGioiTinhNhanVien"
        Me.lblGioiTinhNhanVien.Size = New System.Drawing.Size(65, 17)
        Me.lblGioiTinhNhanVien.TabIndex = 6
        Me.lblGioiTinhNhanVien.Text = "Giới tính: "
        '
        'lblDiaChiNhanVien
        '
        Me.lblDiaChiNhanVien.AutoSize = True
        Me.lblDiaChiNhanVien.Location = New System.Drawing.Point(499, 70)
        Me.lblDiaChiNhanVien.Name = "lblDiaChiNhanVien"
        Me.lblDiaChiNhanVien.Size = New System.Drawing.Size(53, 17)
        Me.lblDiaChiNhanVien.TabIndex = 7
        Me.lblDiaChiNhanVien.Text = "Địa chỉ:"
        '
        'lblHocVi
        '
        Me.lblHocVi.AutoSize = True
        Me.lblHocVi.Location = New System.Drawing.Point(501, 110)
        Me.lblHocVi.Name = "lblHocVi"
        Me.lblHocVi.Size = New System.Drawing.Size(51, 17)
        Me.lblHocVi.TabIndex = 8
        Me.lblHocVi.Text = "Học vị:"
        '
        'lblViTri
        '
        Me.lblViTri.AutoSize = True
        Me.lblViTri.Location = New System.Drawing.Point(501, 146)
        Me.lblViTri.Name = "lblViTri"
        Me.lblViTri.Size = New System.Drawing.Size(39, 17)
        Me.lblViTri.TabIndex = 9
        Me.lblViTri.Text = "Vị trí:"
        '
        'txtMaNhanVien
        '
        Me.txtMaNhanVien.Location = New System.Drawing.Point(205, 73)
        Me.txtMaNhanVien.Name = "txtMaNhanVien"
        Me.txtMaNhanVien.Size = New System.Drawing.Size(200, 23)
        Me.txtMaNhanVien.TabIndex = 10
        '
        'txtHoTenNhanVien
        '
        Me.txtHoTenNhanVien.Location = New System.Drawing.Point(205, 107)
        Me.txtHoTenNhanVien.Name = "txtHoTenNhanVien"
        Me.txtHoTenNhanVien.Size = New System.Drawing.Size(200, 23)
        Me.txtHoTenNhanVien.TabIndex = 11
        '
        'timeNgaySinh
        '
        Me.timeNgaySinh.Cursor = System.Windows.Forms.Cursors.Default
        Me.timeNgaySinh.CustomFormat = "dd-MM-yyyy"
        Me.timeNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.timeNgaySinh.Location = New System.Drawing.Point(205, 141)
        Me.timeNgaySinh.Name = "timeNgaySinh"
        Me.timeNgaySinh.Size = New System.Drawing.Size(200, 23)
        Me.timeNgaySinh.TabIndex = 12
        '
        'cboGioiTinh
        '
        Me.cboGioiTinh.FormattingEnabled = True
        Me.cboGioiTinh.Items.AddRange(New Object() {"Nam", "Nữ", "Không xác định"})
        Me.cboGioiTinh.Location = New System.Drawing.Point(205, 170)
        Me.cboGioiTinh.Name = "cboGioiTinh"
        Me.cboGioiTinh.Size = New System.Drawing.Size(92, 24)
        Me.cboGioiTinh.TabIndex = 13
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(596, 70)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(188, 23)
        Me.txtDiaChi.TabIndex = 14
        '
        'cboHocVi
        '
        Me.cboHocVi.FormattingEnabled = True
        Me.cboHocVi.Items.AddRange(New Object() {"Cử nhân", "Thạc sĩ", "Tiến sĩ"})
        Me.cboHocVi.Location = New System.Drawing.Point(596, 110)
        Me.cboHocVi.Name = "cboHocVi"
        Me.cboHocVi.Size = New System.Drawing.Size(121, 24)
        Me.cboHocVi.TabIndex = 15
        '
        'cboViTri
        '
        Me.cboViTri.FormattingEnabled = True
        Me.cboViTri.Items.AddRange(New Object() {"Nhân viên", "Bác sĩ", "Giám đốc"})
        Me.cboViTri.Location = New System.Drawing.Point(596, 146)
        Me.cboViTri.Name = "cboViTri"
        Me.cboViTri.Size = New System.Drawing.Size(121, 24)
        Me.cboViTri.TabIndex = 16
        '
        'frThongTinNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 567)
        Me.Controls.Add(Me.cboViTri)
        Me.Controls.Add(Me.cboHocVi)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.cboGioiTinh)
        Me.Controls.Add(Me.timeNgaySinh)
        Me.Controls.Add(Me.txtHoTenNhanVien)
        Me.Controls.Add(Me.txtMaNhanVien)
        Me.Controls.Add(Me.lblViTri)
        Me.Controls.Add(Me.lblHocVi)
        Me.Controls.Add(Me.lblDiaChiNhanVien)
        Me.Controls.Add(Me.lblGioiTinhNhanVien)
        Me.Controls.Add(Me.lblNgaySinh)
        Me.Controls.Add(Me.lblHoTenNV)
        Me.Controls.Add(Me.lblMaNV)
        Me.Controls.Add(Me.btnUpdateNV)
        Me.Controls.Add(Me.GridThongTinNV)
        Me.Controls.Add(Me.lblThongTinNhanVien)
        Me.Name = "frThongTinNhanVien"
        Me.Text = "Thông Tin Nhân Viên"
        CType(Me.GridThongTinNV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NHANVIENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLPMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblThongTinNhanVien As System.Windows.Forms.Label
    Friend WithEvents GridThongTinNV As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdateNV As System.Windows.Forms.Button
    Friend WithEvents QLPMDataSet As QLPM1.QLPMDataSet
    Friend WithEvents NHANVIENBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NHANVIENTableAdapter As QLPM1.QLPMDataSetTableAdapters.NHANVIENTableAdapter
    Friend WithEvents MaNVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoTenNVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NgaySinhDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GioiTinhDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiaChiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HocViDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ViTriDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblMaNV As System.Windows.Forms.Label
    Friend WithEvents lblHoTenNV As System.Windows.Forms.Label
    Friend WithEvents lblNgaySinh As System.Windows.Forms.Label
    Friend WithEvents lblGioiTinhNhanVien As System.Windows.Forms.Label
    Friend WithEvents lblDiaChiNhanVien As System.Windows.Forms.Label
    Friend WithEvents lblHocVi As System.Windows.Forms.Label
    Friend WithEvents lblViTri As System.Windows.Forms.Label
    Friend WithEvents txtMaNhanVien As System.Windows.Forms.TextBox
    Friend WithEvents txtHoTenNhanVien As System.Windows.Forms.TextBox
    Friend WithEvents timeNgaySinh As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboGioiTinh As System.Windows.Forms.ComboBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents cboHocVi As System.Windows.Forms.ComboBox
    Friend WithEvents cboViTri As System.Windows.Forms.ComboBox
End Class
