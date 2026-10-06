Option Strict On
Option Infer On

Partial Structure LengthPow4

    Public Shared Function FromInchsPow4(d As Double) As LengthPow4
        Return New LengthPow4 With {.MyInchsPow4 = d}
    End Function
    Public Shared Function FromInchsPow4(d As Double?) As LengthPow4?
        If d.HasValue Then
            Return FromInchsPow4(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length to the fourth power in in⁴ </summary>
    Public ReadOnly Property InchsPow4() As Double
        Get
            Return MyInchsPow4
        End Get
    End Property
    Private Property MyInchsPow4() As Double
        Get
            Return Me.Value(SupportedLengthPow4Units.InchsPow4)
        End Get
        Set(value As Double)
            Me.Value(SupportedLengthPow4Units.InchsPow4) = value
        End Set
    End Property

End Structure