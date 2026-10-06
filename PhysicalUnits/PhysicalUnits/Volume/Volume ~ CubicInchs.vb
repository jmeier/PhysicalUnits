Option Strict On
Option Infer On

Partial Structure Volume

    Public Shared Function FromCubicInchs(d As Double) As Volume
        Return FromInchsPow3(d)
    End Function
    Public Shared Function FromCubicInchs(d As Double?) As Volume?
        If d.HasValue Then
            Return FromInchsPow3(d.Value)
        Else
            Return Nothing
        End If
    End Function
    Public ReadOnly Property CubicInchs() As Double
        Get
            Return InchsPow3
        End Get
    End Property

End Structure