Imports System.ComponentModel
Imports System.Text


Partial Public Class frMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

       
    End Sub

    Private Sub ribbonControl1_Click(sender As Object, e As EventArgs) Handles ribbonControl1.Click

    End Sub

    
#Region "BenhNhan"

    Private Sub btnPhieuKham_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPhieuKham.ItemClick
        frLapPhieukhambenh.Show()
    End Sub

    Private Sub btnDanhSachKhamBenh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDanhSachKhamBenh.ItemClick
        Dim frm As frmDanhsachkhambenh
        frm = New frmDanhsachkhambenh
        frm.Show()
    End Sub


    Private Sub btnLapHoaDon_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLapHoaDon.ItemClick
        Dim frm As frmLaphoadonthanhtoan
        frm = New frmLaphoadonthanhtoan
        frm.Show()
    End Sub

    Private Sub btnTraCuuBenhNhan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTraCuuBenhNhan.ItemClick
        Dim frm As frmTracuubenhnhan
        frm = New frmTracuubenhnhan
        frm.Show()
    End Sub

#End Region

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        frThayDoiQuiDinh.Show()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        frBaoCaoDoanhThu.Show()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        frBaoCaoSuDungThuoc.Show()
    End Sub

    Private Sub btnAbout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAbout.ItemClick
        frGioiThieu.Show()
    End Sub
End Class
