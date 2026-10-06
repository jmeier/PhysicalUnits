Option Strict On
Option Infer On

Partial Structure Pressure

    Public ReadOnly Property Sign() As Integer
        Get
            Return Math.Sign(Me._NewtonsPerSquaremeter)
        End Get
    End Property

    Public Function Abs() As Pressure
        Return FromNewtonsPerSquaremeter(Math.Abs(Me._NewtonsPerSquaremeter))
    End Function

    Public Shared Function Min(a As Pressure, b As Pressure) As Pressure
        If a._NewtonsPerSquaremeter < b._NewtonsPerSquaremeter Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As Pressure, b As Pressure) As Pressure
        If a._NewtonsPerSquaremeter > b._NewtonsPerSquaremeter Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As Pressure, b As Pressure, f As Double) As Pressure
        Return Pressure.FromNewtonsPerSquaremeter(a._NewtonsPerSquaremeter + f * (b._NewtonsPerSquaremeter - a._NewtonsPerSquaremeter))
    End Function

End Structure