Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(values As IEnumerable(Of Acceleration)) As Acceleration
        Dim result = Acceleration.Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    <Extension>
    Public Function Min(values As IEnumerable(Of Acceleration)) As Acceleration
        Dim result = Acceleration.MaxValue
        For Each item In values
            If item < result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Max(values As IEnumerable(Of Acceleration)) As Acceleration
        Dim result = Acceleration.MinValue
        For Each item In values
            If item > result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Average(values As IEnumerable(Of Acceleration)) As Acceleration
        Return Acceleration.FromMetersPerSquaresecond(Aggregate i In values Into d = Average(i.MetersPerSquaresecond))
    End Function


    <Extension>
    Public Function MetersPerSquaresecond(value As Acceleration?) As Double?
        If value.HasValue Then
            Return value.Value.MetersPerSquaresecond
        Else
            Return Nothing
        End If
    End Function

    Public Function MeterPerSquareseconds(value As Double) As Acceleration
        Return Acceleration.FromMetersPerSquaresecond(value)
    End Function
    Public Function MeterPerSquareseconds(value As Double?) As Acceleration?
        If value.HasValue Then
            Return Acceleration.FromMetersPerSquaresecond(value)
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function MillimetersPerSquaresecond(value As Acceleration?) As Double?
        If value.HasValue Then
            Return value.Value.MillimetersPerSquaresecond
        Else
            Return Nothing
        End If
    End Function

    Public Function MillimetersPerSquaresecond(value As Double) As Acceleration
        Return Acceleration.FromMillimetersPerSquaresecond(value)
    End Function
    Public Function MillimetersPerSquaresecond(value As Double?) As Acceleration?
        If value.HasValue Then
            Return Acceleration.FromMillimetersPerSquaresecond(value)
        Else
            Return Nothing
        End If
    End Function

End Module