Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(values As IEnumerable(Of Volume)) As Volume
        Dim result = Volume.Zero
        For Each item In values
            result += item
        Next
        Return result
    End Function

    <Extension>
    Public Function Min(values As IEnumerable(Of Volume)) As Volume
        Dim result = Volume.MaxValue
        For Each item In values
            If item < result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Max(values As IEnumerable(Of Volume)) As Volume
        Dim result = Volume.MinValue
        For Each item In values
            If item > result Then result = item
        Next
        Return result
    End Function

    <Extension>
    Public Function Average(values As IEnumerable(Of Volume)) As Volume
        Return Volume.FromMetersPow3(Aggregate i In values Into d = Average(i.MetersPow3))
    End Function

#Region "CubicMillimeters, MillimetersPow3"

    <Extension>
    Public Function CubicMillimeters(value As Volume?) As Double?
        If value.HasValue Then
            Return value.Value.MillimetersPow3
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function CubicMillimeters(value As Double) As Volume
        Return Volume.FromMillimetersPow3(value)
    End Function

    <Extension>
    Public Function CubicMillimeters(value As Double?) As Volume?
        If value.HasValue Then
            Return Volume.FromMillimetersPow3(value)
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function MillimetersPow3(value As Volume?) As Double?
        If value.HasValue Then
            Return value.Value.MillimetersPow3
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function MillimetersPow3(value As Double) As Volume
        Return Volume.FromMillimetersPow3(value)
    End Function

    <Extension>
    Public Function MillimetersPow3(value As Double?) As Volume?
        If value.HasValue Then
            Return Volume.FromMillimetersPow3(value)
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "CubicCentimeters, CentimetersPow3"

    <Extension>
    Public Function CubicCentimeters(value As Volume?) As Double?
        If value.HasValue Then
            Return value.Value.CentimetersPow3
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function CubicCentimeters(value As Double) As Volume
        Return Volume.FromCentimetersPow3(value)
    End Function

    <Extension>
    Public Function CubicCentimeters(value As Double?) As Volume?
        If value.HasValue Then
            Return Volume.FromCentimetersPow3(value)
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function CentimetersPow3(value As Volume?) As Double?
        If value.HasValue Then
            Return value.Value.CentimetersPow3
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function CentimetersPow3(value As Double) As Volume
        Return Volume.FromCentimetersPow3(value)
    End Function

    <Extension>
    Public Function CentimetersPow3(value As Double?) As Volume?
        If value.HasValue Then
            Return Volume.FromCentimetersPow3(value)
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "CubicDecimeters, DecimetersPow3"

    <Extension>
    Public Function CubicDecimeters(value As Volume?) As Double?
        If value.HasValue Then
            Return value.Value.DecimetersPow3
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function CubicDecimeters(value As Double) As Volume
        Return Volume.FromDecimetersPow3(value)
    End Function

    <Extension>
    Public Function CubicDecimeters(value As Double?) As Volume?
        If value.HasValue Then
            Return Volume.FromDecimetersPow3(value)
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function DecimetersPow3(value As Volume?) As Double?
        If value.HasValue Then
            Return value.Value.DecimetersPow3
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function DecimetersPow3(value As Double) As Volume
        Return Volume.FromDecimetersPow3(value)
    End Function

    <Extension>
    Public Function DecimetersPow3(value As Double?) As Volume?
        If value.HasValue Then
            Return Volume.FromDecimetersPow3(value)
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "CubicMeters, MetersPow3"

    <Extension>
    Public Function CubicMeters(value As Volume?) As Double?
        If value.HasValue Then
            Return value.Value.MetersPow3
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function CubicMeters(value As Double) As Volume
        Return Volume.FromMetersPow3(value)
    End Function

    <Extension>
    Public Function CubicMeters(value As Double?) As Volume?
        If value.HasValue Then
            Return Volume.FromMetersPow3(value)
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function MetersPow3(value As Volume?) As Double?
        If value.HasValue Then
            Return value.Value.MetersPow3
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function MetersPow3(value As Double) As Volume
        Return Volume.FromMetersPow3(value)
    End Function

    <Extension>
    Public Function MetersPow3(value As Double?) As Volume?
        If value.HasValue Then
            Return Volume.FromMetersPow3(value)
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "CubicKilometers, KilometersPow3"

    <Extension>
    Public Function CubicKilometers(value As Volume?) As Double?
        If value.HasValue Then
            Return value.Value.KilometersPow3
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function CubicKilometers(value As Double) As Volume
        Return Volume.FromKilometersPow3(value)
    End Function

    <Extension>
    Public Function CubicKilometers(value As Double?) As Volume?
        If value.HasValue Then
            Return Volume.FromKilometersPow3(value)
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function KilometersPow3(value As Volume?) As Double?
        If value.HasValue Then
            Return value.Value.KilometersPow3
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function KilometersPow3(value As Double) As Volume
        Return Volume.FromKilometersPow3(value)
    End Function

    <Extension>
    Public Function KilometersPow3(value As Double?) As Volume?
        If value.HasValue Then
            Return Volume.FromKilometersPow3(value)
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "CubicInchs, InchsPow3"

    <Extension>
    Public Function CubicInchs(value As Volume?) As Double?
        If value.HasValue Then
            Return value.Value.InchsPow3
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function CubicInchs(value As Double) As Volume
        Return Volume.FromInchsPow3(value)
    End Function

    <Extension>
    Public Function CubicInchs(value As Double?) As Volume?
        If value.HasValue Then
            Return Volume.FromInchsPow3(value)
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function InchsPow3(value As Volume?) As Double?
        If value.HasValue Then
            Return value.Value.InchsPow3
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function InchsPow3(value As Double) As Volume
        Return Volume.FromInchsPow3(value)
    End Function

    <Extension>
    Public Function InchsPow3(value As Double?) As Volume?
        If value.HasValue Then
            Return Volume.FromInchsPow3(value)
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "CubicFeet, FeetPow3"

    <Extension>
    Public Function CubicFeet(value As Volume?) As Double?
        If value.HasValue Then
            Return value.Value.FeetPow3
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function CubicFeet(value As Double) As Volume
        Return Volume.FromFeetPow3(value)
    End Function

    <Extension>
    Public Function CubicFeet(value As Double?) As Volume?
        If value.HasValue Then
            Return Volume.FromFeetPow3(value)
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function FeetPow3(value As Volume?) As Double?
        If value.HasValue Then
            Return value.Value.FeetPow3
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function FeetPow3(value As Double) As Volume
        Return Volume.FromFeetPow3(value)
    End Function

    <Extension>
    Public Function FeetPow3(value As Double?) As Volume?
        If value.HasValue Then
            Return Volume.FromFeetPow3(value)
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "CubicYards, YardsPow3"

    <Extension>
    Public Function CubicYards(value As Volume?) As Double?
        If value.HasValue Then
            Return value.Value.YardsPow3
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function CubicYards(value As Double) As Volume
        Return Volume.FromYardsPow3(value)
    End Function

    <Extension>
    Public Function CubicYards(value As Double?) As Volume?
        If value.HasValue Then
            Return Volume.FromYardsPow3(value)
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function YardsPow3(value As Volume?) As Double?
        If value.HasValue Then
            Return value.Value.YardsPow3
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function YardsPow3(value As Double) As Volume
        Return Volume.FromYardsPow3(value)
    End Function

    <Extension>
    Public Function YardsPow3(value As Double?) As Volume?
        If value.HasValue Then
            Return Volume.FromYardsPow3(value)
        Else
            Return Nothing
        End If
    End Function

#End Region

End Module