Option Strict On
Option Infer On

Imports System.Runtime.Serialization

Partial Structure TimesTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})
    Implements ISerializable

    Private Const SerialisationKey = "value"

    <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
    Sub New(info As SerializationInfo, context As StreamingContext)
        If info Is Nothing Then Throw New ArgumentNullException("info")
        _ValueTimesSecond = CType(_ValueTimesSecond.Create(info.GetDouble(SerialisationKey), _ValueTimesSecond.DefaultUnit), T)
    End Sub

    Public Sub GetObjectData(info As SerializationInfo, context As StreamingContext) Implements ISerializable.GetObjectData
        If info Is Nothing Then Throw New ArgumentNullException("info")
        info.AddValue(SerialisationKey, _ValueTimesSecond.GetValue(_ValueTimesSecond.DefaultUnit))
    End Sub

End Structure