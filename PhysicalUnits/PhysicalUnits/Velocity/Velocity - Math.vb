Option Strict On
Option Infer On

Partial Structure Velocity

    Public ReadOnly Property Sign() As Integer
        Get
            Return Math.Sign(Me._MetersPerSecond)
        End Get
    End Property

    Public Function Abs() As Velocity
        Return FromMetersPerSecond(Math.Abs(Me._MetersPerSecond))
    End Function

    Public Shared Function Min(a As Velocity, b As Velocity) As Velocity
        If a._MetersPerSecond < b._MetersPerSecond Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As Velocity, b As Velocity) As Velocity
        If a._MetersPerSecond > b._MetersPerSecond Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As Velocity, b As Velocity, f As Double) As Velocity
        Return Velocity.FromMetersPerSecond(a._MetersPerSecond + f * (b._MetersPerSecond - a._MetersPerSecond))
    End Function

End Structure