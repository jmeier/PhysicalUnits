Option Strict On
Option Infer On

Imports System.ComponentModel
Imports System.Runtime.Serialization

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure Volume

    Public Sub New(unit As SupportedVolumeUnits, value As Double)
        Me.Value(unit) = value
    End Sub

    Private Property Value(unit As SupportedVolumeUnits) As Double
        Get
            Dim f = ConversionFactor(unit)
            Return Me._MetersPow3 * f
        End Get
        Set(value As Double)
            Dim f = ConversionFactor(unit)
            Me._MetersPow3 = value / f
        End Set
    End Property

End Structure