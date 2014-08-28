<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CMCS_Reports
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.memberlistbtn = New System.Windows.Forms.Button
        Me.threemonthdefaulteebtn = New System.Windows.Forms.Button
        Me.twomonthdefaulteebtn = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(15, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(689, 65)
        Me.Panel1.TabIndex = 15
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
        'memberlistbtn
        '
        Me.memberlistbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.memberlistbtn.Location = New System.Drawing.Point(33, 106)
        Me.memberlistbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.memberlistbtn.Name = "memberlistbtn"
        Me.memberlistbtn.Size = New System.Drawing.Size(187, 96)
        Me.memberlistbtn.TabIndex = 18
        Me.memberlistbtn.Text = "Member " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "List"
        Me.memberlistbtn.UseVisualStyleBackColor = True
        '
        'threemonthdefaulteebtn
        '
        Me.threemonthdefaulteebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.threemonthdefaulteebtn.Location = New System.Drawing.Point(492, 106)
        Me.threemonthdefaulteebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.threemonthdefaulteebtn.Name = "threemonthdefaulteebtn"
        Me.threemonthdefaulteebtn.Size = New System.Drawing.Size(187, 96)
        Me.threemonthdefaulteebtn.TabIndex = 17
        Me.threemonthdefaulteebtn.Text = "Three Month Defaultee"
        Me.threemonthdefaulteebtn.UseVisualStyleBackColor = True
        '
        'twomonthdefaulteebtn
        '
        Me.twomonthdefaulteebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.twomonthdefaulteebtn.Location = New System.Drawing.Point(274, 106)
        Me.twomonthdefaulteebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.twomonthdefaulteebtn.Name = "twomonthdefaulteebtn"
        Me.twomonthdefaulteebtn.Size = New System.Drawing.Size(187, 96)
        Me.twomonthdefaulteebtn.TabIndex = 16
        Me.twomonthdefaulteebtn.Text = "Two Month Defaultee"
        Me.twomonthdefaulteebtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(151, 241)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 96)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Final Account Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(396, 241)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(187, 96)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Duration Wise Report"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CMCS_Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 385)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.memberlistbtn)
        Me.Controls.Add(Me.threemonthdefaulteebtn)
        Me.Controls.Add(Me.twomonthdefaulteebtn)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CMCS_Reports"
        Me.Text = "CMCS_Reports"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents memberlistbtn As System.Windows.Forms.Button
    Friend WithEvents threemonthdefaulteebtn As System.Windows.Forms.Button
    Friend WithEvents twomonthdefaulteebtn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
