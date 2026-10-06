Option Strict On
Option Infer On

Partial Structure Force
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

        Dim n = Math.Log10(Math.Abs(Me._Newtons))
        Select Case n
            Case < 3
                Return $"{Me.Newtons.ToString(format, provider)} N"

            Case < 6
                Return $"{Me.Kilonewtons.ToString(format, provider)} kN"

            Case Else
                Return $"{Me.Meganewtons.ToString(format, provider)} MN"

        End Select
    End Function

End Structure