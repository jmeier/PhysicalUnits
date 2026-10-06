Option Strict On
Option Infer On

Partial Structure Pressure

    Public Shared Function FromTechnicalAtmospheres(d As Double) As Pressure
        Return New Pressure With {.MyTechnicalAtmospheres = d}
    End Function
    Public Shared Function FromTechnicalAtmospheres(d As Double?) As Pressure?
        If d.HasValue Then
            Return FromTechnicalAtmospheres(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> at </summary>
    Public ReadOnly Property TechnicalAtmospheres() As Double
        Get
            Return MyTechnicalAtmospheres
        End Get
    End Property
    Private Property MyTechnicalAtmospheres() As Double
        Get
            Return Me.Value(SupportedPressureUnits.TechnicalAtmospheres)
        End Get
        Set(value As Double)
            Me.Value(SupportedPressureUnits.TechnicalAtmospheres) = value
        End Set
    End Property

End Structure