Option Strict On
Option Infer On

Partial Structure TimesVolume(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

#Region "Equality, Comparison"

    Public Shared Operator =(a As TimesVolume(Of T), b As TimesVolume(Of T)) As Boolean
        Return a._ValueTimesCubicMeter.Equals(b._ValueTimesCubicMeter)
    End Operator
    Public Shared Operator <>(a As TimesVolume(Of T), b As TimesVolume(Of T)) As Boolean
        Return Not a._ValueTimesCubicMeter.Equals(b._ValueTimesCubicMeter)
    End Operator
    Public Shared Operator <(a As TimesVolume(Of T), b As TimesVolume(Of T)) As Boolean
        Return a._ValueTimesCubicMeter.CompareTo(b._ValueTimesCubicMeter) < 0
    End Operator
    Public Shared Operator >(a As TimesVolume(Of T), b As TimesVolume(Of T)) As Boolean
        Return a._ValueTimesCubicMeter.CompareTo(b._ValueTimesCubicMeter) > 0
    End Operator
    Public Shared Operator <=(a As TimesVolume(Of T), b As TimesVolume(Of T)) As Boolean
        Return a._ValueTimesCubicMeter.CompareTo(b._ValueTimesCubicMeter) <= 0
    End Operator
    Public Shared Operator >=(a As TimesVolume(Of T), b As TimesVolume(Of T)) As Boolean
        Return a._ValueTimesCubicMeter.CompareTo(b._ValueTimesCubicMeter) >= 0
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As TimesVolume(Of T)) As TimesVolume(Of T)
        Return a
    End Operator
    Public Shared Operator +(a As TimesVolume(Of T)?) As TimesVolume(Of T)?
        Return a
    End Operator
    Public Shared Operator -(a As TimesVolume(Of T)) As TimesVolume(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(-a._ValueTimesCubicMeter.GetValue(unit), unit), TimesVolume(Of T))
    End Operator
    Public Shared Operator -(a As TimesVolume(Of T)?) As TimesVolume(Of T)?
        If a.HasValue Then
            Dim aa = a.Value
            Dim unit = aa.DefaultUnit
            Return CType(aa.Create(-aa._ValueTimesCubicMeter.GetValue(unit), unit), TimesVolume(Of T))
        Else
            Return Nothing
        End If
    End Operator

    Public Shared Operator +(a As TimesVolume(Of T), b As TimesVolume(Of T)) As TimesVolume(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValueTimesCubicMeter.GetValue(unit) + b._ValueTimesCubicMeter.GetValue(unit), unit), TimesVolume(Of T))
    End Operator

    Public Shared Operator -(a As TimesVolume(Of T), b As TimesVolume(Of T)) As TimesVolume(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValueTimesCubicMeter.GetValue(unit) - b._ValueTimesCubicMeter.GetValue(unit), unit), TimesVolume(Of T))
    End Operator

    Public Shared Operator *(a As TimesVolume(Of T), b As Double) As TimesVolume(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValueTimesCubicMeter.GetValue(unit) * b, unit), TimesVolume(Of T))
    End Operator
    Public Shared Operator *(a As Double, b As TimesVolume(Of T)) As TimesVolume(Of T)
        Return b * a
    End Operator

    Public Shared Operator /(a As TimesVolume(Of T), b As Double) As TimesVolume(Of T)
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a._ValueTimesCubicMeter.GetValue(unit) / b, unit), TimesVolume(Of T))
    End Operator

    Public Shared Operator /(a As TimesVolume(Of T), b As TimesVolume(Of T)) As Double
        Dim unit = a.DefaultUnit
        Return a._ValueTimesCubicMeter.GetValue(unit) / b._ValueTimesCubicMeter.GetValue(unit)
    End Operator

    Public Shared Operator /(a As TimesVolume(Of T), b As Volume) As T
        Return a.ValueTimesVolume(b)
    End Operator
    Public Shared Operator /(a As Volume, b As TimesVolume(Of T)) As OneOver(Of T)
        Return b.ValueTimesVolume(a).OneOver
    End Operator

    'Public Shared Operator /(a As TimesVolume(Of T), b As PerVolume(Of T)) As LengthPow6
    '    Dim unit = a.DefaultUnit
    '    Dim va = a.ValueTimesCubicMeter.GetValue(unit)
    '    Dim vb = b.ValuePerCubicmeter.GetValue(unit)
    '    Return MetersPow6(va * vb)
    'End Operator

    Public Shared Operator /(a As TimesVolume(Of T), b As T) As Volume
        Dim unit = b.DefaultUnit
        Return Cubicmeters(a._ValueTimesCubicMeter.GetValue(unit) / b.GetValue(unit))
    End Operator

#End Region

End Structure