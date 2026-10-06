Option Strict On
Option Infer On

Partial Structure LengthPow4

    Public Shared Function FromFeetPow4(d As Double) As LengthPow4
        Return New LengthPow4 With {.MyFeetPow4 = d}
    End Function
    Public Shared Function FromFeetPow4(d As Double?) As LengthPow4?
        If d.HasValue Then
            Return FromFeetPow4(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length to the fourth power in ft⁴ </summary>
    Public ReadOnly Property FeetPow4() As Double
        Get
            Return MyFeetPow4
        End Get
    End Property
    Private Property MyFeetPow4() As Double
        Get
            Return Me.Value(SupportedLengthPow4Units.FeetPow4)
        End Get
        Set(value As Double)
            Me.Value(SupportedLengthPow4Units.FeetPow4) = value
        End Set
    End Property

End Structure