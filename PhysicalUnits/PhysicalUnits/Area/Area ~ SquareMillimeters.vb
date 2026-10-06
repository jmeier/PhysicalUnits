Option Strict On
Option Infer On

Partial Structure Area

    Public Shared Function FromSquareMillimeters(d As Double) As Area
        Return New Area With {.MySquaremillimeters = d}
    End Function
    Public Shared Function FromSquareMillimeters(d As Double?) As Area?
        If d.HasValue Then
            Return FromSquareMillimeters(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Area in mm² </summary>
    Public ReadOnly Property SquareMillimeters() As Double
        Get
            Return MySquaremillimeters
        End Get
    End Property
    Private Property MySquareMillimeters() As Double
        Get
            Return Me.Value(SupportedAreaUnits.SquareMillimeters)
        End Get
        Set(value As Double)
            Me.Value(SupportedAreaUnits.SquareMillimeters) = value
        End Set
    End Property


End Structure