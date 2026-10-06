Option Strict On
Option Infer On

Partial Structure SoundPressure

    Public Shared Function FromDecibel(d As Double) As SoundPressure
        Return New SoundPressure With {._Decibel = d}
    End Function
    Public Shared Function FromDecibel(d As Double?) As SoundPressure?
        If d.HasValue Then
            Return FromDecibel(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> SoundPressure in dB </summary>
    ''' <remarks> Sound pressure level (SPL) </remarks>
    Public ReadOnly Property Decibel() As Double
        Get
            Return _Decibel
        End Get
    End Property
    Private _Decibel As Double

End Structure