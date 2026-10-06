Option Strict On
Option Infer On

Imports System.Xml
Imports System.Xml.Serialization

Partial Structure LengthPow4
    Implements System.Xml.Serialization.IXmlSerializable

    Const xmlUnitAttributeName = "Unit"

    Private Function GetSchema() As Schema.XmlSchema Implements IXmlSerializable.GetSchema
        Return Nothing
    End Function

    Private Sub WriteXml(writer As XmlWriter) Implements IXmlSerializable.WriteXml
        writer.WriteAttributeString(xmlUnitAttributeName, SupportedLengthPow4Units.MetersPow4.ToString)
        writer.WriteValue(Me.MetersPow4)
    End Sub

    Private Sub ReadXml(reader As XmlReader) Implements IXmlSerializable.ReadXml
        reader.MoveToContent()
        Dim strUnit = reader.GetAttribute(xmlUnitAttributeName)
        Dim unit = CType([Enum].Parse(GetType(SupportedLengthPow4Units), strUnit, True), SupportedLengthPow4Units)
        Dim isEmptyElement = reader.IsEmptyElement
        If Not isEmptyElement Then
            Me.Value(unit) = reader.ReadElementContentAsDouble
        End If
    End Sub

End Structure