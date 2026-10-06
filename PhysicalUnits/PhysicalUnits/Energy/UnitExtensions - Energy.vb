Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(values As IEnumerable(Of Energy)) As Energy
        Dim result = Energy.Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    <Extension>
    Public Function Min(values As IEnumerable(Of Energy)) As Energy
        Dim result = Energy.MaxValue
        For Each item In values
            If item < result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Max(values As IEnumerable(Of Energy)) As Energy
        Dim result = Energy.MinValue
        For Each item In values
            If item > result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Average(values As IEnumerable(Of Energy)) As Energy
        Return Energy.FromJoules(Aggregate i In values Into d = Average(i.Joules))
    End Function


    <Extension>
    Public Function Joules(value As Energy?) As Double?
        If value.HasValue Then
            Return value.Value.Joules
        Else
            Return Nothing
        End If
    End Function

    Public Function Joules(value As Double) As Energy
        Return Energy.FromJoules(value)
    End Function
    Public Function Joules(value As Double?) As Energy?
        If value.HasValue Then
            Return Energy.FromJoules(value)
        Else
            Return Nothing
        End If
    End Function

End Module