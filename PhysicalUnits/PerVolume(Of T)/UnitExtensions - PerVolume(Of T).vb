Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of PerVolume(Of T))) As PerVolume(Of T)
        Dim result = PhysicalUnits.PerVolume(Of T).Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    <Extension>
    Public Function Min(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of PerVolume(Of T))) As PerVolume(Of T)
        Dim result As PerVolume(Of T)
        Dim isfirst As Boolean = True
        For Each item In values
            If isfirst Then
                result = item
                isfirst = False
            ElseIf item < result Then
                result = item
            End If
        Next
        Return result
    End Function

    <Extension>
    Public Function Max(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of PerVolume(Of T))) As PerVolume(Of T)
        Dim result As PerVolume(Of T)
        Dim isfirst As Boolean = True
        For Each item In values
            If isfirst Then
                result = item
                isfirst = False
            ElseIf item > result Then
                result = item
            End If
        Next
        Return result
    End Function

    <Extension>
    Public Function Average(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of PerVolume(Of T))) As PerVolume(Of T)
        Dim unit = (New PerVolume(Of T)).DefaultUnit
        Return CType((New PerVolume(Of T)).Create((Aggregate i In values Into d = Average(i.GetValue(unit))), unit), PerVolume(Of T))
    End Function



    <Extension>
    Public Function PerCubicmeter(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T) As PerVolume(Of T)
        Return PhysicalUnits.PerVolume(Of T).FromPerCubicmeter(value)
    End Function

    <Extension>
    Public Function PerCubicmeter(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T?) As PerVolume(Of T)?
        If value.HasValue Then
            Return PhysicalUnits.PerVolume(Of T).FromPerCubicmeter(value.Value)
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function ValuePerCubicmeter(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As PerVolume(Of T)?) As T?
        If value.HasValue Then
            Return value.Value.ValuePerCubicmeter
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function PerVolume(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T, volume As Volume) As PerVolume(Of T)
        Return PhysicalUnits.PerVolume(Of T).FromPerCubicmeter(value) / volume.CubicMeters
    End Function

    <Extension>
    Public Function PerVolume(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T?, volume As Volume) As PerVolume(Of T)?
        If value.HasValue Then
            Return PhysicalUnits.PerVolume(Of T).FromPerCubicmeter(value.Value) / volume.CubicMeters
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function ValuePerVolume(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As PerVolume(Of T)?, volume As Volume) As T?
        If value.HasValue Then
            Return (value.Value / volume.CubicMeters).ValuePerCubicmeter
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function Abs(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As PerVolume(Of T)?) As PerVolume(Of T)?
        If value.HasValue Then
            Return value.Value.Abs
        Else
            Return Nothing
        End If
    End Function

End Module