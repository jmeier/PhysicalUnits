Option Strict On
Option Infer On

Partial Structure Pressure

    Public Shared Function FromBars(d As Double) As Pressure
        Return New Pressure With {.MyBars = d}
    End Function
    Public Shared Function FromBars(d As Double?) As Pressure?
        If d.HasValue Then
            Return FromBars(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Pressure in bar </summary>
    Public ReadOnly Property Bars() As Double
        Get
            Return MyBars
        End Get
    End Property
    Private Property MyBars() As Double
        Get
            Return Me.Value(SupportedPressureUnits.Bars)
        End Get
        Set(value As Double)
            Me.Value(SupportedPressureUnits.Bars) = value
        End Set
    End Property

End Structure