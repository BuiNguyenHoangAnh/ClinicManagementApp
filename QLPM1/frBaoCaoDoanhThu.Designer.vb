<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frBaoCaoDoanhThu
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
        Me.dtThangBaoCao = New System.Windows.Forms.DateTimePicker()
        Me.btnThongKe = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtTongDoanhThu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtThangBaoCao
        '
        Me.dtThangBaoCao.CustomFormat = "MM-yyyy"
        Me.dtThangBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtThangBaoCao.Location = New System.Drawing.Point(385, 93)
        Me.dtThangBaoCao.Name = "dtThangBaoCao"
        Me.dtThangBaoCao.Size = New System.Drawing.Size(103, 22)
        Me.dtThangBaoCao.TabIndex = 0
        '
        'btnThongKe
        '
        Me.btnThongKe.Location = New System.Drawing.Point(519, 84)
        Me.btnThongKe.Name = "btnThongKe"
        Me.btnThongKe.Size = New System.Drawing.Size(95, 45)
        Me.btnThongKe.TabIndex = 1
        Me.btnThongKe.Text = "Thống kê"
        Me.btnThongKe.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(44, 187)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(776, 319)
        Me.DataGridView1.TabIndex = 2
        '
        'txtTongDoanhThu
        '
        Me.txtTongDoanhThu.Location = New System.Drawing.Point(688, 159)
        Me.txtTongDoanhThu.Name = "txtTongDoanhThu"
        Me.txtTongDoanhThu.ReadOnly = True
        Me.txtTongDoanhThu.Size = New System.Drawing.Size(132, 22)
        Me.txtTongDoanhThu.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(569, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tổng doanh thu:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(251, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tháng báo cáo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(248, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(379, 36)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Báo Cáo Doanh Thu Tháng"
        '
        'frBaoCaoDoanhThu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QLPM1.My.Resources.Resources.blurred_background_8
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 547)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTongDoanhThu)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnThongKe)
        Me.Controls.Add(Me.dtThangBaoCao)
        Me.Name = "frBaoCaoDoanhThu"
        Me.Text = "Báo Cáo Doanh Thu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtThangBaoCao As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnThongKe As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtTongDoanhThu As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
