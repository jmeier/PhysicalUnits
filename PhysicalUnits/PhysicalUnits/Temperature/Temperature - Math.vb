Option Strict On
Option Infer On

Partial Structure Temperature

    'Public ReadOnly Property Sign() As Integer
    '    Get
    '        Return Math.Sign(Me._Kelvin)
    '    End Get
    'End Property

    'Public Function Abs() As Temperature
    '    Return FromSquaremeters(Math.Abs(Me._Kelvin))
    'End Function

    Public Shared Function Min(a As Temperature, b As Temperature) As Temperature
        If a._Kelvin < b._Kelvin Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As Temperature, b As Temperature) As Temperature
        If a._Kelvin > b._Kelvin Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As Temperature, b As Temperature, f As Double) As Temperature
        Return Temperature.FromKelvin(a._Kelvin + f * (b._Kelvin - a._Kelvin))
    End Function

End Structure