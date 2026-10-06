Option Strict On
Option Infer On

Partial Structure PerArea(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

#Region "Equality, Comparison"

    Public Shared Operator =(a As PerArea(Of T), b As PerArea(Of T)) As Boolean
        Return a._ValuePerSquaremeter.Equals(b._ValuePerSquaremeter)
    End Operator
    Public Shared Operator <>(a As PerArea(Of T), b As PerArea(Of T)) As Boolean
        Return Not a._ValuePerSquaremeter.Equals(b._ValuePerSquaremeter)
    End Operator
    Public Shared Operator <(a As PerArea(Of T), b As PerArea(Of T)) As Boolean
        Return a._ValuePerSquaremeter.CompareTo(b._ValuePerSquaremeter) < 0
    End Operator
    Public Shared Operator >(a As PerArea(Of T), b As PerArea(Of T)) As Boolean
        Return a._ValuePerSquaremeter.CompareTo(b._ValuePerSquaremeter) > 0
    End Operator
    Public Shared Operator <=(a As PerArea(Of T), b As PerArea(Of T)) As Boolean
        Return a._ValuePerSquaremeter.CompareTo(b._ValuePerSquaremeter) <= 0
    End Operator
    Public Shared Operator >=(a As PerArea(Of T), b As PerArea(Of T)) As Boolean
        Return a._ValuePerSquaremeter.CompareTo(b._ValuePerSquaremeter) >= 0
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As PerArea(Of T)) As PerArea(Of T)
        Return a
    End Operator
    Public Shared Operator +(a As PerArea(Of T)?) As PerArea(Of T)?
        Return a
    End Operator
    Public Shared Operator -(a As PerArea(Of T)) As PerArea(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(-a._ValuePerSquaremeter.GetValue(unit), unit), PerArea(Of T))
    End Operator
    Public Shared Operator -(a As PerArea(Of T)?) As PerArea(Of T)?
        If a.HasValue Then
            Dim aa = a.Value
            Dim unit = aa.DefaultUnit
            Return CType(aa.Create(-aa._ValuePerSquaremeter.GetValue(unit), unit), PerArea(Of T))
        Else
            Return Nothing
        End If
    End Operator

    Public Shared Operator +(a As PerArea(Of T), b As PerArea(Of T)) As PerArea(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValuePerSquaremeter.GetValue(unit) + b._ValuePerSquaremeter.GetValue(unit), unit), PerArea(Of T))
    End Operator

    Public Shared Operator -(a As PerArea(Of T), b As PerArea(Of T)) As PerArea(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValuePerSquaremeter.GetValue(unit) - b._ValuePerSquaremeter.GetValue(unit), unit), PerArea(Of T))
    End Operator

    Public Shared Operator *(a As PerArea(Of T), b As Double) As PerArea(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValuePerSquaremeter.GetValue(unit) * b, unit), PerArea(Of T))
    End Operator
    Public Shared Operator *(a As Double, b As PerArea(Of T)) As PerArea(Of T)
        Return b * a
    End Operator

    Public Shared Operator *(a As PerArea(Of T), b As Length) As PerLength(Of T)
        Return New PerLength(Of T)((a * b.Meters).ValuePerSquaremeter)
    End Operator
    Public Shared Operator *(a As Length, b As PerArea(Of T)) As PerLength(Of T)
        Return New PerLength(Of T)((a.Meters * b).ValuePerSquaremeter)
    End Operator

    Public Shared Operator *(a As PerArea(Of T), b As Area) As T
        Return a.ValuePerArea(b)
    End Operator
    Public Shared Operator *(a As Area, b As PerArea(Of T)) As T
        Return b.ValuePerArea(a)
    End Operator


    Public Shared Operator /(a As PerArea(Of T), b As Double) As PerArea(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValuePerSquaremeter.GetValue(unit) / b, unit), PerArea(Of T))
    End Operator

    Public Shared Operator /(a As PerArea(Of T), b As PerArea(Of T)) As Double
        Dim unit = a.DefaultUnit
        Return a._ValuePerSquaremeter.GetValue(unit) / b._ValuePerSquaremeter.GetValue(unit)
    End Operator

#End Region

End Structure