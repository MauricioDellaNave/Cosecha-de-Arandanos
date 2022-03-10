<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmVerTotal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVerTotal))
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSector = New System.Windows.Forms.Label
        Me.txtBandeja = New System.Windows.Forms.TextBox
        Me.txtKilos = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(84, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 19)
        Me.Label2.Text = "VER TOTALES"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(61, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 19)
        Me.Label1.Text = "Pampero Azul 2015"
        '
        'lblSector
        '
        Me.lblSector.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.lblSector.Location = New System.Drawing.Point(59, 91)
        Me.lblSector.Name = "lblSector"
        Me.lblSector.Size = New System.Drawing.Size(148, 22)
        Me.lblSector.Text = "Total ingresado"
        '
        'txtBandeja
        '
        Me.txtBandeja.Enabled = False
        Me.txtBandeja.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.txtBandeja.Location = New System.Drawing.Point(101, 126)
        Me.txtBandeja.MaxLength = 5
        Me.txtBandeja.Name = "txtBandeja"
        Me.txtBandeja.Size = New System.Drawing.Size(92, 26)
        Me.txtBandeja.TabIndex = 52
        '
        'txtKilos
        '
        Me.txtKilos.Enabled = False
        Me.txtKilos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.txtKilos.Location = New System.Drawing.Point(101, 156)
        Me.txtKilos.MaxLength = 5
        Me.txtKilos.Name = "txtKilos"
        Me.txtKilos.Size = New System.Drawing.Size(92, 26)
        Me.txtKilos.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(49, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 22)
        Me.Label3.Text = "Kilos :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(70, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 29)
        Me.Label4.Text = "ESC - SALIR"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(19, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 22)
        Me.Label5.Text = "Bandejas :"
        '
        'FrmVerTotal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 320)
        Me.Controls.Add(Me.txtBandeja)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKilos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSector)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmVerTotal"
        Me.Text = "FrmVerTotal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSector As System.Windows.Forms.Label
    Friend WithEvents txtBandeja As System.Windows.Forms.TextBox
    Friend WithEvents txtKilos As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
