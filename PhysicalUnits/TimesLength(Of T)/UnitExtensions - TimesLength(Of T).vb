Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of TimesLength(Of T))) As TimesLength(Of T)
        Dim result = PhysicalUnits.TimesLength(Of T).Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    <Extension>
    Public Function Min(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of TimesLength(Of T))) As TimesLength(Of T)
        Dim result As TimesLength(Of T)
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
    Public Function Max(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of TimesLength(Of T))) As TimesLength(Of T)
        Dim result As TimesLength(Of T)
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
    Public Function Average(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(values As IEnumerable(Of TimesLength(Of T))) As TimesLength(Of T)
        Dim unit = (New TimesLength(Of T)).DefaultUnit
        Return CType((New TimesLength(Of T)).Create((Aggregate i In values Into d = Average(i.GetValue(unit))), unit), TimesLength(Of T))
    End Function



    <Extension>
    Public Function TimesMeter(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T) As TimesLength(Of T)
        Return PhysicalUnits.TimesLength(Of T).FromTimesMeter(value)
    End Function

    <Extension>
    Public Function TimesMeter(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T?) As TimesLength(Of T)?
        If value.HasValue Then
            Return PhysicalUnits.TimesLength(Of T).FromTimesMeter(value.Value)
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function ValueTimesMeter(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As TimesLength(Of T)?) As T?
        If value.HasValue Then
            Return value.Value.ValueTimesMeter
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function TimesLength(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T, length As Length) As TimesLength(Of T)
        Return PhysicalUnits.TimesLength(Of T).FromTimesMeter(value) * length.Meters
    End Function

    <Extension>
    Public Function TimesLength(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As T?, length As Length) As TimesLength(Of T)?
        If value.HasValue Then
            Return PhysicalUnits.TimesLength(Of T).FromTimesMeter(value.Value) * length.Meters
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function ValueTimesLength(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As TimesLength(Of T)?, length As Length) As T?
        If value.HasValue Then
            Return (value.Value * length.Meters).ValueTimesMeter
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function Abs(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(value As TimesLength(Of T)?) As TimesLength(Of T)?
        If value.HasValue Then
            Return value.Value.Abs
        Else
            Return Nothing
        End If
    End Function

End Module