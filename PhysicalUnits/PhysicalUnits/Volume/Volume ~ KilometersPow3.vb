Option Strict On
Option Infer On

Partial Structure Volume

    Public Shared Function FromKilometersPow3(d As Double) As Volume
        Return New Volume With {.MyKilometersPow3 = d}
    End Function
    Public Shared Function FromKilometersPow3(d As Double?) As Volume?
        If d.HasValue Then
            Return FromKilometersPow3(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length to the third power in km^3 </summary>
    Public ReadOnly Property KilometersPow3() As Double
        Get
            Return MyKilometersPow3
        End Get
    End Property
    Private Property MyKilometersPow3() As Double
        Get
            Return Me.Value(SupportedVolumeUnits.KilometersPow3)
        End Get
        Set(value As Double)
            Me.Value(SupportedVolumeUnits.KilometersPow3) = value
        End Set
    End Property

End Structure