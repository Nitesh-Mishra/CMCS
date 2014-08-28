Imports CrystalDecisions.CrystalReports.Engine

Public Class cmcs_durationwise_report

    Private Sub cmcs_durationwise_report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datefrom.Format = DateTimePickerFormat.Custom
        datefrom.CustomFormat = "yyyy/MM/dd"

        dateto.Format = DateTimePickerFormat.Custom
        dateto.CustomFormat = "yyyy/MM/dd"
        Me.AcceptButton = durationwisebtn
    End Sub

    Private Sub durationwisebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles durationwisebtn.Click
        Dim d1, d2 As String
        Dim d11, d22 As Date
        d11 = datefrom.Text
        d22 = dateto.Text
        d1 = d11.ToString("yyyyMMdd")
        d2 = d22.ToString("yyyyMMdd")
        ' d22 = dateto.Text
        'MsgBox(d11.ToString)
        'Dim d1, d2 As String
        ' d1 = d11.ToString()
        'd2 = d22.ToString()
        Try
            con.Open()


            Dim rd As New ReportDocument
            Dim p1fs1, p1fs2 As New CrystalDecisions.Shared.ParameterFields
            Dim p1f1, p1f2 As New CrystalDecisions.Shared.ParameterField
            Dim p1r1, p1r2 As New CrystalDecisions.Shared.ParameterDiscreteValue
            p1f1.ParameterFieldName = "d1"
            p1f2.ParameterFieldName = "d2"
            'MsgBox(muid)
            p1r1.Value = d1
            p1r2.Value = d2

            p1f1.CurrentValues.Add(p1r1)
            p1f2.CurrentValues.Add(p1r2)
            p1fs1.Add(p1f1)
            p1fs1.Add(p1f2)
            CrystalReportViewer1.ParameterFieldInfo = p1fs1 'to pass parameter inf.to CRV
            Dim cr As New durationwise_report
            CrystalReportViewer1.ReportSource = cr
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub
End Class