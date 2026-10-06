Option Strict On
Option Infer On

Partial Structure Volume

    Public Shared Function FromYardsPow3(d As Double) As Volume
        Return New Volume With {.MyYardsPow3 = d}
    End Function
    Public Shared Function FromYardsPow3(d As Double?) As Volume?
        If d.HasValue Then
            Return FromYardsPow3(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length to the third power in yd^3 </summary>
    Public ReadOnly Property YardsPow3() As Double
        Get
            Return MyYardsPow3
        End Get
    End Property
    Private Property MyYardsPow3() As Double
        Get
            Return Me.Value(SupportedVolumeUnits.YardsPow3)
        End Get
        Set(value As Double)
            Me.Value(SupportedVolumeUnits.YardsPow3) = value
        End Set
    End Property

End Structure