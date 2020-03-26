Public Class frmLogin

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbLogin.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub lbPassword_Click(sender As Object, e As EventArgs) Handles lbPassword.Click

    End Sub

    Private Sub BtLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click

    End Sub

    Private Sub LblRegistrar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblRegistrar.LinkClicked
        frmRegistro.ShowDialog()
    End Sub
End Class
