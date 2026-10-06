Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of PerTime(Of T))) As PerTime(Of T)
        Dim result = PhysicalUnits.PerTime(Of T).Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    <Extension>
    Public Function Min(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of PerTime(Of T))) As PerTime(Of T)
        Dim result As PerTime(Of T)
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
    Public Function Max(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of PerTime(Of T))) As PerTime(Of T)
        Dim result As PerTime(Of T)
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
    Public Function Average(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of PerTime(Of T))) As PerTime(Of T)
        Dim unit = (New PerTime(Of T)).DefaultUnit
        Return CType((New PerTime(Of T)).Create((Aggregate i In values Into d = Average(i.GetValue(unit))), unit), PerTime(Of T))
    End Function



    <Extension>
    Public Function PerTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T) As PerTime(Of T)
        Return PhysicalUnits.PerTime(Of T).FromPerSecond(value)
    End Function

    <Extension>
    Public Function PerTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T?) As PerTime(Of T)?
        If value.HasValue Then
            Return PhysicalUnits.PerTime(Of T).FromPerSecond(value.Value)
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function ValuePerTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As PerTime(Of T)?) As T?
        If value.HasValue Then
            Return value.Value.ValuePerSecond
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function PerTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T, time As TimeSpan) As PerTime(Of T)
        Return PhysicalUnits.PerTime(Of T).FromPerSecond(value) / time.TotalSeconds
    End Function

    <Extension>
    Public Function PerTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T?, time As TimeSpan) As PerTime(Of T)?
        If value.HasValue Then
            Return PhysicalUnits.PerTime(Of T).FromPerSecond(value.Value) / time.TotalSeconds
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function ValuePerTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As PerTime(Of T)?, time As TimeSpan) As T?
        If value.HasValue Then
            Return (value.Value / time.TotalSeconds).ValuePerSecond
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function Abs(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As PerTime(Of T)?) As PerTime(Of T)?
        If value.HasValue Then
            Return value.Value.Abs
        Else
            Return Nothing
        End If
    End Function

End Module