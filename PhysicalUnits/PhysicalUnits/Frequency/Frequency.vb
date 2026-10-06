Option Strict On
Option Infer On

Imports System.ComponentModel

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure Frequency

    Public Sub New(unit As SupportedFrequencyUnits, value As Double)
        Me.Value(unit) = value
    End Sub

    Private Property Value(unit As SupportedFrequencyUnits) As Double
        Get
            Dim f = ConversionFactor(unit)
            Return Me._Hertz * f
        End Get
        Set(value As Double)
            Dim f = ConversionFactor(unit)
            Me._Hertz = value / f
        End Set
    End Property

End Structure