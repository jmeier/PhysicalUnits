Option Strict On
Option Infer On

Partial Structure PerVolume(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

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

    Public Function Abs() As PerVolume(Of T)
        Return If(Me < Zero, -Me, Me)
    End Function

    Public Shared Function Min(a As PerVolume(Of T), b As PerVolume(Of T)) As PerVolume(Of T)
        If a._ValuePerCubicemeter.CompareTo(b._ValuePerCubicemeter) < 0 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As PerVolume(Of T), b As PerVolume(Of T)) As PerVolume(Of T)
        If a._ValuePerCubicemeter.CompareTo(b._ValuePerCubicemeter) > 0 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As PerVolume(Of T), b As PerVolume(Of T), f As Double) As PerVolume(Of T)
        Dim unit = a.DefaultUnit
        Dim va = a._ValuePerCubicemeter.GetValue(unit)
        Dim vb = b._ValuePerCubicemeter.GetValue(unit)
        Return CType(a.Create(va + f * (vb - va), unit), PerVolume(Of T))
    End Function

End Structure