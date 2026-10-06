Option Strict On
Option Infer On

Partial Structure PerLength(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

#Region "Equality, Comparison"

    Public Shared Operator =(a As PerLength(Of T), b As PerLength(Of T)) As Boolean
        Return a._ValuePerRunningMeter.Equals(b._ValuePerRunningMeter)
    End Operator
    Public Shared Operator <>(a As PerLength(Of T), b As PerLength(Of T)) As Boolean
        Return Not a._ValuePerRunningMeter.Equals(b._ValuePerRunningMeter)
    End Operator
    Public Shared Operator <(a As PerLength(Of T), b As PerLength(Of T)) As Boolean
        Return a._ValuePerRunningMeter.CompareTo(b._ValuePerRunningMeter) < 0
    End Operator
    Public Shared Operator >(a As PerLength(Of T), b As PerLength(Of T)) As Boolean
        Return a._ValuePerRunningMeter.CompareTo(b._ValuePerRunningMeter) > 0
    End Operator
    Public Shared Operator <=(a As PerLength(Of T), b As PerLength(Of T)) As Boolean
        Return a._ValuePerRunningMeter.CompareTo(b._ValuePerRunningMeter) <= 0
    End Operator
    Public Shared Operator >=(a As PerLength(Of T), b As PerLength(Of T)) As Boolean
        Return a._ValuePerRunningMeter.CompareTo(b._ValuePerRunningMeter) >= 0
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As PerLength(Of T)) As PerLength(Of T)
        Return a
    End Operator
    Public Shared Operator +(a As PerLength(Of T)?) As PerLength(Of T)?
        Return a
    End Operator
    Public Shared Operator -(a As PerLength(Of T)) As PerLength(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(-a._ValuePerRunningMeter.GetValue(unit), unit), PerLength(Of T))
    End Operator
    Public Shared Operator -(a As PerLength(Of T)?) As PerLength(Of T)?
        If a.HasValue Then
            Dim aa = a.Value
            Dim unit = aa.DefaultUnit
            Return CType(aa.Create(-aa._ValuePerRunningMeter.GetValue(unit), unit), PerLength(Of T))
        Else
            Return Nothing
        End If
    End Operator

    Public Shared Operator +(a As PerLength(Of T), b As PerLength(Of T)) As PerLength(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValuePerRunningMeter.GetValue(unit) + b._ValuePerRunningMeter.GetValue(unit), unit), PerLength(Of T))
    End Operator

    Public Shared Operator -(a As PerLength(Of T), b As PerLength(Of T)) As PerLength(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValuePerRunningMeter.GetValue(unit) - b._ValuePerRunningMeter.GetValue(unit), unit), PerLength(Of T))
    End Operator

    Public Shared Operator *(a As PerLength(Of T), b As Double) As PerLength(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValuePerRunningMeter.GetValue(unit) * b, unit), PerLength(Of T))
    End Operator
    Public Shared Operator *(a As Double, b As PerLength(Of T)) As PerLength(Of T)
        Return b * a
    End Operator

    Public Shared Operator *(a As PerLength(Of T), b As Length) As T
        Return a.ValuePerRunningLength(b)
    End Operator
    Public Shared Operator *(a As Length, b As PerLength(Of T)) As T
        Return b.ValuePerRunningLength(a)
    End Operator


    Public Shared Operator /(a As PerLength(Of T), b As Double) As PerLength(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValuePerRunningMeter.GetValue(unit) / b, unit), PerLength(Of T))
    End Operator

    Public Shared Operator /(a As PerLength(Of T), b As PerLength(Of T)) As Double
        Dim unit = a.DefaultUnit
        Return a._ValuePerRunningMeter.GetValue(unit) / b._ValuePerRunningMeter.GetValue(unit)
    End Operator

#End Region

End Structure