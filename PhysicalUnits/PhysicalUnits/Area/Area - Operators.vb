Option Strict On
Option Infer On

Partial Structure Area

#Region "Equality, Comparison"

    Public Shared Operator =(a As Area, b As Area) As Boolean
        Return a._MetersPow2 = b._MetersPow2
    End Operator
    Public Shared Operator <>(a As Area, b As Area) As Boolean
        Return a._MetersPow2 <> b._MetersPow2
    End Operator
    Public Shared Operator <(a As Area, b As Area) As Boolean
        Return a._MetersPow2 < b._MetersPow2
    End Operator
    Public Shared Operator >(a As Area, b As Area) As Boolean
        Return a._MetersPow2 > b._MetersPow2
    End Operator
    Public Shared Operator <=(a As Area, b As Area) As Boolean
        Return a._MetersPow2 <= b._MetersPow2
    End Operator
    Public Shared Operator >=(a As Area, b As Area) As Boolean
        Return a._MetersPow2 >= b._MetersPow2
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As Area) As Area
        Return a
    End Operator
    Public Shared Operator +(a As Area?) As Area?
        Return a
    End Operator
    Public Shared Operator -(a As Area) As Area
        Return Area.FromSquaremeters(-a._MetersPow2)
    End Operator
    Public Shared Operator -(a As Area?) As Area?
        Return Area.FromSquaremeters(-a?._MetersPow2)
    End Operator

    Public Shared Operator +(a As Area, b As Area) As Area
        Return Area.FromSquaremeters(a._MetersPow2 + b._MetersPow2)
    End Operator
    Public Shared Operator -(a As Area, b As Area) As Area
        Return Area.FromSquaremeters(a._MetersPow2 - b._MetersPow2)
    End Operator

    Public Shared Operator *(a As Area, b As Double) As Area
        Return Area.FromSquaremeters(a._MetersPow2 * b)
    End Operator
    Public Shared Operator *(a As Double, b As Area) As Area
        Return Area.FromSquaremeters(b._MetersPow2 * a)
    End Operator

    Public Shared Operator *(a As Area, b As Area) As LengthPow4
        Return LengthPow4.FromMetersPow4(a.Squaremeters * b.Squaremeters)
    End Operator

    Public Shared Operator *(a As PerLength(Of Force), b As Area) As TimesLength(Of Force)
        Return NewtonMeters(a.ValuePerRunningMeter.Newtons * b.SquareMeters)
    End Operator
    Public Shared Operator *(a As Area, b As PerLength(Of Force)) As TimesLength(Of Force)
        Return NewtonMeters(b.ValuePerRunningMeter.Newtons * a.SquareMeters)
    End Operator

    Public Shared Operator /(a As Area, b As Double) As Area
        Return Area.FromSquaremeters(a._MetersPow2 / b)
    End Operator
    Public Shared Operator /(a As Area, b As Area) As Double
        Return a._MetersPow2 / b._MetersPow2
    End Operator

    Public Shared Operator /(a As Area, b As Length) As Length
        Return Length.FromMeters(a._MetersPow2 / b.Meters)
    End Operator

    Public Shared Operator *(a As Area, b As Length) As Volume
        Return Volume.FromMetersPow3(a.Squaremeters * b.Meters)
    End Operator
    Public Shared Operator *(a As Length, b As Area) As Volume
        Return Volume.FromMetersPow3(a.Meters * b.Squaremeters)
    End Operator

    'Public Shared Operator *(a As Area, b As PerVolume(Of Force)) As PerLength(Of Force)
    '    Return Volume.FromMetersPow3(a.SquareMeters * b.Meters)
    'End Operator
    'Public Shared Operator *(a As PerVolume(Of Force), b As Area) As PerLength(Of Force)
    '    Return Volume.FromMetersPow3(a.Meters * b.SquareMeters)
    'End Operator


#End Region

#Region "Vector Arithmetics"

    Public Shared Operator /(a As Vector3D(Of Force), d As Area) As Vector3D(Of Pressure)
        Return New Vector3D(Of Pressure)(x:=a.X / d,
                                               y:=a.Y / d,
                                               z:=a.Z / d)
    End Operator
    Public Shared Operator *(a As Vector3D(Of Force), d As Area) As Vector3D(Of TimesArea(Of Force))
        Return New Vector3D(Of TimesArea(Of Force))(x:=a.X * d,
                                                    y:=a.Y * d,
                                                    z:=a.Z * d)
    End Operator


#End Region

End Structure