Option Strict On
Option Infer On

Partial Structure PerLength(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Shared ReadOnly MaxValue As PerLength(Of T) = FromDoubleAndDefaultUnitPerMeter(Double.MaxValue)
    Public Shared ReadOnly MinValue As PerLength(Of T) = FromDoubleAndDefaultUnitPerMeter(Double.MinValue)
    Public Shared ReadOnly Zero As PerLength(Of T) = FromDoubleAndDefaultUnitPerMeter(0)
    Public Shared ReadOnly NaN As PerLength(Of T) = FromDoubleAndDefaultUnitPerMeter(Double.NaN)
    Public Shared ReadOnly PositiveInfinity As PerLength(Of T) = FromDoubleAndDefaultUnitPerMeter(Double.PositiveInfinity)
    Public Shared ReadOnly NegativeInfinity As PerLength(Of T) = FromDoubleAndDefaultUnitPerMeter(Double.NegativeInfinity)

End Structure