Option Strict On
Option Infer On

Partial Structure SoundPressure

    Public ReadOnly Property Sign() As Integer
        Get
            Return Math.Sign(Me._Decibel)
        End Get
    End Property

    Public Function Abs() As SoundPressure
        Return FromDecibel(Math.Abs(Me._Decibel))
    End Function

    Public Shared Function Min(a As SoundPressure, b As SoundPressure) As SoundPressure
        If a._Decibel < b._Decibel Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As SoundPressure, b As SoundPressure) As SoundPressure
        If a._Decibel > b._Decibel Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As SoundPressure, b As SoundPressure, f As Double) As SoundPressure
        Return SoundPressure.FromDecibel(a._Decibel + f * (b._Decibel - a._Decibel))
    End Function

End Structure