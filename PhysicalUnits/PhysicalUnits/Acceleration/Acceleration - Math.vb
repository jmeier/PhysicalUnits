Option Strict On
Option Infer On

Partial Structure Acceleration

    Public ReadOnly Property Sign() As Integer
        Get
            Return Math.Sign(Me._MetersPerSquareSecond)
        End Get
    End Property

    Public Function Abs() As Acceleration
        Return FromMetersPerSquareSecond(Math.Abs(Me._MetersPerSquareSecond))
    End Function

    Public Shared Function Min(a As Acceleration, b As Acceleration) As Acceleration
        If a._MetersPerSquareSecond < b._MetersPerSquareSecond Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As Acceleration, b As Acceleration) As Acceleration
        If a._MetersPerSquareSecond > b._MetersPerSquareSecond Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As Acceleration, b As Acceleration, f As Double) As Acceleration
        Return Acceleration.FromMetersPerSquaresecond(a._MetersPerSquareSecond + f * (b._MetersPerSquareSecond - a._MetersPerSquareSecond))
    End Function

End Structure