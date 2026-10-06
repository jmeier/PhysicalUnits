Option Strict On
Option Infer On

Partial Structure Elevation

    Public Shared Function FromMetersAboveNN(d As Double) As Elevation
        Return New Elevation With {._MetersAboveNN = d}
    End Function
    Public Shared Function FromMetersAboveNN(d As Double?) As Elevation?
        If d.HasValue Then
            Return FromMetersAboveNN(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Elevation in m above NN</summary>
    Public ReadOnly Property MetersAboveNN() As Double
        Get
            Return _MetersAboveNN
        End Get
    End Property
    Private _MetersAboveNN As Double

End Structure