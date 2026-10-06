Option Strict On
Option Infer On

Partial Structure Pressure

    Public Shared Function FromKilonewtonsPerSquaremeter(d As Double) As Pressure
        Return New Pressure With {.MyKilonewtonsPerSquaremeter = d}
    End Function
    Public Shared Function FromKilonewtonsPerSquaremeter(d As Double?) As Pressure?
        If d.HasValue Then
            Return FromKilonewtonsPerSquaremeter(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Pressure in kN/m² </summary>
    Public ReadOnly Property KilonewtonsPerSquaremeter() As Double
        Get
            Return MyKilonewtonsPerSquaremeter
        End Get
    End Property
    Private Property MyKilonewtonsPerSquaremeter() As Double
        Get
            Return Me.Value(SupportedPressureUnits.KilonewtonsPerSquaremeter)
        End Get
        Set(value As Double)
            Me.Value(SupportedPressureUnits.KilonewtonsPerSquaremeter) = value
        End Set
    End Property

End Structure