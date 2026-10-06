Option Strict On
Option Infer On

Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

#Region "NewtonsCubicMeter"

    <Extension>
    Public Function NewtonCubicMeters(value As TimesVolume(Of Force)) As Double
        Return value.ValueTimesCubicMeter.Newtons
    End Function

    <Extension>
    Public Function NewtonCubicMeters(value As TimesVolume(Of Force)?) As Double?
        If value.HasValue Then
            Return value.Value.ValueTimesCubicMeter.Newtons
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function NewtonCubicMeters(value As Double) As TimesVolume(Of Force)
        Return Newtons(value).TimesCubicMeter
    End Function

    <Extension>
    Public Function NewtonCubicMeters(value As Double?) As TimesVolume(Of Force)?
        If value.HasValue Then
            Return Newtons(value).TimesCubicMeter
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "KilonewtonsCubicMeter"

    <Extension>
    Public Function KilonewtonCubicMeters(value As TimesVolume(Of Force)) As Double
        Return value.ValueTimesCubicMeter.Kilonewtons
    End Function

    <Extension>
    Public Function KilonewtonCubicMeters(value As TimesVolume(Of Force)?) As Double?
        If value.HasValue Then
            Return value.Value.ValueTimesCubicMeter.Kilonewtons
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function KilonewtonCubicMeters(value As Double) As TimesVolume(Of Force)
        Return Kilonewtons(value).TimesCubicMeter
    End Function

    <Extension>
    Public Function KilonewtonCubicMeters(value As Double?) As TimesVolume(Of Force)?
        If value.HasValue Then
            Return Kilonewtons(value).TimesCubicMeter
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "MeganewtonsCubicMeter"

    <Extension>
    Public Function MeganewtonCubicMeters(value As TimesVolume(Of Force)) As Double
        Return value.ValueTimesCubicMeter.Meganewtons
    End Function

    <Extension>
    Public Function MeganewtonCubicMeters(value As TimesVolume(Of Force)?) As Double?
        If value.HasValue Then
            Return value.Value.ValueTimesCubicMeter.Meganewtons
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function MeganewtonCubicMeters(value As Double) As TimesVolume(Of Force)
        Return Meganewtons(value).TimesCubicMeter
    End Function

    <Extension>
    Public Function MeganewtonCubicMeters(value As Double?) As TimesVolume(Of Force)?
        If value.HasValue Then
            Return Meganewtons(value).TimesCubicMeter
        Else
            Return Nothing
        End If
    End Function

#End Region

End Module