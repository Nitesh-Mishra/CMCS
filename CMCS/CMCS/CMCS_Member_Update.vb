Imports System.Data.Odbc
Imports CMCS.db_connection
Public Class CMCS_Member_Update

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub
    Private Sub salarytextbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salarytextbox.TextChanged

    End Sub

    Private Sub clearbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbtn.Click
        addresstextbox.Text = ""
        desigtextbox.Text = ""
        departtextbox.Text = ""
        branchtextbox.Text = ""
        salarytextbox.Text = ""
        familytextbox.Text = ""
        contacttextbox.Text = ""
        nomineenametextbox.Clear()
        nomineecontacttextbox.Clear()
        relationtextbox.Clear()
    End Sub

    Private Sub closebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebtn.Click
        Me.Hide()
        CMCS_Home.Show()
    End Sub

    Private Sub okbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okbtn.Click
        Try
            con.Open()
            vmemberid = memidtextbox.Text
            Dim cmd As New OdbcCommand("select * from cmcs_member_master where member_id='" + vmemberid + "'", con)
            Dim dr, dr1, dr2 As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                addresstextbox.Text = dr(3)
                desigtextbox.Text = dr(8)
                departtextbox.Text = dr(6)
                salarytextbox.Text = dr(10)
                branchtextbox.Text = dr(7)
                familytextbox.Text = dr(11)
                contacttextbox.Text = (12)
            End While
            Dim cmd1 As New OdbcCommand("select * from cmcs_account where member_id='" + vmemberid + "'", con)
            dr1 = cmd1.ExecuteReader
            While dr1.Read
                noofsharestextbox.Text = dr1(2)
                minbalanacetextbox.Text = dr1(3)
            End While
            Dim cmd2 As New OdbcCommand("select * from cmcs_nominee where member_id='" + vmemberid + "'", con)
            dr2 = cmd2.ExecuteReader
            While dr2.Read
                nomineenametextbox.Text = dr2(2)
                nomineecontacttextbox.Text = dr2(4)
                relationtextbox.Text = dr2(3)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub CMCS_Member_Update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AcceptButton = okbtn
        memidtextbox.Focus()
    End Sub

    Private Sub savebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savebtn.Click
        Try
            con.Open()
            Dim cmd, cmd1 As OdbcCommand
            cmd = New OdbcCommand("update cmcs_member_master set address='" + addresstextbox.Text + "',designation='" + desigtextbox.Text + "',department='" + departtextbox.Text + "',gross_salary='" + salarytextbox.Text + "',branch='" + branchtextbox.Text + "',number_of_family_member='" + familytextbox.Text + "',contact_no='" + contacttextbox.Text + "' where member_id='" + memidtextbox.Text + "'", con)
            cmd.ExecuteNonQuery()
            cmd1 = New OdbcCommand("update cmcs_nominee set name='" + nomineenametextbox.Text + "',relation_with_member='" + relationtextbox.Text + "',contact_no='" + nomineecontacttextbox.Text + "' where member_id='" + memidtextbox.Text + "'", con)
            cmd1.ExecuteNonQuery()

            Dim vbalance, voldinterest, vtotalbalance As Double
            Dim vdate As String
            Dim dr As OdbcDataReader

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
            Dim vdte As String
            vdte = Now
            'vtotalbalance = vbalance + newinterest
            'MsgBox("Your total balance is " & vtotalbalance, MsgBoxStyle.Information)
            Dim cmd3 As New OdbcCommand("update cmcs_account set no_of_shares='" + noofsharestextbox.Text + "',minimum_balance='" + minbalanacetextbox.Text + "',date_of_change='" + vdte + "' where member_id='" + vmemberid + "'", con)
            cmd3.ExecuteNonQuery()
            MsgBox("Data updated successfully", MsgBoxStyle.Information)
        Catch ex As Exception

        End Try
    End Sub
End Class