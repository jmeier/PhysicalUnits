Option Strict On
Option Infer On

Partial Structure Length

    Public Shared Function FromFeet(d As Double) As Length
        Return New Length With {.MyFeet = d}
    End Function
    Public Shared Function FromFeet(d As Double?) As Length?
        If d.HasValue Then
            Return FromFeet(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length in ft </summary>
    Public ReadOnly Property Feet() As Double
        Get
            Return MyFeet
        End Get
    End Property
    Private Property MyFeet() As Double
        Get
            Return Me.Value(SupportedLengthUnits.Feet)
        End Get
        Set(value As Double)
            Me.Value(SupportedLengthUnits.Feet) = value
        End Set
    End Property

End Structure