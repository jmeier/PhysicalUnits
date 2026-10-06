Option Strict On
Option Infer On

Partial Structure Intensity
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

        Dim n = Math.Log10(Math.Abs(Me._WattsPerSquaremeter))
        Select Case n
            Case < 3
                Return $"{Me.WattsPerSquaremeter.ToString(format, provider)} W/m²"

            Case Else
                Return $"{Me.KilowattsPerSquaremeter.ToString(format, provider)} kW/m²"

        End Select
    End Function

End Structure