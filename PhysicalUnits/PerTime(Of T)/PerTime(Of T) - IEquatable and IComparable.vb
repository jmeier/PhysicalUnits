Option Strict On
Option Infer On

Partial Structure PerTime(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})
    Implements IEquatable(Of PerTime(Of T)), IComparable(Of PerTime(Of T))

    Public Overrides Function GetHashCode() As Integer
        Return _ValuePerSecond.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is PerTime(Of T) Then
            Return DirectCast(obj, PerTime(Of T))._ValuePerSecond.Equals(Me._ValuePerSecond)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As PerTime(Of T)) As Boolean Implements System.IEquatable(Of PerTime(Of T)).Equals
        Return other._ValuePerSecond.Equals(Me._ValuePerSecond)
    End Function

    Public Function CompareTo(other As PerTime(Of T)) As Integer Implements System.IComparable(Of PerTime(Of T)).CompareTo
        Return Me._ValuePerSecond.CompareTo(other._ValuePerSecond)
    End Function

End Structure