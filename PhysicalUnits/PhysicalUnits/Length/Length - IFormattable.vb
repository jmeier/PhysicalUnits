Option Strict On
Option Infer On

Partial Structure Length
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

        Dim n = Math.Log10(Math.Abs(Me._Meters))
        Select Case n
            Case < -2
                Return $"{Me.Millimeters.ToString(format, provider)} mm"

            Case < 0
                Return $"{Me.Centimeters.ToString(format, provider)} cm"

            Case < 3
                Return $"{Me.Meters.ToString(format, provider)} m"

            Case Else
                Return $"{Me.Kilometers.ToString(format, provider)} km"

        End Select
    End Function

End Structure