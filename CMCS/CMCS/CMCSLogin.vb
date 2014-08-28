Imports CMCS.db_connection
Imports System.Data.Odbc
Public Class CMCSLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okbtn.Click
        Try
            con.Open()
            Dim cmd As New OdbcCommand("SELECT * FROM cmcs_login", con)
            Dim dr As OdbcDataReader = cmd.ExecuteReader()
            While dr.Read()
                If dr!uid = usernametextbox.Text And dr!pass = passtextbox.Text Then
                    Me.Hide()
                    CMCS_Home.Show()
                    usernametextbox.Clear()
                    passtextbox.Clear()
                Else
                    MsgBox("Login Failed")
                    usernametextbox.Clear()
                    passtextbox.Clear()
                    usernametextbox.Focus()
                    'Exit Sub
                End If
            End While
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelbtn.Click
        Me.Close()
    End Sub

    Private Sub CMCSLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        usernametextbox.Focus()
    End Sub
End Class
