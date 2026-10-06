Option Strict On
Option Infer On

Partial Structure PerTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

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

    Public Function Abs() As PerTime(Of T)
        Return If(Me < Zero, -Me, Me)
    End Function

    Public Shared Function Min(a As PerTime(Of T), b As PerTime(Of T)) As PerTime(Of T)
        If a._ValuePerSecond.CompareTo(b._ValuePerSecond) < 0 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As PerTime(Of T), b As PerTime(Of T)) As PerTime(Of T)
        If a._ValuePerSecond.CompareTo(b._ValuePerSecond) > 0 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As PerTime(Of T), b As PerTime(Of T), f As Double) As PerTime(Of T)
        Dim unit = a.DefaultUnit
        Dim da = a._ValuePerSecond.GetValue(unit)
        Dim db = b._ValuePerSecond.GetValue(unit)
        Return CType(a.Create(da + (db - da) * f, unit), PerTime(Of T))
    End Function

End Structure