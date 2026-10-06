Option Strict On
Option Infer On

Partial Structure SoundPressure

    Public Shared ReadOnly MaxValue As SoundPressure = FromDecibel(Double.MaxValue)
    Public Shared ReadOnly MinValue As SoundPressure = FromDecibel(Double.MinValue)
    Public Shared ReadOnly Zero As SoundPressure = FromDecibel(0)
    Public Shared ReadOnly NaN As SoundPressure = FromDecibel(Double.NaN)
    Public Shared ReadOnly NegativeInfinity As SoundPressure = FromDecibel(Double.NegativeInfinity)
    Public Shared ReadOnly PositiveInfinity As SoundPressure = FromDecibel(Double.PositiveInfinity)

    Public Shared ReadOnly OneDecibel As SoundPressure = FromDecibel(1.0)

End Structure