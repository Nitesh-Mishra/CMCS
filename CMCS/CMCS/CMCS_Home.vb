Public Class CMCS_Home

 
    Private Sub memberregistrationbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles memberregistrationbtn.Click
        CMCS_Add_Member.Show()
    End Sub

    Private Sub loanregistrationbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loanregistrationbtn.Click
        CMCS_Loan_Registration.Show()
    End Sub

    Private Sub loantransactionbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loantransactionbtn.Click
        CMCS_Loan_Transaction.Show()
    End Sub

    Private Sub loantypebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loantypebtn.Click
        CMCS_Setting.Show()
    End Sub

    Private Sub managememberbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles managememberbtn.Click
        CMCS_Manage_Member.Show()
    End Sub

    Private Sub changepasswordbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changepasswordbtn.Click
        CMCS_Reports.Show()
    End Sub

    Private Sub twomonthdefaulteebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CMCS_Two_Month_Defaulters_Form.Show()
    End Sub

    Private Sub threemonthdefaulteebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CMCS_Three_Month_Defaulters_form.Show()

    End Sub

    Private Sub memberlistbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CMCS_Member_List_Form.Show()
    End Sub

    Private Sub logoutlink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles logoutlink.LinkClicked
        Me.Hide()
        CMCSLogin.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class