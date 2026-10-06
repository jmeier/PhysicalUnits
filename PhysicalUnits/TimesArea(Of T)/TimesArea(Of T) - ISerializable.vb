Option Strict On
Option Infer On

Imports System.Runtime.Serialization

Partial Structure TimesArea(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})
    Implements ISerializable

    Private Const SerialisationKey = "value"

    <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
    Sub New(info As SerializationInfo, context As StreamingContext)
        If info Is Nothing Then Throw New ArgumentNullException("info")
        _ValueTimesSquareMeter = CType(_ValueTimesSquareMeter.Create(info.GetDouble(SerialisationKey), _ValueTimesSquareMeter.DefaultUnit), T)
    End Sub

    Public Sub GetObjectData(info As SerializationInfo, context As StreamingContext) Implements ISerializable.GetObjectData
        If info Is Nothing Then Throw New ArgumentNullException("info")
        info.AddValue(SerialisationKey, _ValueTimesSquareMeter.GetValue(_ValueTimesSquareMeter.DefaultUnit))
    End Sub

End Structure