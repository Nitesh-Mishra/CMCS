Imports CMCS.db_connection
Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Public Class CMCS_Manage_Member

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        CMCS_Member_Update.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myDate As DateTime = Now
        Dim myYear As Int32 = myDate.Year
        Dim myYear1 As Int32 = myYear + 1
        MsgBox(myYear)
        MsgBox(myYear1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CMCS_Member_Id.Show()
        Me.Hide()
    End Sub
End Class