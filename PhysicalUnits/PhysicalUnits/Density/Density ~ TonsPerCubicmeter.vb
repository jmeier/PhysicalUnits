Option Strict On
Option Infer On

Partial Structure Density

    Public Shared Function FromTonsPerCubicmeter(d As Double) As Density
        Return New Density With {._KilogramsPerCubicmeter = d * 1000}
    End Function
    Public Shared Function FromTonsPerCubicmeter(d As Double?) As Density?
        If d.HasValue Then
            Return FromTonsPerCubicmeter(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Material unit weight in t/m³ </summary>
    Public ReadOnly Property TonsPerCubicmeter() As Double
        Get
            Return MyTonsPerCubicmeter
        End Get
    End Property
    Private Property MyTonsPerCubicmeter() As Double
        Get
            Return Me.Value(SupportedDensityUnits.TonsPerCubicmeter)
        End Get
        Set(value As Double)
            Me.Value(SupportedDensityUnits.TonsPerCubicmeter) = value
        End Set
    End Property


End Structure