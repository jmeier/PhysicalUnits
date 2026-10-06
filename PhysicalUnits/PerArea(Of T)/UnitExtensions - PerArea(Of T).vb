Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of PerArea(Of T))) As PerArea(Of T)
        Dim result = PhysicalUnits.PerArea(Of T).Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    <Extension>
    Public Function Min(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of PerArea(Of T))) As PerArea(Of T)
        Dim result As PerArea(Of T)
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
    Public Function Max(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of PerArea(Of T))) As PerArea(Of T)
        Dim result As PerArea(Of T)
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
    Public Function Average(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of PerArea(Of T))) As PerArea(Of T)
        Dim unit = (New PerArea(Of T)).DefaultUnit
        Return CType((New PerArea(Of T)).Create((Aggregate i In values Into d = Average(i.GetValue(unit))), unit), PerArea(Of T))
    End Function



    <Extension>
    Public Function PerSquaremeter(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T) As PerArea(Of T)
        Return PhysicalUnits.PerArea(Of T).FromPerSquaremeter(value)
    End Function

    <Extension>
    Public Function PerSquaremeter(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T?) As PerArea(Of T)?
        If value.HasValue Then
            Return PhysicalUnits.PerArea(Of T).FromPerSquaremeter(value.Value)
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function ValuePerSquaremeter(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As PerArea(Of T)?) As T?
        If value.HasValue Then
            Return value.Value.ValuePerSquaremeter
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function PerArea(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T, area As Area) As PerArea(Of T)
        Return PhysicalUnits.PerArea(Of T).FromPerSquaremeter(value) / area.Squaremeters
    End Function

    <Extension>
    Public Function PerArea(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T?, area As Area) As PerArea(Of T)?
        If value.HasValue Then
            Return PhysicalUnits.PerArea(Of T).FromPerSquaremeter(value.Value) / area.SquareMeters
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function ValuePerArea(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As PerArea(Of T)?, area As Area) As T?
        If value.HasValue Then
            Return (value.Value / area.Squaremeters).ValuePerSquaremeter
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function Abs(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As PerArea(Of T)?) As PerArea(Of T)?
        If value.HasValue Then
            Return value.Value.Abs
        Else
            Return Nothing
        End If
    End Function

End Module