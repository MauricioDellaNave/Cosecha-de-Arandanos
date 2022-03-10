<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmSalir
    Inherits System.Windows.Forms.Form

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar con el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSalir))
        Me.btnTeclado = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.txtClave = New System.Windows.Forms.TextBox
        Me.InputPanel1 = New Microsoft.WindowsCE.Forms.InputPanel(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'btnTeclado
        '
        Me.btnTeclado.Location = New System.Drawing.Point(161, 101)
        Me.btnTeclado.Name = "btnTeclado"
        Me.btnTeclado.Size = New System.Drawing.Size(72, 20)
        Me.btnTeclado.TabIndex = 9
        Me.btnTeclado.Text = "Teclado"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 20)
        Me.Label1.Text = "Ingrese la clave para salir de la aplicación."
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(113, 151)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(72, 20)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(15, 151)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(72, 20)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(15, 100)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(140, 21)
        Me.txtClave.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'FrmSalir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 320)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnTeclado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtClave)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmSalir"
        Me.Text = "FrmSalir"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTeclado As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents InputPanel1 As Microsoft.WindowsCE.Forms.InputPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
