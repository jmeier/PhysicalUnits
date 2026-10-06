Option Strict On
Option Infer On

Partial Structure PerLength(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Shared Function FromPerRunningMeter(d As T) As PerLength(Of T)
        Return New PerLength(Of T) With {._ValuePerRunningMeter = d}
    End Function
    Public Shared Function FromPerRunningMeter(d As T?) As PerLength(Of T)?
        If d.HasValue Then
            Return FromPerRunningMeter(d.Value)
        Else
            Return Nothing
        End If
    End Function

    Public ReadOnly Property ValuePerRunningMeter() As T
        Get
            Return _ValuePerRunningMeter
        End Get
    End Property
    Private _ValuePerRunningMeter As T

End Structure