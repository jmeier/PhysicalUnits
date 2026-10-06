Option Strict On
Option Infer On

Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of TimesArea(Of T))) As TimesArea(Of T)
        Dim result = PhysicalUnits.TimesArea(Of T).Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    <Extension>
    Public Function Min(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of TimesArea(Of T))) As TimesArea(Of T)
        Dim result As TimesArea(Of T)
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
    Public Function Max(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of TimesArea(Of T))) As TimesArea(Of T)
        Dim result As TimesArea(Of T)
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
    Public Function Average(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of TimesArea(Of T))) As TimesArea(Of T)
        Dim unit = (New TimesArea(Of T)).DefaultUnit
        Return CType((New TimesArea(Of T)).Create((Aggregate i In values Into d = Average(i.GetValue(unit))), unit), TimesArea(Of T))
    End Function



    <Extension>
    Public Function TimesSquareMeter(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T) As TimesArea(Of T)
        Return PhysicalUnits.TimesArea(Of T).FromTimesSquareMeter(value)
    End Function

    <Extension>
    Public Function TimesSquareMeter(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T?) As TimesArea(Of T)?
        If value.HasValue Then
            Return PhysicalUnits.TimesArea(Of T).FromTimesSquareMeter(value.Value)
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function ValueTimesSquareMeter(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As TimesArea(Of T)?) As T?
        If value.HasValue Then
            Return value.Value.ValueTimesSquareMeter
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function TimesArea(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T, Area As Area) As TimesArea(Of T)
        Return PhysicalUnits.TimesArea(Of T).FromTimesSquareMeter(value) * Area.SquareMeters
    End Function

    <Extension>
    Public Function TimesArea(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T?, Area As Area) As TimesArea(Of T)?
        If value.HasValue Then
            Return PhysicalUnits.TimesArea(Of T).FromTimesSquareMeter(value.Value) * Area.SquareMeters
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function ValueTimesArea(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As TimesArea(Of T)?, Area As Area) As T?
        If value.HasValue Then
            Return (value.Value * Area.SquareMeters).ValueTimesSquareMeter
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function Abs(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As TimesArea(Of T)?) As TimesArea(Of T)?
        If value.HasValue Then
            Return value.Value.Abs
        Else
            Return Nothing
        End If
    End Function

End Module