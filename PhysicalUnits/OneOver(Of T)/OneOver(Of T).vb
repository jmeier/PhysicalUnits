Option Strict On
Option Infer On

Imports System.ComponentModel

<TypeConverter(GetType(UnitConverter))>
<Serializable()>
<CLSCompliant(True)>
Public Structure OneOver(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Sub New(value As T)
        Me._OneOverValue = value
    End Sub

    Public Shared Function From(d As T) As OneOver(Of T)
        Return New OneOver(Of T) With {._OneOverValue = d}
    End Function
    Public Shared Function From(d As T?) As OneOver(Of T)?
        If d.HasValue Then
            Return From(d.Value)
        Else
            Return Nothing
        End If
    End Function


    Private _OneOverValue As T
    Public ReadOnly Property OneOver() As T
        Get
            Return _OneOverValue
        End Get
    End Property

    Public Shared Function FromDoubleAndDefaultUnitPerMeter(value As Double) As OneOver(Of T)
        Dim d = DirectCast((New T).Create(value, (New T).DefaultUnit), T)
        Return New OneOver(Of T)(d)
    End Function

End Structure