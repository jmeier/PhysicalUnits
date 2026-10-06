Option Strict On
Option Infer On

Partial Structure Length

    Public Shared Function FromMeters(d As Double) As Length
        Return New Length With {._Meters = d}
    End Function
    Public Shared Function FromMeters(d As Double?) As Length?
        If d.HasValue Then
            Return FromMeters(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length in m </summary>
    Public ReadOnly Property Meters() As Double
        Get
            Return _Meters
        End Get
    End Property
    Private _Meters As Double

End Structure