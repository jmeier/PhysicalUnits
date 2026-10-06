Option Strict On
Option Infer On

Partial Structure Energy

#Region "Equality, Comparison"

    Public Shared Operator =(a As Energy, b As Energy) As Boolean
        Return a._Joules = b._Joules
    End Operator
    Public Shared Operator <>(a As Energy, b As Energy) As Boolean
        Return a._Joules <> b._Joules
    End Operator
    Public Shared Operator <(a As Energy, b As Energy) As Boolean
        Return a._Joules < b._Joules
    End Operator
    Public Shared Operator >(a As Energy, b As Energy) As Boolean
        Return a._Joules > b._Joules
    End Operator
    Public Shared Operator <=(a As Energy, b As Energy) As Boolean
        Return a._Joules <= b._Joules
    End Operator
    Public Shared Operator >=(a As Energy, b As Energy) As Boolean
        Return a._Joules >= b._Joules
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As Energy) As Energy
        Return a
    End Operator
    Public Shared Operator +(a As Energy?) As Energy?
        Return a
    End Operator
    Public Shared Operator -(a As Energy) As Energy
        Return Energy.FromJoules(-a._Joules)
    End Operator
    Public Shared Operator -(a As Energy?) As Energy?
        Return Energy.FromJoules(-a?._Joules)
    End Operator

    Public Shared Operator +(a As Energy, b As Energy) As Energy
        Return Energy.FromJoules(a._Joules + b._Joules)
    End Operator
    Public Shared Operator -(a As Energy, b As Energy) As Energy
        Return Energy.FromJoules(a._Joules - b._Joules)
    End Operator

    Public Shared Operator *(a As Energy, b As Double) As Energy
        Return Energy.FromJoules(a._Joules * b)
    End Operator
    Public Shared Operator *(a As Double, b As Energy) As Energy
        Return Energy.FromJoules(b._Joules * a)
    End Operator
    Public Shared Operator /(a As Energy, b As Double) As Energy
        Return Energy.FromJoules(a._Joules / b)
    End Operator
    Public Shared Operator /(a As Energy, b As Energy) As Double
        Return a._Joules / b._Joules
    End Operator

#End Region

End Structure