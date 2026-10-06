Option Strict On
Option Infer On

Partial Structure Elevation

    Public Shared Function FromFeetAboveNN(d As Double) As Elevation
        Return New Elevation With {.MyFeetAboveNN = d}
    End Function
    Public Shared Function FromFeetAboveNN(d As Double?) As Elevation?
        If d.HasValue Then
            Return FromFeetAboveNN(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Elevation in ft above NN </summary>
    Public ReadOnly Property FeetAboveNN() As Double
        Get
            Return MyFeetAboveNN
        End Get
    End Property
    Private Property MyFeetAboveNN() As Double
        Get
            Return Me.Value(SupportedElevationUnits.FeetAboveNN)
        End Get
        Set(value As Double)
            Me.Value(SupportedElevationUnits.FeetAboveNN) = value
        End Set
    End Property

End Structure