<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frTiepnhanNhanvien
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
        Me.lblMaNV = New System.Windows.Forms.Label()
        Me.lblHoTenNV = New System.Windows.Forms.Label()
        Me.lblNgaySinh = New System.Windows.Forms.Label()
        Me.lblGioiTinhNhanVien = New System.Windows.Forms.Label()
        Me.lblViTri = New System.Windows.Forms.Label()
        Me.lblDiaChiNhanVien = New System.Windows.Forms.Label()
        Me.lblHocVi = New System.Windows.Forms.Label()
        Me.txtMaNhanVien = New System.Windows.Forms.TextBox()
        Me.txtHoTenNhanVien = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.cboGioiTinh = New System.Windows.Forms.ComboBox()
        Me.cboViTri = New System.Windows.Forms.ComboBox()
        Me.cboHocVi = New System.Windows.Forms.ComboBox()
        Me.GridNhanVien = New System.Windows.Forms.DataGridView()
        Me.MaNVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoTenNVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioiTinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HocViDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViTriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NHANVIENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QLPMDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QLPMDataSet = New QLPM1.QLPMDataSet()
        Me.btnNhapNhanVien = New System.Windows.Forms.Button()
        Me.timeNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.NHANVIENTableAdapter = New QLPM1.QLPMDataSetTableAdapters.NHANVIENTableAdapter()
        CType(Me.GridNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NHANVIENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLPMDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLPMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMaNV
        '
        Me.lblMaNV.AutoSize = True
        Me.lblMaNV.Location = New System.Drawing.Point(48, 56)
        Me.lblMaNV.Name = "lblMaNV"
        Me.lblMaNV.Size = New System.Drawing.Size(94, 17)
        Me.lblMaNV.TabIndex = 0
        Me.lblMaNV.Text = "Mã nhân viên:"
        '
        'lblHoTenNV
        '
        Me.lblHoTenNV.AutoSize = True
        Me.lblHoTenNV.Location = New System.Drawing.Point(48, 89)
        Me.lblHoTenNV.Name = "lblHoTenNV"
        Me.lblHoTenNV.Size = New System.Drawing.Size(118, 17)
        Me.lblHoTenNV.TabIndex = 0
        Me.lblHoTenNV.Text = "Họ tên nhân viên:"
        '
        'lblNgaySinh
        '
        Me.lblNgaySinh.AutoSize = True
        Me.lblNgaySinh.Location = New System.Drawing.Point(48, 126)
        Me.lblNgaySinh.Name = "lblNgaySinh"
        Me.lblNgaySinh.Size = New System.Drawing.Size(73, 17)
        Me.lblNgaySinh.TabIndex = 0
        Me.lblNgaySinh.Text = "Ngày sinh:"
        '
        'lblGioiTinhNhanVien
        '
        Me.lblGioiTinhNhanVien.AutoSize = True
        Me.lblGioiTinhNhanVien.Location = New System.Drawing.Point(48, 160)
        Me.lblGioiTinhNhanVien.Name = "lblGioiTinhNhanVien"
        Me.lblGioiTinhNhanVien.Size = New System.Drawing.Size(65, 17)
        Me.lblGioiTinhNhanVien.TabIndex = 0
        Me.lblGioiTinhNhanVien.Text = "Giới tính: "
        '
        'lblViTri
        '
        Me.lblViTri.AutoSize = True
        Me.lblViTri.Location = New System.Drawing.Point(495, 121)
        Me.lblViTri.Name = "lblViTri"
        Me.lblViTri.Size = New System.Drawing.Size(39, 17)
        Me.lblViTri.TabIndex = 0
        Me.lblViTri.Text = "Vị trí:"
        '
        'lblDiaChiNhanVien
        '
        Me.lblDiaChiNhanVien.AutoSize = True
        Me.lblDiaChiNhanVien.Location = New System.Drawing.Point(495, 47)
        Me.lblDiaChiNhanVien.Name = "lblDiaChiNhanVien"
        Me.lblDiaChiNhanVien.Size = New System.Drawing.Size(53, 17)
        Me.lblDiaChiNhanVien.TabIndex = 0
        Me.lblDiaChiNhanVien.Text = "Địa chỉ:"
        '
        'lblHocVi
        '
        Me.lblHocVi.AutoSize = True
        Me.lblHocVi.Location = New System.Drawing.Point(495, 83)
        Me.lblHocVi.Name = "lblHocVi"
        Me.lblHocVi.Size = New System.Drawing.Size(51, 17)
        Me.lblHocVi.TabIndex = 0
        Me.lblHocVi.Text = "Học vị:"
        '
        'txtMaNhanVien
        '
        Me.txtMaNhanVien.Location = New System.Drawing.Point(201, 50)
        Me.txtMaNhanVien.Name = "txtMaNhanVien"
        Me.txtMaNhanVien.Size = New System.Drawing.Size(200, 23)
        Me.txtMaNhanVien.TabIndex = 1
        '
        'txtHoTenNhanVien
        '
        Me.txtHoTenNhanVien.Location = New System.Drawing.Point(201, 83)
        Me.txtHoTenNhanVien.Name = "txtHoTenNhanVien"
        Me.txtHoTenNhanVien.Size = New System.Drawing.Size(200, 23)
        Me.txtHoTenNhanVien.TabIndex = 1
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(576, 47)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(261, 23)
        Me.txtDiaChi.TabIndex = 1
        '
        'cboGioiTinh
        '
        Me.cboGioiTinh.FormattingEnabled = True
        Me.cboGioiTinh.Items.AddRange(New Object() {"Nam", "Nữ", "Không xác định"})
        Me.cboGioiTinh.Location = New System.Drawing.Point(201, 157)
        Me.cboGioiTinh.Name = "cboGioiTinh"
        Me.cboGioiTinh.Size = New System.Drawing.Size(92, 24)
        Me.cboGioiTinh.TabIndex = 2
        '
        'cboViTri
        '
        Me.cboViTri.FormattingEnabled = True
        Me.cboViTri.Items.AddRange(New Object() {"Nhân viên", "Bác sĩ", "Giám đốc"})
        Me.cboViTri.Location = New System.Drawing.Point(576, 121)
        Me.cboViTri.Name = "cboViTri"
        Me.cboViTri.Size = New System.Drawing.Size(121, 24)
        Me.cboViTri.TabIndex = 2
        '
        'cboHocVi
        '
        Me.cboHocVi.FormattingEnabled = True
        Me.cboHocVi.Items.AddRange(New Object() {"Cử nhân", "Thạc sĩ", "Tiến sĩ"})
        Me.cboHocVi.Location = New System.Drawing.Point(576, 83)
        Me.cboHocVi.Name = "cboHocVi"
        Me.cboHocVi.Size = New System.Drawing.Size(121, 24)
        Me.cboHocVi.TabIndex = 2
        '
        'GridNhanVien
        '
        Me.GridNhanVien.AutoGenerateColumns = False
        Me.GridNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridNhanVien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaNVDataGridViewTextBoxColumn, Me.HoTenNVDataGridViewTextBoxColumn, Me.NgaySinhDataGridViewTextBoxColumn, Me.GioiTinhDataGridViewTextBoxColumn, Me.DiaChiDataGridViewTextBoxColumn, Me.HocViDataGridViewTextBoxColumn, Me.ViTriDataGridViewTextBoxColumn})
        Me.GridNhanVien.DataSource = Me.NHANVIENBindingSource
        Me.GridNhanVien.Location = New System.Drawing.Point(51, 206)
        Me.GridNhanVien.Name = "GridNhanVien"
        Me.GridNhanVien.RowTemplate.Height = 24
        Me.GridNhanVien.Size = New System.Drawing.Size(1041, 342)
        Me.GridNhanVien.TabIndex = 4
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
        Me.NHANVIENBindingSource.DataSource = Me.QLPMDataSetBindingSource
        '
        'QLPMDataSetBindingSource
        '
        Me.QLPMDataSetBindingSource.DataSource = Me.QLPMDataSet
        Me.QLPMDataSetBindingSource.Position = 0
        '
        'QLPMDataSet
        '
        Me.QLPMDataSet.DataSetName = "QLPMDataSet"
        Me.QLPMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnNhapNhanVien
        '
        Me.btnNhapNhanVien.Location = New System.Drawing.Point(576, 160)
        Me.btnNhapNhanVien.Name = "btnNhapNhanVien"
        Me.btnNhapNhanVien.Size = New System.Drawing.Size(121, 29)
        Me.btnNhapNhanVien.TabIndex = 5
        Me.btnNhapNhanVien.Text = "Nhập nhân viên"
        Me.btnNhapNhanVien.UseVisualStyleBackColor = True
        '
        'timeNgaySinh
        '
        Me.timeNgaySinh.Cursor = System.Windows.Forms.Cursors.Default
        Me.timeNgaySinh.CustomFormat = "dd-MM-yyyy"
        Me.timeNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.timeNgaySinh.Location = New System.Drawing.Point(201, 119)
        Me.timeNgaySinh.Name = "timeNgaySinh"
        Me.timeNgaySinh.Size = New System.Drawing.Size(200, 23)
        Me.timeNgaySinh.TabIndex = 7
        '
        'NHANVIENTableAdapter
        '
        Me.NHANVIENTableAdapter.ClearBeforeFill = True
        '
        'frTiepnhanNhanvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 577)
        Me.Controls.Add(Me.timeNgaySinh)
        Me.Controls.Add(Me.btnNhapNhanVien)
        Me.Controls.Add(Me.GridNhanVien)
        Me.Controls.Add(Me.cboHocVi)
        Me.Controls.Add(Me.cboViTri)
        Me.Controls.Add(Me.cboGioiTinh)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtHoTenNhanVien)
        Me.Controls.Add(Me.txtMaNhanVien)
        Me.Controls.Add(Me.lblHocVi)
        Me.Controls.Add(Me.lblDiaChiNhanVien)
        Me.Controls.Add(Me.lblViTri)
        Me.Controls.Add(Me.lblGioiTinhNhanVien)
        Me.Controls.Add(Me.lblNgaySinh)
        Me.Controls.Add(Me.lblHoTenNV)
        Me.Controls.Add(Me.lblMaNV)
        Me.Name = "frTiepnhanNhanvien"
        Me.Text = "Tiếp nhận Nhân viên"
        CType(Me.GridNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NHANVIENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLPMDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLPMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMaNV As System.Windows.Forms.Label
    Friend WithEvents lblHoTenNV As System.Windows.Forms.Label
    Friend WithEvents lblNgaySinh As System.Windows.Forms.Label
    Friend WithEvents lblGioiTinhNhanVien As System.Windows.Forms.Label
    Friend WithEvents lblViTri As System.Windows.Forms.Label
    Friend WithEvents lblDiaChiNhanVien As System.Windows.Forms.Label
    Friend WithEvents lblHocVi As System.Windows.Forms.Label
    Friend WithEvents txtMaNhanVien As System.Windows.Forms.TextBox
    Friend WithEvents txtHoTenNhanVien As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents cboGioiTinh As System.Windows.Forms.ComboBox
    Friend WithEvents cboViTri As System.Windows.Forms.ComboBox
    Friend WithEvents cboHocVi As System.Windows.Forms.ComboBox
    Friend WithEvents GridNhanVien As System.Windows.Forms.DataGridView
    Friend WithEvents btnNhapNhanVien As System.Windows.Forms.Button
    Friend WithEvents timeNgaySinh As System.Windows.Forms.DateTimePicker
    Friend WithEvents QLPMDataSetBindingSource As System.Windows.Forms.BindingSource
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
End Class
