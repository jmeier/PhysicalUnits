Option Strict On
Option Infer On

Partial Structure Density

#Region "Equality, Comparison"

    Public Shared Operator =(a As Density, b As Density) As Boolean
        Return a._KilogramsPerCubicmeter = b._KilogramsPerCubicmeter
    End Operator
    Public Shared Operator <>(a As Density, b As Density) As Boolean
        Return a._KilogramsPerCubicmeter <> b._KilogramsPerCubicmeter
    End Operator
    Public Shared Operator <(a As Density, b As Density) As Boolean
        Return a._KilogramsPerCubicmeter < b._KilogramsPerCubicmeter
    End Operator
    Public Shared Operator >(a As Density, b As Density) As Boolean
        Return a._KilogramsPerCubicmeter > b._KilogramsPerCubicmeter
    End Operator
    Public Shared Operator <=(a As Density, b As Density) As Boolean
        Return a._KilogramsPerCubicmeter <= b._KilogramsPerCubicmeter
    End Operator
    Public Shared Operator >=(a As Density, b As Density) As Boolean
        Return a._KilogramsPerCubicmeter >= b._KilogramsPerCubicmeter
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As Density) As Density
        Return a
    End Operator
    Public Shared Operator +(a As Density?) As Density?
        Return a
    End Operator
    Public Shared Operator -(a As Density) As Density
        Return New Density With {._KilogramsPerCubicmeter = a._KilogramsPerCubicmeter}
    End Operator
    Public Shared Operator -(a As Density?) As Density?
        Return Density.FromKilogramsPerCubicmeter(a?._KilogramsPerCubicmeter)
    End Operator

    Public Shared Operator +(a As Density, b As Density) As Density
        Return Density.FromKilogramsPerCubicmeter(a._KilogramsPerCubicmeter + b._KilogramsPerCubicmeter)
    End Operator
    Public Shared Operator -(a As Density, b As Density) As Density
        Return Density.FromKilogramsPerCubicmeter(a._KilogramsPerCubicmeter - b._KilogramsPerCubicmeter)
    End Operator

    Public Shared Operator *(a As Density, b As Double) As Density
        Return Density.FromKilogramsPerCubicmeter(a._KilogramsPerCubicmeter * b)
    End Operator
    Public Shared Operator *(a As Double, b As Density) As Density
        Return Density.FromKilogramsPerCubicmeter(b._KilogramsPerCubicmeter * a)
    End Operator
    Public Shared Operator /(a As Density, b As Double) As Density
        Return Density.FromKilogramsPerCubicmeter(a._KilogramsPerCubicmeter / b)
    End Operator
    Public Shared Operator /(a As Density, b As Density) As Double
        Return a._KilogramsPerCubicmeter / b._KilogramsPerCubicmeter
    End Operator

    Public Shared Operator *(a As Density, b As Acceleration) As PerVolume(Of Force)
        'kg/m³ * m/s² = N/m³
        '1N ≡ 1 kg·m/s² 
        Return NewtonsPerCubicMeter(a._KilogramsPerCubicmeter * b.MetersPerSquareSecond)
    End Operator
    Public Shared Operator *(a As Acceleration, b As Density) As PerVolume(Of Force)
        Return NewtonsPerCubicMeter(b._KilogramsPerCubicmeter * a.MetersPerSquareSecond)
    End Operator

    Public Shared Operator *(a As Density, b As Volume) As Mass
        Return Mass.FromKilograms(a._KilogramsPerCubicmeter * b.MetersPow3)
    End Operator
    Public Shared Operator *(a As Volume, b As Density) As Mass
        Return Mass.FromKilograms(b._KilogramsPerCubicmeter * a.MetersPow3)
    End Operator

#End Region

End Structure