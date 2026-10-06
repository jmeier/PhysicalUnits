Option Strict On
Option Infer On

Partial Structure Intensity

    Public Shared ReadOnly MaxValue As Intensity = FromWattsPerSquaremeter(Double.MaxValue)
    Public Shared ReadOnly MinValue As Intensity = FromWattsPerSquaremeter(Double.MinValue)
    Public Shared ReadOnly Zero As Intensity = FromWattsPerSquaremeter(0)
    Public Shared ReadOnly NaN As Intensity = FromWattsPerSquaremeter(Double.NaN)
    Public Shared ReadOnly NegativeInfinity As Intensity = FromWattsPerSquaremeter(Double.NegativeInfinity)
    Public Shared ReadOnly PositiveInfinity As Intensity = FromWattsPerSquaremeter(Double.PositiveInfinity)

    Public Shared ReadOnly OneWattPerSquareMeter As Intensity = FromWattsPerSquaremeter(1.0)

End Structure