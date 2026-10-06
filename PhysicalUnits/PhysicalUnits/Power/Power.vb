Option Strict On
Option Infer On

Imports System.ComponentModel

''' <summary>
''' Power (base unit: Watt)
''' 1 W = 1 J / s
''' </summary>
<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure Power

    Public Sub New(unit As SupportedPowerUnits, value As Double)
        Me.Value(unit) = value
    End Sub

    Private Property Value(unit As SupportedPowerUnits) As Double
        Get
            Dim f = ConversionFactor(unit)
            Return Me._Watts * f
        End Get
        Set(value As Double)
            Dim f = ConversionFactor(unit)
            Me._Watts = value / f
        End Set
    End Property

End Structure