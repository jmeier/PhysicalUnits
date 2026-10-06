Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(values As IEnumerable(Of Force)) As Force
        Dim result = Force.Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    <Extension>
    Public Function Min(values As IEnumerable(Of Force)) As Force
        Dim result = Force.MaxValue
        For Each item In values
            If item < result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Max(values As IEnumerable(Of Force)) As Force
        Dim result = Force.MinValue
        For Each item In values
            If item > result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Average(values As IEnumerable(Of Force)) As Force
        Return Force.FromNewtons(Aggregate i In values Into d = Average(i.Newtons))
    End Function


    <Extension>
    Public Function Newtons(value As Force?) As Double?
        If value.HasValue Then
            Return value.Value.Newtons
        Else
            Return Nothing
        End If
    End Function

    Public Function Newtons(value As Double) As Force
        Return Force.FromNewtons(value)
    End Function
    Public Function Newtons(value As Double?) As Force?
        If value.HasValue Then
            Return Force.FromNewtons(value)
        Else
            Return Nothing
        End If
    End Function

    Public Function Newtons(values As Double()) As Force()
        Return Array.ConvertAll(values, AddressOf Force.FromNewtons)
    End Function

    Public Function Newtons(values As IEnumerable(Of Double)) As IEnumerable(Of Force)
        Return values.Select(AddressOf Force.FromNewtons)
    End Function


    <Extension>
    Public Function Kilonewtons(value As Force?) As Double?
        If value.HasValue Then
            Return value.Value.Kilonewtons
        Else
            Return Nothing
        End If
    End Function

    Public Function Kilonewtons(value As Double) As Force
        Return Force.FromKilonewtons(value)
    End Function
    Public Function Kilonewtons(value As Double?) As Force?
        If value.HasValue Then
            Return Force.FromKilonewtons(value)
        Else
            Return Nothing
        End If
    End Function

    Public Function Kilonewtons(values As Double()) As Force()
        Return Array.ConvertAll(values, AddressOf Force.FromKilonewtons)
    End Function

    Public Function Kilonewtons(values As IEnumerable(Of Double)) As IEnumerable(Of Force)
        Return values.Select(AddressOf Force.FromKilonewtons)
    End Function


    <Extension>
    Public Function Meganewtons(value As Force?) As Double?
        If value.HasValue Then
            Return value.Value.Meganewtons
        Else
            Return Nothing
        End If
    End Function

    Public Function Meganewtons(value As Double) As Force
        Return Force.FromMeganewtons(value)
    End Function
    Public Function Meganewtons(value As Double?) As Force?
        If value.HasValue Then
            Return Force.FromMeganewtons(value)
        Else
            Return Nothing
        End If
    End Function

    Public Function Meganewtons(values As Double()) As Force()
        Return Array.ConvertAll(values, AddressOf Force.FromMeganewtons)
    End Function

    Public Function Meganewtons(values As IEnumerable(Of Double)) As IEnumerable(Of Force)
        Return values.Select(AddressOf Force.FromMeganewtons)
    End Function


    <Extension>
    Public Function Giganewtons(value As Force?) As Double?
        If value.HasValue Then
            Return value.Value.Giganewtons
        Else
            Return Nothing
        End If
    End Function

    Public Function Giganewtons(value As Double) As Force
        Return Force.FromGiganewtons(value)
    End Function
    Public Function Giganewtons(value As Double?) As Force?
        If value.HasValue Then
            Return Force.FromGiganewtons(value)
        Else
            Return Nothing
        End If
    End Function

    Public Function Giganewtons(values As Double()) As Force()
        Return Array.ConvertAll(values, AddressOf Force.FromGiganewtons)
    End Function

    Public Function Giganewtons(values As IEnumerable(Of Double)) As IEnumerable(Of Force)
        Return values.Select(AddressOf Force.FromGiganewtons)
    End Function

End Module