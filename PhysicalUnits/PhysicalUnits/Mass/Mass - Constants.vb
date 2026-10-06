Option Strict On
Option Infer On

Partial Structure Mass

    Public Shared ReadOnly MaxValue As Mass = FromKilograms(Double.MaxValue)
    Public Shared ReadOnly MinValue As Mass = FromKilograms(Double.MinValue)
    Public Shared ReadOnly Zero As Mass = FromKilograms(0)
    Public Shared ReadOnly NaN As Mass = FromKilograms(Double.NaN)
    Public Shared ReadOnly NegativeInfinity As Mass = FromKilograms(Double.NegativeInfinity)
    Public Shared ReadOnly PositiveInfinity As Mass = FromKilograms(Double.PositiveInfinity)

    Public Shared ReadOnly OneKilogram As Mass = FromKilograms(1)
    Public Shared ReadOnly OneTon As Mass = FromTons(1)

End Structure