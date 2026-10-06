Option Strict On
Option Infer On

Imports System.ComponentModel

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure TimesLength(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Sub New(value As T)
        Me._ValueTimesMeter = value
    End Sub

    Public ReadOnly Property ValueTimesLength(length As Length) As T
        Get
            Return (Me * length.Meters).ValueTimesMeter
        End Get
    End Property

    Public Shared Function FromDoubleAndDefaultUnitTimesMeter(value As Double) As TimesLength(Of T)
        Return DirectCast((New T).Create(value, (New T).DefaultUnit), T).TimesMeter
    End Function

End Structure