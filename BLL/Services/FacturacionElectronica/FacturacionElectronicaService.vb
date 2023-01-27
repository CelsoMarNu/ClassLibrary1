
Imports Intercom

Public Class FacturacionElectronicaService
    Public Async Function procesarLotePorFactura(ByVal tipo As Integer, ByVal nroDocumento As String, ByVal nroTimbrado As String) As Task(Of Models.ProcesarLotePorFactura.ProcesarLotePorFacturaResponseEnvelope)
        Dim parametros = Await optenerParametros()
        Dim soapenv As XNamespace = parametros.SoapEnv
        Dim ws As XNamespace = parametros.WS
        Dim soapResult As String
        Dim result As Models.ProcesarLotePorFactura.ProcesarLotePorFacturaResponseEnvelope = New Models.ProcesarLotePorFactura.ProcesarLotePorFacturaResponseEnvelope()
        Try
            Try
                Dim cabecera = traerCabecera()
                If Not cabecera.Any() Then
                    Return New Models.ProcesarLotePorFactura.ProcesarLotePorFacturaResponseEnvelope()
                End If
            Catch e As Exception
            End Try
        Catch e As exception
        End Try
        Return result
    End Function
End Class



