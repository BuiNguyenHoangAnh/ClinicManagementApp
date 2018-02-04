<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frThayDoiQuiDinh
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
        Me.txtSoBenhNhanToiDa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ckbSoBenhNhanToiDa = New System.Windows.Forms.CheckBox()
        Me.ckbTienKhamQuiDinh = New System.Windows.Forms.CheckBox()
        Me.txtTienKhamQuiDinh = New System.Windows.Forms.TextBox()
        Me.btnThayDoi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSoBenhNhanToiDa
        '
        Me.txtSoBenhNhanToiDa.Location = New System.Drawing.Point(299, 110)
        Me.txtSoBenhNhanToiDa.Name = "txtSoBenhNhanToiDa"
        Me.txtSoBenhNhanToiDa.Size = New System.Drawing.Size(156, 22)
        Me.txtSoBenhNhanToiDa.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "THAY ĐỔI QUI ĐỊNH"
        '
        'ckbSoBenhNhanToiDa
        '
        Me.ckbSoBenhNhanToiDa.AutoSize = True
        Me.ckbSoBenhNhanToiDa.BackColor = System.Drawing.Color.Transparent
        Me.ckbSoBenhNhanToiDa.Location = New System.Drawing.Point(58, 112)
        Me.ckbSoBenhNhanToiDa.Name = "ckbSoBenhNhanToiDa"
        Me.ckbSoBenhNhanToiDa.Size = New System.Drawing.Size(235, 21)
        Me.ckbSoBenhNhanToiDa.TabIndex = 2
        Me.ckbSoBenhNhanToiDa.Text = "Số lượng bệnh nhân khám tối đa"
        Me.ckbSoBenhNhanToiDa.UseVisualStyleBackColor = False
        '
        'ckbTienKhamQuiDinh
        '
        Me.ckbTienKhamQuiDinh.AutoSize = True
        Me.ckbTienKhamQuiDinh.BackColor = System.Drawing.Color.Transparent
        Me.ckbTienKhamQuiDinh.Location = New System.Drawing.Point(58, 155)
        Me.ckbTienKhamQuiDinh.Name = "ckbTienKhamQuiDinh"
        Me.ckbTienKhamQuiDinh.Size = New System.Drawing.Size(150, 21)
        Me.ckbTienKhamQuiDinh.TabIndex = 3
        Me.ckbTienKhamQuiDinh.Text = "Tiền khám qui định"
        Me.ckbTienKhamQuiDinh.UseVisualStyleBackColor = False
        '
        'txtTienKhamQuiDinh
        '
        Me.txtTienKhamQuiDinh.Location = New System.Drawing.Point(299, 153)
        Me.txtTienKhamQuiDinh.Name = "txtTienKhamQuiDinh"
        Me.txtTienKhamQuiDinh.Size = New System.Drawing.Size(156, 22)
        Me.txtTienKhamQuiDinh.TabIndex = 1
        '
        'btnThayDoi
        '
        Me.btnThayDoi.Location = New System.Drawing.Point(58, 201)
        Me.btnThayDoi.Name = "btnThayDoi"
        Me.btnThayDoi.Size = New System.Drawing.Size(116, 38)
        Me.btnThayDoi.TabIndex = 4
        Me.btnThayDoi.Text = "Thay Đổi"
        Me.btnThayDoi.UseVisualStyleBackColor = True
        '
        'frThayDoiQuiDinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QLPM1.My.Resources.Resources.blurred_background_8
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(582, 304)
        Me.Controls.Add(Me.btnThayDoi)
        Me.Controls.Add(Me.ckbTienKhamQuiDinh)
        Me.Controls.Add(Me.ckbSoBenhNhanToiDa)
        Me.Controls.Add(Me.txtTienKhamQuiDinh)
        Me.Controls.Add(Me.txtSoBenhNhanToiDa)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frThayDoiQuiDinh"
        Me.Text = "Thay đổi qui định"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSoBenhNhanToiDa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ckbSoBenhNhanToiDa As System.Windows.Forms.CheckBox
    Friend WithEvents ckbTienKhamQuiDinh As System.Windows.Forms.CheckBox
    Friend WithEvents txtTienKhamQuiDinh As System.Windows.Forms.TextBox
    Friend WithEvents btnThayDoi As System.Windows.Forms.Button
End Class
