Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(values As IEnumerable(Of Density)) As Density
        Dim result = Density.Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    <Extension>
    Public Function Min(values As IEnumerable(Of Density)) As Density
        Dim result = Density.MaxValue
        For Each item In values
            If item < result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Max(values As IEnumerable(Of Density)) As Density
        Dim result = Density.MinValue
        For Each item In values
            If item > result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Average(values As IEnumerable(Of Density)) As Density
        Return Density.FromKilogramsPerCubicmeter(Aggregate i In values Into d = Average(i.KilogramsPerCubicmeter))
    End Function


    <Extension>
    Public Function GramsPerCubiccentimeter(value As Density?) As Double?
        If value.HasValue Then
            Return value.Value.GramsPerCubiccentimeter
        Else
            Return Nothing
        End If
    End Function

    Public Function GramsPerCubiccentimeter(value As Double) As Density
        Return Density.FromGramsPerCubiccentimeter(value)
    End Function
    Public Function GramsPerCubiccentimeter(value As Double?) As Density?
        If value.HasValue Then
            Return Density.FromGramsPerCubiccentimeter(value)
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function KilogramsPerCubicmeter(value As Density?) As Double?
        If value.HasValue Then
            Return value.Value.KilogramsPerCubicmeter
        Else
            Return Nothing
        End If
    End Function

    Public Function KilogramsPerCubicmeter(value As Double) As Density
        Return Density.FromKilogramsPerCubicmeter(value)
    End Function
    Public Function KilogramsPerCubicmeter(value As Double?) As Density?
        If value.HasValue Then
            Return Density.FromKilogramsPerCubicmeter(value)
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function TonsPerCubicmeter(value As Density?) As Double?
        If value.HasValue Then
            Return value.Value.TonsPerCubicmeter
        Else
            Return Nothing
        End If
    End Function

    Public Function TonsPerCubicmeter(value As Double) As Density
        Return Density.FromTonsPerCubicmeter(value)
    End Function
    Public Function TonsPerCubicmeter(value As Double?) As Density?
        If value.HasValue Then
            Return Density.FromTonsPerCubicmeter(value)
        Else
            Return Nothing
        End If
    End Function

End Module