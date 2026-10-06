Option Strict On
Option Infer On

Partial Structure PerVolume(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

#Region "Equality, Comparison"

    Public Shared Operator =(a As PerVolume(Of T), b As PerVolume(Of T)) As Boolean
        Return a._ValuePerCubicemeter.Equals(b._ValuePerCubicemeter)
    End Operator
    Public Shared Operator <>(a As PerVolume(Of T), b As PerVolume(Of T)) As Boolean
        Return Not a._ValuePerCubicemeter.Equals(b._ValuePerCubicemeter)
    End Operator
    Public Shared Operator <(a As PerVolume(Of T), b As PerVolume(Of T)) As Boolean
        Return a._ValuePerCubicemeter.CompareTo(b._ValuePerCubicemeter) < 0
    End Operator
    Public Shared Operator >(a As PerVolume(Of T), b As PerVolume(Of T)) As Boolean
        Return a._ValuePerCubicemeter.CompareTo(b._ValuePerCubicemeter) > 0
    End Operator
    Public Shared Operator <=(a As PerVolume(Of T), b As PerVolume(Of T)) As Boolean
        Return a._ValuePerCubicemeter.CompareTo(b._ValuePerCubicemeter) <= 0
    End Operator
    Public Shared Operator >=(a As PerVolume(Of T), b As PerVolume(Of T)) As Boolean
        Return a._ValuePerCubicemeter.CompareTo(b._ValuePerCubicemeter) >= 0
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As PerVolume(Of T)) As PerVolume(Of T)
        Return a
    End Operator
    Public Shared Operator +(a As PerVolume(Of T)?) As PerVolume(Of T)?
        Return a
    End Operator
    Public Shared Operator -(a As PerVolume(Of T)) As PerVolume(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(-a._ValuePerCubicemeter.GetValue(unit), unit), PerVolume(Of T))
    End Operator
    Public Shared Operator -(a As PerVolume(Of T)?) As PerVolume(Of T)?
        If a.HasValue Then
            Dim aa = a.Value
            Dim unit = aa.DefaultUnit
            Return CType(aa.Create(-aa._ValuePerCubicemeter.GetValue(unit), unit), PerVolume(Of T))
        Else
            Return Nothing
        End If
    End Operator

    Public Shared Operator +(a As PerVolume(Of T), b As PerVolume(Of T)) As PerVolume(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValuePerCubicemeter.GetValue(unit) + b._ValuePerCubicemeter.GetValue(unit), unit), PerVolume(Of T))
    End Operator

    Public Shared Operator -(a As PerVolume(Of T), b As PerVolume(Of T)) As PerVolume(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValuePerCubicemeter.GetValue(unit) - b._ValuePerCubicemeter.GetValue(unit), unit), PerVolume(Of T))
    End Operator

    Public Shared Operator *(a As PerVolume(Of T), b As Double) As PerVolume(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValuePerCubicemeter.GetValue(unit) * b, unit), PerVolume(Of T))
    End Operator
    Public Shared Operator *(a As Double, b As PerVolume(Of T)) As PerVolume(Of T)
        Return b * a
    End Operator

    Public Shared Operator *(a As PerVolume(Of T), b As Length) As PerArea(Of T)
        Return New PerArea(Of T)((a * b.Meters).ValuePerCubicmeter)
    End Operator
    Public Shared Operator *(a As Length, b As PerVolume(Of T)) As PerArea(Of T)
        Return New PerArea(Of T)((a.Meters * b).ValuePerCubicmeter)
    End Operator

    Public Shared Operator *(a As PerVolume(Of T), b As Area) As PerLength(Of T)
        Return New PerLength(Of T)((a * b.SquareMeters).ValuePerCubicmeter)
    End Operator
    Public Shared Operator *(a As Area, b As PerVolume(Of T)) As PerLength(Of T)
        Return New PerLength(Of T)((a.SquareMeters * b).ValuePerCubicmeter)
    End Operator

    Public Shared Operator *(a As PerVolume(Of T), b As Volume) As T
        Return a.ValuePerVolume(b)
    End Operator
    Public Shared Operator *(a As Volume, b As PerVolume(Of T)) As T
        Return b.ValuePerVolume(a)
    End Operator


    Public Shared Operator /(a As PerVolume(Of T), b As Double) As PerVolume(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValuePerCubicemeter.GetValue(unit) / b, unit), PerVolume(Of T))
    End Operator

    Public Shared Operator /(a As PerVolume(Of T), b As PerVolume(Of T)) As Double
        Dim unit = a.DefaultUnit
        Return a._ValuePerCubicemeter.GetValue(unit) / b._ValuePerCubicemeter.GetValue(unit)
    End Operator

#End Region

End Structure