Option Strict On
Option Infer On

Partial Structure Length

    Public Shared Function FromMillimeters(d As Double) As Length
        Return New Length With {.MyMillimeters = d}
    End Function
    Public Shared Function FromMillimeters(d As Double?) As Length?
        If d.HasValue Then
            Return FromMillimeters(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length in mm </summary>
    Public ReadOnly Property Millimeters() As Double
        Get
            Return MyMillimeters
        End Get
    End Property
    Private Property MyMillimeters() As Double
        Get
            Return Me.Value(SupportedLengthUnits.Millimeters)
        End Get
        Set(value As Double)
            Me.Value(SupportedLengthUnits.Millimeters) = value
        End Set
    End Property

End Structure