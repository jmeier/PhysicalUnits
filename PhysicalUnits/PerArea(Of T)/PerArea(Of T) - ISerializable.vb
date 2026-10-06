Option Strict On
Option Infer On

Imports System.Runtime.Serialization

Partial Structure PerArea(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})
    Implements ISerializable

    Private Const SerialisationKey = "value"

    <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
    Sub New(info As SerializationInfo, context As StreamingContext)
        If info Is Nothing Then Throw New ArgumentNullException(NameOf(info))
        _ValuePerSquaremeter = CType(_ValuePerSquaremeter.Create(info.GetDouble(SerialisationKey), _ValuePerSquaremeter.DefaultUnit), T)
    End Sub

    Public Sub GetObjectData(info As SerializationInfo, context As StreamingContext) Implements ISerializable.GetObjectData
        If info Is Nothing Then Throw New ArgumentNullException(NameOf(info))
        info.AddValue(SerialisationKey, _ValuePerSquaremeter.GetValue(_ValuePerSquaremeter.DefaultUnit))
    End Sub

End Structure