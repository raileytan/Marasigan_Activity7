<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        TextBox1 = New TextBox()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        TextBox5 = New TextBox()
        Label6 = New Label()
        TextBox4 = New TextBox()
        TextBox6 = New TextBox()
        Label7 = New Label()
        btnSave = New Button()
        llblAlreadyHaveAnAccount = New LinkLabel()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(39, 63)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(149, 27)
        TextBox1.TabIndex = 1
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(39, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 1
        Label1.Text = "First Name"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(231, 63)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(149, 27)
        TextBox2.TabIndex = 2
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(231, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 20)
        Label2.TabIndex = 1
        Label2.Text = "Middle Name"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(422, 63)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(149, 27)
        TextBox3.TabIndex = 3
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(422, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 20)
        Label3.TabIndex = 1
        Label3.Text = "Last Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(39, 122)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 20)
        Label4.TabIndex = 1
        Label4.Text = "Birthdate"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(39, 150)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(341, 27)
        DateTimePicker1.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(39, 215)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 20)
        Label5.TabIndex = 1
        Label5.Text = "Username"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(332, 240)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(239, 27)
        TextBox5.TabIndex = 7
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(332, 215)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 20)
        Label6.TabIndex = 1
        Label6.Text = "Password"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(39, 240)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(239, 27)
        TextBox4.TabIndex = 6
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(422, 147)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(149, 27)
        TextBox6.TabIndex = 5
        TextBox6.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(422, 122)
        Label7.Name = "Label7"
        Label7.Size = New Size(36, 20)
        Label7.TabIndex = 1
        Label7.Text = "Age"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(260, 301)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 8
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' llblAlreadyHaveAnAccount
        ' 
        llblAlreadyHaveAnAccount.AutoSize = True
        llblAlreadyHaveAnAccount.Location = New Point(188, 338)
        llblAlreadyHaveAnAccount.Name = "llblAlreadyHaveAnAccount"
        llblAlreadyHaveAnAccount.Size = New Size(256, 20)
        llblAlreadyHaveAnAccount.TabIndex = 9
        llblAlreadyHaveAnAccount.TabStop = True
        llblAlreadyHaveAnAccount.Text = "Already have an account? Login here!"
        ' 
        ' frmRegister
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(616, 394)
        Controls.Add(llblAlreadyHaveAnAccount)
        Controls.Add(btnSave)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label4)
        Controls.Add(Label7)
        Controls.Add(Label3)
        Controls.Add(TextBox6)
        Controls.Add(Label2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label6)
        Controls.Add(TextBox4)
        Controls.Add(TextBox5)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Name = "frmRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmRegister"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents llblAlreadyHaveAnAccount As LinkLabel
End Class
