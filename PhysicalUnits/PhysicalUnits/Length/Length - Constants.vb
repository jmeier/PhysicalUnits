Option Strict On
Option Infer On

Partial Structure Length

    Public Shared ReadOnly MaxValue As Length = FromMeters(Double.MaxValue)
    Public Shared ReadOnly MinValue As Length = FromMeters(Double.MinValue)
    Public Shared ReadOnly Zero As Length = FromMeters(0)
    Public Shared ReadOnly NaN As Length = FromMeters(Double.NaN)
    Public Shared ReadOnly NegativeInfinity As Length = FromMeters(Double.NegativeInfinity)
    Public Shared ReadOnly PositiveInfinity As Length = FromMeters(Double.PositiveInfinity)

    Public Shared ReadOnly LightYear As Length = FromMeters(9460730472580800)
    Public Shared ReadOnly OneMeter As Length = FromMeters(1)
    Public Shared ReadOnly OneCentimeter As Length = FromCentimeters(1)
    Public Shared ReadOnly OneMillimeter As Length = FromMillimeters(1)

End Structure