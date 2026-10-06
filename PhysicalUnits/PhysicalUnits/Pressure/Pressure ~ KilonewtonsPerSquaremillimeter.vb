Option Strict On
Option Infer On

Partial Structure Pressure

    Shared Function FromKilonewtonsPerSquaremillimeter(d As Double) As Pressure
        Return New Pressure With {.MyKilonewtonsPerSquaremillimeter = d}
    End Function
    Public Shared Function FromKilonewtonsPerSquaremillimeter(d As Double?) As Pressure?
        If d.HasValue Then
            Return FromKilonewtonsPerSquaremillimeter(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Pressure in kN/mm² </summary>
    Public ReadOnly Property KilonewtonsPerSquaremillimeter() As Double
        Get
            Return MyKilonewtonsPerSquaremillimeter
        End Get
    End Property
    Private Property MyKilonewtonsPerSquaremillimeter() As Double
        Get
            Return Me.Value(SupportedPressureUnits.KilonewtonsPerSquaremillimeter)
        End Get
        Set(value As Double)
            Me.Value(SupportedPressureUnits.KilonewtonsPerSquaremillimeter) = value
        End Set
    End Property

End Structure