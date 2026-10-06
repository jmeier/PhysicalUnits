Option Strict On
Option Infer On

Partial Structure Length

    Public Shared Function FromDecimeters(d As Double) As Length
        Return New Length With {.MyDecimeters = d}
    End Function
    Public Shared Function FromDecimeters(d As Double?) As Length?
        If d.HasValue Then
            Return FromDecimeters(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length in dm </summary>
    Public ReadOnly Property Decimeters() As Double
        Get
            Return MyDecimeters
        End Get
    End Property
    Private Property MyDecimeters() As Double
        Get
            Return Me.Value(SupportedLengthUnits.Decimeters)
        End Get
        Set(value As Double)
            Me.Value(SupportedLengthUnits.Decimeters) = value
        End Set
    End Property

End Structure