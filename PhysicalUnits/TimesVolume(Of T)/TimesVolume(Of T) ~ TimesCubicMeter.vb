Option Strict On
Option Infer On

Partial Structure TimesVolume(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Shared Function FromTimesCubicMeter(d As T) As TimesVolume(Of T)
        Return New TimesVolume(Of T) With {._ValueTimesCubicMeter = d}
    End Function
    Public Shared Function FromTimesCubicMeter(d As T?) As TimesVolume(Of T)?
        If d.HasValue Then
            Return FromTimesCubicMeter(d.Value)
        Else
            Return Nothing
        End If
    End Function

    Public ReadOnly Property ValueTimesCubicMeter() As T
        Get
            Return _ValueTimesCubicMeter
        End Get
    End Property
    Private _ValueTimesCubicMeter As T

End Structure