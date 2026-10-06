Option Strict On
Option Infer On

Partial Structure Density

    Public ReadOnly Property Sign() As Integer
        Get
            Return Math.Sign(Me._KilogramsPerCubicmeter)
        End Get
    End Property

    Public Function Abs() As Density
        Return FromKilogramsPerCubicmeter(Math.Abs(Me._KilogramsPerCubicmeter))
    End Function

    Public Shared Function Min(a As Density, b As Density) As Density
        If a._KilogramsPerCubicmeter < b._KilogramsPerCubicmeter Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As Density, b As Density) As Density
        If a._KilogramsPerCubicmeter > b._KilogramsPerCubicmeter Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As Density, b As Density, f As Double) As Density
        Return Density.FromKilogramsPerCubicmeter(a._KilogramsPerCubicmeter + f * (b._KilogramsPerCubicmeter - a._KilogramsPerCubicmeter))
    End Function

End Structure