Option Strict On
Option Infer On

Imports System.ComponentModel

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure SoundPressure

    Public Sub New(unit As SupportedSoundPressureUnits, value As Double)
        Me.Value(unit) = value
    End Sub

    Private Property Value(unit As SupportedSoundPressureUnits) As Double
        Get
            Dim f = ConversionFactor(unit)
            Return Me._Decibel * f
        End Get
        Set(value As Double)
            Dim f = ConversionFactor(unit)
            Me._Decibel = value / f
        End Set
    End Property

End Structure