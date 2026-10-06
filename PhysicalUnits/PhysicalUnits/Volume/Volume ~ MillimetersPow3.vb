Option Strict On
Option Infer On

Partial Structure Volume

    Public Shared Function FromMillimetersPow3(d As Double) As Volume
        Return New Volume With {.MyMillimetersPow3 = d}
    End Function
    Public Shared Function FromMillimetersPow3(d As Double?) As Volume?
        If d.HasValue Then
            Return FromMillimetersPow3(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length to the third power in mm^3 </summary>
    Public ReadOnly Property MillimetersPow3() As Double
        Get
            Return MyMillimetersPow3
        End Get
    End Property
    Private Property MyMillimetersPow3() As Double
        Get
            Return Me.Value(SupportedVolumeUnits.MillimetersPow3)
        End Get
        Set(value As Double)
            Me.Value(SupportedVolumeUnits.MillimetersPow3) = value
        End Set
    End Property

End Structure