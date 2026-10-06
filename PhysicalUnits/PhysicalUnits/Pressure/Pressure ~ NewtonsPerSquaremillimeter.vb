Option Strict On
Option Infer On

Partial Structure Pressure

    Shared Function FromNewtonsPerSquaremillimeter(d As Double) As Pressure
        Return New Pressure With {.MyNewtonsPerSquaremillimeter = d}
    End Function
    Public Shared Function FromNewtonsPerSquaremillimeter(d As Double?) As Pressure?
        If d.HasValue Then
            Return FromNewtonsPerSquaremillimeter(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Pressure in N/mm² </summary>
    Public ReadOnly Property NewtonsPerSquaremillimeter() As Double
        Get
            Return MyNewtonsPerSquaremillimeter
        End Get
    End Property
    Private Property MyNewtonsPerSquaremillimeter() As Double
        Get
            Return Me.Value(SupportedPressureUnits.NewtonsPerSquaremillimeter)
        End Get
        Set(value As Double)
            Me.Value(SupportedPressureUnits.NewtonsPerSquaremillimeter) = value
        End Set
    End Property

End Structure