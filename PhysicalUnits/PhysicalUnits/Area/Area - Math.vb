Option Strict On
Option Infer On

Partial Structure Area

    Public ReadOnly Property Sign() As Integer
        Get
            Return Math.Sign(Me._MetersPow2)
        End Get
    End Property

    Public Function Abs() As Area
        Return FromSquaremeters(Math.Abs(Me._MetersPow2))
    End Function

    Public Function Pow2() As LengthPow4
        Return LengthPow4.FromMetersPow4(Me.Squaremeters ^ 2)
    End Function

    Public Function Sqrt() As Length
        Return Length.FromMeters(Math.Sqrt(Me._MetersPow2))
    End Function

    Public Shared Function Min(a As Area, b As Area) As Area
        If a._MetersPow2 < b._MetersPow2 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As Area, b As Area) As Area
        If a._MetersPow2 > b._MetersPow2 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As Area, b As Area, f As Double) As Area
        Return Area.FromMetersPow2(a._MetersPow2 + f * (b._MetersPow2 - a._MetersPow2))
    End Function

End Structure