Option Strict On
Option Infer On

Partial Structure TimesArea(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

#Region "Equality, Comparison"

    Public Shared Operator =(a As TimesArea(Of T), b As TimesArea(Of T)) As Boolean
        Return a._ValueTimesSquareMeter.Equals(b._ValueTimesSquareMeter)
    End Operator
    Public Shared Operator <>(a As TimesArea(Of T), b As TimesArea(Of T)) As Boolean
        Return Not a._ValueTimesSquareMeter.Equals(b._ValueTimesSquareMeter)
    End Operator
    Public Shared Operator <(a As TimesArea(Of T), b As TimesArea(Of T)) As Boolean
        Return a._ValueTimesSquareMeter.CompareTo(b._ValueTimesSquareMeter) < 0
    End Operator
    Public Shared Operator >(a As TimesArea(Of T), b As TimesArea(Of T)) As Boolean
        Return a._ValueTimesSquareMeter.CompareTo(b._ValueTimesSquareMeter) > 0
    End Operator
    Public Shared Operator <=(a As TimesArea(Of T), b As TimesArea(Of T)) As Boolean
        Return a._ValueTimesSquareMeter.CompareTo(b._ValueTimesSquareMeter) <= 0
    End Operator
    Public Shared Operator >=(a As TimesArea(Of T), b As TimesArea(Of T)) As Boolean
        Return a._ValueTimesSquareMeter.CompareTo(b._ValueTimesSquareMeter) >= 0
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As TimesArea(Of T)) As TimesArea(Of T)
        Return a
    End Operator
    Public Shared Operator +(a As TimesArea(Of T)?) As TimesArea(Of T)?
        Return a
    End Operator
    Public Shared Operator -(a As TimesArea(Of T)) As TimesArea(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(-a._ValueTimesSquareMeter.GetValue(unit), unit), TimesArea(Of T))
    End Operator
    Public Shared Operator -(a As TimesArea(Of T)?) As TimesArea(Of T)?
        If a.HasValue Then
            Dim aa = a.Value
            Dim unit = aa.DefaultUnit
            Return CType(aa.Create(-aa._ValueTimesSquareMeter.GetValue(unit), unit), TimesArea(Of T))
        Else
            Return Nothing
        End If
    End Operator

    Public Shared Operator +(a As TimesArea(Of T), b As TimesArea(Of T)) As TimesArea(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValueTimesSquareMeter.GetValue(unit) + b._ValueTimesSquareMeter.GetValue(unit), unit), TimesArea(Of T))
    End Operator

    Public Shared Operator -(a As TimesArea(Of T), b As TimesArea(Of T)) As TimesArea(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValueTimesSquareMeter.GetValue(unit) - b._ValueTimesSquareMeter.GetValue(unit), unit), TimesArea(Of T))
    End Operator

    Public Shared Operator *(a As TimesArea(Of T), b As Double) As TimesArea(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValueTimesSquareMeter.GetValue(unit) * b, unit), TimesArea(Of T))
    End Operator
    Public Shared Operator *(a As Double, b As TimesArea(Of T)) As TimesArea(Of T)
        Return b * a
    End Operator

    Public Shared Operator /(a As TimesArea(Of T), b As Double) As TimesArea(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValueTimesSquareMeter.GetValue(unit) / b, unit), TimesArea(Of T))
    End Operator

    Public Shared Operator /(a As TimesArea(Of T), b As TimesArea(Of T)) As Double
        Dim unit = a.DefaultUnit
        Return a._ValueTimesSquareMeter.GetValue(unit) / b._ValueTimesSquareMeter.GetValue(unit)
    End Operator

    Public Shared Operator /(a As TimesArea(Of T), b As Area) As T
        Return a.ValueTimesArea(b)
    End Operator
    Public Shared Operator /(a As Area, b As TimesArea(Of T)) As OneOver(Of T)
        Return b.ValueTimesArea(a).OneOver
    End Operator

    Public Shared Operator /(a As TimesArea(Of T), b As PerArea(Of T)) As LengthPow4
        Dim unit = a.DefaultUnit
        Dim va = a.ValueTimesSquareMeter.GetValue(unit)
        Dim vb = b.ValuePerSquaremeter.GetValue(unit)
        Return MetersPow4(va * vb)
    End Operator

    Public Shared Operator /(a As TimesArea(Of T), b As T) As Area
        Dim unit = b.DefaultUnit
        Return Squaremeters(a._ValueTimesSquareMeter.GetValue(unit) / b.GetValue(unit))
    End Operator

#End Region

End Structure