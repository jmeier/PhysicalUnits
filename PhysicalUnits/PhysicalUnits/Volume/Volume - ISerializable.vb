Option Strict On
Option Infer On

Imports System.Runtime.Serialization

Partial Structure Volume
    Implements ISerializable

    Private Const SerialisationKey = "value"

    <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
    Sub New(info As SerializationInfo, context As StreamingContext)
        If info Is Nothing Then Throw New ArgumentNullException(NameOf(info))
        _MetersPow3 = info.GetDouble(SerialisationKey)
    End Sub

    Public Sub GetObjectData(info As SerializationInfo, context As StreamingContext) Implements ISerializable.GetObjectData
        If info Is Nothing Then Throw New ArgumentNullException(NameOf(info))
        info.AddValue(SerialisationKey, _MetersPow3)
    End Sub


End Structure