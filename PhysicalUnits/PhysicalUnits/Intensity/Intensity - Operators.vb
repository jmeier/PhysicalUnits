Option Strict On
Option Infer On

Partial Structure Intensity

#Region "Equality, Comparison"

    Public Shared Operator =(a As Intensity, b As Intensity) As Boolean
        Return a._WattsPerSquaremeter = b._WattsPerSquaremeter
    End Operator
    Public Shared Operator <>(a As Intensity, b As Intensity) As Boolean
        Return a._WattsPerSquaremeter <> b._WattsPerSquaremeter
    End Operator
    Public Shared Operator <(a As Intensity, b As Intensity) As Boolean
        Return a._WattsPerSquaremeter < b._WattsPerSquaremeter
    End Operator
    Public Shared Operator >(a As Intensity, b As Intensity) As Boolean
        Return a._WattsPerSquaremeter > b._WattsPerSquaremeter
    End Operator
    Public Shared Operator <=(a As Intensity, b As Intensity) As Boolean
        Return a._WattsPerSquaremeter <= b._WattsPerSquaremeter
    End Operator
    Public Shared Operator >=(a As Intensity, b As Intensity) As Boolean
        Return a._WattsPerSquaremeter >= b._WattsPerSquaremeter
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As Intensity) As Intensity
        Return a
    End Operator
    Public Shared Operator +(a As Intensity?) As Intensity?
        Return a
    End Operator
    Public Shared Operator -(a As Intensity) As Intensity
        Return Intensity.FromWattsPerSquaremeter(-a._WattsPerSquaremeter)
    End Operator
    Public Shared Operator -(a As Intensity?) As Intensity?
        Return Intensity.FromWattsPerSquaremeter(-a?._WattsPerSquaremeter)
    End Operator


    Public Shared Operator +(a As Intensity, b As Intensity) As Intensity
        Return Intensity.FromWattsPerSquaremeter(a._WattsPerSquaremeter + b._WattsPerSquaremeter)
    End Operator
    Public Shared Operator -(a As Intensity, b As Intensity) As Intensity
        Return Intensity.FromWattsPerSquaremeter(a._WattsPerSquaremeter - b._WattsPerSquaremeter)
    End Operator

    Public Shared Operator *(a As Intensity, b As Double) As Intensity
        Return Intensity.FromWattsPerSquaremeter(a._WattsPerSquaremeter * b)
    End Operator
    Public Shared Operator *(a As Double, b As Intensity) As Intensity
        Return Intensity.FromWattsPerSquaremeter(b._WattsPerSquaremeter * a)
    End Operator
    Public Shared Operator /(a As Intensity, b As Double) As Intensity
        Return Intensity.FromWattsPerSquaremeter(a._WattsPerSquaremeter / b)
    End Operator
    Public Shared Operator /(a As Intensity, b As Intensity) As Double
        Return a._WattsPerSquaremeter / b._WattsPerSquaremeter
    End Operator

    Public Shared Operator *(a As Intensity, b As Area) As Power
        Return Power.FromWatts(a.WattsPerSquaremeter * b.SquareMeters)
    End Operator

#End Region

End Structure