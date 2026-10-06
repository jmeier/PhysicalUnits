Option Strict On
Option Infer On

Partial Structure Velocity

    Public Shared Function FromKilometersPerHour(d As Double) As Velocity
        Return New Velocity With {.MyKilometersPerHour = d}
    End Function
    Public Shared Function FromKilometersPerHour(d As Double?) As Velocity?
        If d.HasValue Then
            Return FromKilometersPerHour(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Velocity in km/h </summary>
    Public ReadOnly Property KilometersPerHour() As Double
        Get
            Return MyKilometersPerHour
        End Get
    End Property
    Private Property MyKilometersPerHour() As Double
        Get
            Return Me.Value(SupportedVelocityUnits.KilometersPerHour)
        End Get
        Set(value As Double)
            Me.Value(SupportedVelocityUnits.KilometersPerHour) = value
        End Set
    End Property

End Structure