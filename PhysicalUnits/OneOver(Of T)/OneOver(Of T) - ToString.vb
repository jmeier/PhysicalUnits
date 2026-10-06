Option Strict On
Option Infer On

Partial Structure OneOver(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Overrides Function ToString() As String
        If IsNaN Then
            Return $"{Double.NaN}"
        ElseIf IsPositiveInfinity Then
            Return Double.PositiveInfinity.ToString
        ElseIf IsNegativeInfinity Then
            Return Double.NegativeInfinity.ToString
        Else
            Return $"1/{Me._OneOverValue}"
        End If

        'Return ToString(provider:=Nothing)
    End Function

    'Public Overloads Function ToString(provider As IFormatProvider) As String
    '    Return Me._ValuePerRunningMeter.ToString
    'End Function

End Structure