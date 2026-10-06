Option Strict On
Option Infer On

Partial Structure TimesLength(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

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

    Public Function Abs() As TimesLength(Of T)
        Return If(Me < Zero, -Me, Me)
    End Function

    Public Shared Function Min(a As TimesLength(Of T), b As TimesLength(Of T)) As TimesLength(Of T)
        If a._ValueTimesMeter.CompareTo(b._ValueTimesMeter) < 0 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As TimesLength(Of T), b As TimesLength(Of T)) As TimesLength(Of T)
        If a._ValueTimesMeter.CompareTo(b._ValueTimesMeter) > 0 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As TimesLength(Of T), b As TimesLength(Of T), f As Double) As TimesLength(Of T)
        Dim unit = a.DefaultUnit
        Dim da = a._ValueTimesMeter.GetValue(unit)
        Dim db = b._ValueTimesMeter.GetValue(unit)
        Return CType(a.Create(da + (db - da) * f, unit), TimesLength(Of T))
    End Function

End Structure