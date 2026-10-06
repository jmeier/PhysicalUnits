Option Strict On
Option Infer On

Partial Structure Volume

    Public ReadOnly Property Sign() As Integer
        Get
            Return Math.Sign(Me._MetersPow3)
        End Get
    End Property

    Public Function Abs() As Volume
        Return FromMetersPow3(Math.Abs(Me._MetersPow3))
    End Function

    Public Shared Function Min(a As Volume, b As Volume) As Volume
        If a._MetersPow3 < b._MetersPow3 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As Volume, b As Volume) As Volume
        If a._MetersPow3 > b._MetersPow3 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As Volume, b As Volume, f As Double) As Volume
        Return Volume.FromMetersPow3(a._MetersPow3 + f * (b._MetersPow3 - a._MetersPow3))
    End Function

End Structure