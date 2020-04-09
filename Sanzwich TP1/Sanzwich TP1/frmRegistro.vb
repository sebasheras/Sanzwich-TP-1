Imports System.Text.RegularExpressions
Public Class frmRegistro

    Private Function validar_Mail(ByVal sMail As String) As Boolean
        Return Regex.IsMatch(sMail,
                "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function
    Private Sub BtRegistrarse_Click(sender As Object, e As EventArgs) Handles btRegistrarse.Click
        Dim ERRORES As String = ""
        Dim Nacimiento As Date
        Dim Años As Integer
        If IsNumeric(txApellidos.Text) Or txApellidos.Text.Trim() = "" Then
            ERRORES += "Apellido, "
        End If
        If IsNumeric(txNombres.Text) Or txNombres.Text.Trim() = "" Then
            ERRORES += "nombre, "
        End If
        If IsNumeric(txMail.Text) Or txMail.Text.Trim() = "" Or validar_Mail(txMail.Text) = False Then
            ERRORES += "mail, "
        End If
        If (txContraseña.Text) <> (txContraseña2.Text) Or txNombres.Text.Trim() = "" Then
            ERRORES += "contraseña, "
        End If
        Nacimiento = dtpNacimiento.Value
        If ERRORES <> "" Then
            ERRORES = ERRORES.Remove(ERRORES.Length - 2)
            MsgBox(ERRORES + " no válida(s)")
            Return
        End If
        FileOpen(1, "usuario.txt", OpenMode.Append)
        WriteLine(1, txUsuario.Text, txContraseña.Text, txNombres.Text, txApellidos.Text, txMail.Text, Format(Nacimiento, "Short Date"))
        FileClose()
        Close()
    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Close()
    End Sub
End Class