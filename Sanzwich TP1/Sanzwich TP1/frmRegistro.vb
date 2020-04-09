Imports System.Text.RegularExpressions
Public Class frmRegistro

    Private Function validar_Mail(ByVal sMail As String) As Boolean
        Return Regex.IsMatch(sMail,
                "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function
    Private Sub BtRegistrarse_Click(sender As Object, e As EventArgs) Handles btRegistrarse.Click
        Dim ERRORES As String = ""
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
        If ERRORES <> "" Then
            ERRORES = ERRORES.Remove(ERRORES.Length - 2)
        End If
        MsgBox(ERRORES + " no válida(s)")
    End Sub
End Class