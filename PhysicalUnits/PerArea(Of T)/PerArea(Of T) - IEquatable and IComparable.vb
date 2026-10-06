Option Strict On
Option Infer On

Partial Structure PerArea(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})
    Implements IEquatable(Of PerArea(Of T)), IComparable(Of PerArea(Of T))

    Public Overrides Function GetHashCode() As Integer
        Return _ValuePerSquaremeter.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is PerArea(Of T) Then
            Return DirectCast(obj, PerArea(Of T))._ValuePerSquaremeter.Equals(Me._ValuePerSquaremeter)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As PerArea(Of T)) As Boolean Implements System.IEquatable(Of PerArea(Of T)).Equals
        Return other._ValuePerSquaremeter.Equals(Me._ValuePerSquaremeter)
    End Function

    Public Function CompareTo(other As PerArea(Of T)) As Integer Implements System.IComparable(Of PerArea(Of T)).CompareTo
        Return Me._ValuePerSquaremeter.CompareTo(other._ValuePerSquaremeter)
    End Function

End Structure