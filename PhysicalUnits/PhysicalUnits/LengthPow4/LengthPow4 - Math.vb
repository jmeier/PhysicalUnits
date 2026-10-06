Option Strict On
Option Infer On

Partial Structure LengthPow4

    Public ReadOnly Property Sign() As Integer
        Get
            Return Math.Sign(Me._MetersPow4)
        End Get
    End Property

    Public Function Abs() As LengthPow4
        Return FromMetersPow4(Math.Abs(Me._MetersPow4))
    End Function

    Public Function Sqrt() As Area
        Return Area.FromSquareMeters(Math.Sqrt(Me._MetersPow4))
    End Function

    Public Shared Function Min(a As LengthPow4, b As LengthPow4) As LengthPow4
        If a._MetersPow4 < b._MetersPow4 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As LengthPow4, b As LengthPow4) As LengthPow4
        If a._MetersPow4 > b._MetersPow4 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As LengthPow4, b As LengthPow4, f As Double) As LengthPow4
        Return LengthPow4.FromMetersPow4(a._MetersPow4 + f * (b._MetersPow4 - a._MetersPow4))
    End Function

End Structure