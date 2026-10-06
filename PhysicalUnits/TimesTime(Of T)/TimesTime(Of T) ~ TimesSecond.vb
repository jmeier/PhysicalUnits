Option Strict On
Option Infer On

Partial Structure TimesTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Shared Function FromTimesSecond(d As T) As TimesTime(Of T)
        Return New TimesTime(Of T) With {._ValueTimesSecond = d}
    End Function
    Public Shared Function FromTimesSecond(d As T?) As TimesTime(Of T)?
        If d.HasValue Then
            Return FromTimesSecond(d.Value)
        Else
            Return Nothing
        End If
    End Function

    Public ReadOnly Property ValueTimesSecond() As T
        Get
            Return _ValueTimesSecond
        End Get
    End Property
    Private _ValueTimesSecond As T

End Structure