Option Strict On
Option Infer On

Partial Structure Power

    Public Shared Function FromKilowatts(d As Double) As Power
        Return New Power With {.MyKilowatts = d}
    End Function
    Public Shared Function FromKilowatts(d As Double?) As Power?
        If d.HasValue Then
            Return FromKilowatts(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Power in kW </summary>
    Public ReadOnly Property Kilowatts() As Double
        Get
            Return MyKilowatts
        End Get
    End Property
    Private Property MyKilowatts() As Double
        Get
            Return Me.Value(SupportedPowerUnits.Kilowatts)
        End Get
        Set(value As Double)
            Me.Value(SupportedPowerUnits.Kilowatts) = value
        End Set
    End Property


End Structure