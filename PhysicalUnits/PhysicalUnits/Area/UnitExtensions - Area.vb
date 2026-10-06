Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(values As IEnumerable(Of Area)) As Area
        Dim result = Area.Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    <Extension>
    Public Function Min(values As IEnumerable(Of Area)) As Area
        Dim result = Area.MaxValue
        For Each item In values
            If item < result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Max(values As IEnumerable(Of Area)) As Area
        Dim result = Area.MinValue
        For Each item In values
            If item > result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Average(values As IEnumerable(Of Area)) As Area
        Return Area.FromSquaremeters(Aggregate i In values Into d = Average(i.Squaremeters))
    End Function


    <Extension>
    Public Function Squarecentimeters(value As Area?) As Double?
        If value.HasValue Then
            Return value.Value.Squarecentimeters
        Else
            Return Nothing
        End If
    End Function

    Public Function Squarecentimeters(value As Double) As Area
        Return Area.FromSquarecentimeters(value)
    End Function
    Public Function Squarecentimeters(value As Double?) As Area?
        If value.HasValue Then
            Return Area.FromSquarecentimeters(value)
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function Squaremeters(value As Area?) As Double?
        If value.HasValue Then
            Return value.Value.Squaremeters
        Else
            Return Nothing
        End If
    End Function

    Public Function Squaremeters(value As Double) As Area
        Return Area.FromSquaremeters(value)
    End Function
    Public Function Squaremeters(value As Double?) As Area?
        If value.HasValue Then
            Return Area.FromSquaremeters(value)
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function Squaremillimeters(value As Area?) As Double?
        If value.HasValue Then
            Return value.Value.Squaremillimeters
        Else
            Return Nothing
        End If
    End Function

    Public Function Squaremillimeters(value As Double) As Area
        Return Area.FromSquaremillimeters(value)
    End Function
    Public Function Squaremillimeters(value As Double?) As Area?
        If value.HasValue Then
            Return Area.FromSquaremillimeters(value)
        Else
            Return Nothing
        End If
    End Function

End Module