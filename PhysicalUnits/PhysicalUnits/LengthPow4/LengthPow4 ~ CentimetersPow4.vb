Option Strict On
Option Infer On

Partial Structure LengthPow4

    Public Shared Function FromCentimetersPow4(d As Double) As LengthPow4
        Return New LengthPow4 With {.MyCentimetersPow4 = d}
    End Function
    Public Shared Function FromCentimetersPow4(d As Double?) As LengthPow4?
        If d.HasValue Then
            Return FromCentimetersPow4(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length to the fourth power in cm⁴ </summary>
    Public ReadOnly Property CentimetersPow4() As Double
        Get
            Return MyCentimetersPow4
        End Get
    End Property
    Private Property MyCentimetersPow4() As Double
        Get
            Return Me.Value(SupportedLengthPow4Units.CentimetersPow4)
        End Get
        Set(value As Double)
            Me.Value(SupportedLengthPow4Units.CentimetersPow4) = value
        End Set
    End Property

End Structure