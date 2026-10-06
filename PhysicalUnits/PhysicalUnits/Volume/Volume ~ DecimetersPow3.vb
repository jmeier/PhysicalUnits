Option Strict On
Option Infer On

Partial Structure Volume

    Public Shared Function FromDecimetersPow3(d As Double) As Volume
        Return New Volume With {.MyDecimetersPow3 = d}
    End Function
    Public Shared Function FromDecimetersPow3(d As Double?) As Volume?
        If d.HasValue Then
            Return FromDecimetersPow3(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length to the third power in dm³ </summary>
    Public ReadOnly Property DecimetersPow3() As Double
        Get
            Return MyDecimetersPow3
        End Get
    End Property
    Private Property MyDecimetersPow3() As Double
        Get
            Return Me.Value(SupportedVolumeUnits.DecimetersPow3)
        End Get
        Set(value As Double)
            Me.Value(SupportedVolumeUnits.DecimetersPow3) = value
        End Set
    End Property

End Structure