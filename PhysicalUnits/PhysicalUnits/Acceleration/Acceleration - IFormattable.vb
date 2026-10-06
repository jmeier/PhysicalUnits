Option Strict On
Option Infer On

Partial Structure Acceleration
    Implements IFormattable

    Public Overrides Function ToString() As String
        Return ToString(format:=Nothing, provider:=Nothing)
    End Function

    Public Overloads Function ToString(provider As IFormatProvider) As String
        Return ToString(format:=Nothing, provider:=provider)
    End Function

    Public Overloads Function ToString(format As String, provider As IFormatProvider) As String Implements IFormattable.ToString
        If IsNaN Then
            Return $"{Double.NaN}"
        ElseIf IsPositiveInfinity Then
            Return Double.PositiveInfinity.ToString
        ElseIf IsNegativeInfinity Then
            Return Double.NegativeInfinity.ToString
        End If

        Dim n = Math.Log10(Math.Abs(Me._MetersPerSquareSecond))
        Select Case n
            Case < -2
                Return $"{Me.MillimetersPerSquareSecond.ToString(format, provider)} m/s²"

            Case Else
                Return $"{Me.MetersPerSquareSecond.ToString(format, provider)} m/s²"

        End Select
    End Function

End Structure