Option Strict On
Option Infer On

Partial Structure LengthPow4

    Public Shared Function FromDecimetersPow4(d As Double) As LengthPow4
        Return New LengthPow4 With {.MyDecimetersPow4 = d}
    End Function
    Public Shared Function FromDecimetersPow4(d As Double?) As LengthPow4?
        If d.HasValue Then
            Return FromDecimetersPow4(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length to the fourth power in dm⁴ </summary>
    Public ReadOnly Property DecimetersPow4() As Double
        Get
            Return MyDecimetersPow4
        End Get
    End Property
    Private Property MyDecimetersPow4() As Double
        Get
            Return Me.Value(SupportedLengthPow4Units.DecimetersPow4)
        End Get
        Set(value As Double)
            Me.Value(SupportedLengthPow4Units.DecimetersPow4) = value
        End Set
    End Property


End Structure