Option Strict On
Option Infer On

Imports System.ComponentModel

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure TimesVolume(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Sub New(value As T)
        Me._ValueTimesCubicMeter = value
    End Sub

    Public ReadOnly Property ValueTimesVolume(Volume As Volume) As T
        Get
            Return (Me * Volume.CubicMeters).ValueTimesCubicMeter
        End Get
    End Property

    Public Shared Function FromDoubleAndDefaultUnitTimesCubicMeter(value As Double) As TimesVolume(Of T)
        Return DirectCast((New T).Create(value, (New T).DefaultUnit), T).TimesCubicMeter
    End Function

End Structure