Option Strict On
Option Infer On

Partial Structure PerArea(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public ReadOnly Property Sign() As Integer
        Get
            Select Case True
                Case Me > Zero
                    Return +1

                Case Me = Zero
                    Return 0

                Case Me < Zero
                    Return -1

                Case Else
                    Throw New ArithmeticException
            End Select
        End Get
    End Property

    Public Function Abs() As PerArea(Of T)
        Return If(Me < Zero, -Me, Me)
    End Function

    Public Shared Function Min(a As PerArea(Of T), b As PerArea(Of T)) As PerArea(Of T)
        If a._ValuePerSquaremeter.CompareTo(b._ValuePerSquaremeter) < 0 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As PerArea(Of T), b As PerArea(Of T)) As PerArea(Of T)
        If a._ValuePerSquaremeter.CompareTo(b._ValuePerSquaremeter) > 0 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As PerArea(Of T), b As PerArea(Of T), f As Double) As PerArea(Of T)
        Dim unit = a.DefaultUnit
        Dim va = a._ValuePerSquaremeter.GetValue(unit)
        Dim vb = b._ValuePerSquaremeter.GetValue(unit)
        Return CType(a.Create(va + f * (vb - va), unit), PerArea(Of T))
    End Function

End Structure