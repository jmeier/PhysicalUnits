Option Strict On
Option Infer On

Imports System.Xml
Imports System.Xml.Serialization

Partial Structure PerTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})
    Implements IXmlSerializable

    Private Function GetSchema() As Schema.XmlSchema Implements IXmlSerializable.GetSchema
        Return Nothing
    End Function
    Private Sub WriteXml(writer As XmlWriter) Implements IXmlSerializable.WriteXml
        Dim x = CType(_ValuePerSecond, IXmlSerializable)
        x.WriteXml(writer)
    End Sub
    Private Sub ReadXml(reader As XmlReader) Implements IXmlSerializable.ReadXml
        Dim x = CType(_ValuePerSecond, IXmlSerializable)
        x.ReadXml(reader)
        _ValuePerSecond = DirectCast(x, T)
    End Sub

End Structure