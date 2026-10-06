Option Strict On
Option Infer On

Partial Structure PerArea(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Shared ReadOnly MaxValue As PerArea(Of T) = FromDoubleAndDefaultUnitPerSquaremeter(Double.MaxValue)
    Public Shared ReadOnly MinValue As PerArea(Of T) = FromDoubleAndDefaultUnitPerSquaremeter(Double.MinValue)
    Public Shared ReadOnly Zero As PerArea(Of T) = FromDoubleAndDefaultUnitPerSquaremeter(0)
    Public Shared ReadOnly NaN As PerArea(Of T) = FromDoubleAndDefaultUnitPerSquaremeter(Double.NaN)
    Public Shared ReadOnly PositiveInfinity As PerArea(Of T) = FromDoubleAndDefaultUnitPerSquaremeter(Double.PositiveInfinity)
    Public Shared ReadOnly NegativeInfinity As PerArea(Of T) = FromDoubleAndDefaultUnitPerSquaremeter(Double.NegativeInfinity)

End Structure