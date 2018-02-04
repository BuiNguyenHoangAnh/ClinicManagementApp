Partial Public Class frMain
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frMain))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnTiepNhanNhanVien = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPhieuKham = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThongTinNhanVien = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTraCuuNhanVien = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDanhSachKhamBenh = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLapHoaDon = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTraCuuBenhNhan = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThuoc = New DevExpress.XtraBars.BarButtonItem()
        Me.btnToaThuoc = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAbout = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonTrangChinh = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonBenhNhan = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageBenhNhan = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonBaoCao = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageBaoCao = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonKhac = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.RibbonPageThuoc = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonThuoc = New DevExpress.XtraBars.Ribbon.RibbonPage()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.btnTiepNhanNhanVien, Me.btnPhieuKham, Me.btnThongTinNhanVien, Me.btnTraCuuNhanVien, Me.btnDanhSachKhamBenh, Me.btnLapHoaDon, Me.btnTraCuuBenhNhan, Me.btnThuoc, Me.btnToaThuoc, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem4, Me.btnAbout})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 17
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonTrangChinh, Me.RibbonBenhNhan, Me.ribbonBaoCao, Me.ribbonKhac})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl1.Size = New System.Drawing.Size(1039, 185)
        '
        'btnTiepNhanNhanVien
        '
        Me.btnTiepNhanNhanVien.Caption = "Tiếp nhận nhân viên"
        Me.btnTiepNhanNhanVien.Id = 2
        Me.btnTiepNhanNhanVien.LargeGlyph = CType(resources.GetObject("btnTiepNhanNhanVien.LargeGlyph"), System.Drawing.Image)
        Me.btnTiepNhanNhanVien.Name = "btnTiepNhanNhanVien"
        Me.btnTiepNhanNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnPhieuKham
        '
        Me.btnPhieuKham.Caption = "Phiếu khám bệnh"
        Me.btnPhieuKham.Id = 3
        Me.btnPhieuKham.LargeGlyph = CType(resources.GetObject("btnPhieuKham.LargeGlyph"), System.Drawing.Image)
        Me.btnPhieuKham.Name = "btnPhieuKham"
        Me.btnPhieuKham.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnThongTinNhanVien
        '
        Me.btnThongTinNhanVien.Caption = "Thông tin nhân viên"
        Me.btnThongTinNhanVien.Id = 4
        Me.btnThongTinNhanVien.LargeGlyph = CType(resources.GetObject("btnThongTinNhanVien.LargeGlyph"), System.Drawing.Image)
        Me.btnThongTinNhanVien.Name = "btnThongTinNhanVien"
        Me.btnThongTinNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnTraCuuNhanVien
        '
        Me.btnTraCuuNhanVien.Caption = "Tra cứu nhân viên"
        Me.btnTraCuuNhanVien.Id = 5
        Me.btnTraCuuNhanVien.LargeGlyph = CType(resources.GetObject("btnTraCuuNhanVien.LargeGlyph"), System.Drawing.Image)
        Me.btnTraCuuNhanVien.Name = "btnTraCuuNhanVien"
        Me.btnTraCuuNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnDanhSachKhamBenh
        '
        Me.btnDanhSachKhamBenh.Caption = "Danh sách khám bệnh"
        Me.btnDanhSachKhamBenh.Id = 6
        Me.btnDanhSachKhamBenh.LargeGlyph = CType(resources.GetObject("btnDanhSachKhamBenh.LargeGlyph"), System.Drawing.Image)
        Me.btnDanhSachKhamBenh.Name = "btnDanhSachKhamBenh"
        Me.btnDanhSachKhamBenh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnLapHoaDon
        '
        Me.btnLapHoaDon.Caption = "Hóa đơn thanh toán"
        Me.btnLapHoaDon.Id = 7
        Me.btnLapHoaDon.LargeGlyph = CType(resources.GetObject("btnLapHoaDon.LargeGlyph"), System.Drawing.Image)
        Me.btnLapHoaDon.Name = "btnLapHoaDon"
        Me.btnLapHoaDon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnTraCuuBenhNhan
        '
        Me.btnTraCuuBenhNhan.Caption = "Tra cứu bệnh nhân"
        Me.btnTraCuuBenhNhan.Id = 8
        Me.btnTraCuuBenhNhan.LargeGlyph = CType(resources.GetObject("btnTraCuuBenhNhan.LargeGlyph"), System.Drawing.Image)
        Me.btnTraCuuBenhNhan.Name = "btnTraCuuBenhNhan"
        Me.btnTraCuuBenhNhan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnThuoc
        '
        Me.btnThuoc.Caption = "Thuốc"
        Me.btnThuoc.Id = 10
        Me.btnThuoc.LargeGlyph = CType(resources.GetObject("btnThuoc.LargeGlyph"), System.Drawing.Image)
        Me.btnThuoc.Name = "btnThuoc"
        Me.btnThuoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnToaThuoc
        '
        Me.btnToaThuoc.Caption = "Toa Thuốc"
        Me.btnToaThuoc.Id = 11
        Me.btnToaThuoc.LargeGlyph = CType(resources.GetObject("btnToaThuoc.LargeGlyph"), System.Drawing.Image)
        Me.btnToaThuoc.Name = "btnToaThuoc"
        Me.btnToaThuoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Báo Cáo Doanh Thu"
        Me.BarButtonItem1.Id = 12
        Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Báo Cáo Sử Dụng Thuốc"
        Me.BarButtonItem2.Id = 13
        Me.BarButtonItem2.LargeGlyph = CType(resources.GetObject("BarButtonItem2.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        Me.BarButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Thay đổi quy định"
        Me.BarButtonItem4.Id = 14
        Me.BarButtonItem4.LargeGlyph = CType(resources.GetObject("BarButtonItem4.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'btnAbout
        '
        Me.btnAbout.Caption = "Giới thiệu"
        Me.btnAbout.Id = 15
        Me.btnAbout.LargeGlyph = CType(resources.GetObject("btnAbout.LargeGlyph"), System.Drawing.Image)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RibbonTrangChinh
        '
        Me.RibbonTrangChinh.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonTrangChinh.Name = "RibbonTrangChinh"
        Me.RibbonTrangChinh.Text = "Trang Chính"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnAbout)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        '
        'RibbonBenhNhan
        '
        Me.RibbonBenhNhan.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageBenhNhan})
        Me.RibbonBenhNhan.Name = "RibbonBenhNhan"
        Me.RibbonBenhNhan.Text = "Bệnh Nhân"
        '
        'RibbonPageBenhNhan
        '
        Me.RibbonPageBenhNhan.ItemLinks.Add(Me.btnDanhSachKhamBenh)
        Me.RibbonPageBenhNhan.ItemLinks.Add(Me.btnPhieuKham)
        Me.RibbonPageBenhNhan.ItemLinks.Add(Me.btnLapHoaDon)
        Me.RibbonPageBenhNhan.ItemLinks.Add(Me.btnTraCuuBenhNhan)
        Me.RibbonPageBenhNhan.Name = "RibbonPageBenhNhan"
        Me.RibbonPageBenhNhan.ShowCaptionButton = False
        Me.RibbonPageBenhNhan.Text = "Quản lý thông tin bệnh nhân"
        '
        'ribbonBaoCao
        '
        Me.ribbonBaoCao.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageBaoCao})
        Me.ribbonBaoCao.Name = "ribbonBaoCao"
        Me.ribbonBaoCao.Text = "Báo Cáo"
        '
        'RibbonPageBaoCao
        '
        Me.RibbonPageBaoCao.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageBaoCao.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageBaoCao.Name = "RibbonPageBaoCao"
        Me.RibbonPageBaoCao.ShowCaptionButton = False
        Me.RibbonPageBaoCao.Text = "Báo Cáo"
        '
        'ribbonKhac
        '
        Me.ribbonKhac.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4})
        Me.ribbonKhac.Name = "ribbonKhac"
        Me.ribbonKhac.Text = "Khác"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Quản lý quy định"
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
        '
        'RibbonPageThuoc
        '
        Me.RibbonPageThuoc.Name = "RibbonPageThuoc"
        Me.RibbonPageThuoc.ShowCaptionButton = False
        Me.RibbonPageThuoc.Text = "Quản lý thuốc"
        '
        'ribbonThuoc
        '
        Me.ribbonThuoc.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageThuoc})
        Me.ribbonThuoc.Name = "ribbonThuoc"
        Me.ribbonThuoc.Text = "Thuốc"
        '
        'frMain
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch
        Me.BackgroundImageStore = Global.QLPM1.My.Resources.Resources.rsz_rrwswgxwikixgglnqqyq
        Me.ClientSize = New System.Drawing.Size(1039, 639)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Name = "frMain"
        Me.Ribbon = Me.ribbonControl1
        Me.Text = "Quản lí Phòng mạch"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private RibbonTrangChinh As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnTiepNhanNhanVien As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPhieuKham As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonBenhNhan As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageBenhNhan As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ribbonBaoCao As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ribbonKhac As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnThongTinNhanVien As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTraCuuNhanVien As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDanhSachKhamBenh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLapHoaDon As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTraCuuBenhNhan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThuoc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnToaThuoc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageBaoCao As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnAbout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents RibbonPageThuoc As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ribbonThuoc As DevExpress.XtraBars.Ribbon.RibbonPage
End Class
