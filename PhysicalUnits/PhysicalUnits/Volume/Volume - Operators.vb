Option Strict On
Option Infer On

Partial Structure Volume

#Region "Equality, Comparison"

    Public Shared Operator =(a As Volume, b As Volume) As Boolean
        Return a._MetersPow3 = b._MetersPow3
    End Operator
    Public Shared Operator <>(a As Volume, b As Volume) As Boolean
        Return a._MetersPow3 <> b._MetersPow3
    End Operator
    Public Shared Operator <(a As Volume, b As Volume) As Boolean
        Return a._MetersPow3 < b._MetersPow3
    End Operator
    Public Shared Operator >(a As Volume, b As Volume) As Boolean
        Return a._MetersPow3 > b._MetersPow3
    End Operator
    Public Shared Operator <=(a As Volume, b As Volume) As Boolean
        Return a._MetersPow3 <= b._MetersPow3
    End Operator
    Public Shared Operator >=(a As Volume, b As Volume) As Boolean
        Return a._MetersPow3 >= b._MetersPow3
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As Volume) As Volume
        Return a
    End Operator
    Public Shared Operator +(a As Volume?) As Volume?
        Return a
    End Operator
    Public Shared Operator -(a As Volume) As Volume
        Return FromMetersPow3(-a._MetersPow3)
    End Operator
    Public Shared Operator -(a As Volume?) As Volume?
        Return FromMetersPow3(-a?._MetersPow3)
    End Operator

    Public Shared Operator +(a As Volume, b As Volume) As Volume
        Return FromMetersPow3(a._MetersPow3 + b._MetersPow3)
    End Operator
    Public Shared Operator -(a As Volume, b As Volume) As Volume
        Return FromMetersPow3(a._MetersPow3 - b._MetersPow3)
    End Operator

    Public Shared Operator *(a As Volume, b As Double) As Volume
        Return FromMetersPow3(a._MetersPow3 * b)
    End Operator
    Public Shared Operator *(a As Double, b As Volume) As Volume
        Return FromMetersPow3(b._MetersPow3 * a)
    End Operator

    Public Shared Operator *(a As Volume, b As Length) As LengthPow4
        Return LengthPow4.FromMetersPow4(a.MetersPow3 * b.Meters)
    End Operator
    Public Shared Operator *(a As Length, b As Volume) As LengthPow4
        Return LengthPow4.FromMetersPow4(a.Meters * b.MetersPow3)
    End Operator

    'Public Shared Operator *(a As LengthPow3, b As Density) As Mass
    '    Return Mass.FromKilograms(a.MetersPow3 * b.KilogramsPerCubicmeter)
    'End Operator
    'Public Shared Operator *(a As Density, b As LengthPow3) As Mass
    '    Return Mass.FromKilograms(a.KilogramsPerCubicmeter * b.MetersPow3)
    'End Operator

    Public Shared Operator *(a As Volume, b As Pressure) As TimesLength(Of Force)
        Return KilonewtonMeters(a.MetersPow3 * b.KilonewtonsPerSquaremeter)
    End Operator
    Public Shared Operator *(a As Pressure, b As Volume) As TimesLength(Of Force)
        Return KilonewtonMeters(a.KilonewtonsPerSquaremeter * b.MetersPow3)
    End Operator

    Public Shared Operator /(a As Volume, b As Double) As Volume
        Return FromMetersPow3(a._MetersPow3 / b)
    End Operator
    Public Shared Operator /(a As Volume, b As Volume) As Double
        Return a._MetersPow3 / b.MetersPow3
    End Operator
    Public Shared Operator /(a As Volume, b As Length) As Area
        Return Area.FromSquaremeters(a._MetersPow3 / b.Meters)
    End Operator
    Public Shared Operator /(a As Volume, b As Area) As Length
        Return Length.FromMeters(a._MetersPow3 / b.Squaremeters)
    End Operator

    Public Shared Operator /(a As TimesLength(Of Force), b As Volume) As Pressure
        Return Pressure.FromNewtonsPerSquaremeter(a.NewtonMeters / b.MetersPow3)
    End Operator


    'Public Shared Operator *(a As PerVolume(Of Force), b As Volume) As Force
    '    Return Force.FromNewtons(a.ValuePerCubicmeter.Newtons * b._MetersPow3)
    'End Operator
    'Public Shared Operator *(a As Volume, b As PerVolume(Of Force)) As Force
    '    Return Force.FromNewtons(b.ValuePerCubicmeter.Newtons * a._MetersPow3)
    'End Operator

#End Region

End Structure