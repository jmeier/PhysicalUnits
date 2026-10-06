Option Strict On
Option Infer On

Partial Structure TimesVolume(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

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

    Public Function Abs() As TimesVolume(Of T)
        Return If(Me < Zero, -Me, Me)
    End Function

    Public Shared Function Min(a As TimesVolume(Of T), b As TimesVolume(Of T)) As TimesVolume(Of T)
        If a._ValueTimesCubicMeter.CompareTo(b._ValueTimesCubicMeter) < 0 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Max(a As TimesVolume(Of T), b As TimesVolume(Of T)) As TimesVolume(Of T)
        If a._ValueTimesCubicMeter.CompareTo(b._ValueTimesCubicMeter) > 0 Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Shared Function Lerp(a As TimesVolume(Of T), b As TimesVolume(Of T), f As Double) As TimesVolume(Of T)
        Dim unit = a.DefaultUnit
        Dim da = a._ValueTimesCubicMeter.GetValue(unit)
        Dim db = b._ValueTimesCubicMeter.GetValue(unit)
        Return CType(a.Create(da + (db - da) * f, unit), TimesVolume(Of T))
    End Function

End Structure