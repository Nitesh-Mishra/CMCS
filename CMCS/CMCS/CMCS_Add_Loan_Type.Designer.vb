<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CMCS_Add_Loan_Type
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
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.loantypetextbox = New System.Windows.Forms.TextBox
        Me.loanidtextbox = New System.Windows.Forms.TextBox
        Me.rateofinteresttextbox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.loanidcombo = New System.Windows.Forms.ComboBox
        Me.closebtn = New System.Windows.Forms.Button
        Me.clearbtn = New System.Windows.Forms.Button
        Me.savebtn = New System.Windows.Forms.Button
        Me.loanidtooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.loantypetextbox)
        Me.GroupBox1.Controls.Add(Me.loanidtextbox)
        Me.GroupBox1.Controls.Add(Me.rateofinteresttextbox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(114, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 161)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Loan Type"
        '
        'loantypetextbox
        '
        Me.loantypetextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loantypetextbox.Location = New System.Drawing.Point(201, 72)
        Me.loantypetextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.loantypetextbox.Name = "loantypetextbox"
        Me.loantypetextbox.Size = New System.Drawing.Size(264, 22)
        Me.loantypetextbox.TabIndex = 2
        '
        'loanidtextbox
        '
        Me.loanidtextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loanidtextbox.Location = New System.Drawing.Point(201, 27)
        Me.loanidtextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.loanidtextbox.Name = "loanidtextbox"
        Me.loanidtextbox.Size = New System.Drawing.Size(264, 22)
        Me.loanidtextbox.TabIndex = 1
        '
        'rateofinteresttextbox
        '
        Me.rateofinteresttextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rateofinteresttextbox.Location = New System.Drawing.Point(201, 117)
        Me.rateofinteresttextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.rateofinteresttextbox.Name = "rateofinteresttextbox"
        Me.rateofinteresttextbox.Size = New System.Drawing.Size(264, 22)
        Me.rateofinteresttextbox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 120)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Rate of Interest"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Loan Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Loan Type ID"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.loanidcombo)
        Me.Panel1.Controls.Add(Me.closebtn)
        Me.Panel1.Controls.Add(Me.clearbtn)
        Me.Panel1.Controls.Add(Me.savebtn)
        Me.Panel1.Location = New System.Drawing.Point(114, 242)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 57)
        Me.Panel1.TabIndex = 56
        '
        'loanidcombo
        '
        Me.loanidcombo.FormattingEnabled = True
        Me.loanidcombo.Items.AddRange(New Object() {"SELECT TO UPDATE"})
        Me.loanidcombo.Location = New System.Drawing.Point(110, 19)
        Me.loanidcombo.Name = "loanidcombo"
        Me.loanidcombo.Size = New System.Drawing.Size(154, 21)
        Me.loanidcombo.TabIndex = 5
        '
        'closebtn
        '
        Me.closebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closebtn.Location = New System.Drawing.Point(385, 15)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(89, 27)
        Me.closebtn.TabIndex = 7
        Me.closebtn.Text = "Close"
        Me.closebtn.UseVisualStyleBackColor = True
        '
        'clearbtn
        '
        Me.clearbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbtn.Location = New System.Drawing.Point(287, 15)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(92, 27)
        Me.clearbtn.TabIndex = 6
        Me.clearbtn.Text = "Clear"
        Me.clearbtn.UseVisualStyleBackColor = True
        '
        'savebtn
        '
        Me.savebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebtn.Location = New System.Drawing.Point(9, 15)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(80, 27)
        Me.savebtn.TabIndex = 4
        Me.savebtn.Text = "Save"
        Me.savebtn.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(12, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(681, 50)
        Me.Panel3.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(651, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "COLLECTORATE MULTIPURPOSE COOPERATIVE SOCIETY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'CMCS_Add_Loan_Type
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 319)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CMCS_Add_Loan_Type"
        Me.Text = "CMCS_Add_Loan_Type (%)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents loantypetextbox As System.Windows.Forms.TextBox
    Friend WithEvents loanidtextbox As System.Windows.Forms.TextBox
    Friend WithEvents rateofinteresttextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents closebtn As System.Windows.Forms.Button
    Friend WithEvents clearbtn As System.Windows.Forms.Button
    Friend WithEvents savebtn As System.Windows.Forms.Button
    Friend WithEvents loanidcombo As System.Windows.Forms.ComboBox
    Friend WithEvents loanidtooltip As System.Windows.Forms.ToolTip
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
