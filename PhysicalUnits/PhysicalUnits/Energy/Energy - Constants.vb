Option Strict On
Option Infer On

Partial Structure Energy

    Public Shared ReadOnly MaxValue As Energy = FromJoules(Double.MaxValue)
    Public Shared ReadOnly MinValue As Energy = FromJoules(Double.MinValue)
    Public Shared ReadOnly Zero As Energy = FromJoules(0)
    Public Shared ReadOnly NaN As Energy = FromJoules(Double.NaN)
    Public Shared ReadOnly NegativeInfinity As Energy = FromJoules(Double.NegativeInfinity)
    Public Shared ReadOnly PositiveInfinity As Energy = FromJoules(Double.PositiveInfinity)

    Public Shared ReadOnly OneJoule As Energy = FromJoules(1.0)

End Structure