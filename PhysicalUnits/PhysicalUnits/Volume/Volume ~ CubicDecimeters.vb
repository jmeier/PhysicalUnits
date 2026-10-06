Option Strict On
Option Infer On

Partial Structure Volume

    Public Shared Function FromCubicDecimeters(d As Double) As Volume
        Return FromDecimetersPow3(d)
    End Function
    Public Shared Function FromCubicDecimeters(d As Double?) As Volume?
        If d.HasValue Then
            Return FromDecimetersPow3(d.Value)
        Else
            Return Nothing
        End If
    End Function
    Public ReadOnly Property CubicDecimeters() As Double
        Get
            Return DecimetersPow3
        End Get
    End Property

End Structure