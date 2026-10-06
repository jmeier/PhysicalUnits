Option Strict On
Option Infer On

Imports System.ComponentModel

''' <summary>
''' Energy ≡ Mass · Length² / Time² ≡ Force · Length
''' </summary>
<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure Energy

    Public Sub New(unit As SupportedEnergyUnits, value As Double)
        Me.Value(unit) = value
    End Sub

    Private Property Value(unit As SupportedEnergyUnits) As Double
        Get
            Dim f = ConversionFactor(unit)
            Return Me._Joules * f
        End Get
        Set(value As Double)
            Dim f = ConversionFactor(unit)
            Me._Joules = value / f
        End Set
    End Property

End Structure