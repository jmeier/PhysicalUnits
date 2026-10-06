Option Strict On
Option Infer On

Partial Structure TimesTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

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

    Public Function Abs() As TimesTime(Of T)
        Return If(Me < Zero, -Me, Me)
    End Function

    Public Shared Function Min(a As TimesTime(Of T), b As TimesTime(Of T)) As TimesTime(Of T)
        If a._ValueTimesSecond.CompareTo(b._ValueTimesSecond) < 0 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As TimesTime(Of T), b As TimesTime(Of T)) As TimesTime(Of T)
        If a._ValueTimesSecond.CompareTo(b._ValueTimesSecond) > 0 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As TimesTime(Of T), b As TimesTime(Of T), f As Double) As TimesTime(Of T)
        Dim unit = a.DefaultUnit
        Dim da = a._ValueTimesSecond.GetValue(unit)
        Dim db = b._ValueTimesSecond.GetValue(unit)
        Return CType(a.Create(da + (db - da) * f, unit), TimesTime(Of T))
    End Function

End Structure