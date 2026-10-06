Option Strict On
Option Infer On

Partial Structure Pressure

#Region "CType"

    Public Shared Widening Operator CType(a As Pressure) As PerArea(Of Force)
        Return New PerArea(Of Force)(Newtons(a.NewtonsPerSquaremeter))
    End Operator

    Public Shared Widening Operator CType(a As PerArea(Of Force)) As Pressure
        Return FromNewtonsPerSquaremeter(a.ValuePerSquaremeter.Newtons)
    End Operator

#End Region

#Region "Equality, Comparison"

    Public Shared Operator =(a As Pressure, b As Pressure) As Boolean
        Return a._NewtonsPerSquaremeter = b._NewtonsPerSquaremeter
    End Operator
    Public Shared Operator <>(a As Pressure, b As Pressure) As Boolean
        Return a._NewtonsPerSquaremeter <> b._NewtonsPerSquaremeter
    End Operator
    Public Shared Operator <(a As Pressure, b As Pressure) As Boolean
        Return a._NewtonsPerSquaremeter < b._NewtonsPerSquaremeter
    End Operator
    Public Shared Operator >(a As Pressure, b As Pressure) As Boolean
        Return a._NewtonsPerSquaremeter > b._NewtonsPerSquaremeter
    End Operator
    Public Shared Operator <=(a As Pressure, b As Pressure) As Boolean
        Return a._NewtonsPerSquaremeter <= b._NewtonsPerSquaremeter
    End Operator
    Public Shared Operator >=(a As Pressure, b As Pressure) As Boolean
        Return a._NewtonsPerSquaremeter >= b._NewtonsPerSquaremeter
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As Pressure) As Pressure
        Return a
    End Operator
    Public Shared Operator +(a As Pressure?) As Pressure?
        Return a
    End Operator
    Public Shared Operator -(a As Pressure) As Pressure
        Return Pressure.FromNewtonsPerSquaremeter(-a._NewtonsPerSquaremeter)
    End Operator
    Public Shared Operator -(a As Pressure?) As Pressure?
        Return Pressure.FromNewtonsPerSquaremeter(-a?._NewtonsPerSquaremeter)
    End Operator

    Public Shared Operator +(a As Pressure, b As Pressure) As Pressure
        Return Pressure.FromNewtonsPerSquaremeter(a._NewtonsPerSquaremeter + b._NewtonsPerSquaremeter)
    End Operator
    Public Shared Operator +(a As Pressure, b As PerArea(Of Force)) As Pressure
        Return Pressure.FromNewtonsPerSquaremeter(a._NewtonsPerSquaremeter + b.ValuePerSquaremeter.Newtons)
    End Operator
    Public Shared Operator +(a As PerArea(Of Force), b As Pressure) As Pressure
        Return Pressure.FromNewtonsPerSquaremeter(a.ValuePerSquaremeter.Newtons + b._NewtonsPerSquaremeter)
    End Operator

    Public Shared Operator -(a As Pressure, b As Pressure) As Pressure
        Return Pressure.FromNewtonsPerSquaremeter(a._NewtonsPerSquaremeter - b._NewtonsPerSquaremeter)
    End Operator
    Public Shared Operator -(a As Pressure, b As PerArea(Of Force)) As Pressure
        Return Pressure.FromNewtonsPerSquaremeter(a._NewtonsPerSquaremeter - b.ValuePerSquaremeter.Newtons)
    End Operator
    Public Shared Operator -(a As PerArea(Of Force), b As Pressure) As Pressure
        Return Pressure.FromNewtonsPerSquaremeter(a.ValuePerSquaremeter.Newtons - b._NewtonsPerSquaremeter)
    End Operator

    Public Shared Operator *(a As Pressure, b As Double) As Pressure
        Return Pressure.FromNewtonsPerSquaremeter(a._NewtonsPerSquaremeter * b)
    End Operator
    Public Shared Operator *(a As Double, b As Pressure) As Pressure
        Return Pressure.FromNewtonsPerSquaremeter(b._NewtonsPerSquaremeter * a)
    End Operator
    Public Shared Operator /(a As Pressure, b As Double) As Pressure
        Return Pressure.FromNewtonsPerSquaremeter(a._NewtonsPerSquaremeter / b)
    End Operator
    Public Shared Operator /(a As Pressure, b As Pressure) As Double
        Return a._NewtonsPerSquaremeter / b._NewtonsPerSquaremeter
    End Operator
    Public Shared Operator /(a As Force, b As Pressure) As Area
        Return Squaremeters(a.Newtons / b._NewtonsPerSquaremeter)
    End Operator

    Public Shared Operator /(a As Pressure, b As Length) As PerVolume(Of Force)
        Return Newtons(a._NewtonsPerSquaremeter / b.Meters).PerCubicmeter
    End Operator

    Public Shared Operator *(a As Pressure, b As Length) As PerLength(Of Force)
        Return NewtonsPerMeter(a.NewtonsPerSquaremeter * b.Meters)
    End Operator
    Public Shared Operator *(a As Length, b As Pressure) As PerLength(Of Force)
        Return NewtonsPerMeter(a.Meters * b.NewtonsPerSquaremeter)
    End Operator

    Public Shared Operator *(a As Pressure, b As Area) As Force
        Return Force.FromNewtons(a.NewtonsPerSquaremeter * b.SquareMeters)
    End Operator
    Public Shared Operator *(a As Area, b As Pressure) As Force
        Return Force.FromNewtons(a.SquareMeters * b.NewtonsPerSquaremeter)
    End Operator

    Public Shared Operator *(a As Pressure, b As LengthPow4) As TimesArea(Of Force)
        Return NewtonSquareMeters(a.NewtonsPerSquaremeter * b.MetersPow4)
    End Operator
    Public Shared Operator *(a As LengthPow4, b As Pressure) As TimesArea(Of Force)
        Return NewtonSquareMeters(a.MetersPow4 * b.NewtonsPerSquaremeter)
    End Operator

#End Region

End Structure