Option Strict On
Option Infer On

Partial Structure OneOver(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

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

    Public Function Abs() As OneOver(Of T)
        Return If(Me < Zero, -Me, Me)
    End Function

    Public Shared Function Min(a As OneOver(Of T), b As OneOver(Of T)) As OneOver(Of T)
        If a._OneOverValue.CompareTo(b._OneOverValue) < 0 Then
            Return b
        Else
            Return a
        End If
    End Function

    Public Shared Function Max(a As OneOver(Of T), b As OneOver(Of T)) As OneOver(Of T)
        If a._OneOverValue.CompareTo(b._OneOverValue) > 0 Then
            Return b
        Else
            Return a
        End If
    End Function

End Structure