Option Strict On
Option Infer On

Partial Structure Acceleration

    Public Shared ReadOnly MaxValue As Acceleration = FromMetersPerSquareSecond(Double.MaxValue)
    Public Shared ReadOnly MinValue As Acceleration = FromMetersPerSquareSecond(Double.MinValue)
    Public Shared ReadOnly Zero As Acceleration = FromMetersPerSquareSecond(0)
    Public Shared ReadOnly NaN As Acceleration = FromMetersPerSquareSecond(Double.NaN)
    Public Shared ReadOnly NegativeInfinity As Acceleration = FromMetersPerSquareSecond(Double.NegativeInfinity)
    Public Shared ReadOnly PositiveInfinity As Acceleration = FromMetersPerSquareSecond(Double.PositiveInfinity)

    Public Shared ReadOnly OneMetersPerSquareSecond As Acceleration = FromMetersPerSquareSecond(1.0)

    Public Shared ReadOnly EarthStandardGravity As Acceleration = FromMetersPerSquareSecond(9.80665)

End Structure