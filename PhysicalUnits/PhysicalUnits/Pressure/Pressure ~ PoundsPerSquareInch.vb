Option Strict On
Option Infer On

Partial Structure Pressure

    Public Shared Function FromPoundsPerSquareInch(d As Double) As Pressure
        Return New Pressure With {.MyPoundsPerSquareInch = d}
    End Function
    Public Shared Function FromPoundsPerSquareInch(d As Double?) As Pressure?
        If d.HasValue Then
            Return FromPoundsPerSquareInch(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> psi </summary>
    Public ReadOnly Property PoundsPerSquareInch() As Double
        Get
            Return MyPoundsPerSquareInch
        End Get
    End Property
    Private Property MyPoundsPerSquareInch() As Double
        Get
            Return Me.Value(SupportedPressureUnits.PoundsPerSquareInch)
        End Get
        Set(value As Double)
            Me.Value(SupportedPressureUnits.PoundsPerSquareInch) = value
        End Set
    End Property

End Structure