Option Strict On
Option Infer On

Partial Structure Velocity

    Public Shared ReadOnly MaxValue As Velocity = FromMetersPerSecond(Double.MaxValue)
    Public Shared ReadOnly MinValue As Velocity = FromMetersPerSecond(Double.MinValue)
    Public Shared ReadOnly Zero As Velocity = FromMetersPerSecond(0)
    Public Shared ReadOnly NaN As Velocity = FromMetersPerSecond(Double.NaN)
    Public Shared ReadOnly PositiveInfinity As Velocity = FromMetersPerSecond(Double.PositiveInfinity)
    Public Shared ReadOnly NegativeInfinity As Velocity = FromMetersPerSecond(Double.NegativeInfinity)

    Public Shared ReadOnly SpeedOfLight As Velocity = FromMetersPerSecond(299792458)

    Public Shared ReadOnly OneMeterPerSecond As Velocity = FromMetersPerSecond(1.0)

End Structure