Option Strict On
Option Infer On

Partial Structure Force

    Public Shared Function FromGiganewtons(d As Double) As Force
        Return New Force With {.MyGiganewtons = d}
    End Function
    Public Shared Function FromGiganewtons(d As Double?) As Force?
        If d.HasValue Then
            Return FromGiganewtons(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Force in GN </summary>
    Public ReadOnly Property Giganewtons() As Double
        Get
            Return MyGiganewtons
        End Get
    End Property
    Private Property MyGiganewtons() As Double
        Get
            Return Me.Value(SupportedForceUnits.Giganewtons)
        End Get
        Set(value As Double)
            Me.Value(SupportedForceUnits.Giganewtons) = value
        End Set
    End Property

End Structure