<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbLogin = New System.Windows.Forms.Label()
        Me.txUsuario = New System.Windows.Forms.TextBox()
        Me.txContraseña = New System.Windows.Forms.TextBox()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.lbPassword = New System.Windows.Forms.Label()
        Me.btLogin = New System.Windows.Forms.Button()
        Me.lblRegistrar = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lbLogin
        '
        Me.lbLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbLogin.Location = New System.Drawing.Point(93, 59)
        Me.lbLogin.Name = "lbLogin"
        Me.lbLogin.Size = New System.Drawing.Size(175, 33)
        Me.lbLogin.TabIndex = 0
        Me.lbLogin.Text = "Bienvenido!"
        Me.lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txUsuario
        '
        Me.txUsuario.Location = New System.Drawing.Point(80, 147)
        Me.txUsuario.Name = "txUsuario"
        Me.txUsuario.Size = New System.Drawing.Size(272, 20)
        Me.txUsuario.TabIndex = 1
        '
        'txContraseña
        '
        Me.txContraseña.Location = New System.Drawing.Point(80, 204)
        Me.txContraseña.Name = "txContraseña"
        Me.txContraseña.Size = New System.Drawing.Size(272, 20)
        Me.txContraseña.TabIndex = 2
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Location = New System.Drawing.Point(13, 150)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lbUsuario.TabIndex = 3
        Me.lbUsuario.Text = "Usuario"
        '
        'lbPassword
        '
        Me.lbPassword.AutoSize = True
        Me.lbPassword.Location = New System.Drawing.Point(13, 207)
        Me.lbPassword.Name = "lbPassword"
        Me.lbPassword.Size = New System.Drawing.Size(61, 13)
        Me.lbPassword.TabIndex = 4
        Me.lbPassword.Text = "Contraseña"
        '
        'btLogin
        '
        Me.btLogin.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btLogin.Location = New System.Drawing.Point(98, 282)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(170, 23)
        Me.btLogin.TabIndex = 5
        Me.btLogin.Text = "Iniciar Sesion"
        Me.btLogin.UseVisualStyleBackColor = True
        '
        'lblRegistrar
        '
        Me.lblRegistrar.AutoSize = True
        Me.lblRegistrar.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblRegistrar.Location = New System.Drawing.Point(143, 319)
        Me.lblRegistrar.Name = "lblRegistrar"
        Me.lblRegistrar.Size = New System.Drawing.Size(60, 13)
        Me.lblRegistrar.TabIndex = 6
        Me.lblRegistrar.TabStop = True
        Me.lblRegistrar.Text = "Registrarse"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 357)
        Me.Controls.Add(Me.lblRegistrar)
        Me.Controls.Add(Me.btLogin)
        Me.Controls.Add(Me.lbPassword)
        Me.Controls.Add(Me.lbUsuario)
        Me.Controls.Add(Me.txContraseña)
        Me.Controls.Add(Me.txUsuario)
        Me.Controls.Add(Me.lbLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbLogin As System.Windows.Forms.Label
    Friend WithEvents txUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txContraseña As TextBox
    Friend WithEvents lbUsuario As Label
    Friend WithEvents lbPassword As Label
    Friend WithEvents btLogin As Button
    Friend WithEvents lblRegistrar As LinkLabel
End Class
