<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        usernametxt = New TextBox()
        passwordtxt = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        login = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' usernametxt
        ' 
        usernametxt.BackColor = Color.White
        usernametxt.BorderStyle = BorderStyle.FixedSingle
        usernametxt.Location = New Point(260, 122)
        usernametxt.Name = "usernametxt"
        usernametxt.Size = New Size(308, 27)
        usernametxt.TabIndex = 0
        ' 
        ' passwordtxt
        ' 
        passwordtxt.BorderStyle = BorderStyle.FixedSingle
        passwordtxt.Location = New Point(260, 186)
        passwordtxt.Name = "passwordtxt"
        passwordtxt.PasswordChar = "*"c
        passwordtxt.Size = New Size(308, 27)
        passwordtxt.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(155, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 28)
        Label1.TabIndex = 2
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(155, 186)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 28)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' login
        ' 
        login.BackColor = SystemColors.ActiveCaption
        login.Font = New Font("Segoe UI", 13F)
        login.Location = New Point(164, 250)
        login.Name = "login"
        login.Size = New Size(149, 50)
        login.TabIndex = 4
        login.Text = "Login"
        login.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 23F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(87, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(665, 52)
        Label3.TabIndex = 5
        Label3.Text = "INTEGRATED MANAGEMENT SYSTEM"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(login)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(passwordtxt)
        Controls.Add(usernametxt)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents usernametxt As TextBox
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents login As Button
    Friend WithEvents Label3 As Label

End Class
