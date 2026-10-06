Option Strict On
Option Infer On

Partial Structure Intensity

    Public ReadOnly Property Sign() As Integer
        Get
            Return Math.Sign(Me._WattsPerSquaremeter)
        End Get
    End Property

    Public Function Abs() As Intensity
        Return FromWattsPerSquaremeter(Math.Abs(Me._WattsPerSquaremeter))
    End Function

    Public Shared Function Min(a As Intensity, b As Intensity) As Intensity
        If a._WattsPerSquaremeter < b._WattsPerSquaremeter Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As Intensity, b As Intensity) As Intensity
        If a._WattsPerSquaremeter > b._WattsPerSquaremeter Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As Intensity, b As Intensity, f As Double) As Intensity
        Return Intensity.FromWattsPerSquaremeter(a._WattsPerSquaremeter + f * (b._WattsPerSquaremeter - a._WattsPerSquaremeter))
    End Function

End Structure