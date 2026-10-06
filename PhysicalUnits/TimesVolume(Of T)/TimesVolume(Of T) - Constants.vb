Option Strict On
Option Infer On

Partial Structure TimesVolume(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Shared ReadOnly MaxValue As TimesVolume(Of T) = FromDoubleAndDefaultUnitTimesCubicMeter(Double.MaxValue)
    Public Shared ReadOnly MinValue As TimesVolume(Of T) = FromDoubleAndDefaultUnitTimesCubicMeter(Double.MinValue)
    Public Shared ReadOnly Zero As TimesVolume(Of T) = FromDoubleAndDefaultUnitTimesCubicMeter(0)
    Public Shared ReadOnly NaN As TimesVolume(Of T) = FromDoubleAndDefaultUnitTimesCubicMeter(Double.NaN)
    Public Shared ReadOnly PositiveInfinity As TimesVolume(Of T) = FromDoubleAndDefaultUnitTimesCubicMeter(Double.PositiveInfinity)
    Public Shared ReadOnly NegativeInfinity As TimesVolume(Of T) = FromDoubleAndDefaultUnitTimesCubicMeter(Double.NegativeInfinity)

End Structure