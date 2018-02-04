Public Class frBaoCaoTest

    Private Sub frBaoCaoTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.BaoCao1' table. You can move, or remove it, as needed.
        Me.BaoCao1TableAdapter.Fill(Me.DataSet1.BaoCao1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class