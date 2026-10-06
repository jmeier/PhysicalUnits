Option Strict On
Option Infer On

Partial Structure TimesLength(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Shared Function FromTimesMeter(d As T) As TimesLength(Of T)
        Return New TimesLength(Of T) With {._ValueTimesMeter = d}
    End Function
    Public Shared Function FromTimesMeter(d As T?) As TimesLength(Of T)?
        If d.HasValue Then
            Return FromTimesMeter(d.Value)
        Else
            Return Nothing
        End If
    End Function

    Public ReadOnly Property ValueTimesMeter() As T
        Get
            Return _ValueTimesMeter
        End Get
    End Property
    Private _ValueTimesMeter As T

End Structure