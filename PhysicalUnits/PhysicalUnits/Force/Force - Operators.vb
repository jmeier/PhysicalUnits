Option Strict On
Option Infer On

Partial Structure Force

#Region "Equality, Comparison"

    Public Shared Operator =(a As Force, b As Force) As Boolean
        Return a._Newtons = b._Newtons
    End Operator
    Public Shared Operator <>(a As Force, b As Force) As Boolean
        Return a._Newtons <> b._Newtons
    End Operator
    Public Shared Operator >(a As Force, b As Force) As Boolean
        Return a._Newtons > b._Newtons
    End Operator
    Public Shared Operator <(a As Force, b As Force) As Boolean
        Return a._Newtons < b._Newtons
    End Operator
    Public Shared Operator >=(a As Force, b As Force) As Boolean
        Return a._Newtons >= b._Newtons
    End Operator
    Public Shared Operator <=(a As Force, b As Force) As Boolean
        Return a._Newtons <= b._Newtons
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As Force) As Force
        Return a
    End Operator
    Public Shared Operator +(a As Force?) As Force?
        Return a
    End Operator
    Public Shared Operator -(a As Force) As Force
        Return Force.FromNewtons(-a._Newtons)
    End Operator
    Public Shared Operator -(a As Force?) As Force?
        Return Force.FromNewtons(-a?._Newtons)
    End Operator

    Public Shared Operator +(a As Force, b As Force) As Force
        Return Force.FromNewtons(a._Newtons + b._Newtons)
    End Operator

    Public Shared Operator -(a As Force, b As Force) As Force
        Return Force.FromNewtons(a._Newtons - b._Newtons)
    End Operator

    Public Shared Operator *(a As Force, b As Double) As Force
        Return Force.FromNewtons(a._Newtons * b)
    End Operator
    Public Shared Operator *(a As Double, b As Force) As Force
        Return Force.FromNewtons(b._Newtons * a)
    End Operator
    Public Shared Operator /(a As Force, b As Double) As Force
        Return Force.FromNewtons(a._Newtons / b)
    End Operator
    Public Shared Operator /(a As Force, b As Force) As Double
        Return a._Newtons / b._Newtons
    End Operator

    Public Shared Operator /(a As Force, b As PerLength(Of Force)) As Length
        Return Length.FromMeters(a._Newtons / b.NewtonsPerMeter)
    End Operator


    Public Shared Operator /(a As Force, b As Area) As Pressure
        Return Pressure.FromNewtonsPerSquaremeter(a.Newtons / b.SquareMeters)
    End Operator

    Public Shared Operator /(a As Force, b As Acceleration) As Mass
        Return Mass.FromKilograms(a.Newtons / b.MetersPerSquareSecond)
    End Operator

    Public Shared Operator /(a As Force, b As Mass) As Acceleration
        Return Acceleration.FromMetersPerSquareSecond(a.Newtons / b.Kilograms)
    End Operator

    Public Shared Operator *(a As Length, b As Force) As TimesLength(Of Force)
        Return NewtonMeters(a.Meters * b.Newtons)
    End Operator
    Public Shared Operator *(a As Force, b As Length) As TimesLength(Of Force)
        Return NewtonMeters(a.Newtons * b.Meters)
    End Operator

    Public Shared Operator *(a As Force, b As Area) As TimesArea(Of Force)
        Return NewtonSquareMeters(a.Newtons * b.SquareMeters)
    End Operator
    Public Shared Operator *(a As Area, b As Force) As TimesArea(Of Force)
        Return NewtonSquareMeters(a.SquareMeters * b.Newtons)
    End Operator

    Public Shared Operator /(a As TimesLength(Of Force), b As Force) As Length
        Return Meters(a.ValueTimesMeter / b)
    End Operator

    Public Shared Operator /(a As Force, b As Length) As PerLength(Of Force)
        Return NewtonsPerMeter(a.Newtons / b.Meters)
    End Operator

    Public Shared Operator /(a As Force, b As Volume) As PerVolume(Of Force)
        Return NewtonsPerCubicMeter(a.Newtons / b.MetersPow3)
    End Operator

#End Region

End Structure