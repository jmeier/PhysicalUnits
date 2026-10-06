Option Strict On
Option Infer On

Partial Structure PerTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Shared Function FromPerSecond(d As T) As PerTime(Of T)
        Return New PerTime(Of T) With {._ValuePerSecond = d}
    End Function
    Public Shared Function FromPerSecond(d As T?) As PerTime(Of T)?
        If d.HasValue Then
            Return FromPerSecond(d.Value)
        Else
            Return Nothing
        End If
    End Function

    Public ReadOnly Property ValuePerSecond() As T
        Get
            Return _ValuePerSecond
        End Get
    End Property
    Private _ValuePerSecond As T

End Structure