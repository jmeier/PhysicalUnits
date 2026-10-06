Option Strict On
Option Infer On

Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

#Region "NewtonsPerCubicMeter"

    <Extension>
    Public Function NewtonsPerCubicMeter(value As PerVolume(Of Force)) As Double
        Return value.ValuePerCubicmeter.Newtons
    End Function

    <Extension>
    Public Function NewtonsPerCubicMeter(value As PerVolume(Of Force)?) As Double?
        If value.HasValue Then
            Return value.Value.ValuePerCubicmeter.Newtons
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function NewtonsPerCubicMeter(value As Double) As PerVolume(Of Force)
        Return Newtons(value).PerCubicmeter
    End Function

    <Extension>
    Public Function NewtonsPerCubicMeter(value As Double?) As PerVolume(Of Force)?
        Return Newtons(value).PerCubicmeter
    End Function

#End Region

#Region "KilonewtonsPerCubicMeter"

    <Extension>
    Public Function KilonewtonsPerCubicMeter(value As PerVolume(Of Force)) As Double
        Return value.ValuePerCubicmeter.Kilonewtons
    End Function

    <Extension>
    Public Function KilonewtonsPerCubicMeter(value As PerVolume(Of Force)?) As Double?
        If value.HasValue Then
            Return value.Value.ValuePerCubicmeter.Kilonewtons
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function KilonewtonsPerCubicMeter(value As Double) As PerVolume(Of Force)
        Return Kilonewtons(value).PerCubicmeter
    End Function

    <Extension>
    Public Function KilonewtonsPerCubicMeter(value As Double?) As PerVolume(Of Force)?
        Return Kilonewtons(value).PerCubicmeter
    End Function

#End Region

#Region "MeganewtonsPerCubicMeter"

    <Extension>
    Public Function MeganewtonsPerCubicMeter(value As PerVolume(Of Force)) As Double
        Return value.ValuePerCubicmeter.Meganewtons
    End Function

    <Extension>
    Public Function MeganewtonsPerCubicMeter(value As PerVolume(Of Force)?) As Double?
        If value.HasValue Then
            Return value.Value.ValuePerCubicmeter.Meganewtons
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function MeganewtonsPerCubicMeter(value As Double) As PerVolume(Of Force)
        Return Meganewtons(value).PerCubicmeter
    End Function

    <Extension>
    Public Function MeganewtonsPerCubicMeter(value As Double?) As PerVolume(Of Force)?
        Return Meganewtons(value).PerCubicmeter
    End Function

#End Region

End Module