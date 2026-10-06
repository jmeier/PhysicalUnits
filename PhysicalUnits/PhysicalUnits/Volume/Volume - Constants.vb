Option Strict On
Option Infer On

Partial Structure Volume

    Public Shared ReadOnly MaxValue As Volume = FromMetersPow3(Double.MaxValue)
    Public Shared ReadOnly MinValue As Volume = FromMetersPow3(Double.MinValue)
    Public Shared ReadOnly Zero As Volume = FromMetersPow3(0)
    Public Shared ReadOnly NaN As Volume = FromMetersPow3(Double.NaN)
    Public Shared ReadOnly NegativeInfinity As Volume = FromMetersPow3(Double.NegativeInfinity)
    Public Shared ReadOnly PositiveInfinity As Volume = FromMetersPow3(Double.PositiveInfinity)

    Public Shared ReadOnly OneCubicMeter As Volume = FromMetersPow3(1.0)
    Public Shared ReadOnly OneCubicCentimeter As Volume = FromMetersPow3(0.01 ^ 3)
    Public Shared ReadOnly OneCubicMillimeter As Volume = FromMetersPow3(0.001 ^ 3)

End Structure