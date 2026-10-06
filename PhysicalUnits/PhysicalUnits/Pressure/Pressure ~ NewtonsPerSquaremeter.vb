Option Strict On
Option Infer On

Partial Structure Pressure

    Public Shared Function FromNewtonsPerSquaremeter(d As Double) As Pressure
        Return New Pressure With {._NewtonsPerSquaremeter = d}
    End Function
    Public Shared Function FromNewtonsPerSquaremeter(d As Double?) As Pressure?
        If d.HasValue Then
            Return FromNewtonsPerSquaremeter(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Pressure in N/m² </summary>
    Public ReadOnly Property NewtonsPerSquaremeter() As Double
        Get
            Return _NewtonsPerSquaremeter
        End Get
    End Property
    Private _NewtonsPerSquaremeter As Double

End Structure