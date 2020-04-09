<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistro
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
        Me.txNombres = New System.Windows.Forms.TextBox()
        Me.txApellidos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txMail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txContraseña = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txContraseña2 = New System.Windows.Forms.TextBox()
        Me.btRegistrarse = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txNombres
        '
        Me.txNombres.Location = New System.Drawing.Point(152, 35)
        Me.txNombres.Name = "txNombres"
        Me.txNombres.Size = New System.Drawing.Size(183, 20)
        Me.txNombres.TabIndex = 0
        '
        'txApellidos
        '
        Me.txApellidos.Location = New System.Drawing.Point(152, 71)
        Me.txApellidos.Name = "txApellidos"
        Me.txApellidos.Size = New System.Drawing.Size(183, 20)
        Me.txApellidos.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombres"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mail"
        '
        'txMail
        '
        Me.txMail.Location = New System.Drawing.Point(152, 111)
        Me.txMail.Name = "txMail"
        Me.txMail.Size = New System.Drawing.Size(183, 20)
        Me.txMail.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Usuario"
        '
        'txUsuario
        '
        Me.txUsuario.Location = New System.Drawing.Point(152, 157)
        Me.txUsuario.Name = "txUsuario"
        Me.txUsuario.Size = New System.Drawing.Size(183, 20)
        Me.txUsuario.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Contraseña"
        '
        'txContraseña
        '
        Me.txContraseña.Location = New System.Drawing.Point(152, 197)
        Me.txContraseña.Name = "txContraseña"
        Me.txContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txContraseña.Size = New System.Drawing.Size(183, 20)
        Me.txContraseña.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Repita contraseña"
        '
        'txContraseña2
        '
        Me.txContraseña2.Location = New System.Drawing.Point(152, 238)
        Me.txContraseña2.Name = "txContraseña2"
        Me.txContraseña2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txContraseña2.Size = New System.Drawing.Size(183, 20)
        Me.txContraseña2.TabIndex = 11
        '
        'btRegistrarse
        '
        Me.btRegistrarse.Location = New System.Drawing.Point(129, 321)
        Me.btRegistrarse.Name = "btRegistrarse"
        Me.btRegistrarse.Size = New System.Drawing.Size(75, 23)
        Me.btRegistrarse.TabIndex = 12
        Me.btRegistrarse.Text = "Registrarse"
        Me.btRegistrarse.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Location = New System.Drawing.Point(129, 350)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btCancelar.TabIndex = 13
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.Location = New System.Drawing.Point(138, 281)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(197, 20)
        Me.dtpNacimiento.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Nacimiento"
        '
        'frmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 387)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpNacimiento)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btRegistrarse)
        Me.Controls.Add(Me.txContraseña2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txContraseña)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txUsuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txMail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txApellidos)
        Me.Controls.Add(Me.txNombres)
        Me.Name = "frmRegistro"
        Me.Text = "Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txNombres As TextBox
    Friend WithEvents txApellidos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txMail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txUsuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txContraseña As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txContraseña2 As TextBox
    Friend WithEvents btRegistrarse As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents dtpNacimiento As DateTimePicker
    Friend WithEvents Label7 As Label
End Class
