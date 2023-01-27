Imports System.Xml.Serialization

Public Class ProcesarLotePorFacturaRequest

    <XmlRoot(ElementName:="gOpeDE", Namespace:="http://ws.efactura.isaltda.py/")>
    Public Class GOpeDE

        <XmlElement(ElementName:="iTipEmi", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property ITipEmi As Integer
    End Class

    <XmlRoot(ElementName:="gTimb", Namespace:="http://ws.efactura.isaltda.py/")>
    Public Class GTimb

        <XmlElement(ElementName:="iTiDE", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property ITiDE As Integer

        <XmlElement(ElementName:="dNumTim", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DNumTim As Integer

        <XmlElement(ElementName:="dEst", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DEst As Integer

        <XmlElement(ElementName:="dPunExp", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DPunExp As Integer

        <XmlElement(ElementName:="dNumDoc", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DNumDoc As Integer
    End Class

    <XmlRoot(ElementName:="gOpeCom", Namespace:="http://ws.efactura.isaltda.py/")>
    Public Class GOpeCom

        <XmlElement(ElementName:="iTipTra", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property ITipTra As Integer

        <XmlElement(ElementName:="iTImp", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property ITImp As Integer

        <XmlElement(ElementName:="cMoneOpe", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property CMoneOpe As String
    End Class

    <XmlRoot(ElementName:="gEmis", Namespace:="http://ws.efactura.isaltda.py/")>
    Public Class GEmis

        <XmlElement(ElementName:="dRucEm", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DRucEm As Integer

        <XmlElement(ElementName:="dDVEmi", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DDVEmi As Integer
    End Class

    <XmlRoot(ElementName:="gDatRec", Namespace:="http://ws.efactura.isaltda.py/")>
    Public Class GDatRec

        <XmlElement(ElementName:="iNatRec", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property INatRec As Integer

        <XmlElement(ElementName:="iTiOpe", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property ITiOpe As Integer

        <XmlElement(ElementName:="iTipIDRec", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property ITipIDRec As Integer

        <XmlElement(ElementName:="dNumIDRec", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DNumIDRec As Integer

        <XmlElement(ElementName:="dNomRec", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DNomRec As String

        <XmlElement(ElementName:="dDirRec", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DDirRec As String

        <XmlElement(ElementName:="dNumCasRec", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DNumCasRec As Integer

        <XmlElement(ElementName:="cPaisRec", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property CPaisRec As String

        <XmlElement(ElementName:="dDesPaisRe", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DDesPaisRe As String
    End Class

    <XmlRoot(ElementName:="gDatGralOpe", Namespace:="http://ws.efactura.isaltda.py/")>
    Public Class GDatGralOpe

        <XmlElement(ElementName:="dFeEmiDE", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DFeEmiDE As Date

        <XmlElement(ElementName:="gOpeCom", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property GOpeCom As GOpeCom

        <XmlElement(ElementName:="gEmis", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property GEmis As GEmis

        <XmlElement(ElementName:="gDatRec", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property GDatRec As GDatRec
    End Class

    <XmlRoot(ElementName:="gCamFE", Namespace:="http://ws.efactura.isaltda.py/")>
    Public Class GCamFE

        <XmlElement(ElementName:="iIndPres", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property IIndPres As Integer
    End Class

    <XmlRoot(ElementName:="gValorRestaItem", Namespace:="http://ws.efactura.isaltda.py/")>
    Public Class GValorRestaItem

        <XmlElement(ElementName:="dDescItem", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DDescItem As Integer

        <XmlElement(ElementName:="dTotOpeItem", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DTotOpeItem As Integer
    End Class

    <XmlRoot(ElementName:="gValorItem", Namespace:="http://ws.efactura.isaltda.py/")>
    Public Class GValorItem

        <XmlElement(ElementName:="dPUniProSer", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DPUniProSer As Integer

        <XmlElement(ElementName:="dTotBruOpeItem", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DTotBruOpeItem As Integer

        <XmlElement(ElementName:="gValorRestaItem", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property GValorRestaItem As GValorRestaItem
    End Class

    <XmlRoot(ElementName:="gCamIVA", Namespace:="http://ws.efactura.isaltda.py/")>
    Public Class GCamIVA

        <XmlElement(ElementName:="iAfecIVA", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property IAfecIVA As Integer

        <XmlElement(ElementName:="dTasaIVA", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DTasaIVA As Integer
    End Class

    <XmlRoot(ElementName:="gCamItem", Namespace:="http://ws.efactura.isaltda.py/")>
    Public Class GCamItem

        <XmlElement(ElementName:="dCodInt", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DCodInt As String

        <XmlElement(ElementName:="dDesProSer", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DDesProSer As String

        <XmlElement(ElementName:="dCantProSer", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DCantProSer As Double

        <XmlElement(ElementName:="gValorItem", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property GValorItem As GValorItem

        <XmlElement(ElementName:="gCamIVA", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property GCamIVA As GCamIVA
    End Class

    <XmlRoot(ElementName:="gPagTarCD", Namespace:="http://ws.efactura.isaltda.py/")>
    Public Class GPagTarCD

        <XmlElement(ElementName:="iDenTarj", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property IDenTarj As Integer

        <XmlElement(ElementName:="dDesDenTarj", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DDesDenTarj As String

        <XmlElement(ElementName:="dRSProTar", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DRSProTar As String

        <XmlElement(ElementName:="iForProPa", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property IForProPa As Integer
    End Class

    <XmlRoot(ElementName:="gPaConEIni", Namespace:="http://ws.efactura.isaltda.py/")>
    Public Class GPaConEIni

        <XmlElement(ElementName:="iTiPago", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property ITiPago As Integer

        <XmlElement(ElementName:="dMonTiPag", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DMonTiPag As Integer

        <XmlElement(ElementName:="cMoneTiPag", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property CMoneTiPag As String

        <XmlElement(ElementName:="gPagTarCD", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property GPagTarCD As GPagTarCD
    End Class

    <XmlRoot(ElementName:="gCamCond", Namespace:="http://ws.efactura.isaltda.py/")>
    Public Class GCamCond

        <XmlElement(ElementName:="iCondOpe", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property ICondOpe As Integer

        <XmlElement(ElementName:="gPaConEIni", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property GPaConEIni As List(Of GPaConEIni)
    End Class

    <XmlRoot(ElementName:="gDtipDE", Namespace:="http://ws.efactura.isaltda.py/")>
    Public Class GDtipDE

        <XmlElement(ElementName:="gCamFE", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property GCamFE As GCamFE

        <XmlElement(ElementName:="gCamItem", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property GCamItem As List(Of GCamItem)

        <XmlElement(ElementName:="gCamCond", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property GCamCond As GCamCond
    End Class

    <XmlRoot(ElementName:="gTotSub", Namespace:="http://ws.efactura.isaltda.py/")>
    Public Class GTotSub

        <XmlElement(ElementName:="dSubExe", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DSubExe As Integer

        <XmlElement(ElementName:="dSub5", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DSub5 As Integer

        <XmlElement(ElementName:="dSub10", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DSub10 As Integer

        <XmlElement(ElementName:="dTotOpe", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DTotOpe As Integer

        <XmlElement(ElementName:="dRedon", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DRedon As Integer
    End Class

    <XmlRoot(ElementName:="DE")>
    Public Class DE

        <XmlElement(ElementName:="gOpeDE", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property GOpeDE As GOpeDE

        <XmlElement(ElementName:="gTimb", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property GTimb As GTimb

        <XmlElement(ElementName:="gDatGralOpe", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property GDatGralOpe As GDatGralOpe

        <XmlElement(ElementName:="gDtipDE", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property GDtipDE As GDtipDE

        <XmlElement(ElementName:="gTotSub", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property GTotSub As GTotSub
    End Class

    <XmlRoot(ElementName:="rDE", Namespace:="http://ws.efactura.isaltda.py/")>
    Public Class RDE

        <XmlElement(ElementName:="DE", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property DE As DE
    End Class

    <XmlRoot(ElementName:="parametrosProcesamiento", Namespace:="http://ws.efactura.isaltda.py/")>
    Public Class ParametrosProcesamiento

        <XmlElement(ElementName:="retornarKuDE", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property RetornarKuDE As Boolean

        <XmlElement(ElementName:="retornarXmlFirmado", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property RetornarXmlFirmado As Boolean

        <XmlElement(ElementName:="templateKuDE", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property TemplateKuDE As String

        <XmlElement(ElementName:="forzarReingreso", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property ForzarReingreso As Boolean

        <XmlElement(ElementName:="notificarMail", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property NotificarMail As Boolean

        <XmlElement(ElementName:="validarCalculos", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property ValidarCalculos As Boolean
    End Class

    <XmlRoot(ElementName:="procesarDocumento", Namespace:="http://ws.efactura.isaltda.py/")>
    Public Class ProcesarDocumento

        <XmlElement(ElementName:="rDE", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property RDE As RDE

        <XmlElement(ElementName:="parametrosProcesamiento", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property ParametrosProcesamiento As ParametrosProcesamiento
    End Class

    <XmlRoot(ElementName:="procesarLotePorFacturaRequest", Namespace:="http://ws.efactura.isaltda.py/")>
    Public Class ProcesarLotePorFacturaRequest

        <XmlElement(ElementName:="procesarDocumento", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property ProcesarDocumento As ProcesarDocumento

        <XmlAttribute(AttributeName:="xmlns", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property Xmlns As String

        <XmlText>
        Public Property Text As String
    End Class

    <XmlRoot(ElementName:="Body")>
    Public Class Body

        <XmlElement(ElementName:="procesarLotePorFacturaRequest", Namespace:="http://ws.efactura.isaltda.py/")>
        Public Property ProcesarLotePorFacturaRequest As ProcesarLotePorFacturaRequest
    End Class

    <XmlRoot(ElementName:="Envelope", Namespace:="http://schemas.xmlsoap.org/soap/envelope/")>
    Public Class Envelope

        <XmlElement(ElementName:="Header", Namespace:="http://schemas.xmlsoap.org/soap/envelope/")>
        Public Property Header As Object

        <XmlElement(ElementName:="Body", Namespace:="http://schemas.xmlsoap.org/soap/envelope/")>
        Public Property Body As Body

        <XmlAttribute(AttributeName:="soapenv", Namespace:="http://schemas.xmlsoap.org/soap/envelope/")>
        Public Property Soapenv As String

        <XmlAttribute(AttributeName:="ws", Namespace:="http://schemas.xmlsoap.org/soap/envelope/")>
        Public Property ws As String
    End Class


End Class
