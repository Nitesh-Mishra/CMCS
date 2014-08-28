Imports System.Data.Odbc
Imports CMCS.db_connection
Imports CrystalDecisions.CrystalReports.Engine

Public Class CMCS_Three_Month_Defaulters_form
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            'Dim mid As Integer
            ' Dim memid As Array
            ' Me.BackColor = Color.Azure
            'Dim regDate As Date = Date.Now()
            'Dim strDate As String = regDate.ToString("ddMMMyyyy")
            ' Dim cmd As OdbcCommand
            ' Dim ds As New DataSet
            ' cmd = New OdbcCommand("select member_id from cmcs_loan_transaction where date_of_payment<DATE_SUB(CURDATE(),INTERVAL 3 MONTH)", con)
            'Dim dr As OdbcDataReader
            'dr = cmd.ExecuteReader
            ' Dim i As Integer
            'i = 0
            '' MsgBox(dr.Item())
            ' While dr.Read
            ''MsgBox(dr.Item(0))
            'Mid = dr.Item(0)
            'namelabel.Text = (dr.Item(0))
            'memid = dr.Item(i)
            'i = i + 1
            ' End While

            ' Dim adp As New OdbcDataAdapter(cmd)
            ' Dim rd As New ReportDocument
            ' Dim p1fs1 As New CrystalDecisions.Shared.ParameterFields
            ' Dim p1f1 As New CrystalDecisions.Shared.ParameterField
            'Dim p1r1 As New CrystalDecisions.Shared.ParameterDiscreteValue
            ' p1f1.ParameterFieldName = "mid"
            'MsgBox(muid)
            ' p1r1.Value = Mid()
            ' p1f1.CurrentValues.Add(p1r1)
            ' p1fs1.Add(p1f1)
            'CrystalReportViewer1.ParameterFieldInfo = p1fs1 'to pass parameter inf.to CRV
            Dim cr As New three_month_defaulters
            CrystalReportViewer1.ReportSource = cr
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub
End Class