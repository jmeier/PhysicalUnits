Option Strict On
Option Infer On

Partial Structure Pressure

    Public Shared Function FromPascals(d As Double) As Pressure
        Return FromNewtonsPerSquaremeter(d)
    End Function
    Public Shared Function FromPascals(d As Double?) As Pressure?
        If d.HasValue Then
            Return FromPascals(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Pressure in Pascals (Pa) </summary>
    Public ReadOnly Property Pascals() As Double
        Get
            Return _NewtonsPerSquaremeter
        End Get
    End Property

End Structure