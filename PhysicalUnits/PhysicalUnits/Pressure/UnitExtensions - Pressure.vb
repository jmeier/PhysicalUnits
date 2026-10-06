Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(values As IEnumerable(Of Pressure)) As Pressure
        Dim result = Pressure.Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    <Extension>
    Public Function Min(values As IEnumerable(Of Pressure)) As Pressure
        Dim result = Pressure.MaxValue
        For Each item In values
            If item < result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Max(values As IEnumerable(Of Pressure)) As Pressure
        Dim result = Pressure.MinValue
        For Each item In values
            If item > result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Average(values As IEnumerable(Of Pressure)) As Pressure
        Return Pressure.FromNewtonsPerSquaremeter(Aggregate i In values Into d = Average(i.NewtonsPerSquaremeter))
    End Function


    <Extension>
    Public Function NewtonsPerSquaremeter(value As Pressure?) As Double?
        If value.HasValue Then
            Return value.Value.NewtonsPerSquaremeter
        Else
            Return Nothing
        End If
    End Function

    Public Function NewtonsPerSquaremeter(value As Double) As Pressure
        Return Pressure.FromNewtonsPerSquaremeter(value)
    End Function
    Public Function NewtonsPerSquaremeter(value As Double?) As Pressure?
        If value.HasValue Then
            Return Pressure.FromNewtonsPerSquaremeter(value)
        Else
            Return Nothing
        End If
    End Function

    Public Function NewtonsPerSquaremeter(values As Double()) As Pressure()
        Return Array.ConvertAll(values, AddressOf Pressure.FromNewtonsPerSquaremeter)
    End Function

    Public Function NewtonsPerSquaremeter(values As IEnumerable(Of Double)) As IEnumerable(Of Pressure)
        Return values.Select(AddressOf Pressure.FromNewtonsPerSquaremeter)
    End Function


    <Extension>
    Public Function KilonewtonsPerSquaremeter(value As Pressure?) As Double?
        If value.HasValue Then
            Return value.Value.KilonewtonsPerSquaremeter
        Else
            Return Nothing
        End If
    End Function

    Public Function KilonewtonsPerSquaremeter(value As Double) As Pressure
        Return Pressure.FromKilonewtonsPerSquaremeter(value)
    End Function
    Public Function KilonewtonsPerSquaremeter(value As Double?) As Pressure?
        If value.HasValue Then
            Return Pressure.FromKilonewtonsPerSquaremeter(value)
        Else
            Return Nothing
        End If
    End Function

    Public Function KilonewtonsPerSquaremeter(values As Double()) As Pressure()
        Return Array.ConvertAll(values, AddressOf Pressure.FromKilonewtonsPerSquaremeter)
    End Function

    Public Function KilonewtonsPerSquaremeter(values As IEnumerable(Of Double)) As IEnumerable(Of Pressure)
        Return values.Select(AddressOf Pressure.FromKilonewtonsPerSquaremeter)
    End Function


    <Extension>
    Public Function KilogramsPerSqarecentimeter(value As Pressure?) As Double?
        If value.HasValue Then
            Return value.Value.KilonewtonsPerSquaremeter * 0.010197162129779
        Else
            Return Nothing
        End If
    End Function

    Public Function KilogramsPerSqarecentimeter(value As Double) As Pressure
        Return Pressure.FromKilonewtonsPerSquaremeter(value / 0.010197162129779)
    End Function
    Public Function KilogramsPerSqarecentimeter(value As Double?) As Pressure?
        If value.HasValue Then
            Return Pressure.FromKilonewtonsPerSquaremeter(value / 0.010197162129779)
        Else
            Return Nothing
        End If
    End Function

    'Public Function KilogramsPerSqarecentimeter(values As Double()) As Pressure()
    '    Return Array.ConvertAll(values, AddressOf Pressure.FromKilogramsPerSqarecentimeter)
    'End Function

    'Public Function KilogramsPerSqarecentimeter(values As IEnumerable(Of Double)) As IEnumerable(Of Pressure)
    '    Return values.Select(AddressOf Pressure.FromKilogramsPerSqarecentimeter)
    'End Function


    <Extension>
    Public Function Bars(value As Pressure?) As Double?
        If value.HasValue Then
            Return value.Value.Bars
        Else
            Return Nothing
        End If
    End Function

    Public Function Bars(value As Double) As Pressure
        Return Pressure.FromBars(value)
    End Function
    Public Function Bar(value As Double?) As Pressure?
        If value.HasValue Then
            Return Pressure.FromBars(value)
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function KilonewtonsPerSquaremillimeter(value As Pressure?) As Double?
        If value.HasValue Then
            Return value.Value.KilonewtonsPerSquaremillimeter
        Else
            Return Nothing
        End If
    End Function

    Public Function KilonewtonsPerSquaremillimeter(value As Double) As Pressure
        Return Pressure.FromKilonewtonsPerSquaremillimeter(value)
    End Function
    Public Function KilonewtonsPerSquaremillimeter(value As Double?) As Pressure?
        If value.HasValue Then
            Return Pressure.FromKilonewtonsPerSquaremillimeter(value)
        Else
            Return Nothing
        End If
    End Function

    Public Function KilonewtonsPerSquaremillimeter(values As Double()) As Pressure()
        Return Array.ConvertAll(values, AddressOf Pressure.FromKilonewtonsPerSquaremillimeter)
    End Function

    Public Function KilonewtonsPerSquaremillimeter(values As IEnumerable(Of Double)) As IEnumerable(Of Pressure)
        Return values.Select(AddressOf Pressure.FromKilonewtonsPerSquaremillimeter)
    End Function


    <Extension>
    Public Function MeganewtonsPerSquaremeter(value As Pressure?) As Double?
        If value.HasValue Then
            Return value.Value.MeganewtonsPerSquaremeter
        Else
            Return Nothing
        End If
    End Function

    Public Function MeganewtonsPerSquaremeter(value As Double) As Pressure
        Return Pressure.FromMeganewtonsPerSquaremeter(value)
    End Function
    Public Function MeganewtonsPerSquaremeter(value As Double?) As Pressure?
        If value.HasValue Then
            Return Pressure.FromMeganewtonsPerSquaremeter(value)
        Else
            Return Nothing
        End If
    End Function

    Public Function MeganewtonsPerSquaremeter(values As Double()) As Pressure()
        Return Array.ConvertAll(values, AddressOf Pressure.FromMeganewtonsPerSquaremeter)
    End Function

    Public Function MeganewtonsPerSquaremeter(values As IEnumerable(Of Double)) As IEnumerable(Of Pressure)
        Return values.Select(AddressOf Pressure.FromMeganewtonsPerSquaremeter)
    End Function


    <Extension>
    Public Function GiganewtonsPerSquaremeter(value As Pressure?) As Double?
        If value.HasValue Then
            Return value.Value.GiganewtonsPerSquaremeter
        Else
            Return Nothing
        End If
    End Function

    Public Function GiganewtonsPerSquaremeter(value As Double) As Pressure
        Return Pressure.FromGiganewtonsPerSquaremeter(value)
    End Function
    Public Function GiganewtonsPerSquaremeter(value As Double?) As Pressure?
        If value.HasValue Then
            Return Pressure.FromGiganewtonsPerSquaremeter(value)
        Else
            Return Nothing
        End If
    End Function

    Public Function GiganewtonsPerSquaremeter(values As Double()) As Pressure()
        Return Array.ConvertAll(values, AddressOf Pressure.FromGiganewtonsPerSquaremeter)
    End Function

    Public Function GiganewtonsPerSquaremeter(values As IEnumerable(Of Double)) As IEnumerable(Of Pressure)
        Return values.Select(AddressOf Pressure.FromGiganewtonsPerSquaremeter)
    End Function


    <Extension>
    Public Function NewtonsPerSquaremillimeter(value As Pressure?) As Double?
        If value.HasValue Then
            Return value.Value.NewtonsPerSquaremillimeter
        Else
            Return Nothing
        End If
    End Function

    Public Function NewtonsPerSquaremillimeter(value As Double) As Pressure
        Return Pressure.FromNewtonsPerSquaremillimeter(value)
    End Function
    Public Function NewtonsPerSquaremillimeter(value As Double?) As Pressure?
        If value.HasValue Then
            Return Pressure.FromNewtonsPerSquaremillimeter(value)
        Else
            Return Nothing
        End If
    End Function

    Public Function NewtonsPerSquaremillimeter(values As Double()) As Pressure()
        Return Array.ConvertAll(values, AddressOf Pressure.FromNewtonsPerSquaremillimeter)
    End Function

    Public Function NewtonsPerSquaremillimeter(values As IEnumerable(Of Double)) As IEnumerable(Of Pressure)
        Return values.Select(AddressOf Pressure.FromNewtonsPerSquaremillimeter)
    End Function


    <Extension>
    Public Function Pascals(value As Pressure?) As Double?
        If value.HasValue Then
            Return value.Value.Pascals
        Else
            Return Nothing
        End If
    End Function

    Public Function Pascals(value As Double) As Pressure
        Return Pressure.FromPascals(value)
    End Function
    Public Function Pascals(value As Double?) As Pressure?
        If value.HasValue Then
            Return Pressure.FromPascals(value)
        Else
            Return Nothing
        End If
    End Function

    Public Function Pascals(values As Double()) As Pressure()
        Return Array.ConvertAll(values, AddressOf Pressure.FromPascals)
    End Function

    Public Function Pascals(values As IEnumerable(Of Double)) As IEnumerable(Of Pressure)
        Return values.Select(AddressOf Pressure.FromPascals)
    End Function


    Public Function Kilopascals(value As Double) As Pressure
        Return Pressure.FromKilonewtonsPerSquaremeter(value)
    End Function
    Public Function Kilopascals(value As Double?) As Pressure?
        If value.HasValue Then
            Return Pressure.FromKilonewtonsPerSquaremeter(value)
        Else
            Return Nothing
        End If
    End Function

    Public Function Kilopascals(values As Double()) As Pressure()
        Return Array.ConvertAll(values, AddressOf Pressure.FromKiloPascals)
    End Function

    Public Function Kilopascals(values As IEnumerable(Of Double)) As IEnumerable(Of Pressure)
        Return values.Select(AddressOf Pressure.FromKiloPascals)
    End Function


    Public Function Megapascals(value As Double) As Pressure
        Return Pressure.FromMegaPascals(value)
    End Function
    Public Function Megapascals(value As Double?) As Pressure?
        If value.HasValue Then
            Return Pressure.FromMegaPascals(value)
        Else
            Return Nothing
        End If
    End Function

    Public Function Megapascals(values As Double()) As Pressure()
        Return Array.ConvertAll(values, AddressOf Pressure.FromMegaPascals)
    End Function

    Public Function Megapascals(values As IEnumerable(Of Double)) As IEnumerable(Of Pressure)
        Return values.Select(AddressOf Pressure.FromMegaPascals)
    End Function


    Public Function Gigapascals(value As Double) As Pressure
        Return Pressure.FromGiganewtonsPerSquaremeter(value)
    End Function
    Public Function Gigapascals(value As Double?) As Pressure?
        If value.HasValue Then
            Return Pressure.FromGiganewtonsPerSquaremeter(value)
        Else
            Return Nothing
        End If
    End Function

    'Public Function Gigapascals(values As Double()) As Pressure()
    '    Return Array.ConvertAll(values, AddressOf Pressure.FromGigapascals)
    'End Function

    'Public Function Gigapascals(values As IEnumerable(Of Double)) As IEnumerable(Of Pressure)
    '    Return values.Select(AddressOf Pressure.FromGigapascals)
    'End Function


    <Extension>
    Public Function PoundsPerSquareInch(value As Pressure?) As Double?
        If value.HasValue Then
            Return value.Value.PoundsPerSquareInch
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function StandardAtmospheres(value As Pressure?) As Double?
        If value.HasValue Then
            Return value.Value.StandardAtmospheres
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function TechnicalAtmospheres(value As Pressure?) As Double?
        If value.HasValue Then
            Return value.Value.TechnicalAtmospheres
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function Torrs(value As Pressure?) As Double?
        If value.HasValue Then
            Return value.Value.Torrs
        Else
            Return Nothing
        End If
    End Function

End Module