Option Strict On
Option Infer On

Partial Structure PerTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Shared ReadOnly MaxValue As PerTime(Of T) = FromDoubleAndDefaultUnitPerSecond(Double.MaxValue)
    Public Shared ReadOnly MinValue As PerTime(Of T) = FromDoubleAndDefaultUnitPerSecond(Double.MinValue)
    Public Shared ReadOnly Zero As PerTime(Of T) = FromDoubleAndDefaultUnitPerSecond(0)
    Public Shared ReadOnly NaN As PerTime(Of T) = FromDoubleAndDefaultUnitPerSecond(Double.NaN)
    Public Shared ReadOnly PositiveInfinity As PerTime(Of T) = FromDoubleAndDefaultUnitPerSecond(Double.PositiveInfinity)
    Public Shared ReadOnly NegativeInfinity As PerTime(Of T) = FromDoubleAndDefaultUnitPerSecond(Double.NegativeInfinity)

End Structure