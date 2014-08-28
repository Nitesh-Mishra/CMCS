Imports System.Data.Odbc
Imports CMCS.db_connection
Imports CMCS.CMCS_Add_Member
Public Class CMCS_Member_Id

    Private Sub CMCS_Member_Id_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AcceptButton = okbtn
        memidtextbox.Focus()
    End Sub

    Private Sub okbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okbtn.Click
        con.Open()
        Dim cmdchk As OdbcCommand
        cmdchk = New OdbcCommand("select * from cmcs_member_master where member_id='" + memidtextbox.Text + "' and is_active=1", con)

        If memidtextbox.Text = "" Then
            MsgBox("Enter the member id", MsgBoxStyle.Critical)

        Else
            If cmdchk.ExecuteNonQuery > 0 Then
                Dim intResponse As Integer

                intResponse = MsgBox("Are you sure to deactivate this account", _
                                     vbYesNo + vbQuestion + vbDefaultButton2, _
                                     "Delete")
                If intResponse = vbYes Then
                    vmemberid = memidtextbox.Text

                    Dim vbalance, voldinterest, vtotalbalance As Double
                    Dim vdate As String
                    Dim dr As OdbcDataReader
                    Try
                        Dim cmd2 As New OdbcCommand("select * from cmcs_account where member_id='" + memidtextbox.Text + "' ", con)

                        dr = cmd2.ExecuteReader
                        While dr.Read
                            vbalance = dr(3)
                            voldinterest = dr(5)
                            vdate = dr(4)
                        End While


                        Dim dt1 As DateTime = Convert.ToDateTime(vdate)
                        ' MsgBox(dt1)
                        Dim dt2 As DateTime = Convert.ToDateTime(Now.ToString("MM/dd/yyy"))
                        'MsgBox(dt2)
                        Dim ts As TimeSpan = dt2.Subtract(dt1)

                        Dim vnoofdays As Integer = Convert.ToInt32(ts.Days)
                        'MsgBox(vnoofdays)
                        'MsgBox(voldinterest)
                        'MsgBox(vbalance)
                        Dim vyear As String
                        Dim vinterest As Double
                        vyear = vnoofdays / 365
                        'MsgBox(vyear)
                        vinterest = vbalance * ((1.06 ^ vyear) - 1)
                        'MsgBox(vinterest)
                        Dim newinterest As String
                        newinterest = voldinterest + vinterest
                        'MsgBox(newinterest)

                        vtotalbalance = vbalance + newinterest
                        MsgBox("Your total balance is " & vtotalbalance, MsgBoxStyle.Information)
                        Dim cmd1 As New OdbcCommand("update cmcs_member_master set is_active=0 where member_id='" + vmemberid + "'", con)
                        cmd1.ExecuteNonQuery()
                        MsgBox("Deactivation Successful", MsgBoxStyle.Critical)
                        memidtextbox.Clear()
                        CMCS_Deactivate_Form.Show()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            Else
                MsgBox("This user doesn't exist", MsgBoxStyle.Critical)

            End If

        End If
        con.Close()
    End Sub

End Class