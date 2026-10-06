Option Strict On
Option Infer On

Partial Structure Frequency

    Public ReadOnly Property Sign() As Integer
        Get
            Return Math.Sign(Me._Hertz)
        End Get
    End Property

    Public Function Abs() As Frequency
        Return FromHertz(Math.Abs(Me._Hertz))
    End Function

    Public Shared Function Min(a As Frequency, b As Frequency) As Frequency
        If a._Hertz < b._Hertz Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As Frequency, b As Frequency) As Frequency
        If a._Hertz > b._Hertz Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As Frequency, b As Frequency, f As Double) As Frequency
        Return Frequency.FromHertz(a._Hertz + f * (b._Hertz - a._Hertz))
    End Function

End Structure