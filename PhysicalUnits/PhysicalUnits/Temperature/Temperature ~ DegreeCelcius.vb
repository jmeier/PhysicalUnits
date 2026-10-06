Option Strict On
Option Infer On

Partial Structure Temperature

    Public Shared Function FromDegreeCelcius(d As Double) As Temperature
        Return New Temperature With {.MyDegreeCelcius = d}
    End Function
    Public Shared Function FromDegreeCelcius(d As Double?) As Temperature?
        If d.HasValue Then
            Return FromDegreeCelcius(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Temperature in °C </summary>
    Public ReadOnly Property DegreeCelcius() As Double
        Get
            Return MyDegreeCelcius
        End Get
    End Property
    Private Property MyDegreeCelcius() As Double
        Get
            Return Me.Value(SupportedTemperatureUnits.Celcius)
        End Get
        Set(value As Double)
            Me.Value(SupportedTemperatureUnits.Celcius) = value
        End Set
    End Property

End Structure