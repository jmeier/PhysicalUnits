Option Strict On
Option Infer On

Imports System.ComponentModel

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure TimesTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Sub New(value As T)
        Me._ValueTimesSecond = value
    End Sub

    Public ReadOnly Property ValueTimesTime(Time As TimeSpan) As T
        Get
            Return (Me * Time.TotalSeconds).ValueTimesSecond
        End Get
    End Property

    Public Shared Function FromDoubleAndDefaultUnitTimesSecond(value As Double) As TimesTime(Of T)
        Return DirectCast((New T).Create(value, (New T).DefaultUnit), T).TimesSecond
    End Function

End Structure