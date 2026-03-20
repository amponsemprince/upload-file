Public Class Form1
    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Dim username As String
        Dim password As String

        username = usernametxt.Text
        password = passwordtxt.Text

        If (username = "admin" And password = "level300") Then
            Me.Hide()
            Dashboard.Show()
        Else
            MessageBox.Show("Invalid Login credentials", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
