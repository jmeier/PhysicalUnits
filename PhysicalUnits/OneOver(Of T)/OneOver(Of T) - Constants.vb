Option Strict On
Option Infer On

Imports System.ComponentModel
Imports System.Runtime.Serialization

Partial Structure OneOver(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Shared ReadOnly MaxValue As OneOver(Of T) = FromDoubleAndDefaultUnitPerMeter(Double.MinValue)
    Public Shared ReadOnly MinValue As OneOver(Of T) = FromDoubleAndDefaultUnitPerMeter(Double.MaxValue)
    Public Shared ReadOnly Zero As OneOver(Of T) = FromDoubleAndDefaultUnitPerMeter(0)
    Public Shared ReadOnly NaN As OneOver(Of T) = FromDoubleAndDefaultUnitPerMeter(Double.NaN)
    Public Shared ReadOnly PositiveInfinity As OneOver(Of T) = FromDoubleAndDefaultUnitPerMeter(Double.PositiveInfinity)
    Public Shared ReadOnly NegativeInfinity As OneOver(Of T) = FromDoubleAndDefaultUnitPerMeter(Double.NegativeInfinity)

End Structure