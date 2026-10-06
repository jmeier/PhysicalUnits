Option Strict On
Option Infer On

Partial Structure Power

    Public Shared Function FromWatts(d As Double) As Power
        Return New Power With {._Watts = d}
    End Function
    Public Shared Function FromWatts(d As Double?) As Power?
        If d.HasValue Then
            Return FromWatts(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Power in W </summary>
    Public ReadOnly Property Watts() As Double
        Get
            Return _Watts
        End Get
    End Property
    Private _Watts As Double

End Structure