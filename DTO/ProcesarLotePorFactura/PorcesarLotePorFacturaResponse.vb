Imports System.Xml.Serialization
Public Class PorcesarLotePorFacturaResponse
    <XmlRoot(ElementName:="documentoElectronicoGenerado", [Namespace]:="")>
    Public Class DocumentoElectronicoGenerado
        <XmlElement(ElementName:="id", [Namespace]:="http://ws.efactura.isaltda.py/")>
        Public Property Id As String
        <XmlElement(ElementName:="KuDE", [Namespace]:="http://ws.efactura.isaltda.py/")>
        Public Property KuDE As String
        <XmlElement(ElementName:="xmlFirmado", [Namespace]:="http://ws.efactura.isaltda.py/")>
        Public Property xmlFirmado As String
    End Class
    <XmlRoot(ElementName:="return", [Namespace]:="http://ws.efactura.isaltda.py/")>
    Public Class [Return]
        <XmlElement(ElementName:="ok", [Namespace]:="http://ws.efactura.isaltda.py/")>
        Public Property Ok As String
        <XmlElement(ElementName:="mensajeError", [Namespace]:="http://ws.efactura.isaltda.py/")>
        Public Property MensajeError As String
        <XmlElement(ElementName:="numDocumentoError", [Namespace]:="http://ws.efactura.isaltda.py/")>
        Public Property NumDocumentoError As String
        <XmlElement(ElementName:="documentoElectronicoGenerado", [Namespace]:="http://ws.efactura.isaltda.py/")>
        Public Property DocumentoElectronicoGenerado As DocumentoElectronicoGenerado
    End Class
    <XmlRoot(ElementName:="procesarLotePorFacturaResponse", [Namespace]:="http://ws.efactura.isaltda.py/")>
    Public Class procesarLotePorFacturaResponse
        <XmlElement(ElementName:="return", [Namespace]:="http://ws.efactura.isaltda.py/")>
        Public Property [Return] As [Return]
        <XmlAttribute(AttributeName:="ns2", [Namespace]:="http://ws.efactura.isaltda.py/")>
        Public Property Ns2 As String
    End Class
    <XmlRoot(ElementName:="Body", [Namespace]:="http://schemas.xmlsoap.org/soap/envelope/")>
    Public Class procesarLotePorFacturaResponseBody
        <XmlElement(ElementName:="procesarLoteFacturasReponse", [Namespace]:="http://ws.efactura.isaltda.py/")>
        Public Property procesarLoteFacturasReponse As procesarLotePorFacturaResponse
    End Class
    <XmlRoot(ElementName:="Envelope", [Namespace]:="http://schemas.xmlsoap.org/soap/envelope/")>
    Public Class procesarLotePorFacturaResponseEnvelope
        <XmlElement(ElementName:="Header", [Namespace]:="http://schemas.xmlsoap.org/soap/envelope/")>
        Public Property Header As String
        <XmlElement(ElementName:="Body", [Namespace]:="http://schemas.xmlsoap.org/soap/envelope/")>
        Public Property Body As procesarLotePorFacturaResponseBody
        <XmlAttribute(AttributeName:="SOAP-ENV", [Namespace]:="")>
        Public Property SOAPENV As String
    End Class
End Class
