<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CMCS_Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.memberregistrationbtn = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.logoutlink = New System.Windows.Forms.LinkLabel
        Me.loanregistrationbtn = New System.Windows.Forms.Button
        Me.loantransactionbtn = New System.Windows.Forms.Button
        Me.loantypebtn = New System.Windows.Forms.Button
        Me.managememberbtn = New System.Windows.Forms.Button
        Me.changepasswordbtn = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'memberregistrationbtn
        '
        Me.memberregistrationbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.memberregistrationbtn.Location = New System.Drawing.Point(41, 114)
        Me.memberregistrationbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.memberregistrationbtn.Name = "memberregistrationbtn"
        Me.memberregistrationbtn.Size = New System.Drawing.Size(187, 96)
        Me.memberregistrationbtn.TabIndex = 1
        Me.memberregistrationbtn.Text = "Member " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Registration"
        Me.memberregistrationbtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(722, 65)
        Me.Panel1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(651, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COLLECTORATE MULTIPURPOSE COOPERATIVE SOCIETY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'logoutlink
        '
        Me.logoutlink.AutoSize = True
        Me.logoutlink.Location = New System.Drawing.Point(668, 82)
        Me.logoutlink.Name = "logoutlink"
        Me.logoutlink.Size = New System.Drawing.Size(55, 16)
        Me.logoutlink.TabIndex = 1
        Me.logoutlink.TabStop = True
        Me.logoutlink.Text = "Logout"
        '
        'loanregistrationbtn
        '
        Me.loanregistrationbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loanregistrationbtn.Location = New System.Drawing.Point(268, 114)
        Me.loanregistrationbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.loanregistrationbtn.Name = "loanregistrationbtn"
        Me.loanregistrationbtn.Size = New System.Drawing.Size(187, 96)
        Me.loanregistrationbtn.TabIndex = 2
        Me.loanregistrationbtn.Text = "Loan " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Registration"
        Me.loanregistrationbtn.UseVisualStyleBackColor = True
        '
        'loantransactionbtn
        '
        Me.loantransactionbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loantransactionbtn.Location = New System.Drawing.Point(494, 114)
        Me.loantransactionbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.loantransactionbtn.Name = "loantransactionbtn"
        Me.loantransactionbtn.Size = New System.Drawing.Size(187, 96)
        Me.loantransactionbtn.TabIndex = 3
        Me.loantransactionbtn.Text = "Loan " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Transaction"
        Me.loantransactionbtn.UseVisualStyleBackColor = True
        '
        'loantypebtn
        '
        Me.loantypebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loantypebtn.Location = New System.Drawing.Point(494, 238)
        Me.loantypebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.loantypebtn.Name = "loantypebtn"
        Me.loantypebtn.Size = New System.Drawing.Size(187, 96)
        Me.loantypebtn.TabIndex = 6
        Me.loantypebtn.Text = "Settings"
        Me.loantypebtn.UseVisualStyleBackColor = True
        '
        'managememberbtn
        '
        Me.managememberbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.managememberbtn.Location = New System.Drawing.Point(43, 238)
        Me.managememberbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.managememberbtn.Name = "managememberbtn"
        Me.managememberbtn.Size = New System.Drawing.Size(187, 96)
        Me.managememberbtn.TabIndex = 4
        Me.managememberbtn.Text = "Manage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Member"
        Me.managememberbtn.UseVisualStyleBackColor = True
        '
        'changepasswordbtn
        '
        Me.changepasswordbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changepasswordbtn.Location = New System.Drawing.Point(268, 238)
        Me.changepasswordbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.changepasswordbtn.Name = "changepasswordbtn"
        Me.changepasswordbtn.Size = New System.Drawing.Size(187, 96)
        Me.changepasswordbtn.TabIndex = 5
        Me.changepasswordbtn.Text = "Reports"
        Me.changepasswordbtn.UseVisualStyleBackColor = True
        '
        'CMCS_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 354)
        Me.Controls.Add(Me.logoutlink)
        Me.Controls.Add(Me.changepasswordbtn)
        Me.Controls.Add(Me.managememberbtn)
        Me.Controls.Add(Me.loantypebtn)
        Me.Controls.Add(Me.loantransactionbtn)
        Me.Controls.Add(Me.loanregistrationbtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.memberregistrationbtn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CMCS_Home"
        Me.Text = "CMCS_Home"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents memberregistrationbtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents loanregistrationbtn As System.Windows.Forms.Button
    Friend WithEvents loantransactionbtn As System.Windows.Forms.Button
    Friend WithEvents loantypebtn As System.Windows.Forms.Button
    Friend WithEvents managememberbtn As System.Windows.Forms.Button
    Friend WithEvents changepasswordbtn As System.Windows.Forms.Button
    Friend WithEvents logoutlink As System.Windows.Forms.LinkLabel
End Class
