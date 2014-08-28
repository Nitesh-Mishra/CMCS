Public Class CMCS_Final_Amount_Reprt_Form

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()

            Dim cr As New final_amount_report
            CrystalReportViewer1.ReportSource = cr
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub
End Class