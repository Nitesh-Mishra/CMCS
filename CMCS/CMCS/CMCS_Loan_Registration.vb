Imports System.Data.Odbc
Imports CMCS.db_connection
Public Class CMCS_Loan_Registration

    Private Sub clearbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbtn.Click
        memidtextbox.Clear()
        loanamounttextbox.Clear()
        loanidcombo.Text = ""
        vitness1textbox.Clear()
        vitness2textbox.Clear()
        dogDateTimePicker.Text = Now
        

    End Sub

    Private Sub closebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebtn.Click
        Me.Hide()
        CMCS_Home.Show()
    End Sub

    Private Sub savebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savebtn.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try

            con.Open()
            If memidtextbox.Text = "" Or vitness1textbox.Text = "" Or vitness2textbox.Text = "" Or loanamounttextbox.Text = "" Then
                MsgBox("Please fill the details", MsgBoxStyle.Critical)
            Else
                Dim vitcmd1, vitcmd2, memcmd, loancheck As OdbcCommand
                loancheck = New OdbcCommand("select * from cmcs_loan_registration where member_id='" + memidtextbox.Text + "' and status=1", con)
                loancheck.ExecuteNonQuery()
                If loancheck.ExecuteNonQuery > 0 Then
                    MsgBox("Loan id already registered to this memeber", MsgBoxStyle.Critical)
                Else
                    memcmd = New OdbcCommand("select * from cmcs_member_master where member_id='" + memidtextbox.Text + "' ", con)
                    memcmd.ExecuteNonQuery()
                    vitcmd1 = New OdbcCommand("select * from cmcs_member_master where member_id ='" + vitness1textbox.Text + "'", con)
                    vitcmd1.ExecuteNonQuery()
                    vitcmd2 = New OdbcCommand("select * from cmcs_member_master where member_id ='" + vitness2textbox.Text + "'", con)
                    vitcmd2.ExecuteNonQuery()
                    If memcmd.ExecuteNonQuery > 0 Then
                        If vitcmd1.ExecuteNonQuery > 0 Then
                            If vitcmd2.ExecuteNonQuery > 0 Then
                                Dim witdr1, witdr2 As OdbcDataReader
                                Dim witname1, witname2, witcon1, witcon2 As String
                                Dim witcmd1 As New OdbcCommand("select name,contact_no from cmcs_member_master where member_id='" + vitness1textbox.Text + "'", con)
                                witdr1 = witcmd1.ExecuteReader()

                                While witdr1.Read
                                    witname1 = witdr1.Item(0)
                                    witcon1 = witdr1.Item(1)
                                End While
                                Dim witcmd2 As New OdbcCommand("select name,contact_no from cmcs_member_master where member_id='" + vitness2textbox.Text + "'", con)
                                witdr2 = witcmd2.ExecuteReader()

                                While witdr2.Read
                                    witname2 = witdr2.Item(0)
                                    witcon2 = witdr2.Item(1)
                                End While
                                Dim cmd As New OdbcCommand("insert into CMCS_Loan_Registration values('','" + memidtextbox.Text + "','" + loanidcombo.Text + "','" + vitness1textbox.Text + "','" + witname1 + "','" + witcon1 + "','" + vitness2textbox.Text + "','" + witname2 + "','" + witcon2 + "','" + dogDateTimePicker.Text + "','" + loanamounttextbox.Text + "','',0,1)", con)
                                cmd.ExecuteNonQuery()
                                Dim cmd1 As New OdbcCommand("update cmcs_loan_registration set balance_due='" + loanamounttextbox.Text + "' where member_id='" + memidtextbox.Text + "'", con)
                                cmd1.ExecuteNonQuery()

                                MsgBox("Information saved successfully", MsgBoxStyle.Information)
                                memidtextbox.Clear()
                                loanamounttextbox.Clear()
                                loanidcombo.Text = ""
                                vitness1textbox.Clear()
                                vitness2textbox.Clear()
                                dogDateTimePicker.Text = Now
                                memidtextbox.Focus()
                            Else
                                MsgBox("Vitness id 1 doesn't exist", MsgBoxStyle.Critical)
                            End If
                        Else
                            MsgBox("Vitness id 2 doesn't exist", MsgBoxStyle.Critical)
                        End If
                    Else
                        MsgBox("Member Id doesn't exit", MsgBoxStyle.Critical)
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    
    Private Sub CMCS_Loan_Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        memidtextbox.Focus()
        dogDateTimePicker.Format = DateTimePickerFormat.Custom
        dogDateTimePicker.CustomFormat = "yyyy/MM/dd"
        Me.AcceptButton = savebtn
    End Sub

    Private Sub loanidcombo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles loanidcombo.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            loanidcombo.Items.Clear()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select type from cmcs_loan_type ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                loanidcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub loanidcombo_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles loanidcombo.DropDown
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            loanidcombo.Items.Clear()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select type from cmcs_loan_type ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                loanidcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub loanidcombo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles loanidcombo.GotFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            loanidcombo.Items.Clear()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select type from cmcs_loan_type ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                loanidcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

End Class