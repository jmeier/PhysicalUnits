Option Strict On
Option Infer On

Partial Structure Elevation

    Public ReadOnly Property Sign() As Integer
        Get
            Return Math.Sign(Me._MetersAboveNN)
        End Get
    End Property

    Public Function Abs() As Elevation
        Return FromMetersAboveNN(Math.Abs(Me._MetersAboveNN))
    End Function

    Public Shared Function Min(a As Elevation, b As Elevation) As Elevation
        If a._MetersAboveNN < b._MetersAboveNN Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As Elevation, b As Elevation) As Elevation
        If a._MetersAboveNN > b._MetersAboveNN Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As Elevation, b As Elevation, f As Double) As Elevation
        Return Elevation.FromMetersAboveNN(a._MetersAboveNN + f * (b._MetersAboveNN - a._MetersAboveNN))
    End Function

End Structure