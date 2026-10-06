Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Min(values As IEnumerable(Of Elevation)) As Elevation
        Dim result = Elevation.MaxValue
        For Each item In values
            If item < result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Max(values As IEnumerable(Of Elevation)) As Elevation
        Dim result = Elevation.MinValue
        For Each item In values
            If item > result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Average(values As IEnumerable(Of Elevation)) As Elevation
        Return Elevation.FromMetersAboveNN(Aggregate i In values Into d = Average(i.MetersAboveNN))
    End Function


    <Extension>
    Public Function MetersAboveNN(value As Elevation?) As Double?
        If value.HasValue Then
            Return value.Value.MetersAboveNN
        Else
            Return Nothing
        End If
    End Function

    Public Function MetersAboveNN(value As Double) As Elevation
        Return Elevation.FromMetersAboveNN(value)
    End Function
    Public Function MetersAboveNN(value As Double?) As Elevation?
        If value.HasValue Then
            Return Elevation.FromMetersAboveNN(value)
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function FeetAboveNN(value As Elevation?) As Double?
        If value.HasValue Then
            Return value.Value.FeetAboveNN
        Else
            Return Nothing
        End If
    End Function

    Public Function FeetAboveNN(value As Double) As Elevation
        Return Elevation.FromFeetAboveNN(value)
    End Function
    Public Function FeetAboveNN(value As Double?) As Elevation?
        If value.HasValue Then
            Return Elevation.FromFeetAboveNN(value)
        Else
            Return Nothing
        End If
    End Function

End Module