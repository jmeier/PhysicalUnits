Option Strict On
Option Infer On

Partial Structure TimesVolume(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})
    Implements IEquatable(Of TimesVolume(Of T)), IComparable(Of TimesVolume(Of T))

    Public Overrides Function GetHashCode() As Integer
        Return _ValueTimesCubicMeter.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is TimesVolume(Of T) Then
            Return DirectCast(obj, TimesVolume(Of T))._ValueTimesCubicMeter.Equals(Me._ValueTimesCubicMeter)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As TimesVolume(Of T)) As Boolean Implements System.IEquatable(Of TimesVolume(Of T)).Equals
        Return other._ValueTimesCubicMeter.Equals(Me._ValueTimesCubicMeter)
    End Function

    Public Function CompareTo(other As TimesVolume(Of T)) As Integer Implements System.IComparable(Of TimesVolume(Of T)).CompareTo
        Return Me._ValueTimesCubicMeter.CompareTo(other._ValueTimesCubicMeter)
    End Function

End Structure