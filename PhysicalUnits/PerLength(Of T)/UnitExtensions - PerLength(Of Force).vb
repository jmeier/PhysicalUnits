Option Strict On
Option Infer On

Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

#Region "NewtonsPerMeter"

    <Extension>
    Public Function NewtonsPerMeter(value As PerLength(Of Force)) As Double
        Return value.ValuePerRunningMeter.Newtons
    End Function

    <Extension>
    Public Function NewtonsPerMeter(value As PerLength(Of Force)?) As Double?
        If value.HasValue Then
            Return value.Value.ValuePerRunningMeter.Newtons
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function NewtonsPerMeter(value As Double) As PerLength(Of Force)
        Return Newtons(value).PerRunningMeter
    End Function

    <Extension>
    Public Function NewtonsPerMeter(value As Double?) As PerLength(Of Force)?
        If value.HasValue Then
            Return Newtons(value).PerRunningMeter
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "KilonewtonsPerMeter"

    <Extension>
    Public Function KilonewtonsPerMeter(value As PerLength(Of Force)) As Double
        Return value.ValuePerRunningMeter.Kilonewtons
    End Function

    <Extension>
    Public Function KilonewtonsPerMeter(value As PerLength(Of Force)?) As Double?
        If value.HasValue Then
            Return value.Value.ValuePerRunningMeter.Kilonewtons
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function KilonewtonsPerMeter(value As Double) As PerLength(Of Force)
        Return Kilonewtons(value).PerRunningMeter
    End Function

    <Extension>
    Public Function KilonewtonsPerMeter(value As Double?) As PerLength(Of Force)?
        If value.HasValue Then
            Return Kilonewtons(value).PerRunningMeter
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "MeganewtonsPerMeter"

    <Extension>
    Public Function MeganewtonsPerMeter(value As PerLength(Of Force)) As Double
        Return value.ValuePerRunningMeter.Meganewtons
    End Function

    <Extension>
    Public Function MeganewtonsPerMeter(value As PerLength(Of Force)?) As Double?
        If value.HasValue Then
            Return value.Value.ValuePerRunningMeter.Meganewtons
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function MeganewtonsPerMeter(value As Double) As PerLength(Of Force)
        Return Meganewtons(value).PerRunningMeter
    End Function

    <Extension>
    Public Function MeganewtonsPerMeter(value As Double?) As PerLength(Of Force)?
        If value.HasValue Then
            Return Meganewtons(value).PerRunningMeter
        Else
            Return Nothing
        End If
    End Function

#End Region

End Module