Option Strict On
Option Infer On

Imports System.ComponentModel

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure TimesArea(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Sub New(value As T)
        Me._ValueTimesSquareMeter = value
    End Sub

    Public ReadOnly Property ValueTimesArea(Area As Area) As T
        Get
            Return (Me * Area.SquareMeters).ValueTimesSquareMeter
        End Get
    End Property

    Public Shared Function FromDoubleAndDefaultUnitTimesSquareMeter(value As Double) As TimesArea(Of T)
        Return DirectCast((New T).Create(value, (New T).DefaultUnit), T).TimesSquareMeter
    End Function

End Structure