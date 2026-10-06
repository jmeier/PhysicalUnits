Option Strict On
Option Infer On

Imports System.ComponentModel

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure Acceleration

    Public Sub New(unit As SupportedAccelerationUnits, value As Double)
        Me.Value(unit) = value
    End Sub

    Private Property Value(unit As SupportedAccelerationUnits) As Double
        Get
            Dim f = ConversionFactor(unit)
            Return Me._MetersPerSquareSecond * f
        End Get
        Set(value As Double)
            Dim f = ConversionFactor(unit)
            Me._MetersPerSquareSecond = value / f
        End Set
    End Property

End Structure