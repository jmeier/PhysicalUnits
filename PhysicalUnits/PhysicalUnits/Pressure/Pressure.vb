Option Strict On
Option Infer On

Imports System.ComponentModel

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure Pressure

    Public Sub New(unit As SupportedPressureUnits, value As Double)
        Me.Value(unit) = value
    End Sub

    Public Property Value(unit As SupportedPressureUnits) As Double
        Get
            If unit = SupportedPressureUnits.NewtonsPerSquaremeter Then
                Return Me._NewtonsPerSquaremeter
            End If
            Dim f = ConversionFactor(unit)
            Return Me._NewtonsPerSquaremeter * f
        End Get
        Set(value As Double)
            If unit = SupportedPressureUnits.NewtonsPerSquaremeter Then
                Me._NewtonsPerSquaremeter = value
            Else
                Dim f = ConversionFactor(unit)
                Me._NewtonsPerSquaremeter = value / f
            End If
        End Set
    End Property

End Structure