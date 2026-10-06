Option Strict On
Option Infer On

Partial Structure LengthPow4

    Public Shared Function FromMillimetersPow4(d As Double) As LengthPow4
        Return New LengthPow4 With {.MyMillimetersPow4 = d}
    End Function
    Public Shared Function FromMillimetersPow4(d As Double?) As LengthPow4?
        If d.HasValue Then
            Return FromMillimetersPow4(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length to the fourth power in mm⁴ </summary>
    Public ReadOnly Property MillimetersPow4() As Double
        Get
            Return MyMillimetersPow4
        End Get
    End Property
    Private Property MyMillimetersPow4() As Double
        Get
            Return Me.Value(SupportedLengthPow4Units.MillimetersPow4)
        End Get
        Set(value As Double)
            Me.Value(SupportedLengthPow4Units.MillimetersPow4) = value
        End Set
    End Property

End Structure