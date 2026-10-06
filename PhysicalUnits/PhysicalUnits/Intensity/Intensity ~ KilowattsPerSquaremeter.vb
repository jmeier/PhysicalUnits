Option Strict On
Option Infer On

Partial Structure Intensity

    Public Shared Function FromKilowattsPerSquaremeter(d As Double) As Intensity
        Return New Intensity With {.MyKilowattsPerSquaremeter = d}
    End Function
    Public Shared Function FromKilowattsPerSquaremeter(d As Double?) As Intensity?
        If d.HasValue Then
            Return FromKilowattsPerSquaremeter(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Intensity in kW/m² </summary>
    Public ReadOnly Property KilowattsPerSquaremeter() As Double
        Get
            Return MyKilowattsPerSquaremeter
        End Get
    End Property
    Private Property MyKilowattsPerSquaremeter() As Double
        Get
            Return Me.Value(SupportedIntensityUnits.KilowattsPerSquaremeter)
        End Get
        Set(value As Double)
            Me.Value(SupportedIntensityUnits.KilowattsPerSquaremeter) = value
        End Set
    End Property


End Structure