Option Strict On
Option Infer On

Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

#Region "NewtonSeconds"

    <Extension>
    Public Function NewtonSeconds(value As TimesTime(Of Force)) As Double
        Return value.ValueTimesSecond.Newtons
    End Function

    <Extension>
    Public Function NewtonSeconds(value As TimesTime(Of Force)?) As Double?
        If value.HasValue Then
            Return value.Value.ValueTimesSecond.Newtons
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function NewtonSeconds(value As Double) As TimesTime(Of Force)
        Return Newtons(value).TimesSecond
    End Function

    <Extension>
    Public Function NewtonSeconds(value As Double?) As TimesTime(Of Force)?
        If value.HasValue Then
            Return Newtons(value).TimesSecond
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "KilonewtonSeconds"

    <Extension>
    Public Function KilonewtonSeconds(value As TimesTime(Of Force)) As Double
        Return value.ValueTimesSecond.Kilonewtons
    End Function

    <Extension>
    Public Function KilonewtonSeconds(value As TimesTime(Of Force)?) As Double?
        If value.HasValue Then
            Return value.Value.ValueTimesSecond.Kilonewtons
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function KilonewtonSeconds(value As Double) As TimesTime(Of Force)
        Return Kilonewtons(value).TimesSecond
    End Function

    <Extension>
    Public Function KilonewtonSeconds(value As Double?) As TimesTime(Of Force)?
        If value.HasValue Then
            Return Kilonewtons(value).TimesSecond
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "MeganewtonSeconds"

    <Extension>
    Public Function MeganewtonSeconds(value As TimesTime(Of Force)) As Double
        Return value.ValueTimesSecond.Meganewtons
    End Function

    <Extension>
    Public Function MeganewtonSeconds(value As TimesTime(Of Force)?) As Double?
        If value.HasValue Then
            Return value.Value.ValueTimesSecond.Meganewtons
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function MeganewtonSeconds(value As Double) As TimesTime(Of Force)
        Return Meganewtons(value).TimesSecond
    End Function

    <Extension>
    Public Function MeganewtonSeconds(value As Double?) As TimesTime(Of Force)?
        If value.HasValue Then
            Return Meganewtons(value).TimesSecond
        Else
            Return Nothing
        End If
    End Function

#End Region

End Module