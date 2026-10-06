Option Strict On
Option Infer On

Partial Structure Length

    Public Shared Function FromInchs(d As Double) As Length
        Return New Length With {.MyInchs = d}
    End Function
    Public Shared Function FromInchs(d As Double?) As Length?
        If d.HasValue Then
            Return FromInchs(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Length in in </summary>
    Public ReadOnly Property Inchs() As Double
        Get
            Return MyInchs
        End Get
    End Property
    Private Property MyInchs() As Double
        Get
            Return Me.Value(SupportedLengthUnits.Inchs)
        End Get
        Set(value As Double)
            Me.Value(SupportedLengthUnits.Inchs) = value
        End Set
    End Property


End Structure