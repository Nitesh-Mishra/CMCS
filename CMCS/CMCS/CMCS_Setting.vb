Imports System.Data.Odbc
Imports CMCS.db_connection
Public Class CMCS_Setting

    Private Sub memberlistbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles memberlistbtn.Click
        Me.Hide()
        CMCS_Add_Loan_Type.Show()
    End Sub

    Private Sub twomonthdefaulteebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles twomonthdefaulteebtn.Click
        con.Open()
        Try
            Dim test1, test2 As Double
            Dim test As String
            Dim add As Double
            Dim cmd1, cmd3 As OdbcCommand
            Dim myDate As DateTime = Now
            Dim myYear As Int32 = myDate.Year
            Dim myYear1 As Int32 = myYear + 1
            'MsgBox(myYear)
            'MsgBox(myYear1)
            'Dim date1, date2 As String
            'Dim currentdate As Date = Now
            'date1 = myYear.ToString + "-03-31"
            'date2 = myYear1.ToString + "-03-31"

            Dim currentDate As DateTime = DateTime.Now
            If currentDate.Month = 7 AndAlso currentDate.Day = 10 Then
                Dim cmd As New OdbcCommand("select loan_id from cmcs_loan_registration where status=1 ", con)
                Dim dr, dr1 As OdbcDataReader
                dr = cmd.ExecuteReader
                While dr.Read
                    'MsgBox(dr.Item(0))
                    test = Convert.ToString(dr.Item(0))
                    'test = dr.Item(0)
                    ' MsgBox(test)
                    cmd1 = New OdbcCommand("select interest,balance_due from cmcs_loan_registration where loan_id='" + test + "'  ", con)
                    dr1 = cmd1.ExecuteReader
                    While dr1.Read
                        test1 = dr1.Item(0)
                        test2 = dr1.Item(1)
                    End While
                    MsgBox(test1)

                    MsgBox(test2)
                    'Dim zero, stringadd As String
                    add = test1 + test2
                    ' stringadd = Convert.ToString(add)
                    'add = test1 + test2
                    'MsgBox(add)
                    Try
                        cmd3 = New OdbcCommand("update cmcs_loan_registration set balance_due=" & add & ",interest=0 where loan_id='" + test + "'", con)
                        cmd3.ExecuteNonQuery()

                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End While



                MsgBox("Data changed successfully", MsgBoxStyle.Information)
            Else
                MsgBox("Today is not the financial year", MsgBoxStyle.Critical)
            End If

            ''MsgBox(date1)
            ''MsgBox(date2)


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changepasswordbtn.Click
        Me.Hide()
        CMCS_Change_Pwd.Show()
    End Sub

    Private Sub CMCS_Setting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AcceptButton = memberlistbtn
    End Sub
End Class