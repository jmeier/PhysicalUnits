Option Strict On
Option Infer On

Partial Structure Volume

    Public Shared Function FromMetersPow3(d As Double) As Volume
        Return New Volume With {._MetersPow3 = d}
    End Function
    Public Shared Function FromMetersPow3(d As Double?) As Volume?
        If d.HasValue Then
            Return FromMetersPow3(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length to the third power in m^3 </summary>
    Public ReadOnly Property MetersPow3() As Double
        Get
            Return _MetersPow3
        End Get
    End Property
    Private _MetersPow3 As Double

End Structure