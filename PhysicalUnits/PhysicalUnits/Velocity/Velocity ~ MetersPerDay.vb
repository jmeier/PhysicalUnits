Option Strict On
Option Infer On

Partial Structure Velocity

    Public Shared Function FromMetersPerDay(d As Double) As Velocity
        Return New Velocity With {.MyMetersPerDay = d}
    End Function
    Public Shared Function FromMetersPerDay(d As Double?) As Velocity?
        If d.HasValue Then
            Return FromMetersPerDay(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Velocity in m/day </summary>
    Public ReadOnly Property MetersPerDay() As Double
        Get
            Return MyMetersPerDay
        End Get
    End Property
    Private Property MyMetersPerDay() As Double
        Get
            Return Me.Value(SupportedVelocityUnits.MetersPerDay)
        End Get
        Set(value As Double)
            Me.Value(SupportedVelocityUnits.MetersPerDay) = value
        End Set
    End Property

End Structure