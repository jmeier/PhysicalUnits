Option Strict On
Option Infer On

Partial Structure TimesTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

#Region "Equality, Comparison"

    Public Shared Operator =(a As TimesTime(Of T), b As TimesTime(Of T)) As Boolean
        Return a._ValueTimesSecond.Equals(b._ValueTimesSecond)
    End Operator
    Public Shared Operator <>(a As TimesTime(Of T), b As TimesTime(Of T)) As Boolean
        Return Not a._ValueTimesSecond.Equals(b._ValueTimesSecond)
    End Operator
    Public Shared Operator <(a As TimesTime(Of T), b As TimesTime(Of T)) As Boolean
        Return a._ValueTimesSecond.CompareTo(b._ValueTimesSecond) < 0
    End Operator
    Public Shared Operator >(a As TimesTime(Of T), b As TimesTime(Of T)) As Boolean
        Return a._ValueTimesSecond.CompareTo(b._ValueTimesSecond) > 0
    End Operator
    Public Shared Operator <=(a As TimesTime(Of T), b As TimesTime(Of T)) As Boolean
        Return a._ValueTimesSecond.CompareTo(b._ValueTimesSecond) <= 0
    End Operator
    Public Shared Operator >=(a As TimesTime(Of T), b As TimesTime(Of T)) As Boolean
        Return a._ValueTimesSecond.CompareTo(b._ValueTimesSecond) >= 0
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As TimesTime(Of T)) As TimesTime(Of T)
        Return a
    End Operator
    Public Shared Operator +(a As TimesTime(Of T)?) As TimesTime(Of T)?
        Return a
    End Operator
    Public Shared Operator -(a As TimesTime(Of T)) As TimesTime(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(-a._ValueTimesSecond.GetValue(unit), unit), TimesTime(Of T))
    End Operator
    Public Shared Operator -(a As TimesTime(Of T)?) As TimesTime(Of T)?
        If a.HasValue Then
            Dim aa = a.Value
            Dim unit = aa.DefaultUnit
            Return CType(aa.Create(-aa._ValueTimesSecond.GetValue(unit), unit), TimesTime(Of T))
        Else
            Return Nothing
        End If
    End Operator

    Public Shared Operator +(a As TimesTime(Of T), b As TimesTime(Of T)) As TimesTime(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValueTimesSecond.GetValue(unit) + b._ValueTimesSecond.GetValue(unit), unit), TimesTime(Of T))
    End Operator

    Public Shared Operator -(a As TimesTime(Of T), b As TimesTime(Of T)) As TimesTime(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValueTimesSecond.GetValue(unit) - b._ValueTimesSecond.GetValue(unit), unit), TimesTime(Of T))
    End Operator

    Public Shared Operator *(a As TimesTime(Of T), b As Double) As TimesTime(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValueTimesSecond.GetValue(unit) * b, unit), TimesTime(Of T))
    End Operator
    Public Shared Operator *(a As Double, b As TimesTime(Of T)) As TimesTime(Of T)
        Return b * a
    End Operator

    Public Shared Operator /(a As TimesTime(Of T), b As Double) As TimesTime(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValueTimesSecond.GetValue(unit) / b, unit), TimesTime(Of T))
    End Operator

    Public Shared Operator /(a As TimesTime(Of T), b As TimesTime(Of T)) As Double
        Dim unit = a.DefaultUnit
        Return a._ValueTimesSecond.GetValue(unit) / b._ValueTimesSecond.GetValue(unit)
    End Operator

    Public Shared Operator /(a As TimesTime(Of T), b As TimeSpan) As T
        Return a.ValueTimesTime(b)
    End Operator
    Public Shared Operator /(a As TimeSpan, b As TimesTime(Of T)) As OneOver(Of T)
        Return b.ValueTimesTime(a).OneOver
    End Operator

    'Public Shared Operator /(a As TimesTime(Of T), b As PerTime(Of T)) As LengthPow6
    '    Dim unit = a.DefaultUnit
    '    Dim va = a.ValueTimesCubicMeter.GetValue(unit)
    '    Dim vb = b.ValuePerCubicmeter.GetValue(unit)
    '    Return MetersPow6(va * vb)
    'End Operator

    Public Shared Operator /(a As TimesTime(Of T), b As T) As TimeSpan
        Dim unit = b.DefaultUnit
        Return TimeSpan.FromSeconds(a._ValueTimesSecond.GetValue(unit) / b.GetValue(unit))
    End Operator

#End Region

End Structure