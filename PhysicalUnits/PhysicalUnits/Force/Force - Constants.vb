Option Strict On
Option Infer On

Partial Structure Force

    Public Shared ReadOnly MaxValue As Force = FromNewtons(Double.MaxValue)
    Public Shared ReadOnly MinValue As Force = FromNewtons(Double.MinValue)
    Public Shared ReadOnly Zero As Force = FromNewtons(0)
    Public Shared ReadOnly NaN As Force = FromNewtons(Double.NaN)
    Public Shared ReadOnly PositiveInfinity As Force = FromNewtons(Double.PositiveInfinity)
    Public Shared ReadOnly NegativeInfinity As Force = FromNewtons(Double.NegativeInfinity)

    Public Shared ReadOnly OneNewton As Force = FromNewtons(1)
    Public Shared ReadOnly OneKilonewton As Force = FromKilonewtons(1)
    Public Shared ReadOnly OneMeganewton As Force = FromMeganewtons(1)
    Public Shared ReadOnly OneGiganewton As Force = FromGiganewtons(1)

End Structure