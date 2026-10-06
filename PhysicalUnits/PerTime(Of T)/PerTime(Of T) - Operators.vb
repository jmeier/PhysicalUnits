Option Strict On
Option Infer On

Partial Structure PerTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

#Region "Equality, Comparison"

    Public Shared Operator =(a As PerTime(Of T), b As PerTime(Of T)) As Boolean
        Return a._ValuePerSecond.Equals(b._ValuePerSecond)
    End Operator
    Public Shared Operator <>(a As PerTime(Of T), b As PerTime(Of T)) As Boolean
        Return Not a._ValuePerSecond.Equals(b._ValuePerSecond)
    End Operator
    Public Shared Operator <(a As PerTime(Of T), b As PerTime(Of T)) As Boolean
        Return a._ValuePerSecond.CompareTo(b._ValuePerSecond) < 0
    End Operator
    Public Shared Operator >(a As PerTime(Of T), b As PerTime(Of T)) As Boolean
        Return a._ValuePerSecond.CompareTo(b._ValuePerSecond) > 0
    End Operator
    Public Shared Operator <=(a As PerTime(Of T), b As PerTime(Of T)) As Boolean
        Return a._ValuePerSecond.CompareTo(b._ValuePerSecond) <= 0
    End Operator
    Public Shared Operator >=(a As PerTime(Of T), b As PerTime(Of T)) As Boolean
        Return a._ValuePerSecond.CompareTo(b._ValuePerSecond) >= 0
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As PerTime(Of T)) As PerTime(Of T)
        Return a
    End Operator
    Public Shared Operator +(a As PerTime(Of T)?) As PerTime(Of T)?
        Return a
    End Operator
    Public Shared Operator -(a As PerTime(Of T)) As PerTime(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(-a._ValuePerSecond.GetValue(unit), unit), PerTime(Of T))
    End Operator
    Public Shared Operator -(a As PerTime(Of T)?) As PerTime(Of T)?
        If a.HasValue Then
            Dim aa = a.Value
            Dim unit = aa.DefaultUnit
            Return CType(aa.Create(-aa._ValuePerSecond.GetValue(unit), unit), PerTime(Of T))
        Else
            Return Nothing
        End If
    End Operator

    Public Shared Operator +(a As PerTime(Of T), b As PerTime(Of T)) As PerTime(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValuePerSecond.GetValue(unit) + b._ValuePerSecond.GetValue(unit), unit), PerTime(Of T))
    End Operator

    Public Shared Operator -(a As PerTime(Of T), b As PerTime(Of T)) As PerTime(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValuePerSecond.GetValue(unit) - b._ValuePerSecond.GetValue(unit), unit), PerTime(Of T))
    End Operator

    Public Shared Operator *(a As PerTime(Of T), b As Double) As PerTime(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValuePerSecond.GetValue(unit) * b, unit), PerTime(Of T))
    End Operator
    Public Shared Operator *(a As Double, b As PerTime(Of T)) As PerTime(Of T)
        Return b * a
    End Operator

    Public Shared Operator *(a As PerTime(Of T), b As TimeSpan) As T
        Return a.ValuePerTime(b)
    End Operator
    Public Shared Operator *(a As TimeSpan, b As PerTime(Of T)) As T
        Return b.ValuePerTime(a)
    End Operator


    Public Shared Operator /(a As PerTime(Of T), b As Double) As PerTime(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValuePerSecond.GetValue(unit) / b, unit), PerTime(Of T))
    End Operator

    Public Shared Operator /(a As PerTime(Of T), b As PerTime(Of T)) As Double
        Dim unit = a.DefaultUnit
        Return a._ValuePerSecond.GetValue(unit) / b._ValuePerSecond.GetValue(unit)
    End Operator

#End Region

End Structure