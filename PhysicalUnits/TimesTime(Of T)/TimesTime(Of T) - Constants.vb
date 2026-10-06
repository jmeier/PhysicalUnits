Option Strict On
Option Infer On

Partial Structure TimesTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Shared ReadOnly MaxValue As TimesTime(Of T) = FromDoubleAndDefaultUnitTimesSecond(Double.MaxValue)
    Public Shared ReadOnly MinValue As TimesTime(Of T) = FromDoubleAndDefaultUnitTimesSecond(Double.MinValue)
    Public Shared ReadOnly Zero As TimesTime(Of T) = FromDoubleAndDefaultUnitTimesSecond(0)
    Public Shared ReadOnly NaN As TimesTime(Of T) = FromDoubleAndDefaultUnitTimesSecond(Double.NaN)
    Public Shared ReadOnly PositiveInfinity As TimesTime(Of T) = FromDoubleAndDefaultUnitTimesSecond(Double.PositiveInfinity)
    Public Shared ReadOnly NegativeInfinity As TimesTime(Of T) = FromDoubleAndDefaultUnitTimesSecond(Double.NegativeInfinity)

End Structure