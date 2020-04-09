Public Class frmLogin

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbLogin.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txUsuario.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txContraseña.TextChanged

    End Sub

    Private Sub lbPassword_Click(sender As Object, e As EventArgs) Handles lbPassword.Click

    End Sub

    Private Sub BtLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        Dim nombre, apellido, dni, fecha, correo, password, usuario As String
        Dim usuarioEncontrado As Boolean
        usuarioEncontrado = False
        If txUsuario.Text = "" Or txContraseña.Text = "" Then
            MsgBox("Rellene los campos")
        Else
            FileOpen(1, "datos.txt", OpenMode.Input)
            While Not EOF(1)
                Input(1, usuario)
                Input(1, password)
                Input(1, nombre)
                Input(1, apellido)
                Input(1, dni)
                Input(1, correo)
                Input(1, fecha)
                If txUsuario.Text = usuario And txContraseña.Text = password Then
                    MsgBox("Iniciado Correctamente")
                    usuarioEncontrado = True
                End If
            End While
            FileClose()
            If usuarioEncontrado = False Then
                MsgBox("Usuario no encontrado")
            End If
        End If
    End Sub

    Private Sub LblRegistrar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblRegistrar.LinkClicked
        frmRegistro.ShowDialog()
    End Sub
End Class
