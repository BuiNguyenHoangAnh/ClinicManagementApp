Imports System.Data
Imports System.Data.SqlClient
Public Class frThayDoiQuiDinh
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Public Sub Taoketnoi()
        Dim str As String = "Data Source=" + SystemInformation.UserDomainName.ToString + ";Initial Catalog=QLPM;Integrated Security=True"
        con.ConnectionString = str
        con.Open()
    End Sub

    Private Sub ThayDoiQuiDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Taoketnoi()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand("select * From THAMSO", con)
        da.Fill(dt)
        txtSoBenhNhanToiDa.DataBindings.Add("text", dt, "SoBenhNhanToiDa")
        txtTienKhamQuiDinh.DataBindings.Add("text", dt, "TienKhamQuiDinh")
        con.Close()
    End Sub

    Private Sub btnThayDoi_Click(sender As Object, e As EventArgs) Handles btnThayDoi.Click
        Taoketnoi()
        If (ckbSoBenhNhanToiDa.Checked) Then
            Dim query As String = "update THAMSO set SoBenhNhanToiDa='" & txtSoBenhNhanToiDa.Text & "'"
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
        ElseIf (ckbTienKhamQuiDinh.Checked) Then
            Dim query2 As String = "update THAMSO set TienKhamQuiDinh='" & txtTienKhamQuiDinh.Text & "'"
            Dim cmd2 As New SqlCommand(query2, con)
            cmd2.ExecuteNonQuery()
        ElseIf (ckbSoBenhNhanToiDa.Checked And ckbTienKhamQuiDinh.Checked) Then
            Dim query3 As String = "update THAMSO set SoBenhNhanToiDa='" & txtSoBenhNhanToiDa.Text & "'and TienKhamQuiDinh='" & txtTienKhamQuiDinh.Text & "'"
            Dim cmd3 As New SqlCommand(query3, con)
            cmd3.ExecuteNonQuery()

        End If
        con.Close()
    End Sub
End Class