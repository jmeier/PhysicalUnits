Option Strict On
Option Infer On

Partial Structure Density

    Public Shared Function FromGramsPerCubiccentimeter(d As Double) As Density
        Return New Density With {._KilogramsPerCubicmeter = d * 1000}
    End Function
    Public Shared Function FromGramsPerCubiccentimeter(d As Double?) As Density?
        If d.HasValue Then
            Return FromGramsPerCubiccentimeter(d.Value)
        Else
            Return Nothing
        End If
    End Function

    Public ReadOnly Property GramsPerCubiccentimeter() As Double
        Get
            Return _KilogramsPerCubicmeter / 1000
        End Get
    End Property

End Structure