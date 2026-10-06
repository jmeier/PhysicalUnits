Option Strict On
Option Infer On

Partial Structure TimesArea(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

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

    Public Function Abs() As TimesArea(Of T)
        Return If(Me < Zero, -Me, Me)
    End Function

    Public Shared Function Min(a As TimesArea(Of T), b As TimesArea(Of T)) As TimesArea(Of T)
        If a._ValueTimesSquareMeter.CompareTo(b._ValueTimesSquareMeter) < 0 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As TimesArea(Of T), b As TimesArea(Of T)) As TimesArea(Of T)
        If a._ValueTimesSquareMeter.CompareTo(b._ValueTimesSquareMeter) > 0 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As TimesArea(Of T), b As TimesArea(Of T), f As Double) As TimesArea(Of T)
        Dim unit = a.DefaultUnit
        Dim da = a._ValueTimesSquareMeter.GetValue(unit)
        Dim db = b._ValueTimesSquareMeter.GetValue(unit)
        Return CType(a.Create(da + (db - da) * f, unit), TimesArea(Of T))
    End Function

End Structure