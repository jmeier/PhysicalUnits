Option Strict On
Option Infer On

Partial Structure Power

#Region "Equality, Comparison"

    Public Shared Operator =(a As Power, b As Power) As Boolean
        Return a._Watts = b._Watts
    End Operator
    Public Shared Operator <>(a As Power, b As Power) As Boolean
        Return a._Watts <> b._Watts
    End Operator
    Public Shared Operator <(a As Power, b As Power) As Boolean
        Return a._Watts < b._Watts
    End Operator
    Public Shared Operator >(a As Power, b As Power) As Boolean
        Return a._Watts > b._Watts
    End Operator
    Public Shared Operator <=(a As Power, b As Power) As Boolean
        Return a._Watts <= b._Watts
    End Operator
    Public Shared Operator >=(a As Power, b As Power) As Boolean
        Return a._Watts >= b._Watts
    End Operator

#End Region

#Region "Arithmetics"
    Public Shared Operator +(a As Power) As Power
        Return a
    End Operator
    Public Shared Operator +(a As Power?) As Power?
        Return a
    End Operator
    Public Shared Operator -(a As Power) As Power
        Return Power.FromWatts(-a._Watts)
    End Operator
    Public Shared Operator -(a As Power?) As Power?
        Return Power.FromWatts(-a?._Watts)
    End Operator

    Public Shared Operator +(a As Power, b As Power) As Power
        Return Power.FromWatts(a._Watts + b._Watts)
    End Operator
    Public Shared Operator -(a As Power, b As Power) As Power
        Return Power.FromWatts(a._Watts - b._Watts)
    End Operator

    Public Shared Operator *(a As Power, b As Double) As Power
        Return Power.FromWatts(a._Watts * b)
    End Operator
    Public Shared Operator *(a As Double, b As Power) As Power
        Return Power.FromWatts(b._Watts * a)
    End Operator
    Public Shared Operator /(a As Power, b As Double) As Power
        Return Power.FromWatts(a._Watts / b)
    End Operator
    Public Shared Operator /(a As Power, b As Power) As Double
        Return a._Watts / b._Watts
    End Operator

    Public Shared Operator /(a As Power, b As TimeSpan) As Energy
        Return Energy.FromJoules(a.Watts / b.TotalSeconds)
    End Operator

    Public Shared Operator /(a As Power, b As Energy) As TimeSpan
        Return TimeSpan.FromSeconds(a.Watts / b.Joules)
    End Operator

    Public Shared Operator /(a As Power, b As Area) As Intensity
        Return Intensity.FromWattsPerSquaremeter(a.Watts / b.SquareMeters)
    End Operator

#End Region

End Structure