Option Strict On
Option Infer On

Partial Structure Temperature

    Public Shared Function FromDegreeRankine(d As Double) As Temperature
        Return New Temperature With {.MyDegreeRankine = d}
    End Function
    Public Shared Function FromDegreeRankine(d As Double?) As Temperature?
        If d.HasValue Then
            Return FromDegreeRankine(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Temperature in °R </summary>
    Public ReadOnly Property DegreeRankine() As Double
        Get
            Return MyDegreeRankine
        End Get
    End Property
    Private Property MyDegreeRankine() As Double
        Get
            Return Me.Value(SupportedTemperatureUnits.Rankine)
        End Get
        Set(value As Double)
            Me.Value(SupportedTemperatureUnits.Rankine) = value
        End Set
    End Property

End Structure