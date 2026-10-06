Option Strict On
Option Infer On

Imports System.Xml
Imports System.Xml.Serialization

Partial Structure OneOver(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})
    Implements IXmlSerializable

    Private Function GetSchema() As System.Xml.Schema.XmlSchema Implements System.Xml.Serialization.IXmlSerializable.GetSchema
        Return Nothing
    End Function
    Private Sub WriteXml(writer As System.Xml.XmlWriter) Implements System.Xml.Serialization.IXmlSerializable.WriteXml
        Dim x = CType(_OneOverValue, System.Xml.Serialization.IXmlSerializable)
        x.WriteXml(writer)
    End Sub
    Private Sub ReadXml(reader As System.Xml.XmlReader) Implements System.Xml.Serialization.IXmlSerializable.ReadXml
        Dim x = CType(_OneOverValue, System.Xml.Serialization.IXmlSerializable)
        x.ReadXml(reader)
        _OneOverValue = DirectCast(x, T)
    End Sub

End Structure