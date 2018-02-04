<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTracuubenhnhan
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
        Me.components = New System.ComponentModel.Container()
        Me.lbName = New System.Windows.Forms.Label()
        Me.tbMakhambenh = New System.Windows.Forms.TextBox()
        Me.ckbMakhambenh = New System.Windows.Forms.CheckBox()
        Me.ckbHoten = New System.Windows.Forms.CheckBox()
        Me.tbHoten = New System.Windows.Forms.TextBox()
        Me.ckbNamsinh = New System.Windows.Forms.CheckBox()
        Me.dNamsinh1 = New System.Windows.Forms.DateTimePicker()
        Me.ckbDiachi = New System.Windows.Forms.CheckBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.lbNamsinh = New System.Windows.Forms.Label()
        Me.dNamsinh2 = New System.Windows.Forms.DateTimePicker()
        Me.ckbNgaykham = New System.Windows.Forms.CheckBox()
        Me.dNgaykham1 = New System.Windows.Forms.DateTimePicker()
        Me.lbNgaykham = New System.Windows.Forms.Label()
        Me.dNgaykham2 = New System.Windows.Forms.DateTimePicker()
        Me.ckbGioitinh = New System.Windows.Forms.CheckBox()
        Me.combGioitinh = New System.Windows.Forms.ComboBox()
        Me.ckbTrieuchung = New System.Windows.Forms.CheckBox()
        Me.tbTrieuchung = New System.Windows.Forms.TextBox()
        Me.ckbLoaibenh = New System.Windows.Forms.CheckBox()
        Me.combLoaiBenh = New System.Windows.Forms.ComboBox()
        Me.ckbThuocsudung = New System.Windows.Forms.CheckBox()
        Me.combThuocsudung = New System.Windows.Forms.ComboBox()
        Me.ckbTongtien = New System.Windows.Forms.CheckBox()
        Me.tbTongtien1 = New System.Windows.Forms.TextBox()
        Me.lbTongtien = New System.Windows.Forms.Label()
        Me.tbTongtien2 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnTracuu = New System.Windows.Forms.Button()
        Me.QLPMDataSet = New QLPM1.QLPMDataSet()
        Me.LOAIBENHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOAIBENHTableAdapter = New QLPM1.QLPMDataSetTableAdapters.LOAIBENHTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLPMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOAIBENHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.BackColor = System.Drawing.Color.Transparent
        Me.lbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(351, 22)
        Me.lbName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(257, 31)
        Me.lbName.TabIndex = 0
        Me.lbName.Text = "Tra cứu bệnh nhân"
        '
        'tbMakhambenh
        '
        Me.tbMakhambenh.Location = New System.Drawing.Point(213, 42)
        Me.tbMakhambenh.Margin = New System.Windows.Forms.Padding(4)
        Me.tbMakhambenh.Name = "tbMakhambenh"
        Me.tbMakhambenh.Size = New System.Drawing.Size(265, 22)
        Me.tbMakhambenh.TabIndex = 4
        '
        'ckbMakhambenh
        '
        Me.ckbMakhambenh.AutoSize = True
        Me.ckbMakhambenh.BackColor = System.Drawing.Color.Transparent
        Me.ckbMakhambenh.Location = New System.Drawing.Point(20, 46)
        Me.ckbMakhambenh.Margin = New System.Windows.Forms.Padding(4)
        Me.ckbMakhambenh.Name = "ckbMakhambenh"
        Me.ckbMakhambenh.Size = New System.Drawing.Size(177, 21)
        Me.ckbMakhambenh.TabIndex = 5
        Me.ckbMakhambenh.Text = "Mã khám bệnh có chứa"
        Me.ckbMakhambenh.UseVisualStyleBackColor = False
        '
        'ckbHoten
        '
        Me.ckbHoten.AutoSize = True
        Me.ckbHoten.BackColor = System.Drawing.Color.Transparent
        Me.ckbHoten.Location = New System.Drawing.Point(20, 86)
        Me.ckbHoten.Margin = New System.Windows.Forms.Padding(4)
        Me.ckbHoten.Name = "ckbHoten"
        Me.ckbHoten.Size = New System.Drawing.Size(72, 21)
        Me.ckbHoten.TabIndex = 6
        Me.ckbHoten.Text = "Họ tên"
        Me.ckbHoten.UseVisualStyleBackColor = False
        '
        'tbHoten
        '
        Me.tbHoten.Location = New System.Drawing.Point(213, 82)
        Me.tbHoten.Margin = New System.Windows.Forms.Padding(4)
        Me.tbHoten.Name = "tbHoten"
        Me.tbHoten.Size = New System.Drawing.Size(265, 22)
        Me.tbHoten.TabIndex = 7
        '
        'ckbNamsinh
        '
        Me.ckbNamsinh.AutoSize = True
        Me.ckbNamsinh.BackColor = System.Drawing.Color.Transparent
        Me.ckbNamsinh.Location = New System.Drawing.Point(20, 128)
        Me.ckbNamsinh.Margin = New System.Windows.Forms.Padding(4)
        Me.ckbNamsinh.Name = "ckbNamsinh"
        Me.ckbNamsinh.Size = New System.Drawing.Size(105, 21)
        Me.ckbNamsinh.TabIndex = 8
        Me.ckbNamsinh.Text = "Năm sinh từ"
        Me.ckbNamsinh.UseVisualStyleBackColor = False
        '
        'dNamsinh1
        '
        Me.dNamsinh1.CustomFormat = "dd-MM-yyyy"
        Me.dNamsinh1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dNamsinh1.Location = New System.Drawing.Point(213, 124)
        Me.dNamsinh1.Margin = New System.Windows.Forms.Padding(4)
        Me.dNamsinh1.Name = "dNamsinh1"
        Me.dNamsinh1.Size = New System.Drawing.Size(104, 22)
        Me.dNamsinh1.TabIndex = 9
        '
        'ckbDiachi
        '
        Me.ckbDiachi.AutoSize = True
        Me.ckbDiachi.BackColor = System.Drawing.Color.Transparent
        Me.ckbDiachi.Location = New System.Drawing.Point(20, 170)
        Me.ckbDiachi.Margin = New System.Windows.Forms.Padding(4)
        Me.ckbDiachi.Name = "ckbDiachi"
        Me.ckbDiachi.Size = New System.Drawing.Size(73, 21)
        Me.ckbDiachi.TabIndex = 10
        Me.ckbDiachi.Text = "Địa chỉ"
        Me.ckbDiachi.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(213, 170)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(265, 66)
        Me.RichTextBox1.TabIndex = 11
        Me.RichTextBox1.Text = ""
        '
        'lbNamsinh
        '
        Me.lbNamsinh.AutoSize = True
        Me.lbNamsinh.BackColor = System.Drawing.Color.Transparent
        Me.lbNamsinh.Location = New System.Drawing.Point(337, 124)
        Me.lbNamsinh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNamsinh.Name = "lbNamsinh"
        Me.lbNamsinh.Size = New System.Drawing.Size(32, 17)
        Me.lbNamsinh.TabIndex = 12
        Me.lbNamsinh.Text = "đến"
        '
        'dNamsinh2
        '
        Me.dNamsinh2.CustomFormat = "dd-MM-yyyy"
        Me.dNamsinh2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dNamsinh2.Location = New System.Drawing.Point(377, 124)
        Me.dNamsinh2.Margin = New System.Windows.Forms.Padding(4)
        Me.dNamsinh2.Name = "dNamsinh2"
        Me.dNamsinh2.Size = New System.Drawing.Size(101, 22)
        Me.dNamsinh2.TabIndex = 13
        '
        'ckbNgaykham
        '
        Me.ckbNgaykham.AutoSize = True
        Me.ckbNgaykham.BackColor = System.Drawing.Color.Transparent
        Me.ckbNgaykham.Location = New System.Drawing.Point(20, 255)
        Me.ckbNgaykham.Margin = New System.Windows.Forms.Padding(4)
        Me.ckbNgaykham.Name = "ckbNgaykham"
        Me.ckbNgaykham.Size = New System.Drawing.Size(117, 21)
        Me.ckbNgaykham.TabIndex = 14
        Me.ckbNgaykham.Text = "Ngày khám từ"
        Me.ckbNgaykham.UseVisualStyleBackColor = False
        '
        'dNgaykham1
        '
        Me.dNgaykham1.CustomFormat = "dd-MM-yyyy"
        Me.dNgaykham1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dNgaykham1.Location = New System.Drawing.Point(213, 251)
        Me.dNgaykham1.Margin = New System.Windows.Forms.Padding(4)
        Me.dNgaykham1.Name = "dNgaykham1"
        Me.dNgaykham1.Size = New System.Drawing.Size(104, 22)
        Me.dNgaykham1.TabIndex = 15
        '
        'lbNgaykham
        '
        Me.lbNgaykham.AutoSize = True
        Me.lbNgaykham.BackColor = System.Drawing.Color.Transparent
        Me.lbNgaykham.Location = New System.Drawing.Point(337, 255)
        Me.lbNgaykham.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNgaykham.Name = "lbNgaykham"
        Me.lbNgaykham.Size = New System.Drawing.Size(32, 17)
        Me.lbNgaykham.TabIndex = 16
        Me.lbNgaykham.Text = "đến"
        '
        'dNgaykham2
        '
        Me.dNgaykham2.CustomFormat = "dd-MM-yyyy"
        Me.dNgaykham2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dNgaykham2.Location = New System.Drawing.Point(377, 251)
        Me.dNgaykham2.Margin = New System.Windows.Forms.Padding(4)
        Me.dNgaykham2.Name = "dNgaykham2"
        Me.dNgaykham2.Size = New System.Drawing.Size(103, 22)
        Me.dNgaykham2.TabIndex = 17
        '
        'ckbGioitinh
        '
        Me.ckbGioitinh.AutoSize = True
        Me.ckbGioitinh.BackColor = System.Drawing.Color.Transparent
        Me.ckbGioitinh.Location = New System.Drawing.Point(20, 298)
        Me.ckbGioitinh.Margin = New System.Windows.Forms.Padding(4)
        Me.ckbGioitinh.Name = "ckbGioitinh"
        Me.ckbGioitinh.Size = New System.Drawing.Size(82, 21)
        Me.ckbGioitinh.TabIndex = 18
        Me.ckbGioitinh.Text = "Giới tính"
        Me.ckbGioitinh.UseVisualStyleBackColor = False
        '
        'combGioitinh
        '
        Me.combGioitinh.FormattingEnabled = True
        Me.combGioitinh.Items.AddRange(New Object() {"Nam", "Nữ", "Không xác định"})
        Me.combGioitinh.Location = New System.Drawing.Point(213, 293)
        Me.combGioitinh.Margin = New System.Windows.Forms.Padding(4)
        Me.combGioitinh.Name = "combGioitinh"
        Me.combGioitinh.Size = New System.Drawing.Size(265, 24)
        Me.combGioitinh.TabIndex = 19
        Me.combGioitinh.Text = "Nam"
        '
        'ckbTrieuchung
        '
        Me.ckbTrieuchung.AutoSize = True
        Me.ckbTrieuchung.BackColor = System.Drawing.Color.Transparent
        Me.ckbTrieuchung.Location = New System.Drawing.Point(20, 341)
        Me.ckbTrieuchung.Margin = New System.Windows.Forms.Padding(4)
        Me.ckbTrieuchung.Name = "ckbTrieuchung"
        Me.ckbTrieuchung.Size = New System.Drawing.Size(106, 21)
        Me.ckbTrieuchung.TabIndex = 20
        Me.ckbTrieuchung.Text = "Triệu chứng"
        Me.ckbTrieuchung.UseVisualStyleBackColor = False
        '
        'tbTrieuchung
        '
        Me.tbTrieuchung.Location = New System.Drawing.Point(213, 337)
        Me.tbTrieuchung.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTrieuchung.Name = "tbTrieuchung"
        Me.tbTrieuchung.Size = New System.Drawing.Size(265, 22)
        Me.tbTrieuchung.TabIndex = 21
        '
        'ckbLoaibenh
        '
        Me.ckbLoaibenh.AutoSize = True
        Me.ckbLoaibenh.BackColor = System.Drawing.Color.Transparent
        Me.ckbLoaibenh.Location = New System.Drawing.Point(20, 380)
        Me.ckbLoaibenh.Margin = New System.Windows.Forms.Padding(4)
        Me.ckbLoaibenh.Name = "ckbLoaibenh"
        Me.ckbLoaibenh.Size = New System.Drawing.Size(93, 21)
        Me.ckbLoaibenh.TabIndex = 22
        Me.ckbLoaibenh.Text = "Loại bệnh"
        Me.ckbLoaibenh.UseVisualStyleBackColor = False
        '
        'combLoaiBenh
        '
        Me.combLoaiBenh.FormattingEnabled = True
        Me.combLoaiBenh.Location = New System.Drawing.Point(213, 375)
        Me.combLoaiBenh.Margin = New System.Windows.Forms.Padding(4)
        Me.combLoaiBenh.Name = "combLoaiBenh"
        Me.combLoaiBenh.Size = New System.Drawing.Size(265, 24)
        Me.combLoaiBenh.TabIndex = 23
        '
        'ckbThuocsudung
        '
        Me.ckbThuocsudung.AutoSize = True
        Me.ckbThuocsudung.BackColor = System.Drawing.Color.Transparent
        Me.ckbThuocsudung.Location = New System.Drawing.Point(20, 420)
        Me.ckbThuocsudung.Margin = New System.Windows.Forms.Padding(4)
        Me.ckbThuocsudung.Name = "ckbThuocsudung"
        Me.ckbThuocsudung.Size = New System.Drawing.Size(125, 21)
        Me.ckbThuocsudung.TabIndex = 24
        Me.ckbThuocsudung.Text = "Thuốc sử dụng"
        Me.ckbThuocsudung.UseVisualStyleBackColor = False
        '
        'combThuocsudung
        '
        Me.combThuocsudung.FormattingEnabled = True
        Me.combThuocsudung.Location = New System.Drawing.Point(213, 415)
        Me.combThuocsudung.Margin = New System.Windows.Forms.Padding(4)
        Me.combThuocsudung.Name = "combThuocsudung"
        Me.combThuocsudung.Size = New System.Drawing.Size(265, 24)
        Me.combThuocsudung.TabIndex = 25
        '
        'ckbTongtien
        '
        Me.ckbTongtien.AutoSize = True
        Me.ckbTongtien.BackColor = System.Drawing.Color.Transparent
        Me.ckbTongtien.Location = New System.Drawing.Point(20, 462)
        Me.ckbTongtien.Margin = New System.Windows.Forms.Padding(4)
        Me.ckbTongtien.Name = "ckbTongtien"
        Me.ckbTongtien.Size = New System.Drawing.Size(106, 21)
        Me.ckbTongtien.TabIndex = 26
        Me.ckbTongtien.Text = "Tổng tiền từ"
        Me.ckbTongtien.UseVisualStyleBackColor = False
        '
        'tbTongtien1
        '
        Me.tbTongtien1.Location = New System.Drawing.Point(213, 458)
        Me.tbTongtien1.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTongtien1.Name = "tbTongtien1"
        Me.tbTongtien1.Size = New System.Drawing.Size(104, 22)
        Me.tbTongtien1.TabIndex = 27
        '
        'lbTongtien
        '
        Me.lbTongtien.AutoSize = True
        Me.lbTongtien.BackColor = System.Drawing.Color.Transparent
        Me.lbTongtien.Location = New System.Drawing.Point(337, 458)
        Me.lbTongtien.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTongtien.Name = "lbTongtien"
        Me.lbTongtien.Size = New System.Drawing.Size(32, 17)
        Me.lbTongtien.TabIndex = 28
        Me.lbTongtien.Text = "đến"
        '
        'tbTongtien2
        '
        Me.tbTongtien2.Location = New System.Drawing.Point(377, 458)
        Me.tbTongtien2.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTongtien2.Name = "tbTongtien2"
        Me.tbTongtien2.Size = New System.Drawing.Size(103, 22)
        Me.tbTongtien2.TabIndex = 29
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 32)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(817, 520)
        Me.DataGridView1.TabIndex = 0
        '
        'btnTracuu
        '
        Me.btnTracuu.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTracuu.Location = New System.Drawing.Point(213, 503)
        Me.btnTracuu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTracuu.Name = "btnTracuu"
        Me.btnTracuu.Size = New System.Drawing.Size(268, 49)
        Me.btnTracuu.TabIndex = 32
        Me.btnTracuu.Text = "Tra cứu"
        Me.btnTracuu.UseVisualStyleBackColor = True
        '
        'QLPMDataSet
        '
        Me.QLPMDataSet.DataSetName = "QLPMDataSet"
        Me.QLPMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LOAIBENHBindingSource
        '
        Me.LOAIBENHBindingSource.DataMember = "LOAIBENH"
        Me.LOAIBENHBindingSource.DataSource = Me.QLPMDataSet
        '
        'LOAIBENHTableAdapter
        '
        Me.LOAIBENHTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.ckbMakhambenh)
        Me.GroupBox3.Controls.Add(Me.btnTracuu)
        Me.GroupBox3.Controls.Add(Me.tbMakhambenh)
        Me.GroupBox3.Controls.Add(Me.ckbHoten)
        Me.GroupBox3.Controls.Add(Me.tbHoten)
        Me.GroupBox3.Controls.Add(Me.tbTongtien2)
        Me.GroupBox3.Controls.Add(Me.ckbNamsinh)
        Me.GroupBox3.Controls.Add(Me.lbTongtien)
        Me.GroupBox3.Controls.Add(Me.dNamsinh1)
        Me.GroupBox3.Controls.Add(Me.tbTongtien1)
        Me.GroupBox3.Controls.Add(Me.ckbDiachi)
        Me.GroupBox3.Controls.Add(Me.ckbTongtien)
        Me.GroupBox3.Controls.Add(Me.RichTextBox1)
        Me.GroupBox3.Controls.Add(Me.combThuocsudung)
        Me.GroupBox3.Controls.Add(Me.lbNamsinh)
        Me.GroupBox3.Controls.Add(Me.ckbThuocsudung)
        Me.GroupBox3.Controls.Add(Me.dNamsinh2)
        Me.GroupBox3.Controls.Add(Me.combLoaiBenh)
        Me.GroupBox3.Controls.Add(Me.ckbNgaykham)
        Me.GroupBox3.Controls.Add(Me.ckbLoaibenh)
        Me.GroupBox3.Controls.Add(Me.dNgaykham1)
        Me.GroupBox3.Controls.Add(Me.tbTrieuchung)
        Me.GroupBox3.Controls.Add(Me.lbNgaykham)
        Me.GroupBox3.Controls.Add(Me.ckbTrieuchung)
        Me.GroupBox3.Controls.Add(Me.dNgaykham2)
        Me.GroupBox3.Controls.Add(Me.combGioitinh)
        Me.GroupBox3.Controls.Add(Me.ckbGioitinh)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(517, 575)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tiêu chuẩn tra cứu"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(581, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 575)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kết quả tra cứu"
        '
        'frmTracuubenhnhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QLPM1.My.Resources.Resources.blurred_background_8
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1466, 661)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lbName)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTracuubenhnhan"
        Me.Text = "Tra cứu bệnh nhân"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLPMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOAIBENHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents tbMakhambenh As System.Windows.Forms.TextBox
    Friend WithEvents ckbMakhambenh As System.Windows.Forms.CheckBox
    Friend WithEvents ckbHoten As System.Windows.Forms.CheckBox
    Friend WithEvents tbHoten As System.Windows.Forms.TextBox
    Friend WithEvents ckbNamsinh As System.Windows.Forms.CheckBox
    Friend WithEvents dNamsinh1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ckbDiachi As System.Windows.Forms.CheckBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents lbNamsinh As System.Windows.Forms.Label
    Friend WithEvents dNamsinh2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ckbNgaykham As System.Windows.Forms.CheckBox
    Friend WithEvents dNgaykham1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbNgaykham As System.Windows.Forms.Label
    Friend WithEvents dNgaykham2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ckbGioitinh As System.Windows.Forms.CheckBox
    Friend WithEvents combGioitinh As System.Windows.Forms.ComboBox
    Friend WithEvents ckbTrieuchung As System.Windows.Forms.CheckBox
    Friend WithEvents tbTrieuchung As System.Windows.Forms.TextBox
    Friend WithEvents ckbLoaibenh As System.Windows.Forms.CheckBox
    Friend WithEvents combLoaiBenh As System.Windows.Forms.ComboBox
    Friend WithEvents ckbThuocsudung As System.Windows.Forms.CheckBox
    Friend WithEvents combThuocsudung As System.Windows.Forms.ComboBox
    Friend WithEvents ckbTongtien As System.Windows.Forms.CheckBox
    Friend WithEvents tbTongtien1 As System.Windows.Forms.TextBox
    Friend WithEvents lbTongtien As System.Windows.Forms.Label
    Friend WithEvents tbTongtien2 As System.Windows.Forms.TextBox
    Friend WithEvents btnTracuu As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents QLPMDataSet As QLPM1.QLPMDataSet
    Friend WithEvents LOAIBENHBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOAIBENHTableAdapter As QLPM1.QLPMDataSetTableAdapters.LOAIBENHTableAdapter
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
