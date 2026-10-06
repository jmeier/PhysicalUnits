Option Strict On
Option Infer On

Partial Structure Volume

    Public Shared Function FromCubicFeet(d As Double) As Volume
        Return FromFeetPow3(d)
    End Function
    Public Shared Function FromCubicFeet(d As Double?) As Volume?
        If d.HasValue Then
            Return FromFeetPow3(d.Value)
        Else
            Return Nothing
        End If
    End Function
    Public ReadOnly Property CubicFeet() As Double
        Get
            Return FeetPow3
        End Get
    End Property

End Structure