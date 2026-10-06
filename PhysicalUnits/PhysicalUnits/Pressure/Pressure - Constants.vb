Option Strict On
Option Infer On

Partial Structure Pressure

    Public Shared ReadOnly MaxValue As Pressure = FromNewtonsPerSquaremeter(Double.MaxValue)
    Public Shared ReadOnly MinValue As Pressure = FromNewtonsPerSquaremeter(Double.MinValue)
    Public Shared ReadOnly Zero As Pressure = FromNewtonsPerSquaremeter(0)
    Public Shared ReadOnly NaN As Pressure = FromNewtonsPerSquaremeter(Double.NaN)
    Public Shared ReadOnly PositiveInfinity As Pressure = FromNewtonsPerSquaremeter(Double.PositiveInfinity)
    Public Shared ReadOnly NegativeInfinity As Pressure = FromNewtonsPerSquaremeter(Double.NegativeInfinity)

    Public Shared ReadOnly OneStandardAtmosphere As Pressure = FromPascals(101325)

End Structure