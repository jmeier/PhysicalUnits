Option Strict On
Option Infer On

Partial Structure Power

    Public ReadOnly Property Sign() As Integer
        Get
            Return Math.Sign(Me._Watts)
        End Get
    End Property

    Public Function Abs() As Power
        Return FromWatts(Math.Abs(Me._Watts))
    End Function

    Public Shared Function Min(a As Power, b As Power) As Power
        If a._Watts < b._Watts Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As Power, b As Power) As Power
        If a._Watts > b._Watts Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As Power, b As Power, f As Double) As Power
        Return Power.FromWatts(a._Watts + f * (b._Watts - a._Watts))
    End Function

End Structure