Option Strict On
Option Infer On

Partial Structure Mass

    Public ReadOnly Property Sign() As Integer
        Get
            Return Math.Sign(Me._Kilograms)
        End Get
    End Property

    Public Function Abs() As Mass
        Return FromKilograms(Math.Abs(Me._Kilograms))
    End Function

    Public Shared Function Min(a As Mass, b As Mass) As Mass
        If a < b Then
            Return a
        Else
            Return b
        End If
    End Function
    Public Shared Function Max(a As Mass, b As Mass) As Mass
        If a > b Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As Mass, b As Mass, f As Double) As Mass
        Return Mass.FromKilograms(a._Kilograms + f * (b._Kilograms - a._Kilograms))
    End Function

End Structure