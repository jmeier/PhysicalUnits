Option Strict On
Option Infer On

Partial Structure Pressure

    Public Shared Function FromKilogramsPerSquarecentimeter(d As Double) As Pressure
        Return New Pressure With {.MyKilogramsPerSquarecentimeter = d}
    End Function
    Public Shared Function FromKilogramsPerSquarecentimeter(d As Double?) As Pressure?
        If d.HasValue Then
            Return FromKilogramsPerSquarecentimeter(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Pressure in kg/cm² </summary>
    Public ReadOnly Property KilogramsPerSquarecentimeter() As Double
        Get
            Return MyKilogramsPerSquarecentimeter
        End Get
    End Property
    Private Property MyKilogramsPerSquarecentimeter() As Double
        Get
            Return Me.Value(SupportedPressureUnits.KilogramsPerSquarecentimeter)
        End Get
        Set(value As Double)
            Me.Value(SupportedPressureUnits.KilogramsPerSquarecentimeter) = value
        End Set
    End Property

End Structure