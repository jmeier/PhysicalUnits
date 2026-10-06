Option Strict On
Option Infer On

Partial Structure PerArea(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Shared Function FromPerSquaremeter(d As T) As PerArea(Of T)
        Return New PerArea(Of T) With {._ValuePerSquaremeter = d}
    End Function
    Public Shared Function FromPerSquaremeter(d As T?) As PerArea(Of T)?
        If d.HasValue Then
            Return FromPerSquaremeter(d.Value)
        Else
            Return Nothing
        End If
    End Function

    Public ReadOnly Property ValuePerSquaremeter() As T
        Get
            Return _ValuePerSquaremeter
        End Get
    End Property
    Private _ValuePerSquaremeter As T

End Structure