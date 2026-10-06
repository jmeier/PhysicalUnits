Option Strict On
Option Infer On

Partial Structure Length

    Public ReadOnly Property Sign() As Integer
        Get
            Return Math.Sign(Me._Meters)
        End Get
    End Property

    Public Function Abs() As Length
        Return FromMeters(Math.Abs(Me._Meters))
    End Function

    Public Function Pow2() As Area
        Return Area.FromSquaremeters(Me.Meters ^ 2)
    End Function

    Public Function Pow3() As Volume
        Return Volume.FromMetersPow3(Me.Meters ^ 3)
    End Function

    Public Function Pow4() As LengthPow4
        Return LengthPow4.FromMetersPow4(Me.Meters ^ 4)
    End Function

    Public Shared Function Min(a As Length, b As Length) As Length
        If a._Meters < b._Meters Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As Length, b As Length) As Length
        If a._Meters > b._Meters Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As Length, b As Length, f As Double) As Length
        Return Length.FromMeters(a._Meters + f * (b._Meters - a._Meters))
    End Function

End Structure