Option Strict On
Option Infer On

Partial Structure Power

    Public Shared ReadOnly MaxValue As Power = FromWatts(Double.MaxValue)
    Public Shared ReadOnly MinValue As Power = FromWatts(Double.MinValue)
    Public Shared ReadOnly Zero As Power = FromWatts(0)
    Public Shared ReadOnly NaN As Power = FromWatts(Double.NaN)
    Public Shared ReadOnly NegativeInfinity As Power = FromWatts(Double.NegativeInfinity)
    Public Shared ReadOnly PositiveInfinity As Power = FromWatts(Double.PositiveInfinity)

    Public Shared ReadOnly OneWatt As Power = FromWatts(1.0)

End Structure