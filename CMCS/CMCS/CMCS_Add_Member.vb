Imports System.Data.Odbc
Imports CMCS.db_connection

Public Class CMCS_Add_Member


    Private Sub CMCS_Add_Member_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim day As Integer
        '  day = dojDateTimePicker.Value.Day
        ' MsgBox(day)
        Me.AcceptButton = savebtn
        nametextbox.Focus()
        dobDateTimePicker.Format = DateTimePickerFormat.Custom
        dobDateTimePicker.CustomFormat = "yyyy/MM/dd"

        dojDateTimePicker.Format = DateTimePickerFormat.Custom
        dojDateTimePicker.CustomFormat = "yyyy/MM/dd"

    End Sub

    Private Sub savebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savebtn.Click
        Try
            con.Open()
            Dim cmd2, cmd3 As OdbcCommand
            Dim vgender As String
            If maleradio.Checked = True Then
                vgender = "Male"
            ElseIf femaleradio.Checked = True Then
                vgender = "Female"
            Else
                vgender = "Others"
            End If
            If nametextbox.Text = "" Or addresstextbox.Text = "" Or vitness1textbox.Text = "" Or vitness2textbox.Text = "" Or salarytextbox.Text = "" Then
                MsgBox("Please fill the information", MsgBoxStyle.Critical)
            Else
                Dim vitcmd1, vitcmd2 As OdbcCommand
                vitcmd1 = New OdbcCommand("select * from cmcs_member_master where member_id ='" + vitness1textbox.Text + "'", con)
                vitcmd1.ExecuteNonQuery()
                vitcmd2 = New OdbcCommand("select * from cmcs_member_master where member_id ='" + vitness2textbox.Text + "'", con)
                vitcmd2.ExecuteNonQuery()
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
                        nomineegroupbox.Visible = True
                        Dim cmd As New OdbcCommand("insert into CMCS_Member_Master values('','" + nametextbox.Text + "','" + gnametextbox.Text + "','" + addresstextbox.Text + "','" + dobDateTimePicker.Text + "','" + qualiftextbox.Text + "','" + departtextbox.Text + "','" + branchtextbox.Text + "','" + desigtextbox.Text + "','" + dojDateTimePicker.Text + "',' + salarytextbox.Text + ',' + familytextbox.Text + ','" + contacttextbox.Text + "',' + vitness1textbox.Text + ','" + witname1 + "','" + witcon1 + "',' + vitness2textbox.Text + ','" + witname2 + "','" + witcon2 + "','" + categorycombo.Text + "','" + vgender + "', '' , 1  ,'" + bloodgroupcombo.Text + "' )", con)
                        cmd.ExecuteNonQuery()
                        Dim vmemid As String
                        Dim memcmd As New OdbcCommand("select member_id from cmcs_member_master order by member_id", con)
                        Dim memdr As OdbcDataReader
                        memdr = memcmd.ExecuteReader
                        While memdr.Read
                            vmemid = memdr.Item(0)
                        End While
                        Dim cmd1 As New OdbcCommand("insert into CMCS_Nominee values('" + vmemid + "','','" + nomineenametextbox.Text + "','" + relationtextbox.Text + "','" + contacttextbox.Text + "')", con)
                        cmd1.ExecuteNonQuery()
                        Dim dateofchange As Date
                        dateofchange = Now
                        Dim acccmd As New OdbcCommand("insert into cmcs_account values('" + vmemid + "','','" + noofsharestextbox.Text + "','" + minbalanacetextbox.Text + "','" + dateofchange + "','')", con)
                        acccmd.ExecuteNonQuery()
                        
                        Dim accnodr As OdbcDataReader
                        Dim vaccno As String
                        Dim accnocmd As New OdbcCommand("select account_no from cmcs_account order by account_no", con)
                        accnodr = accnocmd.ExecuteReader()
                        While accnodr.Read
                            vaccno = accnodr.Item(0)
                        End While
                        MsgBox("Member Registration Successful with Member ID :" + vmemid + " and Account No : " + vaccno + "", MsgBoxStyle.Information)
                        nametextbox.Text = ""
                        gnametextbox.Text = ""
                        dobDateTimePicker.Text = Now
                        addresstextbox.Text = ""
                        qualiftextbox.Text = ""
                        desigtextbox.Text = ""
                        departtextbox.Text = ""
                        branchtextbox.Text = ""
                        salarytextbox.Text = ""
                        dojDateTimePicker.Text = Now
                        familytextbox.Text = ""
                        contacttextbox.Text = ""
                        bloodgroupcombo.Text = ""
                        noofsharestextbox.Text = ""
                        minbalanacetextbox.Text = ""
                        nomineenametextbox.Clear()
                        nomineecontacttextbox.Clear()
                        relationtextbox.Clear()
                        categorycombo.Text = ""
                        maleradio.Checked = False
                        femaleradio.Checked = False
                        otherradio.Checked = False

                        vitness1textbox.Text = ""
                        vitness2textbox.Text = ""
                    End If
                Else
                    MsgBox("The given vitness doesn't exist", MsgBoxStyle.Critical)
                End If
                
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()

    End Sub

    Private Sub closebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebtn.Click
        Me.Hide()
        CMCS_Home.Show()
    End Sub

    Private Sub clearbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbtn.Click
        nametextbox.Text = ""
        gnametextbox.Text = ""
        dobDateTimePicker.Text = Now
        addresstextbox.Text = ""
        qualiftextbox.Text = ""
        desigtextbox.Text = ""
        departtextbox.Text = ""
        branchtextbox.Text = ""
        salarytextbox.Text = ""
        dojDateTimePicker.Text = Now
        familytextbox.Text = ""
        contacttextbox.Text = ""

        categorycombo.Text = ""
        maleradio.Checked = False
        femaleradio.Checked = False
        otherradio.Checked = False

        vitness1textbox.Text = ""
        vitness2textbox.Text = ""
        bloodgroupcombo.Text = ""
        noofsharestextbox.Text = ""
        minbalanacetextbox.Text = ""
        nomineenametextbox.Clear()
        nomineecontacttextbox.Clear()
        relationtextbox.Clear()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class