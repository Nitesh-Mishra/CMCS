Imports System.Data.Odbc
Imports CMCS.db_connection

Public Class CMCS_Change_Pwd

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savebtn.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim op, np, rp As String
            op = opwd.Text
            np = npwd.Text
            rp = rpwd.Text
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select pass from CMCS_Login where pass = '" + op + "'", con)
            If cmd.ExecuteNonQuery > 0 Then
                If (np = rp) Then
                    Dim cmd1 As OdbcCommand
                    cmd1 = New OdbcCommand("update CMCS_Login set pass='" + np + "'", con)
                    cmd1.ExecuteNonQuery()
                    MsgBox("Password Changed Successfully", MsgBoxStyle.Information)
                    opwd.Clear()
                    npwd.Clear()
                    rpwd.Clear()
                Else
                    MsgBox("Password not matched", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Enter correct Password", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Backbtn.Click
        Me.Hide()
        CMCS_Home.Show()
    End Sub

    Private Sub Change_Pwd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opwd.Focus()
        Me.AcceptButton = savebtn
    End Sub
End Class