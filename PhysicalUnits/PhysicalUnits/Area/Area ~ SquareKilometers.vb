Option Strict On
Option Infer On

Partial Structure Area

    Public Shared Function FromSquareKilometers(d As Double) As Area
        Return New Area With {.MySquareKilometers = d}
    End Function
    Public Shared Function FromSquareKilometers(d As Double?) As Area?
        If d.HasValue Then
            Return FromSquareKilometers(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Area in cm² </summary>
    Public ReadOnly Property SquareKilometers() As Double
        Get
            Return MySquareKilometers
        End Get
    End Property
    Private Property MySquareKilometers() As Double
        Get
            Return Me.Value(SupportedAreaUnits.SquareKilometers)
        End Get
        Set(value As Double)
            Me.Value(SupportedAreaUnits.SquareKilometers) = value
        End Set
    End Property


End Structure