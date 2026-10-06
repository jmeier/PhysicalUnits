Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Abs(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As OneOver(Of T)?) As OneOver(Of T)?
        If value.HasValue Then
            Return value.Value.Abs
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function Sum(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of OneOver(Of T))) As OneOver(Of T)
        Dim result = PhysicalUnits.OneOver(Of T).Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    '<Extension>
    'Public Function Min(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of OneOver(Of T))) As OneOver(Of T)
    '    Dim result As OneOver(Of T)
    '    Dim isfirst As Boolean = True
    '    For Each item In values
    '        If isfirst Then
    '            result = item
    '            isfirst = False
    '        ElseIf item < result Then
    '            result = item
    '        End If
    '    Next
    '    Return result
    'End Function

    '<Extension>
    'Public Function Max(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of OneOver(Of T))) As OneOver(Of T)
    '    Dim result As OneOver(Of T)
    '    Dim isfirst As Boolean = True
    '    For Each item In values
    '        If isfirst Then
    '            result = item
    '            isfirst = False
    '        ElseIf item > result Then
    '            result = item
    '        End If
    '    Next
    '    Return result
    'End Function

    '<Extension>
    'Public Function Average(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of OneOver(Of T))) As OneOver(Of T)
    '    Dim unit = (New OneOver(Of T)).DefaultUnit
    '    Return CType((New OneOver(Of T)).Create((Aggregate i In values Into d = Average(i.GetValue(unit))), unit), OneOver(Of T))
    'End Function


    <Extension>
    Public Function OneOver(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T) As OneOver(Of T)
        Return New OneOver(Of T)(value:=value)
    End Function

    <Extension>
    Public Function OneOver(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T?) As OneOver(Of T)?
        If value.HasValue Then
            Return New OneOver(Of T)(value:=value.Value)
        Else
            Return Nothing
        End If
    End Function

End Module