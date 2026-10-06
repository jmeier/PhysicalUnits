Option Strict On
Option Infer On

Partial Structure Density

    Public Shared Function FromKilogramsPerCubicmeter(d As Double) As Density
        Return New Density With {._KilogramsPerCubicmeter = d}
    End Function
    Public Shared Function FromKilogramsPerCubicmeter(d As Double?) As Density?
        If d.HasValue Then
            Return FromKilogramsPerCubicmeter(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Material density in kg/m³ </summary>
    Public ReadOnly Property KilogramsPerCubicmeter() As Double
        Get
            Return _KilogramsPerCubicmeter
        End Get
    End Property
    Private _KilogramsPerCubicmeter As Double

End Structure