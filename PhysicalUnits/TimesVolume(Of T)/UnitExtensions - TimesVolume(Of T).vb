Option Strict On
Option Infer On

Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of TimesVolume(Of T))) As TimesVolume(Of T)
        Dim result = PhysicalUnits.TimesVolume(Of T).Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    <Extension>
    Public Function Min(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of TimesVolume(Of T))) As TimesVolume(Of T)
        Dim result As TimesVolume(Of T)
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
    Public Function Max(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of TimesVolume(Of T))) As TimesVolume(Of T)
        Dim result As TimesVolume(Of T)
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
    Public Function Average(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of TimesVolume(Of T))) As TimesVolume(Of T)
        Dim unit = (New TimesVolume(Of T)).DefaultUnit
        Return CType((New TimesVolume(Of T)).Create((Aggregate i In values Into d = Average(i.GetValue(unit))), unit), TimesVolume(Of T))
    End Function



    <Extension>
    Public Function TimesCubicMeter(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T) As TimesVolume(Of T)
        Return PhysicalUnits.TimesVolume(Of T).FromTimesCubicMeter(value)
    End Function

    <Extension>
    Public Function TimesCubicMeter(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T?) As TimesVolume(Of T)?
        If value.HasValue Then
            Return PhysicalUnits.TimesVolume(Of T).FromTimesCubicMeter(value.Value)
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function ValueTimesCubicMeter(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As TimesVolume(Of T)?) As T?
        If value.HasValue Then
            Return value.Value.ValueTimesCubicMeter
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function TimesVolume(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T, Volume As Volume) As TimesVolume(Of T)
        Return PhysicalUnits.TimesVolume(Of T).FromTimesCubicMeter(value) * Volume.CubicMeters
    End Function

    <Extension>
    Public Function TimesVolume(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T?, Volume As Volume) As TimesVolume(Of T)?
        If value.HasValue Then
            Return PhysicalUnits.TimesVolume(Of T).FromTimesCubicMeter(value.Value) * Volume.CubicMeters
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function ValueTimesVolume(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As TimesVolume(Of T)?, Volume As Volume) As T?
        If value.HasValue Then
            Return (value.Value * Volume.CubicMeters).ValueTimesCubicMeter
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function Abs(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As TimesVolume(Of T)?) As TimesVolume(Of T)?
        If value.HasValue Then
            Return value.Value.Abs
        Else
            Return Nothing
        End If
    End Function

End Module