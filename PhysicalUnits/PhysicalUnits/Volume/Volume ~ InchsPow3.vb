Option Strict On
Option Infer On

Partial Structure Volume

    Public Shared Function FromInchsPow3(d As Double) As Volume
        Return New Volume With {.MyInchsPow3 = d}
    End Function
    Public Shared Function FromInchsPow3(d As Double?) As Volume?
        If d.HasValue Then
            Return FromInchsPow3(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length to the third power in in^3 </summary>
    Public ReadOnly Property InchsPow3() As Double
        Get
            Return MyInchsPow3
        End Get
    End Property
    Private Property MyInchsPow3() As Double
        Get
            Return Me.Value(SupportedVolumeUnits.InchsPow3)
        End Get
        Set(value As Double)
            Me.Value(SupportedVolumeUnits.InchsPow3) = value
        End Set
    End Property

End Structure