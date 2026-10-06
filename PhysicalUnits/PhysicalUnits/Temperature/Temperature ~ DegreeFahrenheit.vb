Option Strict On
Option Infer On

Partial Structure Temperature

    Public Shared Function FromDegreeFahrenheit(d As Double) As Temperature
        Return New Temperature With {.MyDegreeFahrenheit = d}
    End Function
    Public Shared Function FromDegreeFahrenheit(d As Double?) As Temperature?
        If d.HasValue Then
            Return FromDegreeFahrenheit(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Temperature in °F </summary>
    Public ReadOnly Property DegreeFahrenheit() As Double
        Get
            Return MyDegreeFahrenheit
        End Get
    End Property
    Private Property MyDegreeFahrenheit() As Double
        Get
            Return Me.Value(SupportedTemperatureUnits.Fahrenheit)
        End Get
        Set(value As Double)
            Me.Value(SupportedTemperatureUnits.Fahrenheit) = value
        End Set
    End Property

End Structure