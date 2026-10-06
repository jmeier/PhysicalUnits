Option Strict On
Option Infer On

Imports System.ComponentModel

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure PerTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Sub New(value As T)
        Me._ValuePerSecond = value
    End Sub

    Public ReadOnly Property ValuePerTime(time As TimeSpan) As T
        Get
            Return (Me * time.TotalSeconds).ValuePerSecond
        End Get
    End Property

    Public Shared Function FromDoubleAndDefaultUnitPerSecond(value As Double) As PerTime(Of T)
        Return DirectCast((New T).Create(value, (New T).DefaultUnit), T).PerTime(TimeSpan.FromSeconds(1))
    End Function

End Structure