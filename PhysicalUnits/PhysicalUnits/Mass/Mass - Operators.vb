Option Strict On
Option Infer On

Partial Structure Mass

#Region "Equality, Comparison"

    Public Shared Operator =(a As Mass, b As Mass) As Boolean
        Return a._Kilograms = b._Kilograms
    End Operator
    Public Shared Operator <>(a As Mass, b As Mass) As Boolean
        Return a._Kilograms <> b._Kilograms
    End Operator
    Public Shared Operator <(a As Mass, b As Mass) As Boolean
        Return a._Kilograms < b._Kilograms
    End Operator
    Public Shared Operator >(a As Mass, b As Mass) As Boolean
        Return a._Kilograms > b._Kilograms
    End Operator
    Public Shared Operator <=(a As Mass, b As Mass) As Boolean
        Return a._Kilograms <= b._Kilograms
    End Operator
    Public Shared Operator >=(a As Mass, b As Mass) As Boolean
        Return a._Kilograms >= b._Kilograms
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As Mass) As Mass
        Return a
    End Operator
    Public Shared Operator +(a As Mass?) As Mass?
        Return a
    End Operator
    Public Shared Operator -(a As Mass) As Mass
        Return Mass.FromKilograms(-a._Kilograms)
    End Operator
    Public Shared Operator -(a As Mass?) As Mass?
        Return Mass.FromKilograms(-a?._Kilograms)
    End Operator

    Public Shared Operator +(a As Mass, b As Mass) As Mass
        Return Mass.FromKilograms(a._Kilograms + b._Kilograms)
    End Operator
    Public Shared Operator -(a As Mass, b As Mass) As Mass
        Return Mass.FromKilograms(a._Kilograms - b._Kilograms)
    End Operator

    Public Shared Operator *(a As Mass, b As Double) As Mass
        Return Mass.FromKilograms(a._Kilograms * b)
    End Operator
    Public Shared Operator *(a As Double, b As Mass) As Mass
        Return Mass.FromKilograms(b._Kilograms * a)
    End Operator
    Public Shared Operator /(a As Mass, b As Double) As Mass
        Return Mass.FromKilograms(a._Kilograms / b)
    End Operator
    Public Shared Operator /(a As Mass, b As Mass) As Double
        Return a._Kilograms / b._Kilograms
    End Operator

    Public Shared Operator *(a As Mass, b As Acceleration) As Force
        Return Force.FromNewtons(a.Kilograms * b.MetersPerSquaresecond)
    End Operator
    Public Shared Operator *(a As Acceleration, b As Mass) As Force
        Return Force.FromNewtons(b.Kilograms * a.MetersPerSquaresecond)
    End Operator

    Public Shared Operator /(a As Mass, b As Volume) As Density
        Return Density.FromKilogramsPerCubicmeter(a.Kilograms / b.CubicMeters)
    End Operator

#End Region


End Structure