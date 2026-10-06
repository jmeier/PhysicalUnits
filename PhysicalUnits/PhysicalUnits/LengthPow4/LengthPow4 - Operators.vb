Option Strict On
Option Infer On

Partial Structure LengthPow4

#Region "Equality, Comparison"

    Public Shared Operator =(a As LengthPow4, b As LengthPow4) As Boolean
        Return a._MetersPow4 = b._MetersPow4
    End Operator
    Public Shared Operator <>(a As LengthPow4, b As LengthPow4) As Boolean
        Return a._MetersPow4 <> b._MetersPow4
    End Operator
    Public Shared Operator <(a As LengthPow4, b As LengthPow4) As Boolean
        Return a._MetersPow4 < b._MetersPow4
    End Operator
    Public Shared Operator >(a As LengthPow4, b As LengthPow4) As Boolean
        Return a._MetersPow4 > b._MetersPow4
    End Operator
    Public Shared Operator <=(a As LengthPow4, b As LengthPow4) As Boolean
        Return a._MetersPow4 <= b._MetersPow4
    End Operator
    Public Shared Operator >=(a As LengthPow4, b As LengthPow4) As Boolean
        Return a._MetersPow4 >= b._MetersPow4
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As LengthPow4) As LengthPow4
        Return a
    End Operator
    Public Shared Operator +(a As LengthPow4?) As LengthPow4?
        Return a
    End Operator
    Public Shared Operator -(a As LengthPow4) As LengthPow4
        Return FromMetersPow4(a._MetersPow4)
    End Operator
    Public Shared Operator -(a As LengthPow4?) As LengthPow4?
        Return FromMetersPow4(a?._MetersPow4)
    End Operator

    Public Shared Operator +(a As LengthPow4, b As LengthPow4) As LengthPow4
        Return FromMetersPow4(a._MetersPow4 + b._MetersPow4)
    End Operator
    Public Shared Operator -(a As LengthPow4, b As LengthPow4) As LengthPow4
        Return FromMetersPow4(a._MetersPow4 - b._MetersPow4)
    End Operator

    Public Shared Operator *(a As LengthPow4, b As Double) As LengthPow4
        Return FromMetersPow4(a._MetersPow4 * b)
    End Operator
    Public Shared Operator *(a As Double, b As LengthPow4) As LengthPow4
        Return FromMetersPow4(b._MetersPow4 * a)
    End Operator
    Public Shared Operator /(a As LengthPow4, b As Double) As LengthPow4
        Return FromMetersPow4(a._MetersPow4 / b)
    End Operator
    Public Shared Operator /(a As LengthPow4, b As LengthPow4) As Double
        Return a._MetersPow4 / b.MetersPow4
    End Operator

    Public Shared Operator /(a As LengthPow4, b As Length) As Volume
        Return Volume.FromMetersPow3(a._MetersPow4 / b.Meters)
    End Operator

    Public Shared Operator /(a As LengthPow4, b As Area) As Area
        Return Area.FromSquareMeters(a._MetersPow4 / b.SquareMeters)
    End Operator

    Public Shared Operator /(a As LengthPow4, b As Volume) As Length
        Return Length.FromMeters(a._MetersPow4 / b.MetersPow3)
    End Operator

#End Region

End Structure