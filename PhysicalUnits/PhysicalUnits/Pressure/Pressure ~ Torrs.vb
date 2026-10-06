Option Strict On
Option Infer On

Partial Structure Pressure

    Public Shared Function FromTorrs(d As Double) As Pressure
        Return New Pressure With {.MyTorrs = d}
    End Function
    Public Shared Function FromTorrs(d As Double?) As Pressure?
        If d.HasValue Then
            Return FromTorrs(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Torr </summary>
    Public ReadOnly Property Torrs() As Double
        Get
            Return MyTorrs
        End Get
    End Property
    Private Property MyTorrs() As Double
        Get
            Return Me.Value(SupportedPressureUnits.Torrs)
        End Get
        Set(value As Double)
            Me.Value(SupportedPressureUnits.Torrs) = value
        End Set
    End Property

End Structure