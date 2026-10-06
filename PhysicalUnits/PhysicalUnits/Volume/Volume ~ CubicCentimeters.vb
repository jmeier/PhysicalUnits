Option Strict On
Option Infer On

Partial Structure Volume

    Public Shared Function FromCubicCentimeters(d As Double) As Volume
        Return FromCentimetersPow3(d)
    End Function
    Public Shared Function FromCubicCentimeters(d As Double?) As Volume?
        If d.HasValue Then
            Return FromCentimetersPow3(d.Value)
        Else
            Return Nothing
        End If
    End Function
    Public ReadOnly Property CubicCentimeters() As Double
        Get
            Return CentimetersPow3
        End Get
    End Property

End Structure