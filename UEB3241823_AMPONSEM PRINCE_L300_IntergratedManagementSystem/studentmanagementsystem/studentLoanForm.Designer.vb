<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentLoanForm
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtStudentName = New TextBox()
        txtGPA = New TextBox()
        txtIncome = New TextBox()
        txtLoanAmount = New TextBox()
        Label5 = New Label()
        btnCheckEligibility = New Button()
        Button2 = New Button()
        btnRepayment = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.Location = New Point(126, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 23)
        Label1.TabIndex = 0
        Label1.Text = "Student Name :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.Location = New Point(130, 166)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 23)
        Label2.TabIndex = 1
        Label2.Text = "GPA : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(123, 213)
        Label3.Name = "Label3"
        Label3.Size = New Size(230, 23)
        Label3.TabIndex = 2
        Label3.Text = "Family Annual Income (GHS):"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(126, 257)
        Label4.Name = "Label4"
        Label4.Size = New Size(218, 20)
        Label4.TabIndex = 3
        Label4.Text = "Loan Amount Requested (GHS):"
        ' 
        ' txtStudentName
        ' 
        txtStudentName.Font = New Font("Segoe UI", 10F)
        txtStudentName.Location = New Point(261, 116)
        txtStudentName.Name = "txtStudentName"
        txtStudentName.Size = New Size(125, 30)
        txtStudentName.TabIndex = 4
        ' 
        ' txtGPA
        ' 
        txtGPA.Font = New Font("Segoe UI", 10F)
        txtGPA.Location = New Point(247, 163)
        txtGPA.Name = "txtGPA"
        txtGPA.Size = New Size(125, 30)
        txtGPA.TabIndex = 5
        ' 
        ' txtIncome
        ' 
        txtIncome.Font = New Font("Segoe UI", 10F)
        txtIncome.Location = New Point(359, 213)
        txtIncome.Name = "txtIncome"
        txtIncome.Size = New Size(125, 30)
        txtIncome.TabIndex = 6
        ' 
        ' txtLoanAmount
        ' 
        txtLoanAmount.Location = New Point(350, 254)
        txtLoanAmount.Name = "txtLoanAmount"
        txtLoanAmount.Size = New Size(125, 27)
        txtLoanAmount.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20F)
        Label5.Location = New Point(117, 18)
        Label5.Name = "Label5"
        Label5.Size = New Size(395, 46)
        Label5.TabIndex = 8
        Label5.Text = "Student Loan Repayment"
        ' 
        ' btnCheckEligibility
        ' 
        btnCheckEligibility.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnCheckEligibility.Location = New Point(139, 354)
        btnCheckEligibility.Name = "btnCheckEligibility"
        btnCheckEligibility.Size = New Size(183, 46)
        btnCheckEligibility.TabIndex = 9
        btnCheckEligibility.Text = "Check ELigibility"
        btnCheckEligibility.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button2.Location = New Point(610, 402)
        Button2.Name = "Button2"
        Button2.Size = New Size(178, 46)
        Button2.TabIndex = 10
        Button2.Text = "Back to Dashboard"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btnRepayment
        ' 
        btnRepayment.BackColor = Color.LightGreen
        btnRepayment.Location = New Point(359, 354)
        btnRepayment.Name = "btnRepayment"
        btnRepayment.Size = New Size(178, 41)
        btnRepayment.TabIndex = 11
        btnRepayment.Text = "Compute Repayment"
        btnRepayment.UseVisualStyleBackColor = False
        ' 
        ' studentLoanForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnRepayment)
        Controls.Add(Button2)
        Controls.Add(btnCheckEligibility)
        Controls.Add(Label5)
        Controls.Add(txtLoanAmount)
        Controls.Add(txtIncome)
        Controls.Add(txtGPA)
        Controls.Add(txtStudentName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "studentLoanForm"
        Text = "studentLoanForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents txtGPA As TextBox
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents txtLoanAmount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCheckEligibility As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnRepayment As Button
End Class
