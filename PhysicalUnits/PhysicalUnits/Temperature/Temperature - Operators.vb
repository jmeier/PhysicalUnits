Option Strict On
Option Infer On

Partial Structure Temperature

#Region "Equality, Comparison"

    Public Shared Operator =(a As Temperature, b As Temperature) As Boolean
        Return a._Kelvin = b._Kelvin
    End Operator
    Public Shared Operator <>(a As Temperature, b As Temperature) As Boolean
        Return a._Kelvin <> b._Kelvin
    End Operator
    Public Shared Operator <(a As Temperature, b As Temperature) As Boolean
        Return a._Kelvin < b._Kelvin
    End Operator
    Public Shared Operator >(a As Temperature, b As Temperature) As Boolean
        Return a._Kelvin > b._Kelvin
    End Operator
    Public Shared Operator <=(a As Temperature, b As Temperature) As Boolean
        Return a._Kelvin <= b._Kelvin
    End Operator
    Public Shared Operator >=(a As Temperature, b As Temperature) As Boolean
        Return a._Kelvin >= b._Kelvin
    End Operator

#End Region

End Structure