Option Strict On
Option Infer On

Partial Structure OneOver(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})
    Implements IEquatable(Of OneOver(Of T)), IComparable(Of OneOver(Of T))

    Public Overrides Function GetHashCode() As Integer
        Return _OneOverValue.GetHashCode
    End Function
    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is OneOver(Of T) Then
            Return DirectCast(obj, OneOver(Of T))._OneOverValue.Equals(Me._OneOverValue)
        Else
            Return False
        End If
    End Function
    Public Overloads Function Equals(other As OneOver(Of T)) As Boolean Implements IEquatable(Of OneOver(Of T)).Equals
        Return other._OneOverValue.Equals(Me._OneOverValue)
    End Function
    Public Function CompareTo(other As OneOver(Of T)) As Integer Implements IComparable(Of OneOver(Of T)).CompareTo
        'this has to be reverse
        Return other._OneOverValue.CompareTo(Me._OneOverValue)
    End Function

End Structure