Option Strict On
Option Infer On

Partial Structure Length

    Public Shared Function FromKilometers(d As Double) As Length
        Return New Length With {.MyKilometers = d}
    End Function
    Public Shared Function FromKilometers(d As Double?) As Length?
        If d.HasValue Then
            Return FromKilometers(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length in km </summary>
    Public ReadOnly Property Kilometers() As Double
        Get
            Return MyKilometers
        End Get
    End Property
    Private Property MyKilometers() As Double
        Get
            Return Me.Value(SupportedLengthUnits.Kilometers)
        End Get
        Set(value As Double)
            Me.Value(SupportedLengthUnits.Kilometers) = value
        End Set
    End Property

End Structure