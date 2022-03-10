Public Class FrmLogin

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnAceptar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        FrmPrincipal.Show()
        Me.Visible = False
    End Sub

    Private Sub btnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class