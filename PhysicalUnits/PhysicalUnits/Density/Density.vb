Option Strict On
Option Infer On

Imports System.ComponentModel

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure Density

    Public Sub New(unit As SupportedDensityUnits, value As Double)
        Me.Value(unit) = value
    End Sub

    Private Property Value(unit As SupportedDensityUnits) As Double
        Get
            Dim f = ConversionFactor(unit)
            Return Me._KilogramsPerCubicmeter * f
        End Get
        Set(value As Double)
            Dim f = ConversionFactor(unit)
            Me._KilogramsPerCubicmeter = value / f
        End Set
    End Property

End Structure