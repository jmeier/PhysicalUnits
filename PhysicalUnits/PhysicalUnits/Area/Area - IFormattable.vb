Option Strict On
Option Infer On

Partial Structure Area
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

        Dim n = Math.Log10(Math.Abs(Me._MetersPow2))
        Select Case n
            Case < -2
                Return $"{Me.SquareMillimeters.ToString(format, provider)} mm²"

            Case < 0
                Return $"{Me.SquareCentimeters.ToString(format, provider)} cm²"

            Case < 3
                Return $"{Me.Squaremeters.ToString(format, provider)} m²"

            Case Else
                Return $"{Me.SquareKilometers.ToString(format, provider)} km²"

        End Select
    End Function

End Structure