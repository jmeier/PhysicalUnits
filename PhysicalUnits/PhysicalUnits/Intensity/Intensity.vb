Option Strict On
Option Infer On

Imports System.ComponentModel

''' <summary>
''' Intensity in W / Length²
''' </summary>
<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure Intensity

    Public Sub New(unit As SupportedIntensityUnits, value As Double)
        Me.Value(unit) = value
    End Sub

    Private Property Value(unit As SupportedIntensityUnits) As Double
        Get
            Dim f = ConversionFactor(unit)
            Return Me._WattsPerSquaremeter * f
        End Get
        Set(value As Double)
            Dim f = ConversionFactor(unit)
            Me._WattsPerSquaremeter = value / f
        End Set
    End Property

End Structure