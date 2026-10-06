Option Strict On
Option Infer On

Partial Structure Mass

    Public Shared Function FromKilograms(d As Double) As Mass
        Return New Mass With {._Kilograms = d}
    End Function

    Public Shared Function FromKilograms(d As Double?) As Mass?
        If d.HasValue Then
            Return FromKilograms(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Mass in kg </summary>
    Public ReadOnly Property Kilograms() As Double
        Get
            Return _Kilograms
        End Get
    End Property
    Private _Kilograms As Double

End Structure