Option Strict On
Option Infer On

Partial Structure LengthPow4

    Public Shared Function FromKilometersPow4(d As Double) As LengthPow4
        Return New LengthPow4 With {.MyKilometersPow4 = d}
    End Function
    Public Shared Function FromKilometersPow4(d As Double?) As LengthPow4?
        If d.HasValue Then
            Return FromKilometersPow4(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length to the fourth power in km⁴ </summary>
    Public ReadOnly Property KilometersPow4() As Double
        Get
            Return MyKilometersPow4
        End Get
    End Property
    Private Property MyKilometersPow4() As Double
        Get
            Return Me.Value(SupportedLengthPow4Units.KilometersPow4)
        End Get
        Set(value As Double)
            Me.Value(SupportedLengthPow4Units.KilometersPow4) = value
        End Set
    End Property

End Structure