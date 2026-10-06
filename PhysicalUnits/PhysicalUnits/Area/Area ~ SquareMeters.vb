Option Strict On
Option Infer On

Partial Structure Area

    Public Shared Function FromSquareMeters(d As Double) As Area
        Return New Area With {._MetersPow2 = d}
    End Function
    Public Shared Function FromSquaremeters(d As Double?) As Area?
        If d.HasValue Then
            Return FromSquareMeters(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Area in m² </summary>
    Public ReadOnly Property SquareMeters() As Double
        Get
            Return _MetersPow2
        End Get
    End Property

End Structure