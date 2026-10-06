Option Strict On
Option Infer On

Partial Structure Elevation

    Public Shared ReadOnly MaxValue As Elevation = FromMetersAboveNN(Double.MaxValue)
    Public Shared ReadOnly MinValue As Elevation = FromMetersAboveNN(Double.MinValue)
    Public Shared ReadOnly Zero As Elevation = FromMetersAboveNN(0)
    Public Shared ReadOnly NaN As Elevation = FromMetersAboveNN(Double.NaN)
    Public Shared ReadOnly NegativeInfinity As Elevation = FromMetersAboveNN(Double.NegativeInfinity)
    Public Shared ReadOnly PositiveInfinity As Elevation = FromMetersAboveNN(Double.PositiveInfinity)

End Structure