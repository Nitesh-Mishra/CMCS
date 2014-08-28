Public Class CMCS_Reports

    Private Sub memberlistbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles memberlistbtn.Click
        Me.Hide()
        CMCS_Member_List_Form.Show()
    End Sub

    Private Sub twomonthdefaulteebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles twomonthdefaulteebtn.Click
        Me.Hide()
        CMCS_Two_Month_Defaulters_Form.Show()
    End Sub

    Private Sub threemonthdefaulteebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles threemonthdefaulteebtn.Click
        Me.Hide()
        CMCS_Three_Month_Defaulters_form.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CMCS_Final_Amount_Reprt_Form.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cmcs_durationwise_report.Show()
    End Sub

    Private Sub CMCS_Reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        memberlistbtn.Focus()
        Me.AcceptButton = memberlistbtn
    End Sub
End Class