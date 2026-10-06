Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of PerLength(Of T))) As PerLength(Of T)
        Dim result = PhysicalUnits.PerLength(Of T).Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    <Extension>
    Public Function Min(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of PerLength(Of T))) As PerLength(Of T)
        Dim result As PerLength(Of T)
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
    Public Function Max(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of PerLength(Of T))) As PerLength(Of T)
        Dim result As PerLength(Of T)
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
    Public Function Average(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of PerLength(Of T))) As PerLength(Of T)
        Dim unit = (New PerLength(Of T)).DefaultUnit
        Return CType((New PerLength(Of T)).Create((Aggregate i In values Into d = Average(i.GetValue(unit))), unit), PerLength(Of T))
    End Function



    <Extension>
    Public Function PerRunningMeter(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T) As PerLength(Of T)
        Return PhysicalUnits.PerLength(Of T).FromPerRunningMeter(value)
    End Function

    <Extension>
    Public Function PerRunningMeter(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T?) As PerLength(Of T)?
        If value.HasValue Then
            Return PhysicalUnits.PerLength(Of T).FromPerRunningMeter(value.Value)
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function ValuePerRunningMeter(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As PerLength(Of T)?) As T?
        If value.HasValue Then
            Return value.Value.ValuePerRunningMeter
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function PerRunningLength(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T, length As Length) As PerLength(Of T)
        Return PhysicalUnits.PerLength(Of T).FromPerRunningMeter(value) / length.Meters
    End Function

    <Extension>
    Public Function PerRunningLength(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T?, length As Length) As PerLength(Of T)?
        If value.HasValue Then
            Return PhysicalUnits.PerLength(Of T).FromPerRunningMeter(value.Value) / length.Meters
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function ValuePerRunningLength(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As PerLength(Of T)?, length As Length) As T?
        If value.HasValue Then
            Return (value.Value / length.Meters).ValuePerRunningMeter
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function Abs(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As PerLength(Of T)?) As PerLength(Of T)?
        If value.HasValue Then
            Return value.Value.Abs
        Else
            Return Nothing
        End If
    End Function

End Module