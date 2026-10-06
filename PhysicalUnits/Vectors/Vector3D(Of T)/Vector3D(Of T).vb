Option Strict On
Option Infer On

Imports System.Runtime.Serialization

'<ComponentModel.TypeConverter(GetType(TVector3DConverter))>
<CLSCompliant(True), Serializable()>
Partial Public Structure Vector3D(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})
    Implements IEquatable(Of Vector3D(Of T)), IComparable(Of Vector3D(Of T))
    Implements System.Xml.Serialization.IXmlSerializable, ISerializable
    'Implements IUnitSupportingArithmetics

    Public ReadOnly Property X As T
    Public ReadOnly Property Y As T
    Public ReadOnly Property Z As T

    Public Sub New(x As T, y As T, z As T)
        Me.X = x
        Me.Y = y
        Me.Z = z
    End Sub

    Public Overrides Function ToString() As String
        Return $"x:={X}; y:={Y}; z:={Z}"
    End Function

    Public Function ToArray() As T()
        Return {_X, _Y, _Z}
    End Function

    <System.ComponentModel.Browsable(False)>
    <System.Xml.Serialization.XmlIgnore()>
    Public ReadOnly Property Rank() As Integer
        Get
            Return 3
        End Get
    End Property

    Public ReadOnly Property Item(index As Integer) As T
        Get
            Select Case index
                Case 0
                    Return _X

                Case 1
                    Return _Y

                Case 2
                    Return _Z

                Case Else
                    Throw New ArgumentOutOfRangeException(NameOf(index))

            End Select
        End Get
    End Property

    'Public Function IsZero() As Boolean
    '    Return Me._X.IsZero AndAlso Me._Y.IsZero AndAlso Me._Z.IsZero
    'End Function

    Public ReadOnly Property Magnitude() As T
        Get
            Dim unit = X.DefaultUnit

            Dim meX = Me.X.GetValue(unit)
            Dim meY = Me.Y.GetValue(unit)
            Dim meZ = Me.Z.GetValue(unit)

            Dim meTotal = Math.Sqrt(meX ^ 2 + meY ^ 2 + meZ ^ 2)

            Return CType(X.Create(meTotal, unit), T)
        End Get
    End Property


    Function Flip() As Vector3D(Of T)
        Return New Vector3D(Of T)(x:=Flip(_X), y:=Flip(_Y), z:=Flip(_Z))
    End Function

#Region "HashCode"

    Public Overrides Function GetHashCode() As Integer
        'Return Vector.GetHashCode(Me)
        Return Me._X.GetHashCode Xor Me._Y.GetHashCode Xor Me._Z.GetHashCode
    End Function

#End Region

#Region "Equals"

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is Vector3D(Of T) Then
            Return Equals(DirectCast(obj, Vector3D(Of T)))
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As Vector3D(Of T)) As Boolean Implements IEquatable(Of Vector3D(Of T)).Equals
        Return Me._X.Equals(other._X) AndAlso Me._Y.Equals(other._Y) AndAlso Me._Z.Equals(other._Z)
    End Function

    Public Overloads Shared Function Equals(a As Vector3D(Of T), b As Vector3D(Of T)) As Boolean
        Return a._X.Equals(b._X) AndAlso a._Y.Equals(b._Y) AndAlso a._Z.Equals(b._Z)
    End Function

#End Region

#Region "ICompareable"

    Private Function CompareTo(other As Vector3D(Of T)) As Integer Implements IComparable(Of Vector3D(Of T)).CompareTo
        Dim unit = X.DefaultUnit

        Dim meX = Me.X.GetValue(unit)
        Dim meY = Me.Y.GetValue(unit)
        Dim meZ = Me.Z.GetValue(unit)
        Dim meTotal = meX ^ 2 + meY ^ 2 + meZ ^ 2

        Dim otherX = other.X.GetValue(unit)
        Dim otherY = other.Y.GetValue(unit)
        Dim otherZ = other.Z.GetValue(unit)
        Dim otherTotal = otherX ^ 2 + otherY ^ 2 + otherZ ^ 2

        Return meTotal.CompareTo(otherTotal)
    End Function

#End Region

#Region "IXmlSerializable - Support"

    Private Const SerialisationKeyX = "X"
    Private Const SerialisationKeyY = "Y"
    Private Const SerialisationKeyZ = "Z"

    Private Function GetSchema() As System.Xml.Schema.XmlSchema Implements System.Xml.Serialization.IXmlSerializable.GetSchema
        Return Nothing
    End Function
    Private Sub WriteXml(writer As System.Xml.XmlWriter) Implements System.Xml.Serialization.IXmlSerializable.WriteXml
        'write x
        writer.WriteStartElement(SerialisationKeyX)
        _X.WriteXml(writer)
        writer.WriteEndElement()

        'write y
        writer.WriteStartElement(SerialisationKeyY)
        _Y.WriteXml(writer)
        writer.WriteEndElement()

        'write z
        writer.WriteStartElement(SerialisationKeyZ)
        _Z.WriteXml(writer)
        writer.WriteEndElement()

    End Sub
    Private Sub ReadXml(reader As System.Xml.XmlReader) Implements System.Xml.Serialization.IXmlSerializable.ReadXml
        reader.MoveToContent()
        If reader.IsEmptyElement Then Exit Sub

        Using r = reader.ReadSubtree
            r.MoveToContent()
            r.Read()

            Do Until r.EOF
                Select Case r.NodeType
                    Case System.Xml.XmlNodeType.Whitespace, Xml.XmlNodeType.SignificantWhitespace, Xml.XmlNodeType.EndElement
                        r.Read()

                    Case System.Xml.XmlNodeType.Element
                        Select Case r.Name
                            Case SerialisationKeyX
                                Me._X.ReadXml(reader)

                            Case SerialisationKeyY
                                Me._Y.ReadXml(reader)

                            Case SerialisationKeyZ
                                Me._Z.ReadXml(reader)

                            Case Else
                                Using r.ReadSubtree
                                    'nothing - just consume the subtree
                                End Using

                        End Select

                    Case Else
                        Throw New Exception

                End Select
            Loop

        End Using

        reader.ReadEndElement()

    End Sub

#End Region

#Region "ISerializable - Support"

    <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
    Sub New(info As SerializationInfo, context As StreamingContext)
        If info Is Nothing Then Throw New ArgumentNullException(NameOf(info))

        X = CType(X.Create(info.GetDouble(SerialisationKeyX), X.DefaultUnit), T)
        Y = CType(Y.Create(info.GetDouble(SerialisationKeyY), Y.DefaultUnit), T)
        Z = CType(Z.Create(info.GetDouble(SerialisationKeyZ), Z.DefaultUnit), T)
    End Sub

    Public Sub GetObjectData(info As SerializationInfo, context As StreamingContext) Implements ISerializable.GetObjectData
        If info Is Nothing Then Throw New ArgumentNullException(NameOf(info))

        info.AddValue(SerialisationKeyX, X.GetValue(X.DefaultUnit))
        info.AddValue(SerialisationKeyY, Y.GetValue(Y.DefaultUnit))
        info.AddValue(SerialisationKeyZ, Z.GetValue(Z.DefaultUnit))
    End Sub

#End Region

End Structure
