Option Strict On
Option Infer On

Partial Structure Density

    Public Shared ReadOnly MaxValue As Density = FromKilogramsPerCubicmeter(Double.MaxValue)
    Public Shared ReadOnly MinValue As Density = FromKilogramsPerCubicmeter(Double.MinValue)
    Public Shared ReadOnly Zero As Density = FromKilogramsPerCubicmeter(0)
    Public Shared ReadOnly NaN As Density = FromKilogramsPerCubicmeter(Double.NaN)
    Public Shared ReadOnly NegativeInfinity As Density = FromKilogramsPerCubicmeter(Double.NegativeInfinity)
    Public Shared ReadOnly PositiveInfinity As Density = FromKilogramsPerCubicmeter(Double.PositiveInfinity)

End Structure