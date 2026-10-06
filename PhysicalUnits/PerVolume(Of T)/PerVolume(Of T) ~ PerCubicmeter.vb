Option Strict On
Option Infer On

Partial Structure PerVolume(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Shared Function FromPerCubicmeter(d As T) As PerVolume(Of T)
        Return New PerVolume(Of T) With {._ValuePerCubicemeter = d}
    End Function
    Public Shared Function FromPerCubicmeter(d As T?) As PerVolume(Of T)?
        If d.HasValue Then
            Return FromPerCubicmeter(d.Value)
        Else
            Return Nothing
        End If
    End Function

    Public ReadOnly Property ValuePerCubicmeter() As T
        Get
            Return _ValuePerCubicemeter
        End Get
    End Property
    Private _ValuePerCubicemeter As T

End Structure