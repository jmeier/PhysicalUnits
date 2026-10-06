Option Strict On
Option Infer On

Partial Structure Force

    Public Shared Function FromKilonewtons(d As Double) As Force
        Return New Force With {.MyKilonewtons = d}
    End Function
    Public Shared Function FromKilonewtons(d As Double?) As Force?
        If d.HasValue Then
            Return FromKilonewtons(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Force in kN </summary>
    Public ReadOnly Property Kilonewtons() As Double
        Get
            Return MyKilonewtons
        End Get
    End Property
    Private Property MyKilonewtons() As Double
        Get
            Return Me.Value(SupportedForceUnits.Kilonewtons)
        End Get
        Set(value As Double)
            Me.Value(SupportedForceUnits.Kilonewtons) = value
        End Set
    End Property

End Structure