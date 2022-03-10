Public Class FrmSalir

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeclado.Click
        If Me.InputPanel1.Enabled = True Then
            Me.InputPanel1.Enabled = False
        Else
            Me.InputPanel1.Enabled = True
        End If
        txtClave.Focus()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.txtClave.Text = ""
        Me.Visible = False
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.txtClave.Text = "cr52401" Then
            Me.Close()
            FrmPrincipal.Close()
        Else
            MsgBox("Código Incorrecto", MsgBoxStyle.Critical, "Información del Sistema")
            txtClave.Text = ""
            txtClave.Focus()
        End If
    End Sub

    Private Sub FrmSalir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtClave.Focus()
    End Sub
End Class