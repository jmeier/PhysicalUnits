Option Strict On
Option Infer On

Partial Structure PerLength(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})
    Implements IEquatable(Of PerLength(Of T)), IComparable(Of PerLength(Of T))

    Public Overrides Function GetHashCode() As Integer
        Return _ValuePerRunningMeter.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is PerLength(Of T) Then
            Return DirectCast(obj, PerLength(Of T))._ValuePerRunningMeter.Equals(Me._ValuePerRunningMeter)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As PerLength(Of T)) As Boolean Implements System.IEquatable(Of PerLength(Of T)).Equals
        Return other._ValuePerRunningMeter.Equals(Me._ValuePerRunningMeter)
    End Function

    Public Function CompareTo(other As PerLength(Of T)) As Integer Implements System.IComparable(Of PerLength(Of T)).CompareTo
        Return Me._ValuePerRunningMeter.CompareTo(other._ValuePerRunningMeter)
    End Function

End Structure