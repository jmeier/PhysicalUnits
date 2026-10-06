Option Strict On
Option Infer On

Partial Structure Mass
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

        Dim n = Math.Log10(Math.Abs(Me._Kilograms))
        Select Case n
            Case < -2
                Return $"{Me.Grams.ToString(format, provider)} g"

            Case < 3
                Return $"{Me.Kilograms.ToString(format, provider)} kg"

            Case Else
                Return $"{Me.Tons.ToString(format, provider)} t"

        End Select
    End Function

End Structure