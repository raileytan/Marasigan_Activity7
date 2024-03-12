Public Class frmRegister
    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        form3.ShowDialog()
    End Sub

    Private Sub llblAlreadyHaveAnAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblAlreadyHaveAnAccount.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub
End Class