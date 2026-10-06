Option Strict On
Option Infer On

Imports System.ComponentModel

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure PerVolume(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Sub New(valuePerCubicmeter As T)
        Me._ValuePerCubicemeter = valuePerCubicmeter
    End Sub

    Public ReadOnly Property ValuePerVolume(Volume As Volume) As T
        Get
            Return (Me * Volume.CubicMeters).ValuePerCubicmeter
        End Get
    End Property

    Private Shared Function FromDoubleAndDefaultUnitPerCubicmeter(value As Double) As PerVolume(Of T)
        Return DirectCast((New T).Create(value, (New T).DefaultUnit), T).PerCubicmeter
    End Function

End Structure