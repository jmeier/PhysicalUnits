Option Strict On
Option Infer On

Partial Structure Intensity

    Public Shared Function FromWattsPerSquaremeter(d As Double) As Intensity
        Return New Intensity With {._WattsPerSquaremeter = d}
    End Function
    Public Shared Function FromWattsPerSquaremeter(d As Double?) As Intensity?
        If d.HasValue Then
            Return FromWattsPerSquaremeter(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Intensity in W/m² </summary>
    Public ReadOnly Property WattsPerSquaremeter() As Double
        Get
            Return _WattsPerSquaremeter
        End Get
    End Property
    Private _WattsPerSquaremeter As Double

End Structure