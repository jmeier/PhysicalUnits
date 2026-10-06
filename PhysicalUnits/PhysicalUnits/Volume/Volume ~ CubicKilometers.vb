Option Strict On
Option Infer On

Partial Structure Volume

    Public Shared Function FromCubicKilometers(d As Double) As Volume
        Return FromKilometersPow3(d)
    End Function
    Public Shared Function FromCubicKilometers(d As Double?) As Volume?
        If d.HasValue Then
            Return FromKilometersPow3(d.Value)
        Else
            Return Nothing
        End If
    End Function
    Public ReadOnly Property CubicKilometers() As Double
        Get
            Return KilometersPow3
        End Get
    End Property

End Structure