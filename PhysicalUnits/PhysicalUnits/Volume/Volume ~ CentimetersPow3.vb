Option Strict On
Option Infer On

Partial Structure Volume

    Public Shared Function FromCentimetersPow3(d As Double) As Volume
        Return New Volume With {.MyCentimetersPow3 = d}
    End Function
    Public Shared Function FromCentimetersPow3(d As Double?) As Volume?
        If d.HasValue Then
            Return FromCentimetersPow3(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length to the third power in cm^3 </summary>
    Public ReadOnly Property CentimetersPow3() As Double
        Get
            Return MyCentimetersPow3
        End Get
    End Property
    Private Property MyCentimetersPow3() As Double
        Get
            Return Me.Value(SupportedVolumeUnits.CentimetersPow3)
        End Get
        Set(value As Double)
            Me.Value(SupportedVolumeUnits.CentimetersPow3) = value
        End Set
    End Property

End Structure