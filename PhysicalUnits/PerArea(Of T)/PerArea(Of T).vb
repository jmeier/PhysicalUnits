Option Strict On
Option Infer On

Imports System.ComponentModel

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure PerArea(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Sub New(valuePerSquaremeter As T)
        Me._ValuePerSquaremeter = valuePerSquaremeter
    End Sub

    Public ReadOnly Property ValuePerArea(area As Area) As T
        Get
            Return (Me * area.Squaremeters).ValuePerSquaremeter
        End Get
    End Property

    Private Shared Function FromDoubleAndDefaultUnitPerSquaremeter(value As Double) As PerArea(Of T)
        Return DirectCast((New T).Create(value, (New T).DefaultUnit), T).PerSquaremeter
    End Function

End Structure