Option Strict On
Option Infer On

Partial Structure Volume

    Public Shared Function FromFeetPow3(d As Double) As Volume
        Return New Volume With {.MyFeetPow3 = d}
    End Function
    Public Shared Function FromFeetPow3(d As Double?) As Volume?
        If d.HasValue Then
            Return FromFeetPow3(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length to the third power in ft^3 </summary>
    Public ReadOnly Property FeetPow3() As Double
        Get
            Return MyFeetPow3
        End Get
    End Property
    Private Property MyFeetPow3() As Double
        Get
            Return Me.Value(SupportedVolumeUnits.FeetPow3)
        End Get
        Set(value As Double)
            Me.Value(SupportedVolumeUnits.FeetPow3) = value
        End Set
    End Property

End Structure