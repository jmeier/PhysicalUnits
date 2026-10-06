Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(values As IEnumerable(Of Power)) As Power
        Dim result = Power.Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    <Extension>
    Public Function Min(values As IEnumerable(Of Power)) As Power
        Dim result = Power.MaxValue
        For Each item In values
            If item < result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Max(values As IEnumerable(Of Power)) As Power
        Dim result = Power.MinValue
        For Each item In values
            If item > result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Average(values As IEnumerable(Of Power)) As Power
        Return Power.FromWatts(Aggregate i In values Into d = Average(i.Watts))
    End Function


    <Extension>
    Public Function Watts(value As Power?) As Double?
        If value.HasValue Then
            Return value.Value.Watts
        Else
            Return Nothing
        End If
    End Function

    Public Function Watts(value As Double) As Power
        Return Power.FromWatts(value)
    End Function
    Public Function Watts(value As Double?) As Power?
        If value.HasValue Then
            Return Power.FromWatts(value)
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function Kilowatts(value As Power?) As Double?
        If value.HasValue Then
            Return value.Value.Kilowatts
        Else
            Return Nothing
        End If
    End Function

    Public Function Kilowatts(value As Double) As Power
        Return Power.FromKilowatts(value)
    End Function
    Public Function Kilowatts(value As Double?) As Power?
        If value.HasValue Then
            Return Power.FromKilowatts(value)
        Else
            Return Nothing
        End If
    End Function

End Module