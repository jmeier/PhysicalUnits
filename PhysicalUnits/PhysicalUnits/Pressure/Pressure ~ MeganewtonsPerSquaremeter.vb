Option Strict On
Option Infer On

Partial Structure Pressure

    Public Shared Function FromMeganewtonsPerSquaremeter(d As Double) As Pressure
        Return New Pressure With {.MyMeganewtonsPerSquaremeter = d}
    End Function
    Public Shared Function FromMeganewtonsPerSquaremeter(d As Double?) As Pressure?
        If d.HasValue Then
            Return FromMeganewtonsPerSquaremeter(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Pressure in MN/m² </summary>
    Public ReadOnly Property MeganewtonsPerSquaremeter() As Double
        Get
            Return MyMeganewtonsPerSquaremeter
        End Get
    End Property
    Private Property MyMeganewtonsPerSquaremeter() As Double
        Get
            Return Me.Value(SupportedPressureUnits.MeganewtonsPerSquaremeter)
        End Get
        Set(value As Double)
            Me.Value(SupportedPressureUnits.MeganewtonsPerSquaremeter) = value
        End Set
    End Property

End Structure