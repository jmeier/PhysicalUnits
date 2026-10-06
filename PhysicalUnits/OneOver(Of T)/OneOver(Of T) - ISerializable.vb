Option Strict On
Option Infer On

Imports System.Runtime.Serialization

Partial Structure OneOver(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})
    Implements ISerializable

    Private Const SerialisationKey = "value"

    <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
    Sub New(info As SerializationInfo, context As StreamingContext)
        If info Is Nothing Then Throw New ArgumentNullException("info")
        _OneOverValue = CType(_OneOverValue.Create(info.GetDouble(SerialisationKey), _OneOverValue.DefaultUnit), T)
    End Sub

    Public Sub GetObjectData(info As SerializationInfo, context As StreamingContext) Implements ISerializable.GetObjectData
        If info Is Nothing Then Throw New ArgumentNullException("info")
        info.AddValue(SerialisationKey, _OneOverValue.GetValue(_OneOverValue.DefaultUnit))
    End Sub

End Structure