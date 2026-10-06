Option Strict On
Option Infer On

Imports System.ComponentModel

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure PerLength(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Sub New(value As T)
        Me._ValuePerRunningMeter = value
    End Sub

    Public ReadOnly Property ValuePerRunningLength(length As Length) As T
        Get
            Return (Me * length.Meters).ValuePerRunningMeter
        End Get
    End Property

    Private Shared Function FromDoubleAndDefaultUnitPerMeter(value As Double) As PerLength(Of T)
        Return DirectCast((New T).Create(value, (New T).DefaultUnit), T).PerRunningMeter
    End Function

End Structure