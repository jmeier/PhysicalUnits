Option Strict On
Option Infer On

Partial Structure TimesLength(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Shared ReadOnly MaxValue As TimesLength(Of T) = FromDoubleAndDefaultUnitTimesMeter(Double.MaxValue)
    Public Shared ReadOnly MinValue As TimesLength(Of T) = FromDoubleAndDefaultUnitTimesMeter(Double.MinValue)
    Public Shared ReadOnly Zero As TimesLength(Of T) = FromDoubleAndDefaultUnitTimesMeter(0)
    Public Shared ReadOnly NaN As TimesLength(Of T) = FromDoubleAndDefaultUnitTimesMeter(Double.NaN)
    Public Shared ReadOnly PositiveInfinity As TimesLength(Of T) = FromDoubleAndDefaultUnitTimesMeter(Double.PositiveInfinity)
    Public Shared ReadOnly NegativeInfinity As TimesLength(Of T) = FromDoubleAndDefaultUnitTimesMeter(Double.NegativeInfinity)

End Structure