Imports System.Data.Odbc
Imports CMCS.db_connection
Imports CrystalDecisions.CrystalReports.Engine

Public Class CMCS_Member_List_Form

    Private Sub CMCS_Member_List_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
           
            Dim cr As New member_list
            CrystalReportViewer1.ReportSource = cr
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

End Class