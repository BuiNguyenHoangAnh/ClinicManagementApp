Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Public Sub Taoketnoi()
        Dim str As String = "Data Source=HOANGNIKON.;Initial Catalog=QLPM;Integrated Security=True"
        con.ConnectionString = str
        con.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Taoketnoi()
        Dim query As String = "update CHITIETHOADON set TienThuocThucTe='" & TextBox1.Text & "'"
        Dim cmd As New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Taoketnoi()
        Dim query As String = "Select * FROM THUOC where MaThuoc='T01'"
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        cmd = New SqlCommand(query, con)
        da = New SqlDataAdapter(query, con)
        da.Fill(dt)
        For Each row As DataRow In dt.Rows
            TextBox1.Text = row("DonGiaQuiDinh").ToString
        Next
        con.Close()
    End Sub
End Class