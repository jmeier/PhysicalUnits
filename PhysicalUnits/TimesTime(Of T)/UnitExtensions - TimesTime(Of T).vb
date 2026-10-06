Option Strict On
Option Infer On

Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of TimesTime(Of T))) As TimesTime(Of T)
        Dim result = PhysicalUnits.TimesTime(Of T).Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    <Extension>
    Public Function Min(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of TimesTime(Of T))) As TimesTime(Of T)
        Dim result As TimesTime(Of T)
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
    Public Function Max(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of TimesTime(Of T))) As TimesTime(Of T)
        Dim result As TimesTime(Of T)
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
    Public Function Average(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of TimesTime(Of T))) As TimesTime(Of T)
        Dim unit = (New TimesTime(Of T)).DefaultUnit
        Return CType((New TimesTime(Of T)).Create((Aggregate i In values Into d = Average(i.GetValue(unit))), unit), TimesTime(Of T))
    End Function



    <Extension>
    Public Function TimesSecond(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T) As TimesTime(Of T)
        Return PhysicalUnits.TimesTime(Of T).FromTimesSecond(value)
    End Function

    <Extension>
    Public Function TimesSecond(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T?) As TimesTime(Of T)?
        If value.HasValue Then
            Return PhysicalUnits.TimesTime(Of T).FromTimesSecond(value.Value)
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function ValueTimesSecond(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As TimesTime(Of T)?) As T?
        If value.HasValue Then
            Return value.Value.ValueTimesSecond
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function TimesTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T, time As TimeSpan) As TimesTime(Of T)
        Return PhysicalUnits.TimesTime(Of T).FromTimesSecond(value) * time.Seconds
    End Function

    <Extension>
    Public Function TimesTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T?, time As TimeSpan) As TimesTime(Of T)?
        If value.HasValue Then
            Return PhysicalUnits.TimesTime(Of T).FromTimesSecond(value.Value) * time.Seconds
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function ValueTimesTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As TimesTime(Of T)?, time As TimeSpan) As T?
        If value.HasValue Then
            Return (value.Value * time.Seconds).ValueTimesSecond
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function Abs(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As TimesTime(Of T)?) As TimesTime(Of T)?
        If value.HasValue Then
            Return value.Value.Abs
        Else
            Return Nothing
        End If
    End Function

End Module