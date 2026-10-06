Option Strict On
Option Infer On

Partial Structure Pressure

    Public Shared Function FromMegaPascals(d As Double) As Pressure
        Return FromPascals(d * 1000 * 1000)
    End Function
    Public Shared Function FromMegaPascals(d As Double?) As Pressure?
        If d.HasValue Then
            Return FromPascals(d.Value * 1000 * 1000)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Megapascals </summary>
    Public ReadOnly Property MegaPascals() As Double
        Get
            Return MeganewtonsPerSquaremeter
        End Get
    End Property

End Structure