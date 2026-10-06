Option Strict On
Option Infer On

Partial Structure Pressure

    Public Shared Function FromKiloPascals(d As Double) As Pressure
        Return FromPascals(d * 1000)
    End Function
    Public Shared Function FromKiloPascals(d As Double?) As Pressure?
        If d.HasValue Then
            Return FromPascals(d.Value * 1000)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Kilopascals </summary>
    Public ReadOnly Property KiloPascals() As Double
        Get
            Return KilonewtonsPerSquaremeter
        End Get
    End Property

End Structure