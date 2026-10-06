Option Strict On
Option Infer On

Partial Structure Pressure

    Public Shared Function FromGiganewtonsPerSquaremeter(d As Double) As Pressure
        Return New Pressure With {.MyGiganewtonsPerSquaremeter = d}
    End Function
    Public Shared Function FromGiganewtonsPerSquaremeter(d As Double?) As Pressure?
        If d.HasValue Then
            Return FromGiganewtonsPerSquaremeter(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Pressure in GN/m² </summary>
    Public ReadOnly Property GiganewtonsPerSquaremeter() As Double
        Get
            Return MyGiganewtonsPerSquaremeter
        End Get
    End Property
    Private Property MyGiganewtonsPerSquaremeter() As Double
        Get
            Return Me.Value(SupportedPressureUnits.GiganewtonsPerSquaremeter)
        End Get
        Set(value As Double)
            Me.Value(SupportedPressureUnits.GiganewtonsPerSquaremeter) = value
        End Set
    End Property

End Structure