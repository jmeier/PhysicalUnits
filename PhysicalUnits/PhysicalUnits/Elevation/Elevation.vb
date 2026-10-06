Option Strict On
Option Infer On

Imports System.ComponentModel

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure Elevation

    Public Sub New(unit As SupportedElevationUnits, value As Double)
        Me.Value(unit) = value
    End Sub

    Private Property Value(unit As SupportedElevationUnits) As Double
        Get
            Dim f = ConversionFactor(unit)
            Return Me._MetersAboveNN * f
        End Get
        Set(value As Double)
            Dim f = ConversionFactor(unit)
            Me._MetersAboveNN = value / f
        End Set
    End Property

End Structure