Option Strict On
Option Infer On

Partial Structure OneOver(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

#Region "Equality, Comparison"

    Public Shared Operator =(a As OneOver(Of T), b As OneOver(Of T)) As Boolean
        Return a._OneOverValue.Equals(b._OneOverValue)
    End Operator
    Public Shared Operator <>(a As OneOver(Of T), b As OneOver(Of T)) As Boolean
        Return Not a._OneOverValue.Equals(b._OneOverValue)
    End Operator
    Public Shared Operator <(a As OneOver(Of T), b As OneOver(Of T)) As Boolean
        Return a._OneOverValue.CompareTo(b._OneOverValue) < 0
    End Operator
    Public Shared Operator >(a As OneOver(Of T), b As OneOver(Of T)) As Boolean
        Return a._OneOverValue.CompareTo(b._OneOverValue) > 0
    End Operator
    Public Shared Operator <=(a As OneOver(Of T), b As OneOver(Of T)) As Boolean
        Return a._OneOverValue.CompareTo(b._OneOverValue) <= 0
    End Operator
    Public Shared Operator >=(a As OneOver(Of T), b As OneOver(Of T)) As Boolean
        Return a._OneOverValue.CompareTo(b._OneOverValue) >= 0
    End Operator

#End Region

#Region "Arithmetics"


    Public Shared Operator +(a As OneOver(Of T), b As OneOver(Of T)) As OneOver(Of T)
        Dim unit = a.DefaultUnit
        Dim va = a._OneOverValue.GetValue(unit)
        Dim vb = b._OneOverValue.GetValue(unit)
        Return CType(a.Create(va * vb / (va + vb), unit), OneOver(Of T))
    End Operator

    Public Shared Operator -(a As OneOver(Of T), b As OneOver(Of T)) As OneOver(Of T)
        Dim unit = a.DefaultUnit
        Dim va = a._OneOverValue.GetValue(unit)
        Dim vb = b._OneOverValue.GetValue(unit)
        Return CType(a.Create(va * vb / (vb - va), unit), OneOver(Of T))
    End Operator

    Public Shared Operator +(a As OneOver(Of T)) As OneOver(Of T)
        Return a
    End Operator
    Public Shared Operator +(a As OneOver(Of T)?) As OneOver(Of T)?
        Return a
    End Operator
    Public Shared Operator -(a As OneOver(Of T)) As OneOver(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(-a._OneOverValue.GetValue(unit), unit), OneOver(Of T))
    End Operator
    Public Shared Operator -(a As OneOver(Of T)?) As OneOver(Of T)?
        If a.HasValue Then
            Dim aa = a.Value
            Dim unit = aa.DefaultUnit
            Return CType(aa.Create(-aa._OneOverValue.GetValue(unit), unit), OneOver(Of T))
        Else
            Return Nothing
        End If
    End Operator

    Public Shared Operator *(a As OneOver(Of T), b As Double) As OneOver(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._OneOverValue.GetValue(unit) / b, unit), OneOver(Of T))
    End Operator
    Public Shared Operator *(a As Double, b As OneOver(Of T)) As OneOver(Of T)
        Return b * a
    End Operator

    Public Shared Operator /(a As OneOver(Of T), b As Double) As OneOver(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._OneOverValue.GetValue(unit) * b, unit), OneOver(Of T))
    End Operator

    Public Shared Operator /(a As Double, b As OneOver(Of T)) As T
        Dim unit = b.DefaultUnit
        Return CType(b._OneOverValue.Create(b._OneOverValue.GetValue(unit) * a, unit), T)
    End Operator

    Public Shared Operator /(a As OneOver(Of T), b As OneOver(Of T)) As Double
        Dim unit = a.DefaultUnit
        Dim va = a._OneOverValue.GetValue(unit)
        Dim vb = b._OneOverValue.GetValue(unit)
        Return vb / va
    End Operator

#End Region

End Structure