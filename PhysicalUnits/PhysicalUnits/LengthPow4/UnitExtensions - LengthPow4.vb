Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(values As IEnumerable(Of LengthPow4)) As LengthPow4
        Dim result = LengthPow4.Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    <Extension>
    Public Function Min(values As IEnumerable(Of LengthPow4)) As LengthPow4
        Dim result = LengthPow4.MaxValue
        For Each item In values
            If item < result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Max(values As IEnumerable(Of LengthPow4)) As LengthPow4
        Dim result = LengthPow4.MinValue
        For Each item In values
            If item > result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Average(values As IEnumerable(Of LengthPow4)) As LengthPow4
        Return LengthPow4.FromMetersPow4(Aggregate i In values Into d = Average(i.MetersPow4))
    End Function



    <Extension>
    Public Function MillimetersPow4(value As LengthPow4?) As Double?
        If value.HasValue Then
            Return value.Value.MillimetersPow4
        Else
            Return Nothing
        End If
    End Function

    Public Function MillimetersPow4(value As Double) As LengthPow4
        Return LengthPow4.FromMillimetersPow4(value)
    End Function
    Public Function MillimetersPow4(value As Double?) As LengthPow4?
        If value.HasValue Then
            Return LengthPow4.FromMillimetersPow4(value)
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function CentimetersPow4(value As LengthPow4?) As Double?
        If value.HasValue Then
            Return value.Value.CentimetersPow4
        Else
            Return Nothing
        End If
    End Function

    Public Function CentimetersPow4(value As Double) As LengthPow4
        Return LengthPow4.FromCentimetersPow4(value)
    End Function
    Public Function CentimetersPow4(value As Double?) As LengthPow4?
        If value.HasValue Then
            Return LengthPow4.FromCentimetersPow4(value)
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function DecimetersPow4(value As LengthPow4?) As Double?
        If value.HasValue Then
            Return value.Value.DecimetersPow4
        Else
            Return Nothing
        End If
    End Function

    Public Function DecimetersPow4(value As Double) As LengthPow4
        Return LengthPow4.FromDecimetersPow4(value)
    End Function
    Public Function DecimetersPow4(value As Double?) As LengthPow4?
        If value.HasValue Then
            Return LengthPow4.FromDecimetersPow4(value)
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function MetersPow4(value As LengthPow4?) As Double?
        If value.HasValue Then
            Return value.Value.MetersPow4
        Else
            Return Nothing
        End If
    End Function

    Public Function MetersPow4(value As Double) As LengthPow4
        Return LengthPow4.FromMetersPow4(value)
    End Function
    Public Function MetersPow4(value As Double?) As LengthPow4?
        If value.HasValue Then
            Return LengthPow4.FromMetersPow4(value)
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function KilometersPow4(value As LengthPow4?) As Double?
        If value.HasValue Then
            Return value.Value.KilometersPow4
        Else
            Return Nothing
        End If
    End Function

    Public Function KilometersPow4(value As Double) As LengthPow4
        Return LengthPow4.FromKilometersPow4(value)
    End Function
    Public Function KilometersPow4(value As Double?) As LengthPow4?
        If value.HasValue Then
            Return LengthPow4.FromKilometersPow4(value)
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function InchsPow4(value As LengthPow4?) As Double?
        If value.HasValue Then
            Return value.Value.InchsPow4
        Else
            Return Nothing
        End If
    End Function

    Public Function InchsPow4(value As Double) As LengthPow4
        Return LengthPow4.FromInchsPow4(value)
    End Function
    Public Function InchsPow4(value As Double?) As LengthPow4?
        If value.HasValue Then
            Return LengthPow4.FromInchsPow4(value)
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function FeetPow4(value As LengthPow4?) As Double?
        If value.HasValue Then
            Return value.Value.FeetPow4
        Else
            Return Nothing
        End If
    End Function

    Public Function FeetPow4(value As Double) As LengthPow4
        Return LengthPow4.FromFeetPow4(value)
    End Function
    Public Function FeetPow4(value As Double?) As LengthPow4?
        If value.HasValue Then
            Return LengthPow4.FromFeetPow4(value)
        Else
            Return Nothing
        End If
    End Function


    <Extension>
    Public Function YardsPow4(value As LengthPow4?) As Double?
        If value.HasValue Then
            Return value.Value.YardsPow4
        Else
            Return Nothing
        End If
    End Function

    Public Function YardsPow4(value As Double) As LengthPow4
        Return LengthPow4.FromYardsPow4(value)
    End Function
    Public Function YardsPow4(value As Double?) As LengthPow4?
        If value.HasValue Then
            Return LengthPow4.FromYardsPow4(value)
        Else
            Return Nothing
        End If
    End Function

End Module