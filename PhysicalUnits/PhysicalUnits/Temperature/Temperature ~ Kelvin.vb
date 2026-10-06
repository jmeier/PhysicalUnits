Option Strict On
Option Infer On

Partial Structure Temperature

    Public Shared Function FromKelvin(d As Double) As Temperature
        Return New Temperature With {._Kelvin = d}
    End Function
    Public Shared Function FromKelvin(d As Double?) As Temperature?
        If d.HasValue Then
            Return FromKelvin(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Temperature in °K </summary>
    Public ReadOnly Property Kelvin() As Double
        Get
            Return _Kelvin
        End Get
    End Property
    Private _Kelvin As Double

End Structure