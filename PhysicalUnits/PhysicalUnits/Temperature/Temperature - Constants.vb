Option Strict On
Option Infer On

Partial Structure Temperature

    Private Const AbsoluteZeroCelcius = -273.15

    Public Shared ReadOnly MaxValue As Temperature = FromKelvin(Double.MaxValue)
    Public Shared ReadOnly MinValue As Temperature = FromKelvin(Double.MinValue)
    Public Shared ReadOnly NaN As Temperature = FromKelvin(Double.NaN)
    Public Shared ReadOnly NegativeInfinity As Temperature = FromKelvin(Double.NegativeInfinity)
    Public Shared ReadOnly PositiveInfinity As Temperature = FromKelvin(Double.PositiveInfinity)

    ''' <summary>
    ''' Absolute zero is the lower limit of the thermodynamic temperature scale
    ''' </summary>
    Public Shared ReadOnly AbsoluteZero As Temperature = FromKelvin(0)

End Structure