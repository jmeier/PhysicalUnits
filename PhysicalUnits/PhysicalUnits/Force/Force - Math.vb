Option Strict On
Option Infer On

Partial Structure Force

    Public ReadOnly Property Sign() As Integer
        Get
            Return Math.Sign(Me._Newtons)
        End Get
    End Property

    Public Function Abs() As Force
        Return FromNewtons(Math.Abs(Me._Newtons))
    End Function

    Public Shared Function Min(a As Force, b As Force) As Force
        If a._Newtons < b._Newtons Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As Force, b As Force) As Force
        If a._Newtons > b._Newtons Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As Force, b As Force, f As Double) As Force
        Return Force.FromNewtons(a._Newtons + f * (b._Newtons - a._Newtons))
    End Function

End Structure