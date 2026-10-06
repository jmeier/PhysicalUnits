Option Strict On
Option Infer On

Partial Structure Frequency

    Public Shared ReadOnly MaxValue As Frequency = FromHertz(Double.MaxValue)
    Public Shared ReadOnly MinValue As Frequency = FromHertz(Double.MinValue)
    Public Shared ReadOnly Zero As Frequency = FromHertz(0)
    Public Shared ReadOnly NaN As Frequency = FromHertz(Double.NaN)
    Public Shared ReadOnly NegativeInfinity As Frequency = FromHertz(Double.NegativeInfinity)
    Public Shared ReadOnly PositiveInfinity As Frequency = FromHertz(Double.PositiveInfinity)

    Public Shared ReadOnly OneHertz As Frequency = FromHertz(1.0)

End Structure