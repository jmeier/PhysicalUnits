Option Strict On
Option Infer On

Partial Structure Volume
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

        Dim n = Math.Log10(Math.Abs(Me._MetersPow3))
        Select Case n
            Case < -2
                Return $"{Me.MillimetersPow3.ToString(format, provider)} mm³"

            Case < 0
                Return $"{Me.CentimetersPow3.ToString(format, provider)} cm³"

            Case < 3
                Return $"{Me.MetersPow3.ToString(format, provider)} m³"

            Case Else
                Return $"{Me.KilometersPow3.ToString(format, provider)} km³"

        End Select
    End Function

End Structure