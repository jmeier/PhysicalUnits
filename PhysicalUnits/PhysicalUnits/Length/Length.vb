Option Strict On
Option Infer On

Imports System.ComponentModel

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure Length

    Public Sub New(unit As SupportedLengthUnits, value As Double)
        Me.Value(unit) = value
    End Sub

    Private Property Value(unit As SupportedLengthUnits) As Double
        Get
            Dim f = ConversionFactor(unit)
            Return Me._Meters * f
        End Get
        Set(value As Double)
            Dim f = ConversionFactor(unit)
            Me._Meters = value / f
        End Set
    End Property

End Structure