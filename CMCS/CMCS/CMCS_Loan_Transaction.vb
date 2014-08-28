Imports System.Data.Odbc
Imports CMCS.db_connection
Public Class CMCS_Loan_Transaction
    Dim vdog As Date
    Dim vlamount, vinterestamount As String
    Private Sub cashradio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cashradio.CheckedChanged
        If cashradio.Checked = True Then
            checknotextbox.Visible = False
        End If
    End Sub

    Private Sub chequeradio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chequeradio.CheckedChanged
        If chequeradio.Checked = True Then
            checknotextbox.Visible = True
        End If
    End Sub

    Private Sub CMCS_Loan_Transaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AcceptButton = savebtn
        checknotextbox.Visible = False
        memberidtextbox.Focus()
        dateofpaymentdatepicker.Format = DateTimePickerFormat.Custom
        dateofpaymentdatepicker.CustomFormat = "yyyy/MM/dd"
        amountduetextbox.Enabled = False
        loanidcombo.Enabled = False
        
    End Sub

    Private Sub closebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebtn.Click
        Me.Hide()
        CMCS_Home.Show()
    End Sub

    Private Sub clearbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbtn.Click
        'reciepttextbox.Clear()
        'loanidtextbox.Clear()
        'installmenttextbox.Clear()
        'cashradio.Checked = False
        'chequeradio.Checked = False
        'Dim dt1 As DateTime = Convert.ToDateTime(DateTimePicker1.Value.ToString("dd/MM/yyy"))

        ' Dim dt2 As DateTime = Convert.ToDateTime(DateTimePicker2.Value.ToString("dd/MM/yyy"))

        ''count total day between selected your date

        'Dim ts As TimeSpan = dt2.Subtract(dt1)
        memberidtextbox.Clear()
        loanidcombo.Text = ""
        amountduetextbox.Clear()
        installmenttextbox.Clear()
        dateofpaymentdatepicker.Text = Now
        cashradio.Checked = False
        chequeradio.Checked = False
        checknotextbox.Clear()
    End Sub


    Private Sub savebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savebtn.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            If memberidtextbox.Text = "" Or installmenttextbox.Text = "" Or amountduetextbox.Text = "" Then
                MsgBox("Please fill the information", MsgBoxStyle.Critical)
            Else
                Dim chkcmd As New OdbcCommand("select * from cmcs_member_master where member_id='" + memberidtextbox.Text + "' and is_active=1", con)
                If chkcmd.ExecuteNonQuery > 0 Then
                    If Val(installmenttextbox.Text) > Val(amountduetextbox.Text) Then
                        MsgBox("Installment amount can not be greater than Due amount", MsgBoxStyle.Critical)
                    Else
                        Dim vmodeofpayment, vchecknumber As String
                        If cashradio.Checked = True Then
                            vmodeofpayment = "Cash"
                            vchecknumber = " - "
                        End If
                        If chequeradio.Checked = True Then
                            vmodeofpayment = "Cheque"
                            vchecknumber = checknotextbox.Text
                        End If


                        Dim vrate As String
                        Dim vinstallmentamount, vamount, vamountdue, vinterest As Double
                        vamount = amountduetextbox.Text
                        vinstallmentamount = installmenttextbox.Text
                        vamountdue = vamount - vinstallmentamount
                        'principle = loanamounttextbox.Text
                        'MsgBox(vamountdue)
                        Dim cmd2 As OdbcCommand
                        cmd2 = New OdbcCommand("select rate_of_interest from cmcs_loan_type where loan_type_id = (select loan_type_id from cmcs_loan_registration where loan_id='" + loanidcombo.Text + "')", con)
                        Dim dr2 As OdbcDataReader
                        dr2 = cmd2.ExecuteReader()
                        While dr2.Read
                            vrate = dr2(0)
                        End While

                        Dim dt1 As DateTime = Convert.ToDateTime(dateofpaymentdatepicker.Text)
                        Dim dt2 As DateTime = Convert.ToDateTime(vdog)
                        'MsgBox(dt2)
                        Dim ts As TimeSpan = dt1.Subtract(dt2)

                        Dim vnoofdays As Integer = Convert.ToInt32(ts.Days)
                        'MsgBox(vnoofdays)
                        vinterest = Math.Ceiling((vlamount * vrate * vnoofdays) / 36500)
                        'MsgBox(vinterest)
                        Dim newinterest As Double
                        newinterest = vinterestamount + vinterest
                        'MsgBox(newinterest)
                        ' MsgBox(vinterest)


                        Dim cmd As New OdbcCommand("insert into CMCS_Loan_Transaction values('', '" + dateofpaymentdatepicker.Text + "', '" + installmenttextbox.Text + "', '" + vmodeofpayment + "', '" + vchecknumber + "', '" + amountduetextbox.Text + "' , '" + loanidcombo.Text + "', '&vinterest&' ,'" + memberidtextbox.Text + "')", con)
                        cmd.ExecuteNonQuery()

                        Dim cmd1 As New OdbcCommand("update cmcs_loan_registration set balance_due=" & vamountdue & ", interest=" & newinterest & " where loan_id= '" + loanidcombo.Text + "' ", con)
                        cmd1.ExecuteNonQuery()
                        Dim vainterest, vabalancedue As String
                        Dim interestdr As OdbcDataReader

                        Dim interestcmd As New OdbcCommand("select * from cmcs_loan_registration where loan_id='" + loanidcombo.Text + "'", con)
                        interestdr = interestcmd.ExecuteReader
                        While interestdr.Read
                            vabalancedue = interestdr(11)
                            vainterest = interestdr(12)
                        End While

                        If vabalancedue = 0 And vainterest <> 0 Then

                            Dim intResponse As Integer

                            intResponse = MsgBox("Your interest is " + vainterest + ". Do you want to pay this amount?", _
                                                 vbYesNo + vbQuestion + vbDefaultButton2, _
                                                 "Interest")
                            If intResponse = vbYes Then
                                Dim cmd3 As New OdbcCommand("update cmcs_loan_registration set balance_due='" + vainterest + "', interest=0 where loan_id='" + loanidcombo.Text + "'", con)
                                cmd3.ExecuteNonQuery()

                            End If
                            If intResponse = vbNo Then
                                Dim cmd4 As New OdbcCommand("update cmcs_loan_registration set balance_due='" + vainterest + "', interest=0 where loan_id='" + loanidcombo.Text + "'", con)
                                cmd4.ExecuteNonQuery()

                            End If
                        End If
                        'MsgBox(loanidcombo.Text)
                        Dim idr As OdbcDataReader
                        Dim itcmd As New OdbcCommand("select * from cmcs_loan_registration where loan_id='" + loanidcombo.Text + "' and status=1", con)
                        idr = itcmd.ExecuteReader
                        While idr.Read
                            'MsgBox(idr(11))
                            vabalancedue = Convert.ToInt32(idr(11))
                            vainterest = Convert.ToInt32(idr(12))
                        End While

                        If vabalancedue = 0 And vainterest = 0 Then
                            Dim cmd5 As New OdbcCommand("update cmcs_loan_registration set status=0 where loan_id='" + loanidcombo.Text + "' and status=1 ", con)
                            cmd5.ExecuteNonQuery()

                        End If
                        'MsgBox("Information saved successfully", MsgBoxStyle.Information)
                        memberidtextbox.Clear()
                        loanidcombo.Text = ""
                        amountduetextbox.Clear()
                        installmenttextbox.Clear()
                        dateofpaymentdatepicker.Text = Now
                        cashradio.Checked = False
                        chequeradio.Checked = False
                        checknotextbox.Clear()
                        Reciept_Form.Show()
                    End If
                Else
                    MsgBox("This user doesn't exist", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub memberidtextbox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles memberidtextbox.LostFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try

            con.Open()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select * from cmcs_loan_registration where member_id='" + memberidtextbox.Text + "' and status=1", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                'vdog = dr(5)
                loanidcombo.Text = dr(0)
                vlamount = Math.Ceiling(dr(11))
                vinterestamount = Math.Ceiling(dr(12))
                amountduetextbox.Text = vlamount
                amountduetextbox.Enabled = False

            End While

            Dim cmd1, cmd2, cmd3 As OdbcCommand
            Dim dr1, dr2 As OdbcDataReader
            cmd1 = New OdbcCommand("select date_of_payment from cmcs_loan_transaction where loan_id='" + loanidcombo.Text + "'", con)
            If cmd1.ExecuteNonQuery > 0 Then
                cmd2 = New OdbcCommand("select date_of_payment from cmcs_loan_transaction where loan_id='" + loanidcombo.Text + "' order by date_of_payment ASC", con)
                dr1 = cmd2.ExecuteReader
                While dr1.Read
                    vdog = dr1(0)
                End While
            Else
                cmd3 = New OdbcCommand("select date_of_granting from cmcs_loan_registration where loan_id='" + loanidcombo.Text + "'", con)
                dr2 = cmd3.ExecuteReader
                While dr2.Read
                    vdog = dr2(0)
                End While
            End If

            'MsgBox(vdog)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

End Class