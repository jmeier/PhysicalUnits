Option Strict On
Option Infer On

Imports System.ComponentModel

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure LengthPow4

    Public Sub New(unit As SupportedLengthPow4Units, value As Double)
        Me.Value(unit) = value
    End Sub

    Private Property Value(unit As SupportedLengthPow4Units) As Double
        Get
            Dim f = ConversionFactor(unit)
            Return Me._MetersPow4 * f
        End Get
        Set(value As Double)
            Dim f = ConversionFactor(unit)
            Me._MetersPow4 = value / f
        End Set
    End Property

End Structure