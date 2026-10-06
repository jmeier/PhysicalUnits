Option Strict On
Option Infer On

Partial Structure Length

    Public Shared Function FromYards(d As Double) As Length
        Return New Length With {.MyYards = d}
    End Function
    Public Shared Function FromYards(d As Double?) As Length?
        If d.HasValue Then
            Return FromYards(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length in yd </summary>
    Public ReadOnly Property Yards() As Double
        Get
            Return MyYards
        End Get
    End Property
    Private Property MyYards() As Double
        Get
            Return Me.Value(SupportedLengthUnits.Yards)
        End Get
        Set(value As Double)
            Me.Value(SupportedLengthUnits.Yards) = value
        End Set
    End Property

End Structure