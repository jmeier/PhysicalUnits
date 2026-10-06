Option Strict On
Option Infer On

Partial Structure Temperature

    Private Shared ReadOnly KnownUnits As ObjectModel.ReadOnlyDictionary(Of SupportedTemperatureUnits, String()) = UnitExtensions.GetKnownUnitDictionary(Of SupportedTemperatureUnits)()

    Public Enum SupportedTemperatureUnits

        ''' <summary> Temperature in °K </summary>
        <UnitSymbol("°K")>
        Kelvin = 0

        ''' <summary> Temperature in °C </summary>
        <UnitSymbol("°C")>
        Celcius

        ''' <summary> Temperature in °F </summary>
        <UnitSymbol("°F")>
        Fahrenheit

        ''' <summary> Temperature in °R </summary>
        <UnitSymbol("°R")>
        Rankine

    End Enum

    Private Shared Function ConvertToKelvin(d As Double, unit As SupportedTemperatureUnits) As Double
        Select Case unit
            Case SupportedTemperatureUnits.Kelvin : Return d
            Case SupportedTemperatureUnits.Celcius : Return d - AbsoluteZeroCelcius
            Case SupportedTemperatureUnits.Fahrenheit : Return (d + 459.67) * 5 / 9
            Case SupportedTemperatureUnits.Rankine : Return d * 5 / 9
            Case Else : Throw New ArgumentOutOfRangeException("unit")
        End Select
    End Function

    Private Shared Function ConvertFromKelvin(d As Double, unit As SupportedTemperatureUnits) As Double
        Select Case unit
            Case SupportedTemperatureUnits.Kelvin : Return d
            Case SupportedTemperatureUnits.Celcius : Return d + AbsoluteZeroCelcius
            Case SupportedTemperatureUnits.Fahrenheit : Return d * 9 / 5 - 459.67
            Case SupportedTemperatureUnits.Rankine : Return d * 9 / 5
            Case Else : Throw New ArgumentOutOfRangeException("unit")
        End Select
    End Function
    Private Shared Function Convert(d As Double, [from] As SupportedTemperatureUnits, [to] As SupportedTemperatureUnits) As Double
        Dim t = ConvertToKelvin(d, [from])
        Return ConvertFromKelvin(t, [to])
    End Function

End Structure