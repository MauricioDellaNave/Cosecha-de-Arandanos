Imports System.IO
Imports System.Net.Sockets
Imports System.Net

Public Class Archivos


#Region "Declaraciones"

    Dim mSector As String
    Dim mLegajoCosechero As String
    Dim mKilos As String
    Dim mNroRemito As String
    Dim mSupervisor As String
    Dim mCantbandejas1 As String
    Dim mCantBandejas2 As String
    Dim mKilo_buscado As String
    Dim mBandeja_buscada As String



#End Region

#Region "Property"


    Public Property Sector() As String
        Get
            Return mSector
        End Get
        Set(ByVal value As String)
            mSector = value
        End Set
    End Property


    Public Property LegajoCosechero() As String
        Get
            Return mLegajoCosechero
        End Get
        Set(ByVal value As String)
            mLegajoCosechero = value
        End Set
    End Property


    Public Property Kilos() As String
        Get
            Return mKilos
        End Get
        Set(ByVal value As String)
            mKilos = value
        End Set
    End Property


    Public Property NroRemito() As String
        Get
            Return mNroRemito
        End Get
        Set(ByVal value As String)
            mNroRemito = value
        End Set
    End Property

    Public Property Supervisor() As String
        Get
            Return mSupervisor
        End Get
        Set(ByVal value As String)
            mSupervisor = value
        End Set
    End Property


    Public Property CantBandejas1() As String
        Get
            Return mCantbandejas1
        End Get
        Set(ByVal value As String)
            mCantbandejas1 = value
        End Set
    End Property


    Public Property CantBandejas2() As String
        Get
            Return mCantBandejas2
        End Get
        Set(ByVal value As String)
            mCantBandejas2 = value
        End Set
    End Property



#End Region

#Region "Metodos"

    Public Function BuscarKilos(ByVal pValor As String) As String

        Try
            Dim objReader As New StreamReader("\Upload\env200.TXT")
            Dim Sline As String = ""
            Dim arrText As New ArrayList
            Dim arrCadena As String()
            Dim encontro As Boolean = False


            'recorro el archivo y lo cargo en una lista

            Sline = objReader.ReadLine

            Do While Sline Is Nothing = False
                arrText.Add(Sline)
                Sline = objReader.ReadLine
            Loop
            objReader.Close()

            For Each cadena In arrText
                arrCadena = Split(cadena, ",")
                If arrCadena(0) = pValor Then
                    mKilo_buscado = arrCadena(3)
                    encontro = True
                    Exit For
                End If

            Next
            If encontro = False Then
                MsgBox("No se encontro estimado", MsgBoxStyle.Critical, "Importante")
            End If
        Catch ex As Exception
            MsgBox("El archivo 'env200.TXT' no se encuentra en el equipo.", MsgBoxStyle.Critical, "Importante")

        End Try
        Return mKilo_buscado
    End Function

    Public Function BuscarBandejas(ByVal pValor As String) As String
        Try
            Dim objReader As New StreamReader("\Upload\env200.TXT")
            Dim Sline As String = ""
            Dim arrText As New ArrayList
            Dim arrCadena As String()
            Dim encontro As Boolean = False

            'recorro el archivo y lo cargo en una lista

            Sline = objReader.ReadLine

            Do While Sline Is Nothing = False
                arrText.Add(Sline)
                Sline = objReader.ReadLine
            Loop
            objReader.Close()

            For Each cadena In arrText
                arrCadena = Split(cadena, ",")
                If arrCadena(0) = pValor Then
                    mBandeja_buscada = arrCadena(4)
                    encontro = True
                    Exit For
                End If

            Next
            If encontro = False Then
                MsgBox("No se encontro redundante de bandejas.", MsgBoxStyle.Critical, "Importante")
            End If
        Catch ex As Exception
            MsgBox("El archivo 'env200.TXT' no se encuentra en el equipo.", MsgBoxStyle.Critical, "Importante")
        End Try
        Return mBandeja_buscada
    End Function


    Public Sub CrearArchivo()
        Try

            'Creamos la carpeta UPLOAD
            If Not Directory.Exists("\Upload") Then
                Directory.CreateDirectory("\Upload")

                'creamos el archivo txt y escribimos
                Const fic As String = "\Upload\CUSTOM.txt"
                'MsgBox("el txt no existe lo creo")
                Dim sw As New System.IO.StreamWriter(fic)
                sw.WriteLine(mSector & "," & mLegajoCosechero & "," & mKilos & "," & mNroRemito & "," & mSupervisor & "," & Format(Now(), "hh:mm:ss") & "," & Format(Now(), "dd/MM/yyyy") & "," & mCantbandejas1 & "," & mCantBandejas2)
                sw.Close()


            Else

                'escribimos en el archivo txt ya existente
                Const fic As String = "\Upload\CUSTOM.txt"
                'MsgBox("el txt ya existe escribo linea nueva")
                Dim sw As New System.IO.StreamWriter(fic, True)
                sw.WriteLine(mSector & "," & mLegajoCosechero & "," & mKilos & "," & mNroRemito & "," & mSupervisor & "," & Format(Now(), "hh:mm:ss") & "," & Format(Now(), "dd/MM/yyyy") & "," & mCantbandejas1 & "," & mCantBandejas2)
                sw.Close()

            End If


        Catch oe As Exception
            MsgBox(oe.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
#End Region



End Class
