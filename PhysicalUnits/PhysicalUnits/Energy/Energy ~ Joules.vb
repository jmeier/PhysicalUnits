Option Strict On
Option Infer On

Partial Structure Energy

    Public Shared Function FromJoules(d As Double) As Energy
        Return New Energy With {._Joules = d}
    End Function
    Public Shared Function FromJoules(d As Double?) As Energy?
        If d.HasValue Then
            Return FromJoules(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Energy in J </summary>
    Public ReadOnly Property Joules() As Double
        Get
            Return _Joules
        End Get
    End Property
    Private _Joules As Double

End Structure