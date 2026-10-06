Option Strict On
Option Infer On

Partial Structure LengthPow4
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

        Dim n = Math.Log10(Math.Abs(Me._MetersPow4))
        Select Case n
            Case < -2
                Return $"{Me.MillimetersPow4.ToString(format, provider)} mm⁴"

            Case < 0
                Return $"{Me.CentimetersPow4.ToString(format, provider)} cm⁴"

            Case < 3
                Return $"{Me.MetersPow4.ToString(format, provider)} m⁴"

            Case Else
                Return $"{Me.KilometersPow4.ToString(format, provider)} km⁴"

        End Select
    End Function

End Structure