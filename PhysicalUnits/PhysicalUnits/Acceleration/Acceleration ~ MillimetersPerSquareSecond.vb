Option Strict On
Option Infer On

Partial Structure Acceleration

    Public Shared Function FromMillimetersPerSquareSecond(d As Double) As Acceleration
        Return New Acceleration With {.MyMillimetersPerSquareSeconds = d}
    End Function
    Public Shared Function FromMillimetersPerSquareSecond(d As Double?) As Acceleration?
        If d.HasValue Then
            Return FromMillimetersPerSquareSecond(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Acceleration in mm/s² </summary>
    Public ReadOnly Property MillimetersPerSquareSecond() As Double
        Get
            Return MyMillimetersPerSquareSeconds
        End Get
    End Property
    Private Property MyMillimetersPerSquareSeconds() As Double
        Get
            Return Me.Value(SupportedAccelerationUnits.MillimetersPerSquareSecond)
        End Get
        Set(value As Double)
            Me.Value(SupportedAccelerationUnits.MillimetersPerSquareSecond) = value
        End Set
    End Property

End Structure