Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(values As IEnumerable(Of Intensity)) As Intensity
        Dim result = Intensity.Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    <Extension>
    Public Function Min(values As IEnumerable(Of Intensity)) As Intensity
        Dim result = Intensity.MaxValue
        For Each item In values
            If item < result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Max(values As IEnumerable(Of Intensity)) As Intensity
        Dim result = Intensity.MinValue
        For Each item In values
            If item > result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Average(values As IEnumerable(Of Intensity)) As Intensity
        Return Intensity.FromWattsPerSquaremeter(Aggregate i In values Into d = Average(i.WattsPerSquaremeter))
    End Function


    <Extension>
    Public Function KilowattsPerSquaremeter(value As Intensity?) As Double?
        If value.HasValue Then
            Return value.Value.KilowattsPerSquaremeter
        Else
            Return Nothing
        End If
    End Function

    Public Function KilowattsPerSquaremeter(value As Double) As Intensity
        Return Intensity.FromKilowattsPerSquaremeter(value)
    End Function
    Public Function KilowattsPerSquaremeter(value As Double?) As Intensity?
        If value.HasValue Then
            Return Intensity.FromKilowattsPerSquaremeter(value)
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function WattsPerSquaremeter(value As Intensity?) As Double?
        If value.HasValue Then
            Return value.Value.WattsPerSquaremeter
        Else
            Return Nothing
        End If
    End Function

    Public Function WattsPerSquaremeter(value As Double) As Intensity
        Return Intensity.FromWattsPerSquaremeter(value)
    End Function
    Public Function WattsPerSquaremeter(value As Double?) As Intensity?
        If value.HasValue Then
            Return Intensity.FromWattsPerSquaremeter(value)
        Else
            Return Nothing
        End If
    End Function

End Module