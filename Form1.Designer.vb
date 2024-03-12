<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtUsername = New TextBox()
        Label2 = New Label()
        txtPassword = New TextBox()
        btnLogin = New Button()
        llblRegister = New LinkLabel()
        llblForgotPassword = New LinkLabel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(192, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(94, 90)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(280, 27)
        txtUsername.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(195, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 0
        Label2.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(94, 166)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(280, 27)
        txtPassword.TabIndex = 1
        txtPassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(183, 218)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' llblRegister
        ' 
        llblRegister.AutoSize = True
        llblRegister.Location = New Point(179, 268)
        llblRegister.Name = "llblRegister"
        llblRegister.Size = New Size(102, 20)
        llblRegister.TabIndex = 3
        llblRegister.TabStop = True
        llblRegister.Text = "Register Now!"
        ' 
        ' llblForgotPassword
        ' 
        llblForgotPassword.AutoSize = True
        llblForgotPassword.Location = New Point(168, 301)
        llblForgotPassword.Name = "llblForgotPassword"
        llblForgotPassword.Size = New Size(127, 20)
        llblForgotPassword.TabIndex = 3
        llblForgotPassword.TabStop = True
        llblForgotPassword.Text = "Forgot password?"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(486, 407)
        Controls.Add(llblForgotPassword)
        Controls.Add(llblRegister)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(Label2)
        Controls.Add(txtUsername)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents llblRegister As LinkLabel
    Friend WithEvents llblForgotPassword As LinkLabel

End Class
