Imports System.Data.Odbc
Imports CMCS.db_connection
Imports CrystalDecisions.CrystalReports.Engine
Public Class CMCS_Deactivate_Form

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Try

            ' MsgBox(vmemberid)
            Dim v As String
            v = vmemberid
            Dim p1fs1 As New CrystalDecisions.Shared.ParameterFields
            Dim p1f1 As New CrystalDecisions.Shared.ParameterField
            Dim p1r1 As New CrystalDecisions.Shared.ParameterDiscreteValue
            p1f1.ParameterFieldName = "vmemberid"
            'MsgBox(muid)
            p1r1.Value = vmemberid
            p1f1.CurrentValues.Add(p1r1)
            p1fs1.Add(p1f1)
            CrystalReportViewer1.ParameterFieldInfo = p1fs1 'to pass parameter inf.to CRV
            Dim cr As New deactivate_report
            CrystalReportViewer1.ReportSource = cr
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub CMCS_Deactivate_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class