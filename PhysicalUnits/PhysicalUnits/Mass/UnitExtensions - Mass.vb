Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(values As IEnumerable(Of Mass)) As Mass
        Dim result = Mass.Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    <Extension>
    Public Function Min(values As IEnumerable(Of Mass)) As Mass
        Dim result = Mass.MaxValue
        For Each item In values
            If item < result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Max(values As IEnumerable(Of Mass)) As Mass
        Dim result = Mass.MinValue
        For Each item In values
            If item > result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Average(values As IEnumerable(Of Mass)) As Mass
        Return Mass.FromKilograms(Aggregate i In values Into d = Average(i.Kilograms))
    End Function


    <Extension>
    Public Function Grams(value As Mass?) As Double?
        If value.HasValue Then
            Return value.Value.Grams
        Else
            Return Nothing
        End If
    End Function

    Public Function Grams(value As Double) As Mass
        Return Mass.FromGrams(value)
    End Function
    Public Function Grams(value As Double?) As Mass?
        If value.HasValue Then
            Return Mass.FromGrams(value)
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function Kilograms(value As Mass?) As Double?
        If value.HasValue Then
            Return value.Value.Kilograms
        Else
            Return Nothing
        End If
    End Function

    Public Function Kilograms(value As Double) As Mass
        Return Mass.FromKilograms(value)
    End Function
    Public Function Kilograms(value As Double?) As Mass?
        If value.HasValue Then
            Return Mass.FromKilograms(value)
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function Tons(value As Mass?) As Double?
        If value.HasValue Then
            Return value.Value.Tons
        Else
            Return Nothing
        End If
    End Function

    Public Function Tons(value As Double) As Mass
        Return Mass.FromTons(value)
    End Function
    Public Function Tons(value As Double?) As Mass?
        If value.HasValue Then
            Return Mass.FromTons(value)
        Else
            Return Nothing
        End If
    End Function

End Module