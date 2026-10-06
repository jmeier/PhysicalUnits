Option Strict On
Option Infer On

Partial Structure Frequency

#Region "Equality, Comparison"

    Public Shared Operator =(a As Frequency, b As Frequency) As Boolean
        Return a._Hertz = b._Hertz
    End Operator
    Public Shared Operator <>(a As Frequency, b As Frequency) As Boolean
        Return a._Hertz <> b._Hertz
    End Operator
    Public Shared Operator <(a As Frequency, b As Frequency) As Boolean
        Return a._Hertz < b._Hertz
    End Operator
    Public Shared Operator >(a As Frequency, b As Frequency) As Boolean
        Return a._Hertz > b._Hertz
    End Operator
    Public Shared Operator <=(a As Frequency, b As Frequency) As Boolean
        Return a._Hertz <= b._Hertz
    End Operator
    Public Shared Operator >=(a As Frequency, b As Frequency) As Boolean
        Return a._Hertz >= b._Hertz
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As Frequency) As Frequency
        Return a
    End Operator
    Public Shared Operator +(a As Frequency?) As Frequency?
        Return a
    End Operator
    Public Shared Operator -(a As Frequency) As Frequency
        Return Frequency.FromHertz(-a._Hertz)
    End Operator
    Public Shared Operator -(a As Frequency?) As Frequency?
        Return Frequency.FromHertz(-a?._Hertz)
    End Operator

    Public Shared Operator +(a As Frequency, b As Frequency) As Frequency
        Return Frequency.FromHertz(a._Hertz + b._Hertz)
    End Operator
    Public Shared Operator -(a As Frequency, b As Frequency) As Frequency
        Return Frequency.FromHertz(a._Hertz - b._Hertz)
    End Operator

    Public Shared Operator *(a As Frequency, b As Double) As Frequency
        Return Frequency.FromHertz(a._Hertz * b)
    End Operator
    Public Shared Operator *(a As Double, b As Frequency) As Frequency
        Return Frequency.FromHertz(b._Hertz * a)
    End Operator
    Public Shared Operator /(a As Frequency, b As Double) As Frequency
        Return Frequency.FromHertz(a._Hertz / b)
    End Operator
    Public Shared Operator /(a As Frequency, b As Frequency) As Double
        Return a._Hertz / b._Hertz
    End Operator

    Public Shared Operator *(a As Frequency, b As TimeSpan) As Double
        Return a._Hertz * b.TotalSeconds
    End Operator
    Public Shared Operator *(a As TimeSpan, b As Frequency) As Double
        Return a.TotalSeconds * b._Hertz
    End Operator

#End Region

End Structure