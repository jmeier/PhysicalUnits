Option Strict On
Option Infer On

Partial Structure TimesTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})
    Implements IEquatable(Of TimesTime(Of T)), IComparable(Of TimesTime(Of T))

    Public Overrides Function GetHashCode() As Integer
        Return _ValueTimesSecond.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is TimesTime(Of T) Then
            Return DirectCast(obj, TimesTime(Of T))._ValueTimesSecond.Equals(Me._ValueTimesSecond)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As TimesTime(Of T)) As Boolean Implements System.IEquatable(Of TimesTime(Of T)).Equals
        Return other._ValueTimesSecond.Equals(Me._ValueTimesSecond)
    End Function

    Public Function CompareTo(other As TimesTime(Of T)) As Integer Implements System.IComparable(Of TimesTime(Of T)).CompareTo
        Return Me._ValueTimesSecond.CompareTo(other._ValueTimesSecond)
    End Function

End Structure