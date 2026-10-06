Option Strict On
Option Infer On

Partial Structure LengthPow4

    Public Shared Function FromYardsPow4(d As Double) As LengthPow4
        Return New LengthPow4 With {.MyYardsPow4 = d}
    End Function
    Public Shared Function FromYardsPow4(d As Double?) As LengthPow4?
        If d.HasValue Then
            Return FromYardsPow4(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length to the fourth power in yd⁴ </summary>
    Public ReadOnly Property YardsPow4() As Double
        Get
            Return MyYardsPow4
        End Get
    End Property
    Private Property MyYardsPow4() As Double
        Get
            Return Me.Value(SupportedLengthPow4Units.YardsPow4)
        End Get
        Set(value As Double)
            Me.Value(SupportedLengthPow4Units.YardsPow4) = value
        End Set
    End Property

End Structure