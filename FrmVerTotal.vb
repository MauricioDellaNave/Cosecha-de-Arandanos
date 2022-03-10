Public Class FrmVerTotal



    Private Sub FrmVerTotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = 27 Then
            FrmPrincipal.Visible = True
            Me.Visible = False
        End If

    End Sub

End Class