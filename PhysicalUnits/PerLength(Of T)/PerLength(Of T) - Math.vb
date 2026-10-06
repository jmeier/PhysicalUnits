Option Strict On
Option Infer On

Partial Structure PerLength(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

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

    Public Function Abs() As PerLength(Of T)
        Return If(Me < Zero, -Me, Me)
    End Function

    Public Shared Function Min(a As PerLength(Of T), b As PerLength(Of T)) As PerLength(Of T)
        If a._ValuePerRunningMeter.CompareTo(b._ValuePerRunningMeter) < 0 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As PerLength(Of T), b As PerLength(Of T)) As PerLength(Of T)
        If a._ValuePerRunningMeter.CompareTo(b._ValuePerRunningMeter) > 0 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As PerLength(Of T), b As PerLength(Of T), f As Double) As PerLength(Of T)
        Dim unit = a.DefaultUnit
        Dim da = a._ValuePerRunningMeter.GetValue(unit)
        Dim db = b._ValuePerRunningMeter.GetValue(unit)
        Return CType(a.Create(da + (db - da) * f, unit), PerLength(Of T))
    End Function

End Structure