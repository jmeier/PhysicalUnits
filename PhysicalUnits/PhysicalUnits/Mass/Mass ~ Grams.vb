Option Strict On
Option Infer On

Partial Structure Mass

    Public Shared Function FromGrams(d As Double) As Mass
        Return New Mass With {.MyGrams = d}
    End Function
    Public Shared Function FromGrams(d As Double?) As Mass?
        If d.HasValue Then
            Return FromGrams(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Mass in g </summary>
    Public ReadOnly Property Grams() As Double
        Get
            Return MyGrams
        End Get
    End Property
    Private Property MyGrams() As Double
        Get
            Return Me.Value(SupportedMassUnits.Grams)
        End Get
        Set(value As Double)
            Me.Value(SupportedMassUnits.Grams) = value
        End Set
    End Property

End Structure