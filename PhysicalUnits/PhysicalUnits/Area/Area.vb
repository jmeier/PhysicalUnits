Option Strict On
Option Infer On

Imports System.ComponentModel

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure Area

    Public Sub New(unit As SupportedAreaUnits, value As Double)
        Me.Value(unit) = value
    End Sub

    Private Property Value(unit As SupportedAreaUnits) As Double
        Get
            Dim f = ConversionFactor(unit)
            Return Me._MetersPow2 * f
        End Get
        Set(value As Double)
            Dim f = ConversionFactor(unit)
            Me._MetersPow2 = value / f
        End Set
    End Property

End Structure