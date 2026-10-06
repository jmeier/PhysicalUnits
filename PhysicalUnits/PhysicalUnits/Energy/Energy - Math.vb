Option Strict On
Option Infer On

Partial Structure Energy

    Public ReadOnly Property Sign() As Integer
        Get
            Return Math.Sign(Me._Joules)
        End Get
    End Property

    Public Function Abs() As Energy
        Return New Energy With {._Joules = Math.Abs(_Joules)}
    End Function

    Public Shared Function Min(a As Energy, b As Energy) As Energy
        If a._Joules < b._Joules Then
            Return a
        Else
            Return b
        End If
    End Function
    Public Shared Function Max(a As Energy, b As Energy) As Energy
        If a._Joules > b._Joules Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As Energy, b As Energy, f As Double) As Energy
        Return Energy.FromJoules(a._Joules + f * (b._Joules - a._Joules))
    End Function

End Structure