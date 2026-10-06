Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(values As IEnumerable(Of Velocity)) As Velocity
        Dim result = Velocity.Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    <Extension>
    Public Function Min(values As IEnumerable(Of Velocity)) As Velocity
        Dim result = Velocity.MaxValue
        For Each item In values
            If item < result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Max(values As IEnumerable(Of Velocity)) As Velocity
        Dim result = Velocity.MinValue
        For Each item In values
            If item > result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Average(values As IEnumerable(Of Velocity)) As Velocity
        Return Velocity.FromMetersPerSecond(Aggregate i In values Into d = Average(i.MetersPerSecond))
    End Function


    <Extension>
    Public Function KilometersPerHour(value As Velocity?) As Double?
        If value.HasValue Then
            Return value.Value.KilometersPerHour
        Else
            Return Nothing
        End If
    End Function

    Public Function KilometersPerHour(value As Double) As Velocity
        Return Velocity.FromKilometersPerHour(value)
    End Function
    Public Function KilometersPerHour(value As Double?) As Velocity?
        If value.HasValue Then
            Return Velocity.FromKilometersPerHour(value)
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function MetersPerDay(value As Velocity?) As Double?
        If value.HasValue Then
            Return value.Value.MetersPerDay
        Else
            Return Nothing
        End If
    End Function

    Public Function MetersPerDay(value As Double) As Velocity
        Return Velocity.FromMetersPerDay(value)
    End Function
    Public Function MetersPerDay(value As Double?) As Velocity?
        If value.HasValue Then
            Return Velocity.FromMetersPerDay(value)
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function MetersPerSecond(value As Velocity?) As Double?
        If value.HasValue Then
            Return value.Value.MetersPerSecond
        Else
            Return Nothing
        End If
    End Function

    Public Function MetersPerSecond(value As Double) As Velocity
        Return Velocity.FromMetersPerSecond(value)
    End Function
    Public Function MetersPerSecond(value As Double?) As Velocity?
        If value.HasValue Then
            Return Velocity.FromMetersPerSecond(value)
        Else
            Return Nothing
        End If
    End Function

End Module
