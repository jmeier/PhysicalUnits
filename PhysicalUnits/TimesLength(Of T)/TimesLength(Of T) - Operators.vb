Option Strict On
Option Infer On

Partial Structure TimesLength(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

#Region "Equality, Comparison"

    Public Shared Operator =(a As TimesLength(Of T), b As TimesLength(Of T)) As Boolean
        Return a._ValueTimesMeter.Equals(b._ValueTimesMeter)
    End Operator
    Public Shared Operator <>(a As TimesLength(Of T), b As TimesLength(Of T)) As Boolean
        Return Not a._ValueTimesMeter.Equals(b._ValueTimesMeter)
    End Operator
    Public Shared Operator <(a As TimesLength(Of T), b As TimesLength(Of T)) As Boolean
        Return a._ValueTimesMeter.CompareTo(b._ValueTimesMeter) < 0
    End Operator
    Public Shared Operator >(a As TimesLength(Of T), b As TimesLength(Of T)) As Boolean
        Return a._ValueTimesMeter.CompareTo(b._ValueTimesMeter) > 0
    End Operator
    Public Shared Operator <=(a As TimesLength(Of T), b As TimesLength(Of T)) As Boolean
        Return a._ValueTimesMeter.CompareTo(b._ValueTimesMeter) <= 0
    End Operator
    Public Shared Operator >=(a As TimesLength(Of T), b As TimesLength(Of T)) As Boolean
        Return a._ValueTimesMeter.CompareTo(b._ValueTimesMeter) >= 0
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As TimesLength(Of T)) As TimesLength(Of T)
        Return a
    End Operator
    Public Shared Operator +(a As TimesLength(Of T)?) As TimesLength(Of T)?
        Return a
    End Operator
    Public Shared Operator -(a As TimesLength(Of T)) As TimesLength(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(-a._ValueTimesMeter.GetValue(unit), unit), TimesLength(Of T))
    End Operator
    Public Shared Operator -(a As TimesLength(Of T)?) As TimesLength(Of T)?
        If a.HasValue Then
            Dim aa = a.Value
            Dim unit = aa.DefaultUnit
            Return CType(aa.Create(-aa._ValueTimesMeter.GetValue(unit), unit), TimesLength(Of T))
        Else
            Return Nothing
        End If
    End Operator

    Public Shared Operator +(a As TimesLength(Of T), b As TimesLength(Of T)) As TimesLength(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValueTimesMeter.GetValue(unit) + b._ValueTimesMeter.GetValue(unit), unit), TimesLength(Of T))
    End Operator

    Public Shared Operator -(a As TimesLength(Of T), b As TimesLength(Of T)) As TimesLength(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValueTimesMeter.GetValue(unit) - b._ValueTimesMeter.GetValue(unit), unit), TimesLength(Of T))
    End Operator

    Public Shared Operator *(a As TimesLength(Of T), b As Double) As TimesLength(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValueTimesMeter.GetValue(unit) * b, unit), TimesLength(Of T))
    End Operator
    Public Shared Operator *(a As Double, b As TimesLength(Of T)) As TimesLength(Of T)
        Return b * a
    End Operator

    Public Shared Operator /(a As TimesLength(Of T), b As Double) As TimesLength(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValueTimesMeter.GetValue(unit) / b, unit), TimesLength(Of T))
    End Operator

    Public Shared Operator /(a As TimesLength(Of T), b As TimesLength(Of T)) As Double
        Dim unit = a.DefaultUnit
        Return a._ValueTimesMeter.GetValue(unit) / b._ValueTimesMeter.GetValue(unit)
    End Operator

    Public Shared Operator /(a As TimesLength(Of T), b As Length) As T
        Return a.ValueTimesLength(b)
    End Operator
    Public Shared Operator /(a As Length, b As TimesLength(Of T)) As OneOver(Of T)
        Return b.ValueTimesLength(a).OneOver
    End Operator

    Public Shared Operator /(a As TimesLength(Of T), b As PerLength(Of T)) As Area
        Dim unit = a.DefaultUnit
        Dim va = a.ValueTimesMeter.GetValue(unit)
        Dim vb = b.ValuePerRunningMeter.GetValue(unit)
        Return Squaremeters(va * vb)
    End Operator

    Public Shared Operator /(a As TimesLength(Of T), b As T) As Length
        Dim unit = a.DefaultUnit
        Return Meters(a._ValueTimesMeter.GetValue(unit) / b.GetValue(unit))
    End Operator

#End Region

End Structure