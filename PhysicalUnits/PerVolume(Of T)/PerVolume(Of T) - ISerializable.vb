Option Strict On
Option Infer On

Imports System.Runtime.Serialization

Partial Structure PerVolume(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})
    Implements ISerializable

    Private Const SerialisationKey = "value"

    <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
    Sub New(info As SerializationInfo, context As StreamingContext)
        If info Is Nothing Then Throw New ArgumentNullException(NameOf(info))
        _ValuePerCubicemeter = CType(_ValuePerCubicemeter.Create(info.GetDouble(SerialisationKey), _ValuePerCubicemeter.DefaultUnit), T)
    End Sub

    Public Sub GetObjectData(info As SerializationInfo, context As StreamingContext) Implements ISerializable.GetObjectData
        If info Is Nothing Then Throw New ArgumentNullException(NameOf(info))
        info.AddValue(SerialisationKey, _ValuePerCubicemeter.GetValue(_ValuePerCubicemeter.DefaultUnit))
    End Sub

End Structure