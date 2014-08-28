<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CMCS_Setting
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
        Me.memberlistbtn = New System.Windows.Forms.Button
        Me.twomonthdefaulteebtn = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.changepasswordbtn = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'memberlistbtn
        '
        Me.memberlistbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.memberlistbtn.Location = New System.Drawing.Point(45, 105)
        Me.memberlistbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.memberlistbtn.Name = "memberlistbtn"
        Me.memberlistbtn.Size = New System.Drawing.Size(187, 96)
        Me.memberlistbtn.TabIndex = 1
        Me.memberlistbtn.Text = "Add Loan Type"
        Me.memberlistbtn.UseVisualStyleBackColor = True
        '
        'twomonthdefaulteebtn
        '
        Me.twomonthdefaulteebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.twomonthdefaulteebtn.Location = New System.Drawing.Point(263, 105)
        Me.twomonthdefaulteebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.twomonthdefaulteebtn.Name = "twomonthdefaulteebtn"
        Me.twomonthdefaulteebtn.Size = New System.Drawing.Size(187, 96)
        Me.twomonthdefaulteebtn.TabIndex = 2
        Me.twomonthdefaulteebtn.Text = "Financial Year Update"
        Me.twomonthdefaulteebtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(689, 65)
        Me.Panel1.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(651, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COLLECTORATE MULTIPURPOSE COOPERATIVE SOCIETY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'changepasswordbtn
        '
        Me.changepasswordbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changepasswordbtn.Location = New System.Drawing.Point(474, 105)
        Me.changepasswordbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.changepasswordbtn.Name = "changepasswordbtn"
        Me.changepasswordbtn.Size = New System.Drawing.Size(187, 96)
        Me.changepasswordbtn.TabIndex = 3
        Me.changepasswordbtn.Text = "Change Password"
        Me.changepasswordbtn.UseVisualStyleBackColor = True
        '
        'CMCS_Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 235)
        Me.Controls.Add(Me.changepasswordbtn)
        Me.Controls.Add(Me.memberlistbtn)
        Me.Controls.Add(Me.twomonthdefaulteebtn)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CMCS_Setting"
        Me.Text = "CMCS_Setting"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents memberlistbtn As System.Windows.Forms.Button
    Friend WithEvents twomonthdefaulteebtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents changepasswordbtn As System.Windows.Forms.Button
End Class
