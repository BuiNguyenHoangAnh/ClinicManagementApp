<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frBaoCaoSuDungThuoc
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtThangBaoCao
        '
        Me.dtThangBaoCao.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtThangBaoCao.CustomFormat = "MM-yyyy"
        Me.dtThangBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtThangBaoCao.Location = New System.Drawing.Point(304, 62)
        Me.dtThangBaoCao.Name = "dtThangBaoCao"
        Me.dtThangBaoCao.Size = New System.Drawing.Size(116, 22)
        Me.dtThangBaoCao.TabIndex = 0
        '
        'btnThongKe
        '
        Me.btnThongKe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnThongKe.Location = New System.Drawing.Point(438, 52)
        Me.btnThongKe.Name = "btnThongKe"
        Me.btnThongKe.Size = New System.Drawing.Size(100, 36)
        Me.btnThongKe.TabIndex = 1
        Me.btnThongKe.Text = "Thống Kê"
        Me.btnThongKe.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 119)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(659, 352)
        Me.DataGridView1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(191, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(347, 36)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Báo Cáo Sử Dụng Thuốc"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(184, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tháng báo cáo"
        '
        'frBaoCaoSuDungThuoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QLPM1.My.Resources.Resources.blurred_background_8
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(737, 502)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnThongKe)
        Me.Controls.Add(Me.dtThangBaoCao)
        Me.Name = "frBaoCaoSuDungThuoc"
        Me.Text = "Báo Cáo Sử Dụng Thuốc"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtThangBaoCao As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnThongKe As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
