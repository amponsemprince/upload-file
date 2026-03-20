<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        btnHospital = New Button()
        btnStudentLoan = New Button()
        logout = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(310, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 48)
        Label1.TabIndex = 0
        Label1.Text = "Dashboard"
        ' 
        ' btnHospital
        ' 
        btnHospital.BackColor = Color.SkyBlue
        btnHospital.Font = New Font("Segoe UI", 10F)
        btnHospital.Location = New Point(29, 201)
        btnHospital.Name = "btnHospital"
        btnHospital.Size = New Size(240, 42)
        btnHospital.TabIndex = 1
        btnHospital.Text = "Hospital Billing Module"
        btnHospital.UseVisualStyleBackColor = False
        ' 
        ' btnStudentLoan
        ' 
        btnStudentLoan.BackColor = Color.DarkSeaGreen
        btnStudentLoan.Font = New Font("Segoe UI", 10F)
        btnStudentLoan.Location = New Point(294, 201)
        btnStudentLoan.Name = "btnStudentLoan"
        btnStudentLoan.Size = New Size(250, 42)
        btnStudentLoan.TabIndex = 2
        btnStudentLoan.Text = "Student Loan Module"
        btnStudentLoan.UseVisualStyleBackColor = False
        ' 
        ' logout
        ' 
        logout.BackColor = Color.Crimson
        logout.Font = New Font("Segoe UI", 10F)
        logout.Location = New Point(579, 201)
        logout.Name = "logout"
        logout.Size = New Size(184, 42)
        logout.TabIndex = 3
        logout.Text = "Logout"
        logout.UseVisualStyleBackColor = False
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(logout)
        Controls.Add(btnStudentLoan)
        Controls.Add(btnHospital)
        Controls.Add(Label1)
        Name = "Dashboard"
        Text = "Dashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnHospital As Button
    Friend WithEvents btnStudentLoan As Button
    Friend WithEvents logout As Button
End Class
