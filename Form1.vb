Public Class Form1
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblRegister.LinkClicked
        frmRegister.Show()
        Me.Hide()
    End Sub
End Class

