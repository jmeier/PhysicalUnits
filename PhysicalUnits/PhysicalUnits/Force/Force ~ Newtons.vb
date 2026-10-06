Option Strict On
Option Infer On

Partial Structure Force

    Public Shared Function FromNewtons(d As Double) As Force
        Return New Force With {._Newtons = d}
    End Function
    Public Shared Function FromNewtons(d As Double?) As Force?
        If d.HasValue Then
            Return FromNewtons(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Force in N </summary>
    Public ReadOnly Property Newtons() As Double
        Get
            Return _Newtons
        End Get
    End Property
    Private _Newtons As Double

End Structure