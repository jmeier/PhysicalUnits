Option Strict On
Option Infer On

Partial Structure Frequency

    Public Shared Function FromHertz(d As Double) As Frequency
        Return New Frequency With {._Hertz = d}
    End Function
    Public Shared Function FromHertz(d As Double?) As Frequency?
        If d.HasValue Then
            Return FromHertz(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Frequency in Hertz (1 Hz = 1/sec) </summary>
    Public ReadOnly Property Hertz() As Double
        Get
            Return _Hertz
        End Get
    End Property
    Private _Hertz As Double

End Structure