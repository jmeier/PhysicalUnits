Option Strict On
Option Infer On

Partial Structure Acceleration

    Public Shared Function FromMetersPerSquareSecond(d As Double) As Acceleration
        Return New Acceleration With {._MetersPerSquareSecond = d}
    End Function
    Public Shared Function FromMetersPerSquareSecond(d As Double?) As Acceleration?
        If d.HasValue Then
            Return FromMetersPerSquaresecond(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Acceleration in m/s² </summary>
    Public ReadOnly Property MetersPerSquareSecond() As Double
        Get
            Return _MetersPerSquareSecond
        End Get
    End Property
    Private _MetersPerSquareSecond As Double

End Structure