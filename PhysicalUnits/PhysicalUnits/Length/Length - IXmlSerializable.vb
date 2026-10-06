Option Strict On
Option Infer On

Imports System.Xml
Imports System.Xml.Serialization

Partial Structure Length
    Implements IXmlSerializable

    Const xmlUnitAttributeName = "Unit"

    Private Function GetSchema() As Schema.XmlSchema Implements IXmlSerializable.GetSchema
        Return Nothing
    End Function

    Private Sub WriteXml(writer As XmlWriter) Implements IXmlSerializable.WriteXml
        writer.WriteAttributeString(xmlUnitAttributeName, SupportedLengthUnits.Meters.ToString)
        writer.WriteValue(Me.Meters)
    End Sub

    Private Sub ReadXml(reader As XmlReader) Implements IXmlSerializable.ReadXml
        reader.MoveToContent()
        Dim strUnit = reader.GetAttribute(xmlUnitAttributeName)
        Dim unit = CType([Enum].Parse(GetType(SupportedLengthUnits), strUnit, True), SupportedLengthUnits)
        Dim isEmptyElement = reader.IsEmptyElement
        If Not isEmptyElement Then
            Me.Value(unit) = reader.ReadElementContentAsDouble
        End If
    End Sub

End Structure