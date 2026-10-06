Option Strict On
Option Infer On

Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    'Some of those Extension are commented out due to the fact they collide 
    'with the (more specific) extensions for Pressure.

#Region "NewtonsPerSquareMeter"

    <Extension>
    Public Function NewtonsPerSquareMeter(value As PerArea(Of Force)) As Double
        Return value.ValuePerSquaremeter.Newtons
    End Function

    <Extension>
    Public Function NewtonsPerSquareMeter(value As PerArea(Of Force)?) As Double?
        If value.HasValue Then
            Return value.Value.ValuePerSquaremeter.Newtons
        Else
            Return Nothing
        End If
    End Function

    '    <Extension>
    '    Public Function NewtonsPerSquareMeter(value As Double) As PerArea(Of Force)
    '        Return Newtons(value).PerSquaremeter
    '    End Function

    '    <Extension>
    '    Public Function NewtonsPerSquareMeter(value As Double?) As PerArea(Of Force)?
    '        Return Newtons(value).PerSquaremeter
    '    End Function

#End Region

#Region "KilonewtonsPerSquareMeter"

    <Extension>
    Public Function KilonewtonsPerSquareMeter(value As PerArea(Of Force)) As Double
        Return value.ValuePerSquaremeter.Kilonewtons
    End Function

    <Extension>
    Public Function KilonewtonsPerSquareMeter(value As PerArea(Of Force)?) As Double?
        If value.HasValue Then
            Return value.Value.ValuePerSquaremeter.Kilonewtons
        Else
            Return Nothing
        End If
    End Function

    '    <Extension>
    '    Public Function KilonewtonsPerSquareMeter(value As Double) As PerArea(Of Force)
    '        Return Kilonewtons(value).PerSquaremeter
    '    End Function

    '    <Extension>
    '    Public Function KilonewtonsPerSquareMeter(value As Double?) As PerArea(Of Force)?
    '        Return Kilonewtons(value).PerSquaremeter
    '    End Function

#End Region

#Region "MeganewtonsPerSquareMeter"

    <Extension>
    Public Function MeganewtonsPerSquareMeter(value As PerArea(Of Force)) As Double
        Return value.ValuePerSquaremeter.Meganewtons
    End Function

    <Extension>
    Public Function MeganewtonsPerSquareMeter(value As PerArea(Of Force)?) As Double?
        If value.HasValue Then
            Return value.Value.ValuePerSquaremeter.Meganewtons
        Else
            Return Nothing
        End If
    End Function

    '    <Extension>
    '    Public Function MeganewtonsPerSquareMeter(value As Double) As PerArea(Of Force)
    '        Return Meganewtons(value).PerSquaremeter
    '    End Function

    '    <Extension>
    '    Public Function MeganewtonsPerSquareMeter(value As Double?) As PerArea(Of Force)?
    '        Return Meganewtons(value).PerSquaremeter
    '    End Function

#End Region

End Module