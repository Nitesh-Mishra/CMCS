<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CMCS_Loan_Transaction
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.loanidcombo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.chequeradio = New System.Windows.Forms.RadioButton
        Me.cashradio = New System.Windows.Forms.RadioButton
        Me.dateofpaymentdatepicker = New System.Windows.Forms.DateTimePicker
        Me.checknotextbox = New System.Windows.Forms.TextBox
        Me.amountduetextbox = New System.Windows.Forms.TextBox
        Me.memberidtextbox = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.closebtn = New System.Windows.Forms.Button
        Me.clearbtn = New System.Windows.Forms.Button
        Me.savebtn = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.installmenttextbox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.installmenttextbox)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.loanidcombo)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.chequeradio)
        Me.Panel2.Controls.Add(Me.cashradio)
        Me.Panel2.Controls.Add(Me.dateofpaymentdatepicker)
        Me.Panel2.Controls.Add(Me.checknotextbox)
        Me.Panel2.Controls.Add(Me.amountduetextbox)
        Me.Panel2.Controls.Add(Me.memberidtextbox)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(76, 70)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(508, 310)
        Me.Panel2.TabIndex = 29
        '
        'loanidcombo
        '
        Me.loanidcombo.Location = New System.Drawing.Point(192, 68)
        Me.loanidcombo.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.loanidcombo.Name = "loanidcombo"
        Me.loanidcombo.Size = New System.Drawing.Size(273, 22)
        Me.loanidcombo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Loan ID"
        '
        'chequeradio
        '
        Me.chequeradio.AutoSize = True
        Me.chequeradio.Location = New System.Drawing.Point(261, 166)
        Me.chequeradio.Margin = New System.Windows.Forms.Padding(4)
        Me.chequeradio.Name = "chequeradio"
        Me.chequeradio.Size = New System.Drawing.Size(79, 20)
        Me.chequeradio.TabIndex = 5
        Me.chequeradio.TabStop = True
        Me.chequeradio.Text = "Cheque"
        Me.chequeradio.UseVisualStyleBackColor = True
        '
        'cashradio
        '
        Me.cashradio.AutoSize = True
        Me.cashradio.Location = New System.Drawing.Point(192, 167)
        Me.cashradio.Margin = New System.Windows.Forms.Padding(4)
        Me.cashradio.Name = "cashradio"
        Me.cashradio.Size = New System.Drawing.Size(61, 20)
        Me.cashradio.TabIndex = 4
        Me.cashradio.TabStop = True
        Me.cashradio.Text = "Cash"
        Me.cashradio.UseVisualStyleBackColor = True
        '
        'dateofpaymentdatepicker
        '
        Me.dateofpaymentdatepicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateofpaymentdatepicker.Location = New System.Drawing.Point(192, 218)
        Me.dateofpaymentdatepicker.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.dateofpaymentdatepicker.Name = "dateofpaymentdatepicker"
        Me.dateofpaymentdatepicker.Size = New System.Drawing.Size(273, 22)
        Me.dateofpaymentdatepicker.TabIndex = 7
        '
        'checknotextbox
        '
        Me.checknotextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checknotextbox.Location = New System.Drawing.Point(344, 167)
        Me.checknotextbox.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.checknotextbox.Name = "checknotextbox"
        Me.checknotextbox.Size = New System.Drawing.Size(121, 20)
        Me.checknotextbox.TabIndex = 6
        Me.checknotextbox.Text = "check number"
        '
        'amountduetextbox
        '
        Me.amountduetextbox.Location = New System.Drawing.Point(192, 115)
        Me.amountduetextbox.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.amountduetextbox.Name = "amountduetextbox"
        Me.amountduetextbox.Size = New System.Drawing.Size(273, 22)
        Me.amountduetextbox.TabIndex = 3
        '
        'memberidtextbox
        '
        Me.memberidtextbox.Location = New System.Drawing.Point(192, 20)
        Me.memberidtextbox.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.memberidtextbox.Name = "memberidtextbox"
        Me.memberidtextbox.Size = New System.Drawing.Size(273, 22)
        Me.memberidtextbox.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 223)
        Me.Label11.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 16)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Date of Payment"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 121)
        Me.Label9.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 16)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Amount Due"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 168)
        Me.Label6.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Mode of Payment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Member ID"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.closebtn)
        Me.Panel1.Controls.Add(Me.clearbtn)
        Me.Panel1.Controls.Add(Me.savebtn)
        Me.Panel1.Location = New System.Drawing.Point(76, 392)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(508, 67)
        Me.Panel1.TabIndex = 30
        '
        'closebtn
        '
        Me.closebtn.Location = New System.Drawing.Point(359, 20)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(116, 27)
        Me.closebtn.TabIndex = 11
        Me.closebtn.Text = "Back"
        Me.closebtn.UseVisualStyleBackColor = True
        '
        'clearbtn
        '
        Me.clearbtn.Location = New System.Drawing.Point(202, 20)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(116, 27)
        Me.clearbtn.TabIndex = 10
        Me.clearbtn.Text = "Clear"
        Me.clearbtn.UseVisualStyleBackColor = True
        '
        'savebtn
        '
        Me.savebtn.Location = New System.Drawing.Point(46, 20)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(116, 27)
        Me.savebtn.TabIndex = 9
        Me.savebtn.Text = "Save"
        Me.savebtn.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(12, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(681, 50)
        Me.Panel3.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(651, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COLLECTORATE MULTIPURPOSE COOPERATIVE SOCIETY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'installmenttextbox
        '
        Me.installmenttextbox.Location = New System.Drawing.Point(192, 268)
        Me.installmenttextbox.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.installmenttextbox.Name = "installmenttextbox"
        Me.installmenttextbox.Size = New System.Drawing.Size(273, 22)
        Me.installmenttextbox.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 272)
        Me.Label4.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 16)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Installment Amount."
        '
        'CMCS_Loan_Transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 478)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CMCS_Loan_Transaction"
        Me.Text = "CMCS Loan Transaction"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dateofpaymentdatepicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents checknotextbox As System.Windows.Forms.TextBox
    Friend WithEvents amountduetextbox As System.Windows.Forms.TextBox
    Friend WithEvents memberidtextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chequeradio As System.Windows.Forms.RadioButton
    Friend WithEvents cashradio As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents closebtn As System.Windows.Forms.Button
    Friend WithEvents clearbtn As System.Windows.Forms.Button
    Friend WithEvents savebtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents loanidcombo As System.Windows.Forms.TextBox
    Friend WithEvents installmenttextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
