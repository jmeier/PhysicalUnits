Option Strict On
Option Infer On

Imports System.ComponentModel

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure Temperature

    Public Sub New(unit As SupportedTemperatureUnits, value As Double)
        Me.Value(unit) = value
    End Sub

    Private Property Value(unit As SupportedTemperatureUnits) As Double
        Get
            Return ConvertFromKelvin(Me._Kelvin, unit)
        End Get
        Set(value As Double)
            Me._Kelvin = ConvertToKelvin(value, unit)
        End Set
    End Property

End Structure