Option Strict On
Option Infer On

Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

#Region "NewtonsMeter"

    <Extension>
    Public Function NewtonMeters(value As TimesLength(Of Force)) As Double
        Return value.ValueTimesMeter.Newtons
    End Function

    <Extension>
    Public Function NewtonMeters(value As TimesLength(Of Force)?) As Double?
        If value.HasValue Then
            Return value.Value.ValueTimesMeter.Newtons
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function NewtonMeters(value As Double) As TimesLength(Of Force)
        Return Newtons(value).TimesMeter
    End Function

    <Extension>
    Public Function NewtonMeters(value As Double?) As TimesLength(Of Force)?
        If value.HasValue Then
            Return Newtons(value).TimesMeter
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "KilonewtonsMeter"

    <Extension>
    Public Function KilonewtonMeters(value As TimesLength(Of Force)) As Double
        Return value.ValueTimesMeter.Kilonewtons
    End Function

    <Extension>
    Public Function KilonewtonMeters(value As TimesLength(Of Force)?) As Double?
        If value.HasValue Then
            Return value.Value.ValueTimesMeter.Kilonewtons
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function KilonewtonMeters(value As Double) As TimesLength(Of Force)
        Return Kilonewtons(value).TimesMeter
    End Function

    <Extension>
    Public Function KilonewtonMeters(value As Double?) As TimesLength(Of Force)?
        If value.HasValue Then
            Return Kilonewtons(value).TimesMeter
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "MeganewtonsMeter"

    <Extension>
    Public Function MeganewtonMeters(value As TimesLength(Of Force)) As Double
        Return value.ValueTimesMeter.Meganewtons
    End Function

    <Extension>
    Public Function MeganewtonMeters(value As TimesLength(Of Force)?) As Double?
        If value.HasValue Then
            Return value.Value.ValueTimesMeter.Meganewtons
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function MeganewtonMeters(value As Double) As TimesLength(Of Force)
        Return Meganewtons(value).TimesMeter
    End Function

    <Extension>
    Public Function MeganewtonMeters(value As Double?) As TimesLength(Of Force)?
        If value.HasValue Then
            Return Meganewtons(value).TimesMeter
        Else
            Return Nothing
        End If
    End Function

#End Region

End Module