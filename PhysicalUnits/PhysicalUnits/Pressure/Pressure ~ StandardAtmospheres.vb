Option Strict On
Option Infer On

Partial Structure Pressure

    Public Shared Function FromStandardAtmospheres(d As Double) As Pressure
        Return New Pressure With {.MyStandardAtmospheres = d}
    End Function
    Public Shared Function FromStandardAtmospheres(d As Double?) As Pressure?
        If d.HasValue Then
            Return FromStandardAtmospheres(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> atm </summary>
    Public ReadOnly Property StandardAtmospheres() As Double
        Get
            Return MyStandardAtmospheres
        End Get
    End Property
    Private Property MyStandardAtmospheres() As Double
        Get
            Return Me.Value(SupportedPressureUnits.StandardAtmospheres)
        End Get
        Set(value As Double)
            Me.Value(SupportedPressureUnits.StandardAtmospheres) = value
        End Set
    End Property

End Structure