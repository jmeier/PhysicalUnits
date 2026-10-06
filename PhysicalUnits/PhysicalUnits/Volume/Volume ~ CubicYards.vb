Option Strict On
Option Infer On

Partial Structure Volume

    Public Shared Function FromCubicYards(d As Double) As Volume
        Return FromYardsPow3(d)
    End Function
    Public Shared Function FromCubicYards(d As Double?) As Volume?
        If d.HasValue Then
            Return FromYardsPow3(d.Value)
        Else
            Return Nothing
        End If
    End Function
    Public ReadOnly Property CubicYards() As Double
        Get
            Return YardsPow3
        End Get
    End Property

End Structure