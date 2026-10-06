Option Strict On
Option Infer On

Partial Structure PerVolume(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Shared ReadOnly MaxValue As PerVolume(Of T) = FromDoubleAndDefaultUnitPerCubicmeter(Double.MaxValue)
    Public Shared ReadOnly MinValue As PerVolume(Of T) = FromDoubleAndDefaultUnitPerCubicmeter(Double.MinValue)
    Public Shared ReadOnly Zero As PerVolume(Of T) = FromDoubleAndDefaultUnitPerCubicmeter(0)
    Public Shared ReadOnly NaN As PerVolume(Of T) = FromDoubleAndDefaultUnitPerCubicmeter(Double.NaN)
    Public Shared ReadOnly PositiveInfinity As PerVolume(Of T) = FromDoubleAndDefaultUnitPerCubicmeter(Double.PositiveInfinity)
    Public Shared ReadOnly NegativeInfinity As PerVolume(Of T) = FromDoubleAndDefaultUnitPerCubicmeter(Double.NegativeInfinity)

End Structure