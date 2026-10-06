Option Strict On
Option Infer On

Imports System.ComponentModel

''' <summary>
''' Force (Force ≡ Mass · Length / Time²
''' </summary>
<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure Force

    Public Sub New(unit As SupportedForceUnits, value As Double)
        Me.Value(unit) = value
    End Sub

    Private Property Value(unit As SupportedForceUnits) As Double
        Get
            Dim f = ConversionFactor(unit)
            Return Me._Newtons * f
        End Get
        Set(value As Double)
            Dim f = ConversionFactor(unit)
            Me._Newtons = value / f
        End Set
    End Property

End Structure