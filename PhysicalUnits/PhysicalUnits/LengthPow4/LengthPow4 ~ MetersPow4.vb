Option Strict On
Option Infer On

Partial Structure LengthPow4

    Public Shared Function FromMetersPow4(d As Double) As LengthPow4
        Return New LengthPow4 With {._MetersPow4 = d}
    End Function
    Public Shared Function FromMetersPow4(d As Double?) As LengthPow4?
        If d.HasValue Then
            Return FromMetersPow4(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length to the fourth power in m^4 </summary>
    Public ReadOnly Property MetersPow4() As Double
        Get
            Return _MetersPow4
        End Get
    End Property
    Private _MetersPow4 As Double

End Structure