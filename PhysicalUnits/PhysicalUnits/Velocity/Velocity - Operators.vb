Option Strict On
Option Infer On

Partial Structure Velocity

#Region "Equality, Comparison"

    Public Shared Operator =(a As Velocity, b As Velocity) As Boolean
        Return a._MetersPerSecond = b._MetersPerSecond
    End Operator
    Public Shared Operator <>(a As Velocity, b As Velocity) As Boolean
        Return a._MetersPerSecond <> b._MetersPerSecond
    End Operator
    Public Shared Operator <(a As Velocity, b As Velocity) As Boolean
        Return a._MetersPerSecond < b._MetersPerSecond
    End Operator
    Public Shared Operator >(a As Velocity, b As Velocity) As Boolean
        Return a._MetersPerSecond > b._MetersPerSecond
    End Operator
    Public Shared Operator <=(a As Velocity, b As Velocity) As Boolean
        Return a._MetersPerSecond <= b._MetersPerSecond
    End Operator
    Public Shared Operator >=(a As Velocity, b As Velocity) As Boolean
        Return a._MetersPerSecond >= b._MetersPerSecond
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As Velocity) As Velocity
        Return a
    End Operator
    Public Shared Operator +(a As Velocity?) As Velocity?
        Return a
    End Operator
    Public Shared Operator -(a As Velocity) As Velocity
        Return Velocity.FromMetersPerSecond(-a._MetersPerSecond)
    End Operator
    Public Shared Operator -(a As Velocity?) As Velocity?
        Return Velocity.FromMetersPerSecond(-a?._MetersPerSecond)
    End Operator

    Public Shared Operator +(a As Velocity, b As Velocity) As Velocity
        Return Velocity.FromMetersPerSecond(a._MetersPerSecond + b._MetersPerSecond)
    End Operator
    Public Shared Operator -(a As Velocity, b As Velocity) As Velocity
        Return Velocity.FromMetersPerSecond(a._MetersPerSecond - b._MetersPerSecond)
    End Operator

    Public Shared Operator *(a As Velocity, b As Double) As Velocity
        Return Velocity.FromMetersPerSecond(a._MetersPerSecond * b)
    End Operator
    Public Shared Operator *(a As Double, b As Velocity) As Velocity
        Return Velocity.FromMetersPerSecond(b._MetersPerSecond * a)
    End Operator
    Public Shared Operator /(a As Velocity, b As Double) As Velocity
        Return Velocity.FromMetersPerSecond(a._MetersPerSecond / b)
    End Operator
    Public Shared Operator /(a As Velocity, b As Velocity) As Double
        Return a._MetersPerSecond / b._MetersPerSecond
    End Operator

    Public Shared Operator *(a As Velocity, b As TimeSpan) As Length
        Return Length.FromMeters(a.MetersPerSecond * b.TotalSeconds)
    End Operator
    Public Shared Operator *(a As TimeSpan, b As Velocity) As Length
        Return Length.FromMeters(a.TotalSeconds * b.MetersPerSecond)
    End Operator

    Public Shared Operator /(a As Velocity, b As TimeSpan) As Acceleration
        Return Acceleration.FromMetersPerSquareSecond(a.MetersPerSecond / b.TotalSeconds)
    End Operator

#End Region

End Structure