<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hospital
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
        Label1 = New Label()
        txtPatientName = New TextBox()
        GroupBox1 = New GroupBox()
        radPrivate = New RadioButton()
        semPrivate = New RadioButton()
        genWard = New RadioButton()
        Label2 = New Label()
        txtDays = New TextBox()
        GroupBox2 = New GroupBox()
        surg = New RadioButton()
        xray = New RadioButton()
        labTest = New RadioButton()
        btnCalculateBill = New Button()
        backBtn = New Button()
        txtBill = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(124, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 20)
        Label1.TabIndex = 0
        Label1.Text = "Patient Name : "
        ' 
        ' txtPatientName
        ' 
        txtPatientName.Location = New Point(239, 28)
        txtPatientName.Name = "txtPatientName"
        txtPatientName.Size = New Size(256, 27)
        txtPatientName.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(radPrivate)
        GroupBox1.Controls.Add(semPrivate)
        GroupBox1.Controls.Add(genWard)
        GroupBox1.Location = New Point(124, 73)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(371, 136)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Ward Type"
        ' 
        ' radPrivate
        ' 
        radPrivate.AutoSize = True
        radPrivate.Location = New Point(30, 91)
        radPrivate.Name = "radPrivate"
        radPrivate.Size = New Size(167, 24)
        radPrivate.TabIndex = 2
        radPrivate.TabStop = True
        radPrivate.Text = "Private (500 per day)"
        radPrivate.UseVisualStyleBackColor = True
        ' 
        ' semPrivate
        ' 
        semPrivate.AutoSize = True
        semPrivate.Location = New Point(30, 61)
        semPrivate.Name = "semPrivate"
        semPrivate.Size = New Size(210, 24)
        semPrivate.TabIndex = 1
        semPrivate.TabStop = True
        semPrivate.Text = "Semi-Private (350 per day) "
        semPrivate.UseVisualStyleBackColor = True
        ' 
        ' genWard
        ' 
        genWard.AutoSize = True
        genWard.Location = New Point(30, 31)
        genWard.Name = "genWard"
        genWard.Size = New Size(212, 24)
        genWard.TabIndex = 0
        genWard.TabStop = True
        genWard.Text = "General Ward (200 per day)"
        genWard.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(124, 229)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 20)
        Label2.TabIndex = 5
        Label2.Text = "Number of Days : "
        ' 
        ' txtDays
        ' 
        txtDays.Location = New Point(258, 226)
        txtDays.Name = "txtDays"
        txtDays.Size = New Size(237, 27)
        txtDays.TabIndex = 6
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(surg)
        GroupBox2.Controls.Add(xray)
        GroupBox2.Controls.Add(labTest)
        GroupBox2.Location = New Point(124, 270)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(371, 136)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Optional Services"
        ' 
        ' surg
        ' 
        surg.AutoSize = True
        surg.Location = New Point(30, 91)
        surg.Name = "surg"
        surg.Size = New Size(159, 24)
        surg.TabIndex = 2
        surg.TabStop = True
        surg.Text = "Surgery (GHS 1000)"
        surg.UseVisualStyleBackColor = True
        ' 
        ' xray
        ' 
        xray.AutoSize = True
        xray.Location = New Point(30, 61)
        xray.Name = "xray"
        xray.Size = New Size(140, 24)
        xray.TabIndex = 1
        xray.TabStop = True
        xray.Text = "X-Ray (GHS 100)"
        xray.UseVisualStyleBackColor = True
        ' 
        ' labTest
        ' 
        labTest.AutoSize = True
        labTest.Location = New Point(30, 31)
        labTest.Name = "labTest"
        labTest.Size = New Size(209, 24)
        labTest.TabIndex = 0
        labTest.TabStop = True
        labTest.Text = "Laboratory Tests (GHS 150)"
        labTest.UseVisualStyleBackColor = True
        ' 
        ' btnCalculateBill
        ' 
        btnCalculateBill.BackColor = Color.Azure
        btnCalculateBill.Location = New Point(592, 289)
        btnCalculateBill.Name = "btnCalculateBill"
        btnCalculateBill.Size = New Size(166, 49)
        btnCalculateBill.TabIndex = 7
        btnCalculateBill.Text = "Calculate Bill"
        btnCalculateBill.UseVisualStyleBackColor = False
        ' 
        ' backBtn
        ' 
        backBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        backBtn.Location = New Point(678, 433)
        backBtn.Name = "backBtn"
        backBtn.Size = New Size(164, 49)
        backBtn.TabIndex = 8
        backBtn.Text = "Back to Dashboard"
        backBtn.UseVisualStyleBackColor = False
        ' 
        ' txtBill
        ' 
        txtBill.BackColor = Color.FloralWhite
        txtBill.Location = New Point(556, 28)
        txtBill.Multiline = True
        txtBill.Name = "txtBill"
        txtBill.ReadOnly = True
        txtBill.Size = New Size(234, 246)
        txtBill.TabIndex = 9
        ' 
        ' hospital
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(863, 494)
        Controls.Add(txtBill)
        Controls.Add(backBtn)
        Controls.Add(btnCalculateBill)
        Controls.Add(GroupBox2)
        Controls.Add(txtDays)
        Controls.Add(Label2)
        Controls.Add(GroupBox1)
        Controls.Add(txtPatientName)
        Controls.Add(Label1)
        Name = "hospital"
        Text = "hospital"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radPrivate As RadioButton
    Friend WithEvents semPrivate As RadioButton
    Friend WithEvents genWard As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDays As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents surg As RadioButton
    Friend WithEvents xray As RadioButton
    Friend WithEvents labTest As RadioButton
    Friend WithEvents btnCalculateBill As Button
    Friend WithEvents backBtn As Button
    Friend WithEvents txtBill As TextBox
End Class
