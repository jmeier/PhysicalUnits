Option Strict On
Option Infer On

Partial Structure Length

    Public Shared Function FromCentimeters(d As Double) As Length
        Return New Length With {.MyCentimeters = d}
    End Function
    Public Shared Function FromCentimeters(d As Double?) As Length?
        If d.HasValue Then
            Return FromCentimeters(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length in cm </summary>
    Public ReadOnly Property Centimeters() As Double
        Get
            Return MyCentimeters
        End Get
    End Property
    Private Property MyCentimeters() As Double
        Get
            Return Me.Value(SupportedLengthUnits.Centimeters)
        End Get
        Set(value As Double)
            Me.Value(SupportedLengthUnits.Centimeters) = value
        End Set
    End Property

End Structure