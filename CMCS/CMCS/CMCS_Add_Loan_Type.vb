Imports System.Data.Odbc
Imports CMCS.db_connection

Public Class CMCS_Add_Loan_Type

    Private Sub savebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savebtn.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            If loanidtextbox.Text = "" Or loantypetextbox.Text = "" Or rateofinteresttextbox.Text = "" Then
                MsgBox("Please fill the information", MsgBoxStyle.Critical)
            Else
                con.Open()
                Dim cmd As OdbcCommand
                cmd = New OdbcCommand("select * from cmcs_loan_type where loan_type_id='" + loanidtextbox.Text + "'", con)
                If cmd.ExecuteNonQuery > 0 Then
                    Dim vloanid, vloantype, vloaninterest As String
                    vloanid = loanidtextbox.Text
                    vloantype = loantypetextbox.Text
                    vloaninterest = rateofinteresttextbox.Text
                    Dim cmd1 As OdbcCommand
                    cmd1 = New OdbcCommand("update cmcs_loan_type set type='" + vloantype + "',rate_of_interest='" + vloaninterest + "' where loan_type_id='" + vloanid + "'", con)
                    cmd1.ExecuteNonQuery()
                    MsgBox("Information has been updated", MsgBoxStyle.Information)
                    loanidtextbox.Clear()
                    loantypetextbox.Clear()
                    rateofinteresttextbox.Clear()
                    loanidcombo.Text = ""
                Else
                    Dim vloanid, vloantype, vloaninterest As String
                    vloanid = loanidtextbox.Text
                    vloantype = loantypetextbox.Text
                    vloaninterest = rateofinteresttextbox.Text
                    Dim cmd1 As OdbcCommand
                    cmd1 = New OdbcCommand("insert into cmcs_loan_type values('" + vloanid + "','" + vloantype + "','" + vloaninterest + "')", con)
                    cmd1.ExecuteNonQuery()
                    MsgBox("Data saved successfully", MsgBoxStyle.Information)
                    loanidtextbox.Clear()
                    loantypetextbox.Clear()
                    rateofinteresttextbox.Clear()
                    loanidcombo.Text = ""
            End If

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        con.Close()
    End Sub

    Private Sub loanidcombo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles loanidcombo.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            loanidcombo.Items.Clear()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select loan_type_id from cmcs_loan_type ", con)
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
            cmd = New OdbcCommand("select loan_type_id from cmcs_loan_type ", con)
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
            cmd = New OdbcCommand("select loan_type_id from cmcs_loan_type ", con)
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

    Private Sub loanidcombo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles loanidcombo.TextChanged
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select * from cmcs_loan_type where loan_type_id='" + loanidcombo.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                loanidtextbox.Text = dr(0)
                loantypetextbox.Text = dr(1)
                rateofinteresttextbox.Text = dr(2)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub clearbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbtn.Click
        loanidtextbox.Clear()
        loantypetextbox.Clear()
        rateofinteresttextbox.Clear()
        loanidcombo.Text = ""
    End Sub

    Private Sub closebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebtn.Click
        Me.Hide()
        CMCS_Home.Show()
    End Sub

    Private Sub CMCS_Add_Loan_Type_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AcceptButton = savebtn
        loanidtextbox.Focus()
        loanidtooltip.SetToolTip(loanidcombo, "Click to see loan id type")
    End Sub
End Class