Public Class studentLoanForm
    Private Sub studentLoanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCheckEligibility_Click(sender As Object, e As EventArgs) Handles btnCheckEligibility.Click
        ' Check all fields are filled
        If txtStudentName.Text = "" Then
            MessageBox.Show("Please enter student name")
            Return
        End If

        If txtGPA.Text = "" Then
            MessageBox.Show("Please enter GPA")
            Return
        End If

        If txtIncome.Text = "" Then
            MessageBox.Show("Please enter family income")
            Return
        End If

        If txtLoanAmount.Text = "" Then
            MessageBox.Show("Please enter loan amount")
            Return
        End If

        ' Get the values from the textboxes
        Dim gpa As Double = Convert.ToDouble(txtGPA.Text)
        Dim income As Double = Convert.ToDouble(txtIncome.Text)

        ' Check eligibility
        If gpa >= 2.5 And income < 40000 Then
            MessageBox.Show("Loan Application Approved!", "Eligibility Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnRepayment.Enabled = True
        Else
            MessageBox.Show("Loan Application Rejected", "Eligibility Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnRepayment.Enabled = False
        End If

    End Sub

    Private Sub btnRepayment_Click(sender As Object, e As EventArgs) Handles btnRepayment.Click
        ' Get the loan amount
        Dim P As Double = Convert.ToDouble(txtLoanAmount.Text)

        ' Set the fixed values
        Dim r As Double = 0.08 / 12    ' Monthly interest rate
        Dim n As Integer = 60          ' 60 months = 5 years

        ' Amortization formula
        ' M = P * r * (1+r)^n / ((1+r)^n - 1)
        Dim M As Double = P * r * (1 + r) ^ n / ((1 + r) ^ n - 1)

        ' Calculate total repayment
        Dim totalRepayment As Double = M * n

        ' Build the message
        Dim repaymentMessage As String = "==============================" & Environment.NewLine &
                                     "     LOAN REPAYMENT DETAILS   " & Environment.NewLine &
                                     "==============================" & Environment.NewLine &
                                     "Student Name    : " & txtStudentName.Text & Environment.NewLine &
                                     "Loan Amount     : GHS " & txtLoanAmount.Text & Environment.NewLine &
                                     "Interest Rate   : 8% per annum" & Environment.NewLine &
                                     "Duration        : 5 years (60 months)" & Environment.NewLine &
                                     "------------------------------" & Environment.NewLine &
                                     "Monthly Payment : GHS " & Math.Round(M, 2) & Environment.NewLine &
                                     "Total Repayment : GHS " & Math.Round(totalRepayment, 2) & Environment.NewLine &
                                     "=============================="

        ' Display the repayment details
        MessageBox.Show(repaymentMessage, "Loan Repayment Schedule",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Dashboard.Show()

    End Sub
End Class