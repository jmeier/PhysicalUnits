Option Strict On
Option Infer On

Partial Structure Acceleration

#Region "Equality, Comparison"

    Public Shared Operator =(a As Acceleration, b As Acceleration) As Boolean
        Return a._MetersPerSquareSecond = b._MetersPerSquareSecond
    End Operator
    Public Shared Operator <>(a As Acceleration, b As Acceleration) As Boolean
        Return a._MetersPerSquareSecond <> b._MetersPerSquareSecond
    End Operator
    Public Shared Operator <(a As Acceleration, b As Acceleration) As Boolean
        Return a._MetersPerSquareSecond < b._MetersPerSquareSecond
    End Operator
    Public Shared Operator >(a As Acceleration, b As Acceleration) As Boolean
        Return a._MetersPerSquareSecond > b._MetersPerSquareSecond
    End Operator
    Public Shared Operator <=(a As Acceleration, b As Acceleration) As Boolean
        Return a._MetersPerSquareSecond <= b._MetersPerSquareSecond
    End Operator
    Public Shared Operator >=(a As Acceleration, b As Acceleration) As Boolean
        Return a._MetersPerSquareSecond >= b._MetersPerSquareSecond
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As Acceleration) As Acceleration
        Return a
    End Operator
    Public Shared Operator +(a As Acceleration?) As Acceleration?
        Return a
    End Operator
    Public Shared Operator -(a As Acceleration) As Acceleration
        Return Acceleration.FromMetersPerSquareSecond(-a._MetersPerSquareSecond)
    End Operator
    Public Shared Operator -(a As Acceleration?) As Acceleration?
        Return Acceleration.FromMetersPerSquareSecond(-a?._MetersPerSquareSecond)
    End Operator

    Public Shared Operator +(a As Acceleration, b As Acceleration) As Acceleration
        Return Acceleration.FromMetersPerSquareSecond(a._MetersPerSquareSecond + b._MetersPerSquareSecond)
    End Operator
    Public Shared Operator -(a As Acceleration, b As Acceleration) As Acceleration
        Return Acceleration.FromMetersPerSquareSecond(a._MetersPerSquareSecond - b._MetersPerSquareSecond)
    End Operator

    Public Shared Operator *(a As Acceleration, b As Double) As Acceleration
        Return Acceleration.FromMetersPerSquareSecond(a._MetersPerSquareSecond * b)
    End Operator
    Public Shared Operator *(a As Double, b As Acceleration) As Acceleration
        Return Acceleration.FromMetersPerSquareSecond(b._MetersPerSquareSecond * a)
    End Operator
    Public Shared Operator /(a As Acceleration, b As Double) As Acceleration
        Return Acceleration.FromMetersPerSquareSecond(a._MetersPerSquareSecond / b)
    End Operator
    Public Shared Operator /(a As Acceleration, b As Acceleration) As Double
        Return a._MetersPerSquareSecond / b._MetersPerSquareSecond
    End Operator

    Public Shared Operator /(a As PerVolume(Of Force), b As Acceleration) As Density
        Return Density.FromKilogramsPerCubicmeter(a.ValuePerCubicmeter.Newtons / b.MetersPerSquareSecond)
    End Operator

    Public Shared Operator *(a As Acceleration, b As TimeSpan) As Velocity
        Return Velocity.FromMetersPerSecond(a.MetersPerSquaresecond * b.TotalSeconds)
    End Operator
    Public Shared Operator *(a As TimeSpan, b As Acceleration) As Velocity
        Return Velocity.FromMetersPerSecond(a.TotalSeconds * b.MetersPerSquaresecond)
    End Operator
#End Region

#Region "Vector Arithmetics"

    'Public Shared Operator *(a As Vector3D(Of Acceleration), d As TimeSpan) As Vector3D(Of Velocity)
    '    Return New Vector3D(Of Velocity)(x:=a.X * d,
    '                                     y:=a.Y * d,
    '                                     z:=a.Z * d)
    'End Operator

#End Region

End Structure