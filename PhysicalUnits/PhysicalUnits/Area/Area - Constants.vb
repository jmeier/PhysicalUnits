Option Strict On
Option Infer On

Partial Structure Area

    Public Shared ReadOnly MaxValue As Area = FromMetersPow2(Double.MaxValue)
    Public Shared ReadOnly MinValue As Area = FromMetersPow2(Double.MinValue)
    Public Shared ReadOnly Zero As Area = FromMetersPow2(0)
    Public Shared ReadOnly NaN As Area = FromMetersPow2(Double.NaN)
    Public Shared ReadOnly NegativeInfinity As Area = FromMetersPow2(Double.NegativeInfinity)
    Public Shared ReadOnly PositiveInfinity As Area = FromMetersPow2(Double.PositiveInfinity)

    Public Shared ReadOnly OneSquareMeter As Area = FromMetersPow2(1.0)
    Public Shared ReadOnly OneSquareCentimeter As Area = FromMetersPow2(0.01 ^ 3)
    Public Shared ReadOnly OneSquareMillimeter As Area = FromMetersPow2(0.001 ^ 3)

End Structure