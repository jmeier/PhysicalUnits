Option Strict On
Option Infer On

Partial Structure Pressure
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

        Dim n = Math.Log10(Math.Abs(Me._NewtonsPerSquaremeter))
        Select Case n
            Case < 0
                Return $"{Me.NewtonsPerSquaremeter.ToString(format, provider)} N/m²"

            Case < 3
                Return $"{Me.KilonewtonsPerSquaremeter.ToString(format, provider)} kN/m²"

            Case Else
                Return $"{Me.MeganewtonsPerSquaremeter.ToString(format, provider)} MN/m²"

        End Select
    End Function

End Structure