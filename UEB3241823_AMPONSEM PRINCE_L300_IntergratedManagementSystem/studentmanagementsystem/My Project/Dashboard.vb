Public Class Dashboard
    Private Sub btnHospital_Click(sender As Object, e As EventArgs) Handles btnHospital.Click
        Me.Hide()
        hospital.Show()
    End Sub

    Private Sub btnStudentLoan_Click(sender As Object, e As EventArgs) Handles btnStudentLoan.Click
        studentLoanForm.Show()
        Me.Hide()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class