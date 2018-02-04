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
        Me.conbGioitinh = New System.Windows.Forms.ComboBox()
        Me.ckbTrieuchung = New System.Windows.Forms.CheckBox()
        Me.tbTrieuchung = New System.Windows.Forms.TextBox()
        Me.ckbLoaibenh = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ckbThuocsudung = New System.Windows.Forms.CheckBox()
        Me.combThuocsudung = New System.Windows.Forms.ComboBox()
        Me.ckbTongtien = New System.Windows.Forms.CheckBox()
        Me.tbTongtien1 = New System.Windows.Forms.TextBox()
        Me.lbTongtien = New System.Windows.Forms.Label()
        Me.tbTongtien2 = New System.Windows.Forms.TextBox()
        Me.lbKetquatracuu = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(263, 18)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(209, 26)
        Me.lbName.TabIndex = 0
        Me.lbName.Text = "Tra cứu bệnh nhân"
        '
        'tbMakhambenh
        '
        Me.tbMakhambenh.Location = New System.Drawing.Point(180, 60)
        Me.tbMakhambenh.Name = "tbMakhambenh"
        Me.tbMakhambenh.Size = New System.Drawing.Size(200, 20)
        Me.tbMakhambenh.TabIndex = 4
        '
        'ckbMakhambenh
        '
        Me.ckbMakhambenh.AutoSize = True
        Me.ckbMakhambenh.Location = New System.Drawing.Point(35, 63)
        Me.ckbMakhambenh.Name = "ckbMakhambenh"
        Me.ckbMakhambenh.Size = New System.Drawing.Size(139, 17)
        Me.ckbMakhambenh.TabIndex = 5
        Me.ckbMakhambenh.Text = "Mã khám bệnh có chứa"
        Me.ckbMakhambenh.UseVisualStyleBackColor = True
        '
        'ckbHoten
        '
        Me.ckbHoten.AutoSize = True
        Me.ckbHoten.Location = New System.Drawing.Point(35, 96)
        Me.ckbHoten.Name = "ckbHoten"
        Me.ckbHoten.Size = New System.Drawing.Size(58, 17)
        Me.ckbHoten.TabIndex = 6
        Me.ckbHoten.Text = "Họ tên"
        Me.ckbHoten.UseVisualStyleBackColor = True
        '
        'tbHoten
        '
        Me.tbHoten.Location = New System.Drawing.Point(180, 93)
        Me.tbHoten.Name = "tbHoten"
        Me.tbHoten.Size = New System.Drawing.Size(200, 20)
        Me.tbHoten.TabIndex = 7
        '
        'ckbNamsinh
        '
        Me.ckbNamsinh.AutoSize = True
        Me.ckbNamsinh.Location = New System.Drawing.Point(35, 130)
        Me.ckbNamsinh.Name = "ckbNamsinh"
        Me.ckbNamsinh.Size = New System.Drawing.Size(82, 17)
        Me.ckbNamsinh.TabIndex = 8
        Me.ckbNamsinh.Text = "Năm sinh từ"
        Me.ckbNamsinh.UseVisualStyleBackColor = True
        '
        'dNamsinh1
        '
        Me.dNamsinh1.Location = New System.Drawing.Point(180, 127)
        Me.dNamsinh1.Name = "dNamsinh1"
        Me.dNamsinh1.Size = New System.Drawing.Size(200, 20)
        Me.dNamsinh1.TabIndex = 9
        '
        'ckbDiachi
        '
        Me.ckbDiachi.AutoSize = True
        Me.ckbDiachi.Location = New System.Drawing.Point(35, 164)
        Me.ckbDiachi.Name = "ckbDiachi"
        Me.ckbDiachi.Size = New System.Drawing.Size(59, 17)
        Me.ckbDiachi.TabIndex = 10
        Me.ckbDiachi.Text = "Địa chỉ"
        Me.ckbDiachi.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(180, 164)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(200, 54)
        Me.RichTextBox1.TabIndex = 11
        Me.RichTextBox1.Text = ""
        '
        'lbNamsinh
        '
        Me.lbNamsinh.AutoSize = True
        Me.lbNamsinh.Location = New System.Drawing.Point(398, 134)
        Me.lbNamsinh.Name = "lbNamsinh"
        Me.lbNamsinh.Size = New System.Drawing.Size(26, 13)
        Me.lbNamsinh.TabIndex = 12
        Me.lbNamsinh.Text = "đến"
        '
        'dNamsinh2
        '
        Me.dNamsinh2.Location = New System.Drawing.Point(440, 127)
        Me.dNamsinh2.Name = "dNamsinh2"
        Me.dNamsinh2.Size = New System.Drawing.Size(200, 20)
        Me.dNamsinh2.TabIndex = 13
        '
        'ckbNgaykham
        '
        Me.ckbNgaykham.AutoSize = True
        Me.ckbNgaykham.Location = New System.Drawing.Point(35, 233)
        Me.ckbNgaykham.Name = "ckbNgaykham"
        Me.ckbNgaykham.Size = New System.Drawing.Size(92, 17)
        Me.ckbNgaykham.TabIndex = 14
        Me.ckbNgaykham.Text = "Ngày khám từ"
        Me.ckbNgaykham.UseVisualStyleBackColor = True
        '
        'dNgaykham1
        '
        Me.dNgaykham1.Location = New System.Drawing.Point(180, 230)
        Me.dNgaykham1.Name = "dNgaykham1"
        Me.dNgaykham1.Size = New System.Drawing.Size(200, 20)
        Me.dNgaykham1.TabIndex = 15
        '
        'lbNgaykham
        '
        Me.lbNgaykham.AutoSize = True
        Me.lbNgaykham.Location = New System.Drawing.Point(398, 237)
        Me.lbNgaykham.Name = "lbNgaykham"
        Me.lbNgaykham.Size = New System.Drawing.Size(26, 13)
        Me.lbNgaykham.TabIndex = 16
        Me.lbNgaykham.Text = "đến"
        '
        'dNgaykham2
        '
        Me.dNgaykham2.Location = New System.Drawing.Point(440, 228)
        Me.dNgaykham2.Name = "dNgaykham2"
        Me.dNgaykham2.Size = New System.Drawing.Size(200, 20)
        Me.dNgaykham2.TabIndex = 17
        '
        'ckbGioitinh
        '
        Me.ckbGioitinh.AutoSize = True
        Me.ckbGioitinh.Location = New System.Drawing.Point(35, 268)
        Me.ckbGioitinh.Name = "ckbGioitinh"
        Me.ckbGioitinh.Size = New System.Drawing.Size(66, 17)
        Me.ckbGioitinh.TabIndex = 18
        Me.ckbGioitinh.Text = "Giới tính"
        Me.ckbGioitinh.UseVisualStyleBackColor = True
        '
        'conbGioitinh
        '
        Me.conbGioitinh.FormattingEnabled = True
        Me.conbGioitinh.Items.AddRange(New Object() {"Nam", "Nữ", "Không xác định"})
        Me.conbGioitinh.Location = New System.Drawing.Point(180, 264)
        Me.conbGioitinh.Name = "conbGioitinh"
        Me.conbGioitinh.Size = New System.Drawing.Size(200, 21)
        Me.conbGioitinh.TabIndex = 19
        '
        'ckbTrieuchung
        '
        Me.ckbTrieuchung.AutoSize = True
        Me.ckbTrieuchung.Location = New System.Drawing.Point(35, 303)
        Me.ckbTrieuchung.Name = "ckbTrieuchung"
        Me.ckbTrieuchung.Size = New System.Drawing.Size(83, 17)
        Me.ckbTrieuchung.TabIndex = 20
        Me.ckbTrieuchung.Text = "Triệu chứng"
        Me.ckbTrieuchung.UseVisualStyleBackColor = True
        '
        'tbTrieuchung
        '
        Me.tbTrieuchung.Location = New System.Drawing.Point(180, 300)
        Me.tbTrieuchung.Name = "tbTrieuchung"
        Me.tbTrieuchung.Size = New System.Drawing.Size(200, 20)
        Me.tbTrieuchung.TabIndex = 21
        '
        'ckbLoaibenh
        '
        Me.ckbLoaibenh.AutoSize = True
        Me.ckbLoaibenh.Location = New System.Drawing.Point(35, 335)
        Me.ckbLoaibenh.Name = "ckbLoaibenh"
        Me.ckbLoaibenh.Size = New System.Drawing.Size(73, 17)
        Me.ckbLoaibenh.TabIndex = 22
        Me.ckbLoaibenh.Text = "Loại bệnh"
        Me.ckbLoaibenh.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(180, 331)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 23
        '
        'ckbThuocsudung
        '
        Me.ckbThuocsudung.AutoSize = True
        Me.ckbThuocsudung.Location = New System.Drawing.Point(35, 367)
        Me.ckbThuocsudung.Name = "ckbThuocsudung"
        Me.ckbThuocsudung.Size = New System.Drawing.Size(98, 17)
        Me.ckbThuocsudung.TabIndex = 24
        Me.ckbThuocsudung.Text = "Thuốc sử dụng"
        Me.ckbThuocsudung.UseVisualStyleBackColor = True
        '
        'combThuocsudung
        '
        Me.combThuocsudung.FormattingEnabled = True
        Me.combThuocsudung.Location = New System.Drawing.Point(180, 363)
        Me.combThuocsudung.Name = "combThuocsudung"
        Me.combThuocsudung.Size = New System.Drawing.Size(200, 21)
        Me.combThuocsudung.TabIndex = 25
        '
        'ckbTongtien
        '
        Me.ckbTongtien.AutoSize = True
        Me.ckbTongtien.Location = New System.Drawing.Point(35, 401)
        Me.ckbTongtien.Name = "ckbTongtien"
        Me.ckbTongtien.Size = New System.Drawing.Size(83, 17)
        Me.ckbTongtien.TabIndex = 26
        Me.ckbTongtien.Text = "Tổng tiền từ"
        Me.ckbTongtien.UseVisualStyleBackColor = True
        '
        'tbTongtien1
        '
        Me.tbTongtien1.Location = New System.Drawing.Point(180, 398)
        Me.tbTongtien1.Name = "tbTongtien1"
        Me.tbTongtien1.Size = New System.Drawing.Size(200, 20)
        Me.tbTongtien1.TabIndex = 27
        '
        'lbTongtien
        '
        Me.lbTongtien.AutoSize = True
        Me.lbTongtien.Location = New System.Drawing.Point(398, 405)
        Me.lbTongtien.Name = "lbTongtien"
        Me.lbTongtien.Size = New System.Drawing.Size(26, 13)
        Me.lbTongtien.TabIndex = 28
        Me.lbTongtien.Text = "đến"
        '
        'tbTongtien2
        '
        Me.tbTongtien2.Location = New System.Drawing.Point(440, 398)
        Me.tbTongtien2.Name = "tbTongtien2"
        Me.tbTongtien2.Size = New System.Drawing.Size(200, 20)
        Me.tbTongtien2.TabIndex = 29
        '
        'lbKetquatracuu
        '
        Me.lbKetquatracuu.AutoSize = True
        Me.lbKetquatracuu.Location = New System.Drawing.Point(32, 435)
        Me.lbKetquatracuu.Name = "lbKetquatracuu"
        Me.lbKetquatracuu.Size = New System.Drawing.Size(80, 13)
        Me.lbKetquatracuu.TabIndex = 30
        Me.lbKetquatracuu.Text = "Kết quả tra cứu"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(35, 461)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(605, 70)
        Me.Panel1.TabIndex = 31
        '
        'frmTracuubenhnhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 552)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbKetquatracuu)
        Me.Controls.Add(Me.tbTongtien2)
        Me.Controls.Add(Me.lbTongtien)
        Me.Controls.Add(Me.tbTongtien1)
        Me.Controls.Add(Me.ckbTongtien)
        Me.Controls.Add(Me.combThuocsudung)
        Me.Controls.Add(Me.ckbThuocsudung)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ckbLoaibenh)
        Me.Controls.Add(Me.tbTrieuchung)
        Me.Controls.Add(Me.ckbTrieuchung)
        Me.Controls.Add(Me.conbGioitinh)
        Me.Controls.Add(Me.ckbGioitinh)
        Me.Controls.Add(Me.dNgaykham2)
        Me.Controls.Add(Me.lbNgaykham)
        Me.Controls.Add(Me.dNgaykham1)
        Me.Controls.Add(Me.ckbNgaykham)
        Me.Controls.Add(Me.dNamsinh2)
        Me.Controls.Add(Me.lbNamsinh)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ckbDiachi)
        Me.Controls.Add(Me.dNamsinh1)
        Me.Controls.Add(Me.ckbNamsinh)
        Me.Controls.Add(Me.tbHoten)
        Me.Controls.Add(Me.ckbHoten)
        Me.Controls.Add(Me.ckbMakhambenh)
        Me.Controls.Add(Me.tbMakhambenh)
        Me.Controls.Add(Me.lbName)
        Me.Name = "frmTracuubenhnhan"
        Me.Text = "Tra cứu bệnh nhân"
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
    Friend WithEvents conbGioitinh As System.Windows.Forms.ComboBox
    Friend WithEvents ckbTrieuchung As System.Windows.Forms.CheckBox
    Friend WithEvents tbTrieuchung As System.Windows.Forms.TextBox
    Friend WithEvents ckbLoaibenh As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ckbThuocsudung As System.Windows.Forms.CheckBox
    Friend WithEvents combThuocsudung As System.Windows.Forms.ComboBox
    Friend WithEvents ckbTongtien As System.Windows.Forms.CheckBox
    Friend WithEvents tbTongtien1 As System.Windows.Forms.TextBox
    Friend WithEvents lbTongtien As System.Windows.Forms.Label
    Friend WithEvents tbTongtien2 As System.Windows.Forms.TextBox
    Friend WithEvents lbKetquatracuu As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
