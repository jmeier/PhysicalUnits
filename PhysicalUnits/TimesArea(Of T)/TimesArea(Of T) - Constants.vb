Option Strict On
Option Infer On

Partial Structure TimesArea(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Shared ReadOnly MaxValue As TimesArea(Of T) = FromDoubleAndDefaultUnitTimesSquareMeter(Double.MaxValue)
    Public Shared ReadOnly MinValue As TimesArea(Of T) = FromDoubleAndDefaultUnitTimesSquareMeter(Double.MinValue)
    Public Shared ReadOnly Zero As TimesArea(Of T) = FromDoubleAndDefaultUnitTimesSquareMeter(0)
    Public Shared ReadOnly NaN As TimesArea(Of T) = FromDoubleAndDefaultUnitTimesSquareMeter(Double.NaN)
    Public Shared ReadOnly PositiveInfinity As TimesArea(Of T) = FromDoubleAndDefaultUnitTimesSquareMeter(Double.PositiveInfinity)
    Public Shared ReadOnly NegativeInfinity As TimesArea(Of T) = FromDoubleAndDefaultUnitTimesSquareMeter(Double.NegativeInfinity)

End Structure