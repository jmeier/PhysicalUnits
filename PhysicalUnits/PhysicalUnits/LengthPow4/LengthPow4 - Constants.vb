Option Strict On
Option Infer On

Partial Structure LengthPow4

    Public Shared ReadOnly MaxValue As LengthPow4 = FromMetersPow4(Double.MaxValue)
    Public Shared ReadOnly MinValue As LengthPow4 = FromMetersPow4(Double.MinValue)
    Public Shared ReadOnly Zero As LengthPow4 = FromMetersPow4(0)
    Public Shared ReadOnly NaN As LengthPow4 = FromMetersPow4(Double.NaN)
    Public Shared ReadOnly NegativeInfinity As LengthPow4 = FromMetersPow4(Double.NegativeInfinity)
    Public Shared ReadOnly PositiveInfinity As LengthPow4 = FromMetersPow4(Double.PositiveInfinity)

End Structure