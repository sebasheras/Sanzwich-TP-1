<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
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
        Me.lbLogin.Location = New System.Drawing.Point(111, 59)
        Me.lbLogin.Name = "lbLogin"
        Me.lbLogin.Size = New System.Drawing.Size(175, 33)
        Me.lbLogin.TabIndex = 0
        Me.lbLogin.Text = "Bienvenido!"
        Me.lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(80, 147)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(80, 204)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(272, 20)
        Me.TextBox2.TabIndex = 2
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
        Me.btLogin.Location = New System.Drawing.Point(116, 278)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(170, 23)
        Me.btLogin.TabIndex = 5
        Me.btLogin.Text = "Iniciar Sesion"
        Me.btLogin.UseVisualStyleBackColor = True
        '
        'lblRegistrar
        '
        Me.lblRegistrar.AutoSize = True
        Me.lblRegistrar.Location = New System.Drawing.Point(168, 321)
        Me.lblRegistrar.Name = "lblRegistrar"
        Me.lblRegistrar.Size = New System.Drawing.Size(60, 13)
        Me.lblRegistrar.TabIndex = 6
        Me.lblRegistrar.TabStop = True
        Me.lblRegistrar.Text = "Registrarse"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 361)
        Me.Controls.Add(Me.lblRegistrar)
        Me.Controls.Add(Me.btLogin)
        Me.Controls.Add(Me.lbPassword)
        Me.Controls.Add(Me.lbUsuario)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbLogin)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbLogin As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lbUsuario As Label
    Friend WithEvents lbPassword As Label
    Friend WithEvents btLogin As Button
    Friend WithEvents lblRegistrar As LinkLabel
End Class
