Option Strict On
Option Infer On

Partial Structure Volume

    Public Shared Function FromCubicMeters(d As Double) As Volume
        Return New Volume With {._MetersPow3 = d}
    End Function
    Public Shared Function FromCubicMeters(d As Double?) As Volume?
        If d.HasValue Then
            Return FromMetersPow3(d.Value)
        Else
            Return Nothing
        End If
    End Function
    Public ReadOnly Property CubicMeters() As Double
        Get
            Return _MetersPow3
        End Get
    End Property

End Structure