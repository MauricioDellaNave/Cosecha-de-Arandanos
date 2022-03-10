Imports System
Imports System.IO
Imports System.Collections

Public Class FrmPrincipal

    Private Sub FrmPrincipal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = 27 Then
            FrmSalir.Visible = True
        End If

        If e.KeyValue = 49 Or e.KeyValue = 151 Then
            FrmColectar.Visible = True
        End If

        If e.KeyValue = 51 Or e.KeyValue = 68 Then
            FrmVerTotal.Visible = True
            CargarTotales()
        End If

    End Sub

    Public Sub CargarTotales()
        'VALIDAR EXISTENCIA DE ARCHIVO
        'cargo el archivo
        Try
            Dim objReader As New StreamReader("\Upload\CUSTOM.TXT")
            Dim Sline As String = ""
            Dim arrText As New ArrayList
            Dim arrCadena As String()
            Dim encontro As Boolean = False
            Dim TotalBandejas As Double = 0.0
            Dim TotalKilos As Double = 0.0

            'recorro el archivo y lo cargo en una lista

            Sline = objReader.ReadLine

            Do While Sline Is Nothing = False
                arrText.Add(Sline)
                Sline = objReader.ReadLine
            Loop
            objReader.Close()

            For Each cadena In arrText
                arrCadena = Split(cadena, ",")
                TotalBandejas = TotalBandejas + arrCadena(7)
                TotalKilos = TotalKilos + arrCadena(2)
            Next

            FrmVerTotal.txtBandeja.Text = TotalBandejas
            FrmVerTotal.txtKilos.Text = TotalKilos
        Catch ex As Exception
            MsgBox("No se ha realizado ninguna cosecha.", MsgBoxStyle.Critical, "Importante")
        End Try
        

    End Sub

End Class
