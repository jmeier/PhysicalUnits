Option Strict On
Option Infer On

Imports System.ComponentModel

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure Mass

    Public Sub New(unit As SupportedMassUnits, value As Double)
        Me.Value(unit) = value
    End Sub

    Private Property Value(unit As SupportedMassUnits) As Double
        Get
            Dim f = ConversionFactor(unit)
            Return Me._Kilograms * f
        End Get
        Set(value As Double)
            Dim f = ConversionFactor(unit)
            Me._Kilograms = value / f
        End Set
    End Property

End Structure