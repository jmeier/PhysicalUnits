Option Strict On
Option Infer On

Partial Structure Mass

    Public Shared Function FromTons(d As Double) As Mass
        Return New Mass With {.MyTons = d}
    End Function
    Public Shared Function FromTons(d As Double?) As Mass?
        If d.HasValue Then
            Return FromTons(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Mass in t </summary>
    Public ReadOnly Property Tons() As Double
        Get
            Return MyTons
        End Get
    End Property
    Private Property MyTons() As Double
        Get
            Return Me.Value(SupportedMassUnits.Tons)
        End Get
        Set(value As Double)
            Me.Value(SupportedMassUnits.Tons) = value
        End Set
    End Property

End Structure