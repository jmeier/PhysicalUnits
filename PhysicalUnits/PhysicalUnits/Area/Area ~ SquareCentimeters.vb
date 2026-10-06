Option Strict On
Option Infer On

Partial Structure Area

    Public Shared Function FromSquareCentimeters(d As Double) As Area
        Return New Area With {.MySquareCentimeters = d}
    End Function
    Public Shared Function FromSquareCentimeters(d As Double?) As Area?
        If d.HasValue Then
            Return FromSquarecentimeters(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Area in cm² </summary>
    Public ReadOnly Property SquareCentimeters() As Double
        Get
            Return MySquareCentimeters
        End Get
    End Property
    Private Property MySquareCentimeters() As Double
        Get
            Return Me.Value(SupportedAreaUnits.SquareCentimeters)
        End Get
        Set(value As Double)
            Me.Value(SupportedAreaUnits.SquareCentimeters) = value
        End Set
    End Property


End Structure