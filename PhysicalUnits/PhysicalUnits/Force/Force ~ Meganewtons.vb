Option Strict On
Option Infer On

Partial Structure Force

    Public Shared Function FromMeganewtons(d As Double) As Force
        Return New Force With {.MyMeganewtons = d}
    End Function
    Public Shared Function FromMeganewtons(d As Double?) As Force?
        If d.HasValue Then
            Return FromMeganewtons(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Force in MN </summary>
    Public ReadOnly Property Meganewtons() As Double
        Get
            Return MyMeganewtons
        End Get
    End Property
    Private Property MyMeganewtons() As Double
        Get
            Return Me.Value(SupportedForceUnits.Meganewtons)
        End Get
        Set(value As Double)
            Me.Value(SupportedForceUnits.Meganewtons) = value
        End Set
    End Property

End Structure