Option Strict On
Option Infer On

Partial Structure TimesArea(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Shared Function FromTimesSquareMeter(d As T) As TimesArea(Of T)
        Return New TimesArea(Of T) With {._ValueTimesSquareMeter = d}
    End Function
    Public Shared Function FromTimesSquareMeter(d As T?) As TimesArea(Of T)?
        If d.HasValue Then
            Return FromTimesSquareMeter(d.Value)
        Else
            Return Nothing
        End If
    End Function

    Public ReadOnly Property ValueTimesSquareMeter() As T
        Get
            Return _ValueTimesSquareMeter
        End Get
    End Property
    Private _ValueTimesSquareMeter As T

End Structure