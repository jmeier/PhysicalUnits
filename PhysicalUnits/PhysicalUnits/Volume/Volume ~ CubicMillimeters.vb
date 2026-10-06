Option Strict On
Option Infer On

Partial Structure Volume

    Public Shared Function FromCubicMillimeters(d As Double) As Volume
        Return FromMillimetersPow3(d)
    End Function
    Public Shared Function FromCubicMillimeters(d As Double?) As Volume?
        If d.HasValue Then
            Return FromMillimetersPow3(d.Value)
        Else
            Return Nothing
        End If
    End Function
    Public ReadOnly Property CubicMillimeters() As Double
        Get
            Return MillimetersPow3
        End Get
    End Property

End Structure