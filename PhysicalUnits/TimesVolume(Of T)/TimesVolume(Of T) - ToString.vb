Option Strict On
Option Infer On

Partial Structure TimesVolume(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Overrides Function ToString() As String
        If IsNaN Then
            Return $"{Double.NaN}"
        ElseIf IsPositiveInfinity Then
            Return Double.PositiveInfinity.ToString
        ElseIf IsNegativeInfinity Then
            Return Double.NegativeInfinity.ToString
        Else
            Return $"{Me._ValueTimesCubicMeter}·m²"
        End If

        'Return ToString(provider:=Nothing)
    End Function

End Structure