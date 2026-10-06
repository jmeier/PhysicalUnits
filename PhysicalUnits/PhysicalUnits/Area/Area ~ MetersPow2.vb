Option Strict On
Option Infer On

Partial Structure Area

    Public Shared Function FromMetersPow2(d As Double) As Area
        Return New Area With {._MetersPow2 = d}
    End Function
    Public Shared Function FromMetersPow2(d As Double?) As Area?
        If d.HasValue Then
            Return FromMetersPow2(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length to the third power in m^2 </summary>
    Public ReadOnly Property MetersPow2() As Double
        Get
            Return _MetersPow2
        End Get
    End Property
    Private _MetersPow2 As Double

End Structure