Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(values As IEnumerable(Of Length)) As Length
        Dim result = Length.Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    <Extension>
    Public Function Min(values As IEnumerable(Of Length)) As Length
        Dim result = Length.MaxValue
        For Each item In values
            If item < result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Max(values As IEnumerable(Of Length)) As Length
        Dim result = Length.MinValue
        For Each item In values
            If item > result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Average(values As IEnumerable(Of Length)) As Length
        Return Length.FromMeters(Aggregate i In values Into d = Average(i.Meters))
    End Function



    <Extension>
    Public Function Meters(value As Length?) As Double?
        If value.HasValue Then
            Return value.Value.Meters
        Else
            Return Nothing
        End If
    End Function

    Public Function Meters(value As Double) As Length
        Return Length.FromMeters(value)
    End Function
    Public Function Meters(value As Double?) As Length?
        If value.HasValue Then
            Return Length.FromMeters(value)
        Else
            Return Nothing
        End If
    End Function

    Public Function Meters(values As Double()) As Length()
        Return Array.ConvertAll(values, AddressOf Length.FromMeters)
    End Function

    Public Function Meters(values As IEnumerable(Of Double)) As IEnumerable(Of Length)
        Return values.Select(AddressOf Length.FromMeters)
    End Function


    <Extension>
    Public Function Millimeters(value As Length?) As Double?
        If value.HasValue Then
            Return value.Value.Millimeters
        Else
            Return Nothing
        End If
    End Function

    Public Function Millimeters(value As Double) As Length
        Return Length.FromMillimeters(value)
    End Function
    Public Function Millimeters(value As Double?) As Length?
        If value.HasValue Then
            Return Length.FromMillimeters(value)
        Else
            Return Nothing
        End If
    End Function

    Public Function Millimeters(values As Double()) As Length()
        Return Array.ConvertAll(values, AddressOf Length.FromMillimeters)
    End Function

    Public Function Millimeters(values As IEnumerable(Of Double)) As IEnumerable(Of Length)
        Return values.Select(AddressOf Length.FromMillimeters)
    End Function


    <Extension>
    Public Function Centimeters(value As Length?) As Double?
        If value.HasValue Then
            Return value.Value.Centimeters
        Else
            Return Nothing
        End If
    End Function

    Public Function Centimeters(value As Double) As Length
        Return Length.FromCentimeters(value)
    End Function
    Public Function Centimeters(value As Double?) As Length?
        If value.HasValue Then
            Return Length.FromCentimeters(value)
        Else
            Return Nothing
        End If
    End Function

    Public Function Centimeters(values As Double()) As Length()
        Return Array.ConvertAll(values, AddressOf Length.FromCentimeters)
    End Function

    Public Function Centimeters(values As IEnumerable(Of Double)) As IEnumerable(Of Length)
        Return values.Select(AddressOf Length.FromCentimeters)
    End Function


    <Extension>
    Public Function Decimeters(value As Length?) As Double?
        If value.HasValue Then
            Return value.Value.Decimeters
        Else
            Return Nothing
        End If
    End Function

    Public Function Decimeters(value As Double) As Length
        Return Length.FromDecimeters(value)
    End Function
    Public Function Decimeters(value As Double?) As Length?
        If value.HasValue Then
            Return Length.FromDecimeters(value)
        Else
            Return Nothing
        End If
    End Function

    Public Function Decimeters(values As Double()) As Length()
        Return Array.ConvertAll(values, AddressOf Length.FromDecimeters)
    End Function

    Public Function Decimeters(values As IEnumerable(Of Double)) As IEnumerable(Of Length)
        Return values.Select(AddressOf Length.FromDecimeters)
    End Function


    <Extension>
    Public Function Feet(value As Length?) As Double?
        If value.HasValue Then
            Return value.Value.Feet
        Else
            Return Nothing
        End If
    End Function

    'Public Function Feet(value As Double) As Length
    '    Return Length.FromFeet(value)
    'End Function
    'Public Function Feet(value As Double?) As Length?
    '    If value.HasValue Then
    '        Return Length.FromFeet(value)
    '    Else
    '        Return Nothing
    '    End If
    'End Function


    <Extension>
    Public Function Inchs(value As Length?) As Double?
        If value.HasValue Then
            Return value.Value.Inchs
        Else
            Return Nothing
        End If
    End Function

    'Public Function Inchs(value As Double) As Length
    '    Return Length.FromInchs(value)
    'End Function
    'Public Function Inchs(value As Double?) As Length?
    '    If value.HasValue Then
    '        Return Length.FromInchs(value)
    '    Else
    '        Return Nothing
    '    End If
    'End Function



    <Extension>
    Public Function Kilometers(value As Length?) As Double?
        If value.HasValue Then
            Return value.Value.Kilometers
        Else
            Return Nothing
        End If
    End Function

    Public Function Kilometers(value As Double) As Length
        Return Length.FromKilometers(value)
    End Function
    Public Function Kilometers(value As Double?) As Length?
        If value.HasValue Then
            Return Length.FromKilometers(value)
        Else
            Return Nothing
        End If
    End Function

    Public Function Kilometers(values As Double()) As Length()
        Return Array.ConvertAll(values, AddressOf Length.FromKilometers)
    End Function

    Public Function Kilometers(values As IEnumerable(Of Double)) As IEnumerable(Of Length)
        Return values.Select(AddressOf Length.FromKilometers)
    End Function


    <Extension>
    Public Function Yards(value As Length?) As Double?
        If value.HasValue Then
            Return value.Value.Yards
        Else
            Return Nothing
        End If
    End Function

    'Public Function Yards(value As Double) As Length
    '    Return Length.FromYards(value)
    'End Function
    'Public Function Yards(value As Double?) As Length?
    '    If value.HasValue Then
    '        Return Length.FromYards(value)
    '    Else
    '        Return Nothing
    '    End If
    'End Function


End Module