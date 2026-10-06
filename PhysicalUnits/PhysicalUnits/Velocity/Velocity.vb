Option Strict On
Option Infer On

Imports System.ComponentModel

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure Velocity

    Public Sub New(unit As SupportedVelocityUnits, value As Double)
        Me.Value(unit) = value
    End Sub

    Private Property Value(unit As SupportedVelocityUnits) As Double
        Get
            Dim f = ConversionFactor(unit)
            Return Me._MetersPerSecond * f
        End Get
        Set(value As Double)
            Dim f = ConversionFactor(unit)
            Me._MetersPerSecond = value / f
        End Set
    End Property

End Structure