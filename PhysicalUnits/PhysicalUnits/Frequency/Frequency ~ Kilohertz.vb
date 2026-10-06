Option Strict On
Option Infer On

Partial Structure Frequency

    Public Shared Function FromKilohertz(d As Double) As Frequency
        Return New Frequency With {.MyKilohertz = d}
    End Function
    Public Shared Function FromKilohertz(d As Double?) As Frequency?
        If d.HasValue Then
            Return FromKilohertz(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Frequency in kHz </summary>
    Public ReadOnly Property Kilohertz() As Double
        Get
            Return MyKilohertz
        End Get
    End Property
    Private Property MyKilohertz() As Double
        Get
            Return Me.Value(SupportedFrequencyUnits.Kilohertz)
        End Get
        Set(value As Double)
            Me.Value(SupportedFrequencyUnits.Kilohertz) = value
        End Set
    End Property

End Structure