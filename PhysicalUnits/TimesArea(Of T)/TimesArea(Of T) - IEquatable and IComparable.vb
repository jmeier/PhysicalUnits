Option Strict On
Option Infer On

Partial Structure TimesArea(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})
    Implements IEquatable(Of TimesArea(Of T)), IComparable(Of TimesArea(Of T))

    Public Overrides Function GetHashCode() As Integer
        Return _ValueTimesSquareMeter.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is TimesArea(Of T) Then
            Return DirectCast(obj, TimesArea(Of T))._ValueTimesSquareMeter.Equals(Me._ValueTimesSquareMeter)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As TimesArea(Of T)) As Boolean Implements System.IEquatable(Of TimesArea(Of T)).Equals
        Return other._ValueTimesSquareMeter.Equals(Me._ValueTimesSquareMeter)
    End Function

    Public Function CompareTo(other As TimesArea(Of T)) As Integer Implements System.IComparable(Of TimesArea(Of T)).CompareTo
        Return Me._ValueTimesSquareMeter.CompareTo(other._ValueTimesSquareMeter)
    End Function

End Structure