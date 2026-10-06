Option Strict On
Option Infer On

Partial Structure SoundPressure

#Region "Equality, Comparison"

    Public Shared Operator =(a As SoundPressure, b As SoundPressure) As Boolean
        Return a._Decibel = b._Decibel
    End Operator
    Public Shared Operator <>(a As SoundPressure, b As SoundPressure) As Boolean
        Return a._Decibel <> b._Decibel
    End Operator
    Public Shared Operator <(a As SoundPressure, b As SoundPressure) As Boolean
        Return a._Decibel < b._Decibel
    End Operator
    Public Shared Operator >(a As SoundPressure, b As SoundPressure) As Boolean
        Return a._Decibel > b._Decibel
    End Operator
    Public Shared Operator <=(a As SoundPressure, b As SoundPressure) As Boolean
        Return a._Decibel <= b._Decibel
    End Operator
    Public Shared Operator >=(a As SoundPressure, b As SoundPressure) As Boolean
        Return a._Decibel >= b._Decibel
    End Operator

#End Region

#Region "Arithmetics"
    Public Shared Operator +(a As SoundPressure) As SoundPressure
        Return a
    End Operator
    Public Shared Operator +(a As SoundPressure?) As SoundPressure?
        Return a
    End Operator
    Public Shared Operator -(a As SoundPressure) As SoundPressure
        Return SoundPressure.FromDecibel(-a._Decibel)
    End Operator
    Public Shared Operator -(a As SoundPressure?) As SoundPressure?
        Return SoundPressure.FromDecibel(-a?._Decibel)
    End Operator


    Public Shared Operator +(a As SoundPressure, b As SoundPressure) As SoundPressure
        Return SoundPressure.FromDecibel(a._Decibel + b._Decibel)
    End Operator
    Public Shared Operator -(a As SoundPressure, b As SoundPressure) As SoundPressure
        Return SoundPressure.FromDecibel(a._Decibel - b._Decibel)
    End Operator

    Public Shared Operator *(a As SoundPressure, b As Double) As SoundPressure
        Return SoundPressure.FromDecibel(a._Decibel * b)
    End Operator
    Public Shared Operator *(a As Double, b As SoundPressure) As SoundPressure
        Return SoundPressure.FromDecibel(b._Decibel * a)
    End Operator
    Public Shared Operator /(a As SoundPressure, b As Double) As SoundPressure
        Return SoundPressure.FromDecibel(a._Decibel / b)
    End Operator
    Public Shared Operator /(a As SoundPressure, b As SoundPressure) As Double
        Return a._Decibel / b._Decibel
    End Operator

#End Region

End Structure