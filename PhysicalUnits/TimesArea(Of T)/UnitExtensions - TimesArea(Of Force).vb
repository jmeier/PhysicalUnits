Option Strict On
Option Infer On

Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

#Region "NewtonsSquareMeter"

    <Extension>
    Public Function NewtonSquareMeters(value As TimesArea(Of Force)) As Double
        Return value.ValueTimesSquareMeter.Newtons
    End Function

    <Extension>
    Public Function NewtonSquareMeters(value As TimesArea(Of Force)?) As Double?
        If value.HasValue Then
            Return value.Value.ValueTimesSquareMeter.Newtons
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function NewtonSquareMeters(value As Double) As TimesArea(Of Force)
        Return Newtons(value).TimesSquareMeter
    End Function

    <Extension>
    Public Function NewtonSquareMeters(value As Double?) As TimesArea(Of Force)?
        If value.HasValue Then
            Return Newtons(value).TimesSquareMeter
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "KilonewtonsSquareMeter"

    <Extension>
    Public Function KilonewtonSquareMeters(value As TimesArea(Of Force)) As Double
        Return value.ValueTimesSquareMeter.Kilonewtons
    End Function

    <Extension>
    Public Function KilonewtonSquareMeters(value As TimesArea(Of Force)?) As Double?
        If value.HasValue Then
            Return value.Value.ValueTimesSquareMeter.Kilonewtons
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function KilonewtonSquareMeters(value As Double) As TimesArea(Of Force)
        Return Kilonewtons(value).TimesSquareMeter
    End Function

    <Extension>
    Public Function KilonewtonSquareMeters(value As Double?) As TimesArea(Of Force)?
        If value.HasValue Then
            Return Kilonewtons(value).TimesSquareMeter
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "MeganewtonsSquareMeter"

    <Extension>
    Public Function MeganewtonSquareMeters(value As TimesArea(Of Force)) As Double
        Return value.ValueTimesSquareMeter.Meganewtons
    End Function

    <Extension>
    Public Function MeganewtonSquareMeters(value As TimesArea(Of Force)?) As Double?
        If value.HasValue Then
            Return value.Value.ValueTimesSquareMeter.Meganewtons
        Else
            Return Nothing
        End If
    End Function

    <Extension>
    Public Function MeganewtonSquareMeters(value As Double) As TimesArea(Of Force)
        Return Meganewtons(value).TimesSquareMeter
    End Function

    <Extension>
    Public Function MeganewtonSquareMeters(value As Double?) As TimesArea(Of Force)?
        If value.HasValue Then
            Return Meganewtons(value).TimesSquareMeter
        Else
            Return Nothing
        End If
    End Function

#End Region

End Module